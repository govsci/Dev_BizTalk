using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using BizTalkLibrary.Objects;
using BizTalkLibrary.Classes;

namespace BizTalkLibrary.Orchestrations
{
    public static class Inbound_PO_cXML_To_ERP
    {
        public static string ReturnNavisionFriendlyName(string i)
        {
            i = i.Replace("'", "");

            if (i.Length > Constants.MAX_CONTACTNAME_LENGTH)
            {
                i = i.Split('/')[0].Trim();
                if (i.Length >= Constants.MAX_CONTACTNAME_LENGTH)
                    i = i.Substring(0, Constants.MAX_CONTACTNAME_LENGTH);
            }
            else
                i.Replace("/", "");
            return i; //.ToUpperInvariant();
        }

        public static int checkExtrinsics(string name, string value)
        {
            int returnValue = 0;
            switch (name)
            {
                case "ExpediteShipping": if (value == "Y") returnValue = 1; break;

            }
            return returnValue;
        }

        public static void CxmlToSalesOrder(XmlDocument cXML)
        {
            if (Database.IsNavisionSalesQuoteImport(cXML))
            {
                CxmlToSalesQuote(cXML);
            }
            else if (!Global.CustomerPoDupCheck(cXML))
            {
                try
                {
                    Constants.F1 setValue = x => x == null ? "" : x.InnerXml.Replace("'", "''").Replace("<![CDATA[", "").Replace("]]>", "");
                    Constants.F1 retreiveValue = x => x.InnerXml ?? "";
                    Constants.F3 setDecimalValue = x => x == null ? 0.0M : decimal.Parse(x.InnerXml.Replace(",", ""));
                    Constants.F4 setIntValue = x => x == null ? 0 : int.Parse(x.InnerXml.Replace(",", ""));

                    /* ################################# cXML Header extractor ################################## */

                    OrderHeader order = new OrderHeader();
                    order.timestamp = Global.GetTimeStamp(DateTime.Now);
                    order.type = "SO";
                    order.payloadID = setValue(cXML.SelectSingleNode("cXML/@payloadID"));
                    order.deploymentMode = setValue(cXML.SelectSingleNode("cXML/Request/@deploymentMode"));
                    order.CxmlCredentials = Global.GetCredentials(cXML);

                    order.date = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/@orderDate"));
                    order.orderID = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/@orderID"));
                    order.requisitionID = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/@requisitionID"));
                    order.total = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Total/Money")).Replace(",", "").Replace("$", "");

                    order.ShipToAddress.AddressID = ReturnNavisionFriendlyName(setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/@addressID")));

                    order.ShipToAddress.Name = Global.FilterStrings(setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Name")));
                    order.ShipToAddress.Name2 = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/@name"));
                    order.ShipToAddress.DeliverTo = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/DeliverTo"));

                    order.comments = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Comments"));

                    if (order.CxmlCredentials.FromIdentity == "Inbound-Sales-Order" && order.CxmlCredentials.SharedSecret == "llnl")
                        order.taxCharged = Database.GetTaxAmount(order.orderID);

                    string extrinsicDeliverTo = "", dodaac = "", bldg = "", room = "";
                    XmlNodeList extrinsics = cXML.SelectNodes("//OrderRequestHeader/Extrinsic");
                    foreach (XmlNode e in extrinsics)
                    {
                        string eName = e.SelectSingleNode("@name").Value;
                        string eValue = e.InnerXml;
                        order.extrinsics += eName + ":" + eValue + "|";
                        order.extrinsicOptions += checkExtrinsics(eName, eValue);
                        if (eName == "Purchase Requisition Number") order.purchReqNumber = eValue;
                        if (eName == "bpaNumber") order.bpaNumber = eValue;
                        if (eName == "customerPoNo") order.customerPoNo = eValue;
                        if (eName.ToUpper() == "DELIVERTO") extrinsicDeliverTo = eValue;
                        if (eName.ToUpper() == "DELIVER_TO") extrinsicDeliverTo = eValue;
                        if (eName.ToUpper() == "DODAAC") dodaac = eValue;
                        if (order.navSellToCustomerNo == "SANDIA NATIONAL LABS") order.notes += eValue;
                        if (eName.ToUpper() == "BUILDING NUMBER") bldg = eValue;
                        if (eName.ToUpper() == "ROOM NUMBER") room = eValue;
                    }

                    if (bldg.Length > 0)
                        extrinsicDeliverTo = $"BLDG*{bldg}";
                    if (room.Length > 0)
                        extrinsicDeliverTo = $"{extrinsicDeliverTo},ROOM*{room}";

                    foreach (XmlNode street in cXML.SelectNodes("//cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/Street"))
                        order.ShipToAddress.Streets.Add(setValue(street));

                    if (order.ShipToAddress.DeliverTo == "" && order.CxmlCredentials.FromIdentity != "Inbound-Sales-Order" && order.ShipToAddress.Streets.Count > 0)
                        order.ShipToAddress.DeliverTo = order.ShipToAddress.Streets[0];   // To handle messedup cxml

                    order.ShipToAddress.City = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/City"));
                    order.ShipToAddress.State = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/State"));
                    order.ShipToAddress.PostalCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/PostalCode"));
                    order.ShipToAddress.Country = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/Country"));
                    order.ShipToAddress.CountryCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/Country/@isoCountryCode"));

                    order.ShipToAddress.EmailAddress = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Email"));
                    order.ShipToAddress.Phone.Name = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Phone/@name"));
                    order.ShipToAddress.Phone.CountryCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Phone/TelephoneNumber/CountryCode/@isoCountryCode"));
                    order.ShipToAddress.Phone.AreaCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Phone/TelephoneNumber/AreaOrCityCode"));
                    order.ShipToAddress.Phone.Number = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Phone/TelephoneNumber/Number"));

                    order.ShipToAddress.Fax.Name = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Fax/@name"));
                    order.ShipToAddress.Fax.CountryCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Fax/TelephoneNumber/CountryCode/@isoCountryCode"));
                    order.ShipToAddress.Fax.AreaCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Fax/TelephoneNumber/AreaOrCityCode"));
                    order.ShipToAddress.Fax.Number = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Fax/TelephoneNumber/Number"));

                    order.BillToAddress.AddressID = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/@addressID"));
                    order.BillToAddress.Name = Global.FilterStrings(setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/Name")));

                    order.BillToAddress.Name2 = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/@name"));
                    if (cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/Name") != null)
                        order.BillToAddress.DeliverTo = Global.FilterStrings(setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/DeliverTo")));

                    order.BillToAddress.Name = Global.filterBillTo(order.BillToAddress.Name, order.BillToAddress.DeliverTo);

                    foreach (XmlNode street in cXML.SelectNodes("//cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/Street"))
                        order.BillToAddress.Streets.Add(setValue(street));

                    order.BillToAddress.City = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/City"));
                    order.BillToAddress.State = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/State"));
                    order.BillToAddress.PostalCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/PostalCode"));
                    order.BillToAddress.Country = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/Country"));

                    order.PCard.Number = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Payment/PCard/@number"));
                    order.PCard.Expiration = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Payment/PCard/@expiration"));
                    order.PCard.Name = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Payment/PCard/@name"));

                    order.paymentTerms = setValue(cXML.SelectSingleNode("//PaymentTerm/@payInNumberOfDays"));

                    string navSalesTeamColor = "";
                    order.navSellToCustomerNo = Database.GetNavSellToCustomerNo(ref navSalesTeamColor, order.CxmlCredentials, order.ShipToAddress.AddressID, order.ShipToAddress.City, order.ShipToAddress.Name);
                    order.navSalesTeamColor = navSalesTeamColor;

                    if (order.taxCharged > 0.0M)
                        order.ShipToAddress.AddressID += "TAX";

                    Database.RecordCxmlData(order);

                    Address shipToAddressObj = new Address();
                    shipToAddressObj.AddressID = order.ShipToAddress.AddressID;
                    shipToAddressObj.City = order.ShipToAddress.City;
                    shipToAddressObj.State = order.ShipToAddress.State;
                    shipToAddressObj.PostalCode = order.ShipToAddress.PostalCode;
                    shipToAddressObj.Streets.Add("");
                    shipToAddressObj.Streets.Add("");

                    if (order.ShipToAddress.State.Length >= 2)
                        order.ShipToAddress.State = order.ShipToAddress.State.Substring(0, 2);

                    if (order.navSellToCustomerNo == "LLNL SHOP STOCK" || order.navSellToCustomerNo == "LLNL EOS")
                    {
                        string shipToContactName = order.ShipToAddress.Name;
                        string[] shipToContactNameArray = shipToContactName.Split(new string[] { "PO #" }, StringSplitOptions.None);
                        shipToContactName = shipToContactNameArray[0].Trim();

                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(shipToContactName);
                        order.BillToAddress.Contact = ReturnNavisionFriendlyName(order.BillToAddress.Name);
                        order.ShipToAddress.Name = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        order.BillToAddress.Name = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);

                        shipToAddressObj.Name = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Name2 = Global.ReturnListStringItem(order.ShipToAddress.Streets,1);
                        shipToAddressObj.Streets[0] = "7000 East Avenue";
                        shipToAddressObj.Streets[1] = extrinsicDeliverTo;
                    }
                    else if (order.navSellToCustomerNo == "BATTELLE COLUMBUS" && !order.ShipToAddress.EmailAddress.EndsWith("@battelleecology.org"))
                    {
                        order.BillToAddress.Name = order.BillToAddress.DeliverTo;
                        order.ShipToAddress.Name = order.BillToAddress.DeliverTo;

                        string[] contact = order.ShipToAddress.DeliverTo.Split('/');
                        if (contact.Length > 1)
                        {
                            order.ShipToAddress.Contact = order.ShipToAddress.Contact = ReturnNavisionFriendlyName(contact[0]);
                            order.BillToAddress.Contact = ReturnNavisionFriendlyName(contact[1]);
                        }
                        else
                            order.ShipToAddress.Contact = order.ShipToAddress.Contact = ReturnNavisionFriendlyName(contact[0]);

                        string emailName = setValue(cXML.SelectSingleNode("//OrderRequestHeader/ShipTo/Address/Email/@name"));
                        if (emailName.Length > 0)
                            order.BillToAddress.Contact = ReturnNavisionFriendlyName(emailName);

                        shipToAddressObj.Name = order.ShipToAddress.Name;
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Streets[1] = Global.ReturnListStringItem(order.ShipToAddress.Streets,1);
                    }
                    else if (order.navSellToCustomerNo == "RICHLAND")
                    {
                        string[] shipToEmailSplit1 = order.ShipToAddress.EmailAddress.Split('@');

                        order.ShipToAddress.Contact = shipToEmailSplit1[0].Replace(".", " ").ToUpper();
                        if (order.ShipToAddress.Contact.Length == 0)
                            order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.EmailAddress);

                        shipToAddressObj.Name = order.ShipToAddress.Name;
                        shipToAddressObj.Name2 = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,1);
                        shipToAddressObj.Streets[1] = Global.ReturnListStringItem(order.ShipToAddress.Streets,2);
                    }
                    else if (order.navSellToCustomerNo == "JEFFERSON SCIENCE")
                    {
                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.Name);
                        order.ShipToAddress.Name = order.ShipToAddress.DeliverTo;
                        order.ShipToAddress.DeliverTo = order.ShipToAddress.Contact;

                        shipToAddressObj.Name = order.ShipToAddress.Name;
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Streets[1] = extrinsicDeliverTo;
                    }
                    else if (order.navSellToCustomerNo == "C12880")
                    {
                        if (order.ShipToAddress.Streets.Count >= 2)
                        {
                            string tempstreet = order.ShipToAddress.Streets[0];
                            order.ShipToAddress.Streets[0] = order.ShipToAddress.Streets[1];
                            order.ShipToAddress.Streets[1] = tempstreet;

                            if (order.ShipToAddress.AddressID == "FAIRVIEW")
                                order.ShipToAddress.AddressID = "1";
                        }
                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.DeliverTo);
                    }
                    else if (order.navSellToCustomerNo == "C14139")
                    {
                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.DeliverTo);
                        string oldemail = order.ShipToAddress.EmailAddress;
                        try
                        {
                            XmlNodeList contacts = cXML.SelectNodes("//OrderRequestHeader/Contact");
                            foreach (XmlNode contact in contacts)
                            {
                                string name = setValue(contact.SelectSingleNode("Name"));
                                if (name.StartsWith("Buyer/Ordering Contact:"))
                                {
                                    order.ShipToAddress.Contact = ReturnNavisionFriendlyName(name.Replace("Buyer/Ordering Contact:", "").Trim());
                                    order.ShipToAddress.EmailAddress = setValue(contact.SelectSingleNode("Email"));
                                }
                            }
                        }
                        catch { }

                        if (order.ShipToAddress.EmailAddress.Length == 0)
                            order.ShipToAddress.EmailAddress = oldemail;

                        shipToAddressObj.Name = order.ShipToAddress.Name;
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Streets[1] = Global.ReturnListStringItem(order.ShipToAddress.Streets,1);
                    }
                    else if (order.navSellToCustomerNo == "SLAC CHEMICAL" || order.navSellToCustomerNo == "SLAC")
                    {
                        string[] deltos = order.ShipToAddress.DeliverTo.Split('/');
                        if (deltos.Length > 0) order.BillToAddress.DeliverTo = deltos[0].Trim();
                        if (deltos.Length > 1) order.ShipToAddress.DeliverTo = deltos[1].Trim();
                        order.BillToAddress.Contact = ReturnNavisionFriendlyName(order.BillToAddress.DeliverTo);
                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.DeliverTo);

                        shipToAddressObj.Name = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,1);
                        shipToAddressObj.Streets[1] = extrinsicDeliverTo;
                    }
                    else if (order.navSellToCustomerNo == "INEEL")
                    {
                        if (order.ShipToAddress.DeliverTo.StartsWith("Attn To:"))
                            order.ShipToAddress.DeliverTo = order.ShipToAddress.DeliverTo.Replace("Attn To:", "").Trim();
                        else
                            order.ShipToAddress.DeliverTo = order.ShipToAddress.EmailAddress.Remove(order.ShipToAddress.EmailAddress.IndexOf('@')).Replace(".", " ");

                        shipToAddressObj.Name = order.ShipToAddress.Name;
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Streets[1] = Global.ReturnListStringItem(order.ShipToAddress.Streets,1);
                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.DeliverTo);
                    }
                    else if (order.navSellToCustomerNo == "OAK RIDGE NTL LAB")
                    {
                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.DeliverTo);
                        shipToAddressObj.Name = order.ShipToAddress.Name;
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,1);
                        shipToAddressObj.Streets[1] = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Streets[1] = extrinsicDeliverTo;
                    }
                    else if (order.navSellToCustomerNo == "LOS ALAMOS NNSA")
                    {
                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.DeliverTo);
                        shipToAddressObj.Name = order.ShipToAddress.Name;
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Streets[1] = Global.ReturnListStringItem(order.ShipToAddress.Streets,1);
                    }
                    else if (order.CxmlCredentials.FromIdentity.StartsWith("ecommerce-") && order.CxmlCredentials.FromIdentity.EndsWith("-import"))
                    {
                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.DeliverTo);
                        order.BillToAddress.Contact = ReturnNavisionFriendlyName(order.BillToAddress.DeliverTo);

                        shipToAddressObj.Name = order.ShipToAddress.Contact;
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Streets[1] = Global.ReturnListStringItem(order.ShipToAddress.Streets,1);
                    }
                    else if (order.navSellToCustomerNo == "BERKELEY")
                    {
                        shipToAddressObj.Name = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,1);
                        shipToAddressObj.Streets[1] = Global.ReturnListStringItem(order.ShipToAddress.Streets,2);
                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.DeliverTo);
                    }
                    else if (order.navSellToCustomerNo == "ARGONNE AMOS")
                    {
                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.DeliverTo);
                        order.BillToAddress.Contact = ReturnNavisionFriendlyName(order.BillToAddress.DeliverTo);

                        shipToAddressObj.Name = order.ShipToAddress.Name;
                        shipToAddressObj.Name2 = "ATTN: " + order.ShipToAddress.Contact;
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        if (Global.ReturnListStringItem(order.ShipToAddress.Streets,1).ToUpper().Contains("CHEMICAL"))
                            shipToAddressObj.Streets[1] = "-CTS CHEMICALS";
                    }
                    else if (order.navSellToCustomerNo == "C10366")
                    {
                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.DeliverTo);
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Streets[1] = Global.ReturnListStringItem(order.ShipToAddress.Streets,1);
                        shipToAddressObj.Name = order.ShipToAddress.Name;
                    }
                    else if (order.navSellToCustomerNo == "NATL SECURITY TECH")
                    {
                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.DeliverTo);
                        shipToAddressObj.Name = order.ShipToAddress.Name;
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Streets[1] = Global.ReturnListStringItem(order.ShipToAddress.Streets,1);
                    }
                    else
                    {
                        order.ShipToAddress.Contact = ReturnNavisionFriendlyName(order.ShipToAddress.DeliverTo);
                        shipToAddressObj.Name = order.ShipToAddress.Name;
                        shipToAddressObj.Streets[0] = Global.ReturnListStringItem(order.ShipToAddress.Streets,0);
                        shipToAddressObj.Streets[1] = Global.ReturnListStringItem(order.ShipToAddress.Streets,1);
                    }

                    if (shipToAddressObj.Streets[0].Contains("-"))
                    {
                        string[] streetsplit = shipToAddressObj.Streets[0].Split('-');
                        shipToAddressObj.Streets[0] = streetsplit[0].Trim();

                        if (shipToAddressObj.Streets[1].Length == 0)
                            shipToAddressObj.Streets[1] = streetsplit[1].Trim();
                        else if (shipToAddressObj.Name2.Length == 0)
                            shipToAddressObj.Name2 = streetsplit[1].Trim();
                    }

                    /* ################################# Create ShipTo address entry & SellTo Contact entry FOR ALL ecommerce customers ########################## */

                    string customerAddressID = order.ShipToAddress.AddressID;
                    order.ShipToAddress.AddressID = ERP_Web_Service_Functions.CheckShipToAddress(shipToAddressObj, order);

                    /* ########################## Populate Contact ID ##################### */
                    if (order.ShipToAddress.Contact.Length > 0)
                        order.ShipToAddress.Contact_ID = ERP_Web_Service_Functions.CheckNavisionContact(order.ShipToAddress.Contact, order);

                    /* ########################## Populate Contact ID ##################### */

                    if (order.BillToAddress.Contact.Length > 0)
                        order.BillToAddress.Contact_ID = ERP_Web_Service_Functions.CheckNavisionContact(order.BillToAddress.Contact, order);

                    /* ########################## Populate Customer Credit Card ##################### */

                    bool creditcardfailed = false;

                    if (order.PCard.Number.Length > 0)
                    {
                        try
                        {
                            ERP_Web_Service_Functions.CheckCreditCard(order);
                        }
                        catch (Exception ex)
                        {
                            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("Adding Credit Card Failed");
                            cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@navSellToCustomerNo", order.navSellToCustomerNo));
                            cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CardNumber", CustomTextEncrypt.Encode(order.PCard.Number)));
                            cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CardExpDate", CustomTextEncrypt.Encode(order.PCard.Expiration)));
                            cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CardName", CustomTextEncrypt.Encode(order.PCard.Name)));

                            Email.SendErrorMessage(ex, "", "Incoming_PO_To_ERP_Class", "CxmlToSalesOrder", order.orderID, cmd);
                            creditcardfailed = true;
                        }
                    }

                    Global.Output("Debug Line 5");

                    /* ################################# cXML Body extractor ################################## */
                    XmlNodeList lines = cXML.SelectNodes("cXML/Request/OrderRequest/ItemOut");
                    bool billingonlypo = false;
                    int lineNumber = 1;
                    DateTime requestedDeliveryDate = Constants.NAVISION_DEFAULT_DATETIME_VALUE;

                    foreach (XmlNode line in lines)
                    {
                        OrderLine orderLine = new OrderLine();
                        orderLine.quantity = setDecimalValue(line.SelectSingleNode("@quantity"));

                        orderLine.lineNumber = setIntValue(line.SelectSingleNode("@lineNumber"));

                        if (line.SelectSingleNode("@requestedDeliveryDate") != null && setValue(line.SelectSingleNode("@requestedDeliveryDate")).Length > 0 && Global.GetDateTime(setValue(line.SelectSingleNode("@requestedDeliveryDate"))).Date >= DateTime.Now.Date)
                        {
                            orderLine.requestedDeliveryDate = Global.GetDateTime(setValue(line.SelectSingleNode("@requestedDeliveryDate")));
                            if (requestedDeliveryDate.Date == Constants.NAVISION_DEFAULT_DATETIME_VALUE.Date)
                                requestedDeliveryDate = orderLine.requestedDeliveryDate;
                            else if (orderLine.requestedDeliveryDate.Date < requestedDeliveryDate.Date)
                                requestedDeliveryDate = orderLine.requestedDeliveryDate;
                        }

                        orderLine.supplierPartID = setValue(line.SelectSingleNode("ItemID/SupplierPartID"));

                        orderLine.supplierPartAuxiliaryID = setValue(line.SelectSingleNode("ItemID/SupplierPartAuxiliaryID"));

                        orderLine.supplierPartID = Global.RemoveStrings(orderLine.supplierPartID);
                        orderLine.supplierPartAuxiliaryID = Global.RemoveStrings(orderLine.supplierPartAuxiliaryID);

                        orderLine.unitPrice = setDecimalValue(line.SelectSingleNode("ItemDetail/UnitPrice/Money"));

                        orderLine.description = setValue(line.SelectSingleNode("ItemDetail/Description"));
                        if (orderLine.description.StartsWith("Quote #")) orderLine.description = Regex.Replace(orderLine.description, @"Quote # Q\d+? \| ", "");
                        if (order.orderID.StartsWith("SLAC") && orderLine.description.ToUpper().Contains("BILLING ONLY")) billingonlypo = true;
                        orderLine.description = orderLine.description.Replace("'", "''");
                        orderLine.description = orderLine.description.Replace("<ShortName>", "").Replace("</ShortName>", "").Trim(); ;

                        orderLine.unitOfMeasure = setValue(line.SelectSingleNode("ItemDetail/UnitOfMeasure"));                        

                        orderLine.originalUnitOfMeasure = $"{orderLine.unitOfMeasure}";
                        if (line.SelectSingleNode("ItemDetail/UnitOfMeasure/@OriginalUOM") != null)
                            orderLine.originalUnitOfMeasure = setValue(line.SelectSingleNode("ItemDetail/UnitOfMeasure/@OriginalUOM"));

                        orderLine.classificationDomain = setValue(line.SelectSingleNode("ItemDetail/Classification/@domain"));
                        orderLine.classification = setValue(line.SelectSingleNode("ItemDetail/Classification"));
                        orderLine.manufacturerPartID = setValue(line.SelectSingleNode("ItemDetail/ManufacturerPartID"));
                        orderLine.manufacturerName = setValue(line.SelectSingleNode("ItemDetail/ManufacturerName"));

                        if (orderLine.manufacturerName.ToUpper() != "SHIPPING")
                            orderLine.manufacturerName = Database.GetVendorName(orderLine.manufacturerName);       // Normalize vendor code

                        orderLine.vendorCode = Database.GetVendorCode(orderLine.manufacturerName);
                        orderLine.unitOfMeasure = ERP_Item_Functions.NormalizeUOM(orderLine.supplierPartID, orderLine.unitOfMeasure, orderLine.vendorCode);

                        orderLine.unitCostStr = setValue(line.SelectSingleNode("ItemDetail/Extrinsic[@name=\"unitCost\"]"));
                        string altNumber = "";

                        // ############################# New function to deal with custom marketbasket part numbers ###############################################################
                        if (orderLine.manufacturerName == "MARKETBASKET")
                            orderLine.gssPartNumber = Database.findMarketBasketPartNumber(order, orderLine);
                        else if (orderLine.manufacturerName == "SHIPPING" || orderLine.supplierPartID.ToUpper().StartsWith("GSSTRANS"))
                            orderLine.gssPartNumber = orderLine.supplierPartID;
                        else
                            orderLine.gssPartNumber = ERP_Item_Functions.findGSSPartnumber(orderLine.supplierPartID, orderLine.unitOfMeasure, orderLine.supplierPartAuxiliaryID, ref altNumber, orderLine.vendorCode);
                        orderLine.altNumber = altNumber;

                        // normalizedUOM = normalizeUM(vendorPartNum, manufacturerName, UOM);

                        XmlNodeList ItemExtrinsics = cXML.SelectNodes("ItemDetail/Extrinsic");
                        foreach (XmlNode e in ItemExtrinsics)
                        {
                            string eName = e.SelectSingleNode("@name").Value;
                            string eValue = e.InnerXml.Replace("'", "''").Replace("<![CDATA[", "").Replace("]]>", "");
                            orderLine.extra += eName + ":" + eValue + "|";

                            if (eName == "quoteNumber" && !orderLine.quoteNumber.Contains(eValue)) orderLine.quoteNumber += eValue + "|";
                        }

                        ////////keejooo added on 062421////////////
                        if (order.navSellToCustomerNo == "SANDIA NATIONAL LABS")
                        {
                            XmlNodeList SandiaItemExtrinsics = cXML.SelectNodes("//ItemDetail/Extrinsic");
                            foreach (XmlNode e in SandiaItemExtrinsics)
                                orderLine.extra += e.InnerXml + " ";
                        }
                        ////////keejooo added on 062421////////////

                        Database.RecordCxmlData(order, orderLine);

                        //decimal rebate = Database.getVendorRebate(order.CxmlCredentials.FromIdentity, orderLine.manufacturerName);

                        order.Lines.Add(orderLine);
                        lineNumber = lineNumber + 1;
                    }

                    order.requestedDeliveryDate = requestedDeliveryDate;

                    if (billingonlypo == false)
                        ERP_Web_Service_Functions.CreateSalesOrder(order, creditcardfailed);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        public static void CxmlToSalesQuote(XmlDocument cXML)
        {

        }

        
    }
}
