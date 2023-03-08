using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using BizTalkLibrary.Objects;
using System.IO;

namespace BizTalkLibrary.Classes
{
    public abstract class Create_Cxml
    {
        public abstract void BuildXml(XmlDocument cXML, string timestamp, Customer customer);
    }

    public class Build702Xml : Create_Cxml
    {
        public override void BuildXml(XmlDocument cXML, string timestamp, Customer customer)
        {
            Build702Po(cXML, timestamp, customer);
        }

        private void Build702Po(XmlDocument cXML, string timestamp, Customer customer)
        {
            /* ########### send the cXML to DB and record information ########### */
            string customerPhoneNumber = checkCustomerPhoneNumber(cXML);
            //            cXML = checkShipping(cXML);

            string emailAddress = "";

            if (customer.OrganizationDesc == "Battelle" || customer.OrganizationDesc == "BMEI")
            {
                emailAddress = "battelle@govsci.com";
                cXML = checkShipping(cXML, emailAddress, "703", "880-5040");
            }

            else if (customer.OrganizationDesc == "Battelle.Richland")
            {
                emailAddress = "pnnlorders@govsci.com";
                cXML = checkShipping(cXML, emailAddress, "703", "880-5040");
            }

            else if (customer.OrganizationDesc == "Idaho National Lab" || customer.OrganizationDesc == "INL")
            {
                if (cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Contact") != null)
                    cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader").RemoveChild(cXML.SelectSingleNode("//Contact"));

                if (cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/PaymentTermCoded") != null)
                    cXML.SelectSingleNode("cXML/Request/OrderRequest").RemoveChild(cXML.SelectSingleNode("//PaymentTermCoded"));

                if (cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Payment") == null)
                {
                    string paymentString = "<PCard expiration=\"\" number=\"\" />";
                    XmlElement paymentBlock = cXML.CreateElement("Payment");
                    paymentBlock.InnerXml = paymentString;
                    cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader").InsertAfter(paymentBlock, cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo"));
                }
                emailAddress = "inlorders@govsci.com";
                cXML = checkShipping(cXML, emailAddress, "703", "880-5040");
            }
            else if (customer.OrganizationDesc == "JLab")
            {
                if (cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Payment") == null)
                {
                    string paymentString = "<PCard expiration=\"\" number=\"\" />";
                    XmlElement paymentBlock = cXML.CreateElement("Payment");
                    paymentBlock.InnerXml = paymentString;
                    cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader").InsertAfter(paymentBlock, cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo"));
                }
                emailAddress = "jlab@govsci.com";
                cXML = checkShipping(cXML, emailAddress, "703", "880-5040");
            }
            else if (customer.OrganizationDesc == "LBNL Industrial PO" || customer.OrganizationDesc == "LBNL-V PO")
            {
                emailAddress = "lbnlorders@govsci.com";
            }
            else if (customer.OrganizationDesc == "City of El Paso")
            {
                emailAddress = "sales-d@govsci.com";
            }
            else if (customer.OrganizationDesc == "PNNL")
            {
                emailAddress = "pnnlorders@govsci.com";
                cXML = checkShipping(cXML, emailAddress, "703", "880-5040");
            }
            else if (customer.OrganizationDesc == "SLAC.Chem")
            {
                emailAddress = "slac.purchasing@govsci.com";
                cXML = checkShipping(cXML, emailAddress, "877", "202-7799");
            }
            else
            {
                emailAddress = "slac.purchasing@govsci.com";
                cXML = checkShipping(cXML, customer.CxmlCredentials);
            }

            bool expedite = false, shipTo = false;

            List<XMLItemBlock> outboundPO = new List<XMLItemBlock>();

            XmlNodeList lines = cXML.SelectNodes("//ItemOut");

            foreach (XmlNode i in lines)
            {
                string uom = Database.GetUnitOfMeasure(i.SelectSingleNode("ItemDetail/UnitOfMeasure").InnerXml, i.SelectSingleNode("ItemDetail/ManufacturerName").InnerXml);
                if (uom.Length>0)
                    i.SelectSingleNode("ItemDetail/UnitOfMeasure").InnerXml = uom;

                outboundPO.Add(new XMLItemBlock(i.SelectSingleNode("ItemDetail/ManufacturerName").InnerXml, i.SelectSingleNode("ItemDetail/UnitPrice/Money").InnerXml, i.SelectSingleNode("@quantity").InnerXml, i));

                if ((i.SelectSingleNode("ItemDetail/ManufacturerName").InnerXml.ToUpper() == "GSS" || i.SelectSingleNode("ItemDetail/ManufacturerName").InnerXml.ToUpper() == "SHIPPING") && i.SelectSingleNode("ItemID/SupplierPartID").InnerXml == "GSSTRANS")
                    expedite = true;
            }

            IEnumerable<string> vendorCodes = outboundPO.Select(n => n.GetVendorCode()).Distinct();

            foreach (string v in vendorCodes)
            {
                // Pull Vendor Credential from DB to build cxml Header

                XmlDocument outgoingPO = new XmlDocument();
                outgoingPO.XmlResolver = null;
                outgoingPO = cXML;
                string orderId = Global.GetOrderId(outgoingPO);

                Vendor vendor = Database.GetVendorConfiguration(customer.Parent.ToString(), v);

                IEnumerable<XMLItemBlock> i = from b in outboundPO where b.GetVendorCode() == v select b;

                outgoingPO = buildCXMLHeader(outgoingPO, vendor, i, emailAddress.Length > 0 ? emailAddress : Constants.adminEmail);
                outgoingPO = checkOutgoingAddress(customer.OrganizationDesc, v, customerPhoneNumber, outgoingPO, vendor.ShipToCode);

                //Added by Zach Aug 1 2015, removes orderVersion from cXML if vendor is VWR and customer is Battelle
                if (v == "VWR" && customer.OrganizationDesc == "Battelle")
                    outgoingPO = Global.ModifyCxml(outgoingPO, customer.OrganizationDesc, true);

                outgoingPO = checkShipping(outgoingPO, v, customer.OrganizationDesc);

                foreach (XmlNode desc in outgoingPO.SelectNodes("ItemDetail/Description"))
                {
                    desc.InnerText = desc.InnerText.Replace("/", ".");
                }

                Global.CreateDump(Constants.DUMP_FOLDERS.OUT_PO_OUTGOING, orderId, timestamp + "." + customer.OrganizationDesc + "." + v, outgoingPO, true);

                // ------- outbound PO special characters fix ---------- 

                if (cXML.SelectSingleNode("//OrderRequestHeader/Extrinsic[@name=\"ExpediteShipping\"]") != null && cXML.SelectSingleNode("//OrderRequestHeader/Extrinsic[@name=\"ExpediteShipping\"]").InnerXml == "Y")
                    expedite = true;

                if (cXML.SelectSingleNode("//OrderRequestHeader/Comments") != null && cXML.SelectSingleNode("//OrderRequestHeader/Comments").InnerXml == "Overnight Shipping")
                    expedite = true;

                //if (cXML.SelectSingleNode("//OrderRequestHeader/ShipTo/Address/@addressID") != null && cXML.SelectSingleNode("//OrderRequestHeader/ShipTo/Address/@addressID").InnerXml.Length > 0)
                shipTo = true;

                try
                {
                    bool sent = Database.CheckBypassPo(vendor, outgoingPO);

                    string file = "";

                    if (vendor.CxmlCredentials.Url.Length > 0 && vendor.Active == 1 && (!expedite || (expedite && vendor.ExpediteShippingAllowed == 1)) && shipTo && !sent)
                        file = Global.CreateDump(Constants.DUMP_FOLDERS.PORT_SEND_CXML_BYPASS_PO_WAITING, orderId, timestamp + "." + customer.OrganizationDesc + "." + v, outgoingPO, false);
                    else
                        file = Global.CreateDump(Constants.DUMP_FOLDERS.OUT_PO_SKIPPED, orderId, timestamp + "." + customer.OrganizationDesc + "." + v, outgoingPO, true);

                    if (!File.Exists(file))
                        throw new Exception("File '" + file + "' does not exist!");
                }
                catch (Exception ex)
                {
                    Email.SendErrorMessage(ex, "", "Create_Cxml", "Build702Po", orderId, null);
                }

                outgoingPO = null;

            }

        }

        private string checkCustomerPhoneNumber(XmlDocument cXML)
        {
            string number;
            try
            {
                number = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Phone/TelephoneNumber/Number").InnerXml;
            }
            catch
            {
                number = "";
            }
            return number;
        }

        private XmlDocument checkShipping(XmlDocument cXML, Credentials creds)
        {
            Constants.F1 setValue = x => x == null ? "" : x.InnerXml;

            XmlNodeList extrinsics = cXML.SelectNodes("//OrderRequestHeader/Extrinsic");
            XmlNode addressNode = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address");
            string prefix = "", shipComplete = "", shipToBlock;

            /* ######################################### SLAC line-level shipto addresses ######################### */
            XmlNodeList existingItemShipToBlock = cXML.SelectNodes("cXML/Request/OrderRequest/ItemOut/ShipTo");
            foreach (XmlNode e in existingItemShipToBlock)
                e.ParentNode.RemoveChild(e);

            foreach (XmlNode e in extrinsics)
            {
                string eName = e.SelectSingleNode("@name").Value;
                string eValue = e.InnerXml;
                if (eName == "Buyer_Id")
                    prefix = eValue + " ";
                else if (eName == "Ship_complete")
                    shipComplete = eValue;
            }

            string addressID = setValue(addressNode.SelectSingleNode("@addressID"));

            string deliverTo = setValue(addressNode.SelectSingleNode("PostalAddress/DeliverTo"));
            string deliverToPatternString = @"(?<firstInput>.*?) / (?<secondInput>.*)";
            Regex deliverToCheck = new Regex(deliverToPatternString);
            Match deliverToMatch = deliverToCheck.Match(deliverTo);
            deliverTo = deliverToMatch.Groups["firstInput"].Value == deliverToMatch.Groups["secondInput"].Value ? deliverToMatch.Groups["firstInput"].Value : deliverTo;

            if (creds.FromIdentity == "SLAC-Chem")
            {
                string[] delivertos = addressNode.SelectSingleNode("PostalAddress/DeliverTo").InnerXml.Split('/');
                deliverTo = delivertos[1].Trim();
            }

            Address ship = Database.GetShipToAddress(addressID);

            deliverTo = prefix + deliverTo;

            shipToBlock = "<DeliverTo>" + deliverTo + "</DeliverTo>";
            foreach (string street in ship.Streets)
                if (street.Length > 0)
                    shipToBlock += $"<Street>{street}</Street>";
            shipToBlock += "<City>" + ship.City + "</City>";
            shipToBlock += "<State>" + ship.State + "</State>";
            shipToBlock += "<PostalCode>" + ship.PostalCode + "</PostalCode>";
            shipToBlock += "<Country>" + ship.CountryCode + "</Country>";
            XmlAttribute countryAtt = cXML.CreateAttribute("isoCountryCode");
            countryAtt.Value = ship.CountryCode;

            shipToBlock = shipToBlock.Replace("&", "&amp;");

            addressNode.SelectSingleNode("@addressID").InnerXml = ship.AddressID;
            addressNode.SelectSingleNode("PostalAddress").InnerXml = shipToBlock;
            addressNode.SelectSingleNode("PostalAddress/Country").Attributes.Append(countryAtt);

            /* ######################### Additional Information for GSS purchasing ################################ */
            addressNode.SelectSingleNode("Email").InnerXml = "slac.purchasing@govsci.com";
            if (addressNode.SelectSingleNode("Phone/TelephoneNumber/AreaOrCityCode") != null)
            {
                addressNode.SelectSingleNode("Phone/TelephoneNumber/AreaOrCityCode").InnerXml = "877";
                addressNode.SelectSingleNode("Phone/TelephoneNumber/Number").InnerXml = "202-7799 x422";
            }
            else
            {
                XmlNode phone = cXML.CreateElement("Phone");
                XmlNode telephoneNumber = cXML.CreateElement("TelephoneNumber");

                XmlNode areaOrCityCode = cXML.CreateElement("AreaOrCityCode");
                areaOrCityCode.AppendChild(cXML.CreateTextNode("877"));
                telephoneNumber.AppendChild(areaOrCityCode);

                XmlNode number = cXML.CreateElement("Number");
                number.AppendChild(cXML.CreateTextNode("202-7799 x422"));
                telephoneNumber.AppendChild(number);

                phone.AppendChild(telephoneNumber);
                addressNode.AppendChild(phone);

            }

            return cXML;
        }

        private XmlDocument checkShipping(XmlDocument cXML, string email, string areaCode, string phoneNumber)
        {
            try
            {
                /* ######################### Additional Information for GSS purchasing ################################ */
                cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Email").InnerXml = email;
                cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Phone/TelephoneNumber/AreaOrCityCode ").InnerXml = areaCode;
                cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Phone/TelephoneNumber/Number").InnerXml = phoneNumber;


            }
            catch { }

            try
            {
                if (email.StartsWith("jlab"))
                {
                    XmlNode extrinsic = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Extrinsic[@name=\"deliverTo\"]");
                    if (extrinsic != null)
                    {
                        string deliverTo = extrinsic.InnerXml;
                        if (deliverTo.Length > 0)
                        {
                            if (cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/DeliverTo") != null)
                                cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/DeliverTo").InnerXml = deliverTo;
                            else
                            {
                                XmlElement delTo = cXML.CreateElement("DeliverTo");
                                delTo.AppendChild(cXML.CreateTextNode(deliverTo));
                                cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress").AppendChild(delTo);
                            }
                        }
                    }
                }
            }
            catch { }

            return cXML;
        }

        private XmlDocument buildCXMLHeader(XmlDocument cXML, Vendor vendor, IEnumerable<XMLItemBlock> itemBlocks, string email)
        {
            string headerBlock, billToBlock, contactBlock;
            double total = 0;

            headerBlock = "<From>";
            headerBlock += "<Credential domain=\"" + vendor.CxmlCredentials.FromDomain + "\">";
            headerBlock += "<Identity>" + vendor.CxmlCredentials.FromIdentity + "</Identity>";
            headerBlock += "</Credential>";
            headerBlock += "</From>";
            headerBlock += "<To>";
            headerBlock += "<Credential domain=\"" + vendor.CxmlCredentials.ToDomain + "\">";
            headerBlock += "<Identity>" + vendor.CxmlCredentials.ToIdentity + "</Identity>";
            headerBlock += "</Credential>";
            headerBlock += "</To>";
            headerBlock += "<Sender>";
            headerBlock += "<Credential domain=\"" + vendor.CxmlCredentials.SenderDomain + "\">";
            if (vendor.CxmlCredentials.SenderIdentity != "") headerBlock += "<Identity>" + vendor.CxmlCredentials.SenderIdentity + "</Identity>";
            headerBlock += "<SharedSecret>" + vendor.CxmlCredentials.SharedSecret + "</SharedSecret>";
            headerBlock += "</Credential>";
            if (vendor.CxmlCredentials.UserAgent != "") headerBlock += "<UserAgent>" + vendor.CxmlCredentials.UserAgent + "</UserAgent>";
            headerBlock += "</Sender>";


            billToBlock = "<Address addressID=\"GSSWH\">";
            billToBlock += "<Name xml:lang=\"en\">Government Scientific Source</Name>";
            billToBlock += "<PostalAddress name=\"VA\">";
            if (vendor.CxmlCredentials.ToIdentity == "19-395-3726" || vendor.CxmlCredentials.ToIdentity == "lbb2b") billToBlock += "<DeliverTo>Government Scientific Source</DeliverTo>";
            billToBlock += "<Street>12355 Sunrise Valley Dr. Suite 400</Street>";
            billToBlock += "<City>Reston</City>";
            billToBlock += "<State>VA</State>";
            if (vendor.CxmlCredentials.ToIdentity == "RAININ") billToBlock += "<PostalCode>20191-3415</PostalCode>";
            else billToBlock += "<PostalCode>20191</PostalCode>";
            billToBlock += "<Country isoCountryCode=\"US\">US</Country>";
            billToBlock += "</PostalAddress>";
            if (vendor.CxmlCredentials.ToIdentity == "19-395-3726")
            {
                if (vendor.CxmlCredentials.FromIdentity == "LBNL2")
                    billToBlock += "<Email name=\"Recipent\">LBNLorders@govsci.com</Email>";
                else
                    billToBlock += "<Email name=\"Recipent\">" + email + "</Email>";
                billToBlock += "<Phone>";
                billToBlock += "<TelephoneNumber>";
                billToBlock += "<CountryCode isoCountryCode=\"US\" />";
                billToBlock += "<AreaOrCityCode />";
                billToBlock += "<Number />";
                billToBlock += "</TelephoneNumber>";
                billToBlock += "</Phone>";
            }
            billToBlock += "</Address>";

            contactBlock = "<Name xml:lang=\"en-US\">(703)880.5040 GSS Purchasing</Name>";
            //          contactBlock += "<Email>purchasing@govsci.com</Email>";
            //          contactBlock += "<Phone name=\"GSS Purchasing\">";
            //          contactBlock += "<TelephoneNumber>";
            //          contactBlock += "<AreaOrCityCode>703</AreaOrCityCode>";
            //          contactBlock += "<Number>880-5040</Number>";
            //          contactBlock += "</TelephoneNumber>";
            //          contactBlock += "</Phone>";

            XmlElement cB = cXML.CreateElement("Contact");
            cB.SetAttribute("role", "user");
            cB.InnerXml = contactBlock;

            cXML.SelectSingleNode("cXML/Header").InnerXml = headerBlock;
            cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo").InnerXml = billToBlock;

            XmlNode insertAfter = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Payment");
            if (insertAfter == null)
                insertAfter = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Shipping");

            cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader").InsertAfter(cB, insertAfter);

            // Modify timestamps
            string cxmlTime = Global.GetCXMLTimeStamp(DateTime.Now);
            cXML.SelectSingleNode("cXML/@timestamp").Value = cxmlTime;
            cXML.SelectSingleNode("cXML/@payloadID").Value = cxmlTime + "@govsci.com";
            cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/@orderDate").Value = cxmlTime;


            XmlNodeList existingItemBlock = cXML.SelectNodes("cXML/Request/OrderRequest/ItemOut");

            foreach (XmlNode e in existingItemBlock)
                cXML.SelectSingleNode("cXML/Request/OrderRequest").RemoveChild(e);

            foreach (XMLItemBlock l in itemBlocks)
            {
                cXML.SelectSingleNode("cXML/Request/OrderRequest").InnerXml += l.ToNodeToString();
                total += l.GetTotal();
            }

            cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Total/Money").InnerXml = total.ToString();

            return cXML;

        }

        private XmlDocument checkOutgoingAddress(string customerID, string vendor, string customerPhoneNumber, XmlDocument cXML, string shipToCode)
        {
            string checkstring = customerID;
            try
            {
                string checkDeliverTo1 = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Name").InnerXml;
                string checkDeliverTo2 = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/DeliverTo").InnerXml;

                if (checkDeliverTo1.Length > Constants.maxDeliveryToLength)
                {
                    checkDeliverTo1 = checkDeliverTo1.Substring(0, Constants.maxDeliveryToLength - 1);
                    cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Name").InnerXml = checkDeliverTo1;
                }
                if (checkstring != "PNNL" && checkDeliverTo2.Split('/').Length > 1 && checkstring != "PNL" && checkstring != "Battelle.Richland")
                {
                    checkDeliverTo2 = checkDeliverTo2.Split('/')[1].Trim();
                    cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/DeliverTo").InnerXml = checkDeliverTo2;
                }
                else if (checkDeliverTo2.Length > Constants.maxDeliveryToLength)
                {
                    checkDeliverTo2 = checkDeliverTo2.Substring(0, Constants.maxDeliveryToLength - 1);
                    cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/DeliverTo").InnerXml = checkDeliverTo2;
                }
            }
            catch {}



            cXML.InnerXml = cXML.InnerXml.Replace("<Country>USA</Country>", "<Country isoCountryCode=\"US\">United States</Country>");
            cXML.InnerXml = cXML.InnerXml.Replace("currency=\"DOLLARS\"", "currency=\"USD\"");
            cXML.InnerXml = cXML.InnerXml.Replace("deploymentMode=\"test\"", "deploymentMode=\"production\"");


            if (vendor == "Forms and Supply")
            {
                try
                {
                    XmlNodeList SupplierPartAuxiliaryIDs = cXML.SelectNodes("cXML/Request/OrderRequest/ItemOut/ItemID/SupplierPartAuxiliaryID");
                    foreach (XmlNode l in SupplierPartAuxiliaryIDs)
                        l.InnerXml = @"Cookie=true|UserName=JLabUser20130307114333|UserEmail=jlab@govsci.com";


                    cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/DeliverTo").InnerXml = "JSA, LLC / Jefferson Lab";
                    cXML.SelectNodes("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/Street").Item(1).InnerXml =
                       cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Extrinsic[@name='deliverTo']").InnerXml;

                    cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader").RemoveChild(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Extrinsic[@name='deliverTo']"));
                }
                catch {}
            }

            if (vendor.ToUpper() == "WESTERN TOOL SUPPLY" || vendor.ToUpper() == "GRAINGER")
            {
                try
                {
                    string deliverTo = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/DeliverTo").InnerXml;
                    cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Name").InnerXml = deliverTo;
                }
                catch { }
            }
            if (vendor.ToUpper() == "MSC INDUSTRIAL SUPPLY")
            {
                try
                {
                    if (customerPhoneNumber.Contains('/'))
                    {
                        string[] phoneBlock = customerPhoneNumber.Split('/');
                        cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Phone/TelephoneNumber/AreaOrCityCode").InnerXml = phoneBlock[0];
                        cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Phone/TelephoneNumber/Number").InnerXml = phoneBlock[1];
                    }
                }
                catch { }
            }
            if (vendor.ToUpper() == "THE OFFICE CITY")
            {
                try
                {
                    cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Extrinsic[@name='DELIVER_TO']").InnerXml = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/DeliverTo").InnerXml + " " + cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Extrinsic[@name='DELIVER_TO']").InnerXml;
                }
                catch { }
            }

            if (vendor == "Thorlabs")
            {
                try
                {
                    cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader").RemoveChild(cXML.SelectSingleNode("//Contact"));
                    cXML.InnerXml = cXML.InnerXml.Replace("<Country>USA</Country>", "<Country isoCountryCode=\"US\"/>");
                    cXML.InnerXml = cXML.InnerXml.Replace("<Country isoCountryCode=\"US\">US</Country>", "<Country isoCountryCode=\"US\"/>");
                }
                catch { }
            }

            /* ######################## Remove follow-up info from outgoing cxml ################################# */
            try
            {
                cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Followup/URL").InnerXml = "";
            }
            catch {}

            if (shipToCode.Length > 0)
            {
                try
                {
                    if (customerID.ToUpper() == "JLAB" && (vendor.ToUpper() == "FISHER SCIENTIFIC" || vendor.ToUpper() == "GRAINGER" || vendor.ToUpper() == "ALFA AESAR"))
                    {
                        string name = cXML.SelectSingleNode("//ShipTo/Address/Name").InnerXml;
                        cXML.SelectSingleNode("//ShipTo/Address/Name").InnerXml = cXML.SelectSingleNode("//ShipTo/Address/@addressID").InnerXml;
                    }

                    cXML.SelectSingleNode("//ShipTo/Address/@addressID").InnerXml = shipToCode;
                }
                catch { }
            }

            return cXML;
        }

        private XmlDocument checkShipping(XmlDocument cXML, string vendorCode, string customerId)
        {
            if ((customerId == "LBNL Industrial PO" || customerId == "LBNL-V PO") && vendorCode != "NEWARK" && vendorCode != "MSC INDUSTRIAL SUPPLY")
            {
                XmlNodeList addressNodes = cXML.SelectNodes("//ShipTo/Address");
                foreach (XmlNode addressNode in addressNodes)
                {
                    addressNode.SelectSingleNode("Email").InnerXml = "LBNLorders@govsci.com";
                    if (vendorCode != "PRAXAIR" && vendorCode != "AIRGAS")
                        addressNode.SelectSingleNode("Phone/TelephoneNumber/Number").InnerXml = @"703/880-5040";
                }
            }
            if (customerId == "LBNL Industrial PO" && vendorCode == "AIRGAS")
            {
                string city = "", state = "", postcode = "", street1 = "", street2 = "", delTo = "";
                List<string> streets = new List<string>();
                string addressId = "";

                XmlNode address = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress");

                city = address.SelectSingleNode("City").InnerXml;
                state = address.SelectSingleNode("State").InnerXml;
                postcode = address.SelectSingleNode("PostalCode").InnerXml;
                for (int i = 0; i < address.SelectNodes("Street").Count; i++)
                    streets.Add(address.SelectNodes("Street").Item(i).InnerXml);

                street1 = streets[1];
                delTo = street2 = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Extrinsic[@name=\"DELIVER_TO\"]").InnerXml;
                street2 = street2.Split('-')[0].TrimStart('0');

                addressId = Database.GetAddressID(customerId, vendorCode, street1, street2, city, state, postcode);

                if (addressId.Length > 0)
                {
                    XmlNodeList addresses = cXML.SelectNodes("//ShipTo/Address");
                    foreach (XmlNode add in addresses)
                    {
                        add.SelectSingleNode("@addressID").InnerXml = addressId;
                        XmlNode post = add.SelectSingleNode("PostalAddress");
                        post.SelectSingleNode("@name").InnerXml = addressId;
                        string deliverTo = post.SelectSingleNode("DeliverTo").InnerXml.Split('/')[0].Trim() + " / " + delTo;
                        string shipToBlock = "<DeliverTo>" + deliverTo + "</DeliverTo>"
                            + "<Street>" + streets[0] + "</Street>"
                            + "<Street>" + streets[1].Split(',')[0] + "</Street>"
                            + "<Street>FOR THE US DEPT. OF ENERGY</Street>"
                            + "<City>" + city + "</City>"
                            + "<State>" + state + "</State>"
                            + "<PostalCode>" + postcode + "</PostalCode>"
                            + "<Country isoCountryCode=\"" + post.SelectSingleNode("Country/@isoCountryCode").InnerXml + "\" />";
                        post.InnerXml = shipToBlock;
                    }
                }
            }
            else if (customerId == "LBNL Industrial PO" && vendorCode == "NEWARK")
            {
                XmlNodeList itemOuts = cXML.SelectNodes("//ItemOut");
                foreach (XmlNode itemOut in itemOuts)
                {
                    XmlNode unitPrice = itemOut.SelectSingleNode("ItemDetail/UnitPrice/Money");
                    decimal unitP = decimal.Parse(unitPrice.InnerXml);
                    unitP = unitP / 0.995M;
                    unitPrice.InnerXml = unitP.ToString("0.000");
                }
            }
            else if (customerId == "LBNL Industrial PO" && vendorCode == "GRAINGER")
            {
                XmlNode address = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress");
                string deliverTo = address.SelectSingleNode("DeliverTo").InnerXml;
                string[] streets = new string[address.SelectNodes("Street").Count];
                for (int i = 0; i < address.SelectNodes("Street").Count; i++)
                    streets[i] = address.SelectNodes("Street")[i].InnerXml;
                string city = address.SelectSingleNode("City").InnerXml;
                string state = address.SelectSingleNode("State").InnerXml;
                string postCode = address.SelectSingleNode("PostalCode").InnerXml;
                string country = address.SelectSingleNode("Country/@isoCountryCode").Value;
                foreach (XmlNode e in address)
                    address.RemoveChild(e);

                string shipToBlock = "<DeliverTo>Lawrence Berkeley National Lab</DeliverTo>";
                if (streets.Length >= 3)
                {
                    shipToBlock += "<Street>" + streets[1] + "</Street>";
                    shipToBlock += "<Street>" + streets[2] + "</Street>";
                    shipToBlock += "<Street>" + streets[0] + "</Street>";
                }
                else if (streets.Length == 2)
                {
                    shipToBlock += "<Street>" + streets[0] + "</Street>";
                    shipToBlock += "<Street>" + streets[1] + "</Street>";
                }
                shipToBlock += "<City>" + city + "</City>";
                shipToBlock += "<State>" + state + "</State>";
                shipToBlock += "<PostalCode>" + postCode + "</PostalCode>";
                shipToBlock += "<Country isoCountryCode=\"" + country + "\"></Country>";
                shipToBlock = shipToBlock.Replace("&", "&amp;");
                address.InnerXml = shipToBlock;

                XmlNodeList itemOuts = cXML.SelectNodes("//ItemOut");
                foreach (XmlNode itemOut in itemOuts)
                {
                    XmlNode unitPrice = itemOut.SelectSingleNode("ItemDetail/UnitPrice/Money");
                    decimal unitP = decimal.Parse(unitPrice.InnerXml);
                    unitP = unitP / 0.98M;
                    unitPrice.InnerXml = unitP.ToString("0.00");
                }

                cXML.SelectSingleNode("//ShipTo/Address/Name").InnerXml = "LAWRENCE BERKELEY LAB / " + deliverTo;
            }
            else if (customerId == "LBNL Industrial PO" && vendorCode == "THORLABS")
            {
                XmlNode shipTo = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo");
                string shipToName = shipTo.SelectSingleNode("Address/Name").InnerXml;

                XmlNodeList streets = shipTo.SelectNodes("Address/PostalAddress/Street");

                if (streets.Count >= 1)
                    shipTo.SelectSingleNode("Address/Name").InnerXml = streets[0].InnerXml;

                string postalAddressXMLBlock = "<DeliverTo>" + shipTo.SelectSingleNode("Address/PostalAddress/DeliverTo").InnerXml + "</DeliverTo>";
                if (streets.Count >= 2) postalAddressXMLBlock += "<Street>" + streets[1].InnerXml + "</Street>";
                if (streets.Count >= 3) postalAddressXMLBlock += "<Street>" + streets[2].InnerXml + "</Street>";
                postalAddressXMLBlock += "<Street>" + shipToName + "</Street>"
                    + "<City>" + shipTo.SelectSingleNode("Address/PostalAddress/City").InnerXml + "</City>"
                    + "<State>" + shipTo.SelectSingleNode("Address/PostalAddress/State").InnerXml + "</State>"
                    + "<PostalCode>" + shipTo.SelectSingleNode("Address/PostalAddress/PostalCode").InnerXml + "</PostalCode>"
                    + "<Country isoCountryCode='" + shipTo.SelectSingleNode("Address/PostalAddress/Country/@isoCountryCode").InnerXml + "'/>";

                shipTo.SelectSingleNode("Address/PostalAddress").InnerXml = postalAddressXMLBlock;

                cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo").InnerXml = shipTo.InnerXml;
            }
            else if (vendorCode.ToUpper() == "DIGIKEY")
            {
                if (customerId == "LBNL Industrial PO" || customerId == "LBNL-V PO")
                {
                    XmlNode postAdd = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress");
                    string deliverTo = postAdd.SelectSingleNode("DeliverTo").InnerXml;
                    string[] streets = new string[postAdd.SelectNodes("Street").Count];
                    for (int i = 0; i < postAdd.SelectNodes("Street").Count; i++)
                        streets[i] = postAdd.SelectNodes("Street")[i].InnerXml;
                    string city = postAdd.SelectSingleNode("City").InnerXml;
                    string state = postAdd.SelectSingleNode("State").InnerXml;
                    string postCode = postAdd.SelectSingleNode("PostalCode").InnerXml;
                    string country = postAdd.SelectSingleNode("Country/@isoCountryCode").Value;

                    string shipToBlock = "<DeliverTo>" + deliverTo + "</DeliverTo>";
                    shipToBlock += "<Street>" + streets[2] + "</Street>";
                    shipToBlock += "<Street>" + streets[1] + "</Street>";
                    shipToBlock += "<Street>FOR THE US DEPT. OF ENERGY</Street>";
                    shipToBlock += "<City>" + city + "</City>";
                    shipToBlock += "<State>" + state + "</State>";
                    shipToBlock += "<PostalCode>" + postCode + "</PostalCode>";
                    shipToBlock += "<Country isoCountryCode=\"" + country + "\"></Country>";
                    shipToBlock = shipToBlock.Replace("&", "&amp;");

                    XmlNodeList addresses = cXML.SelectNodes("//ShipTo/Address");
                    foreach (XmlNode a in addresses)
                    {
                        XmlNode add = a.SelectSingleNode("PostalAddress");
                        foreach (XmlNode e in add)
                            add.RemoveChild(e);
                        add.InnerXml = shipToBlock;
                        a.SelectSingleNode("Name").InnerXml = streets[0];
                    }

                    cXML.SelectSingleNode("cXML").Attributes["version"].InnerXml = "1.2.009";
                    XmlNodeList itemDetail = cXML.SelectNodes("//ItemOut/ItemDetail");
                    foreach (XmlNode node in itemDetail)
                    {
                        XmlNode unitPrice = node.SelectSingleNode("UnitPrice/Money");
                        if (unitPrice != null)
                        {
                            try
                            {
                                decimal unitPriceDeci = decimal.Parse(unitPrice.InnerText);
                                unitPriceDeci = unitPriceDeci / 0.98M;
                                unitPrice.InnerXml = unitPriceDeci.ToString("G29");
                            }
                            catch { }
                        }

                        XmlNodeList classes = node.SelectNodes("Classification");
                        if (classes != null)
                        {
                            foreach (XmlNode n in classes)
                                if (n.Attributes["domain"].InnerXml.Length == 0)
                                    node.RemoveChild(n);
                        }

                        XmlNode url = node.SelectSingleNode("URL");
                        if (url != null)
                            node.RemoveChild(url);
                    }

                    string comments = cXML.SelectSingleNode("//OrderRequestHeader/Comments").InnerXml;
                    if (comments == "Overnight Shipping")
                        cXML.SelectSingleNode("//OrderRequestHeader/Comments").InnerXml = "***Overnight Order - Prepay/Add on Digikey Acct***";
                }
                else if (customerId == "BMEI")
                {
                    XmlNode orderRequestHeader = cXML.SelectSingleNode("//OrderRequestHeader");
                    if (orderRequestHeader.SelectSingleNode("Contact") != null)
                    {
                        foreach (XmlNode contact in orderRequestHeader.SelectNodes("Contact"))
                            orderRequestHeader.RemoveChild(contact);
                    }

                    foreach (XmlNode itemOut in cXML.SelectNodes("//OrderRequest/ItemOut"))
                    {
                        XmlNode itemDetail = itemOut.SelectSingleNode("ItemDetail");
                        XmlNode manufacturerName = itemDetail.SelectSingleNode("ManufacturerName");
                        if (manufacturerName != null)
                            itemDetail.RemoveChild(manufacturerName);
                    }
                }
                else if (customerId == "Battelle")
                {
                    try
                    {
                        XmlAttribute attr1 = cXML.SelectSingleNode("cXML").Attributes["xmlns:xsi"];
                        if (attr1 != null) cXML.SelectSingleNode("cXML").Attributes.Remove(attr1);

                        XmlAttribute attr2 = cXML.SelectSingleNode("cXML").Attributes["xmlns:xsd"];
                        if (attr2 != null) cXML.SelectSingleNode("cXML").Attributes.Remove(attr2);
                    }
                    catch { }
                }
                else if (customerId == "PNNL")
                {
                    try
                    {
                        string email = "";
                        XmlNodeList nodes = cXML.SelectNodes("//OrderRequest/ItemOut");
                        foreach (XmlNode node in nodes)
                            email = node.SelectSingleNode("ShipTo/Address/Email").InnerText;

                        if (email.Length > 0)
                        {
                            cXML.SelectSingleNode("//OrderRequestHeader/ShipTo/Address/Email").InnerText = email;

                            //string[] emailArray = email.Split('@');
                            //string[] nameArray = emailArray[0].Split('.');
                            //string name = nameArray[0];
                            //if (nameArray.Length > 1) name += " " + nameArray[1];

                            //string[] streets = new string[cXML.SelectNodes("//OrderRequestHeader/ShipTo/Address/PostalAddress/Street").Count];
                            //for (int i = 0; i < cXML.SelectNodes("//OrderRequestHeader/ShipTo/Address/PostalAddress/Street").Count; i++)
                            //    streets[i] = cXML.SelectNodes("//OrderRequestHeader/ShipTo/Address/PostalAddress/Street")[i].InnerText;
                            //string street3 = streets.Length >= 3 ? streets[2] : name;

                            //string shipToAddress = "<DeliverTo>" + street3 + "</DeliverTo>";
                            //if (streets.Length > 0) shipToAddress += "<Street>" + streets[0] + "</Street>";
                            //if (streets.Length > 1) shipToAddress += "<Street>" + streets[1] + "</Street>";
                            //shipToAddress += "<Street>" + cXML.SelectSingleNode("//OrderRequestHeader/ShipTo/Address/PostalAddress/DeliverTo").InnerXml + "</Street>"
                            //    + "<City>" + cXML.SelectSingleNode("//OrderRequestHeader/ShipTo/Address/PostalAddress/City").InnerXml + "</City>"
                            //    + "<State>" + cXML.SelectSingleNode("//OrderRequestHeader/ShipTo/Address/PostalAddress/State").InnerXml + "</State>"
                            //    + "<PostalCode>" + cXML.SelectSingleNode("//OrderRequestHeader/ShipTo/Address/PostalAddress/PostalCode").InnerXml + "</PostalCode>"
                            //    + "<Country isoCountryCode='" + cXML.SelectSingleNode("//OrderRequestHeader/ShipTo/Address/PostalAddress/Country/@isoCountryCode").InnerXml + "'/>";
                            //cXML.SelectSingleNode("//OrderRequestHeader/ShipTo/Address/PostalAddress").InnerXml = shipToAddress;
                        }
                    }
                    catch { }

                    XmlNodeList itemDetail = cXML.SelectNodes("//ItemOut/ItemDetail");
                    foreach (XmlNode node in itemDetail)
                    {
                        XmlNode unitPrice = node.SelectSingleNode("UnitPrice/Money");
                        if (unitPrice != null)
                        {
                            try
                            {
                                decimal unitPriceDeci = decimal.Parse(unitPrice.InnerText);
                                unitPriceDeci = unitPriceDeci / 0.98M;
                                unitPrice.InnerXml = unitPriceDeci.ToString("G29");
                            }
                            catch { }
                        }
                    }
                }
                else if (customerId == "SLAC")
                {
                    XmlNodeList itemDetail = cXML.SelectNodes("//ItemOut/ItemDetail");
                    foreach (XmlNode node in itemDetail)
                    {
                        XmlNode unitPrice = node.SelectSingleNode("UnitPrice/Money");
                        if (unitPrice != null)
                        {
                            try
                            {
                                decimal unitPriceDeci = decimal.Parse(unitPrice.InnerText);
                                unitPriceDeci = unitPriceDeci / 0.96M;
                                unitPrice.InnerXml = unitPriceDeci.ToString("G29");
                            }
                            catch { }
                        }
                    }
                }

                try
                {
                    XmlNodeList contacts = cXML.SelectNodes("//Contact");
                    foreach (XmlNode contact in contacts)
                        if (contact.SelectSingleNode("@role").InnerText.Contains(" "))
                            contact.SelectSingleNode("@role").InnerText = contact.SelectSingleNode("@role").InnerText.Replace(" ", "").Trim();
                }
                catch { }
            }
            else if (customerId == "LBNL Industrial PO" && (vendorCode.ToUpper() == "PRAXAIR" || vendorCode.ToUpper() == "LINDE"))
            {
                XmlNodeList shiptos = cXML.SelectNodes("//ShipTo");
                foreach (XmlNode shipto in shiptos)
                {
                    XmlNode postalAddress = shipto.SelectSingleNode("Address/PostalAddress");
                    XmlNodeList streets = postalAddress.SelectNodes("Street");
                    string shipToBlock = "<DeliverTo>" + postalAddress.SelectSingleNode("DeliverTo").InnerXml.Split('/')[0].Trim() + "</DeliverTo>"
                        + "<Street>" + streets[1].InnerXml + "</Street>"
                        + "<Street>" + streets[2].InnerXml + "</Street>"
                        + "<City>" + postalAddress.SelectSingleNode("City").InnerXml + "</City>"
                        + "<State>" + postalAddress.SelectSingleNode("State").InnerXml + "</State>"
                        + "<PostalCode>" + postalAddress.SelectSingleNode("PostalCode").InnerXml + "</PostalCode>"
                        + "<Country isoCountryCode=\"" + postalAddress.SelectSingleNode("Country/@isoCountryCode").InnerXml + "\"></Country>";
                    postalAddress.InnerXml = shipToBlock;
                    shipto.SelectSingleNode("Address/Name").InnerXml = streets[0].InnerXml;
                }
            }
            else if (customerId == "LBNL-V PO" && vendorCode == "QIAGEN")
            {
                cXML.SelectSingleNode("cXML/@payloadID").InnerXml = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/@orderID").InnerXml + "@govsci.com";
            }
            else if (customerId == "LBNL-V PO" && (vendorCode == "MILLIPORE" || vendorCode == "SIGMA"))
            {
                XmlNode orderReqHeader = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader");
                if (orderReqHeader.SelectSingleNode("Payment") != null)
                    orderReqHeader.RemoveChild(orderReqHeader.SelectSingleNode("Payment"));

                XmlNodeList shipToPhone = cXML.SelectNodes("//ShipTo/Address/Phone/TelephoneNumber/CountryCode");
                foreach (XmlNode s in shipToPhone)
                    s.SelectSingleNode("@isoCountryCode").InnerXml = "US";

                cXML.SelectSingleNode("cXML/@payloadID").InnerXml = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/@orderID").InnerXml + "@govsci.com";

                XmlNode postalAddress = cXML.SelectSingleNode("//ShipTo/Address/PostalAddress");
                string deliverTo = postalAddress.SelectSingleNode("DeliverTo").InnerXml;
                string[] streets = new string[postalAddress.SelectNodes("Street").Count];
                for (int i = 0; i < streets.Length; i++)
                    streets[i] = postalAddress.SelectNodes("Street")[i].InnerXml;
                string city = postalAddress.SelectSingleNode("City").InnerXml;
                string state = postalAddress.SelectSingleNode("State").InnerXml;
                string postalCode = postalAddress.SelectSingleNode("PostalCode").InnerXml;
                string country = postalAddress.SelectSingleNode("Country").InnerXml;
                string countryCode = postalAddress.SelectSingleNode("Country/@isoCountryCode").InnerXml;

                string addressBlock = "<DeliverTo>" + deliverTo + "</DeliverTo>"
                    + "<DeliverTo>" + streets[2] + "</DeliverTo>"
                    + "<Street>" + streets[1] + "</Street>"
                    + "<City>" + city + "</City>"
                    + "<State>" + state + "</State>"
                    + "<PostalCode>" + postalCode + "</PostalCode>"
                    + "<Country isoCountryCode='" + countryCode + "'>" + countryCode + "</Country>";

                cXML.SelectSingleNode("//ShipTo/Address/Name").InnerXml = streets[0];
                postalAddress.InnerXml = addressBlock;
            }
            else if (customerId == "LBNL-V PO" && vendorCode == "VWR")
            {
                XmlNodeList delToNodes = cXML.SelectNodes("//ShipTo/Address/PostalAddress/DeliverTo");
                foreach (XmlNode delToNode in delToNodes)
                    delToNode.InnerXml = delToNode.InnerXml.Split('/')[0].Trim();

                XmlNode orderRequest = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader");
                XmlAttribute orderVersion = orderRequest.Attributes["orderVersion"];
                if (orderVersion != null)
                    orderRequest.Attributes.Remove(orderVersion);

                XmlNodeList itemOut = cXML.SelectNodes("//ItemOut");
                foreach (XmlNode n in itemOut)
                {
                    XmlNode itemDetail = n.SelectSingleNode("ItemDetail");
                    if (itemDetail.SelectSingleNode("URL") != null)
                        itemDetail.RemoveChild(itemDetail.SelectSingleNode("URL"));
                    XmlNode url = cXML.CreateElement("URL");
                    itemDetail.AppendChild(url);
                }
            }
            else if (customerId == "LBNL-V PO" && vendorCode == "LIFE TECHNOLOGIES")
            {
                XmlNodeList itemOuts = cXML.SelectNodes("//ItemOut");
                foreach (XmlNode itemOut in itemOuts)
                {
                    XmlNode unitPrice = itemOut.SelectSingleNode("ItemDetail/UnitPrice/Money");
                    decimal unitP = decimal.Parse(unitPrice.InnerXml);
                    unitP = unitP / 0.965M;
                    unitPrice.InnerXml = unitP.ToString("0.000");
                }
            }
            else if (customerId == "LBNL-V PO" && vendorCode == "OPERON")
            {
                string bldgroom = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Extrinsic[@name=\"DELIVER_TO\"]").InnerXml;
                string shipToBlock = "";
                XmlNode address = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress");
                if (bldgroom.StartsWith("978"))
                {
                    string deliverTo = address.SelectSingleNode("DeliverTo").InnerXml.Split('/')[0].Trim();
                    string country = address.SelectSingleNode("Country/@isoCountryCode").Value;
                    shipToBlock = "<DeliverTo>" + deliverTo + "</DeliverTo>";
                    shipToBlock += "<Street>JOINT BIOENERGY INSTITUTE / LBNL</Street>";
                    shipToBlock += "<Street>5885 HOLLIS STREET 4TH FL</Street>";
                    shipToBlock += "<Street>DELIVER TO " + bldgroom + "</Street>";
                    shipToBlock += "<City>EMERYVILLE</City>";
                    shipToBlock += "<State>CA</State>";
                    shipToBlock += "<PostalCode>94608</PostalCode>";
                    shipToBlock += "<Country isoCountryCode=\"" + country + "\"></Country>";

                    shipToBlock = shipToBlock.Replace("&", "&amp;");
                    XmlNodeList addresses = cXML.SelectNodes("//ShipTo/Address/PostalAddress");
                    foreach (XmlNode a in addresses)
                    {
                        foreach (XmlNode e in a)
                            a.RemoveChild(e);
                        a.InnerXml = shipToBlock;
                    }
                }
            }
            else if (customerId == "LBNL-V PO" && vendorCode == "ROCHE")
            {
                string bldgroom = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Extrinsic[@name=\"DELIVER_TO\"]").InnerXml;
                XmlNode postAdd = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress");
                string deliverTo = postAdd.SelectSingleNode("DeliverTo").InnerXml;
                string[] streets = new string[postAdd.SelectNodes("Street").Count];
                for (int i = 0; i < postAdd.SelectNodes("Street").Count; i++)
                    streets[i] = postAdd.SelectNodes("Street")[i].InnerXml;
                string city = postAdd.SelectSingleNode("City").InnerXml;
                string state = postAdd.SelectSingleNode("State").InnerXml;
                string postCode = postAdd.SelectSingleNode("PostalCode").InnerXml;
                string country = postAdd.SelectSingleNode("Country/@isoCountryCode").Value;

                string shipToBlock = "<DeliverTo>" + deliverTo + " / " + bldgroom + "</DeliverTo>";
                shipToBlock += "<Street>" + streets[1] + "</Street>";
                shipToBlock += "<City>" + city + "</City>";
                shipToBlock += "<State>" + state + "</State>";
                shipToBlock += "<PostalCode>" + postCode + "</PostalCode>";
                shipToBlock += "<Country isoCountryCode=\"" + country + "\"></Country>";
                shipToBlock = shipToBlock.Replace("&", "&amp;");

                XmlNodeList addresses = cXML.SelectNodes("//ShipTo/Address");
                foreach (XmlNode a in addresses)
                {
                    XmlNode add = a.SelectSingleNode("PostalAddress");
                    foreach (XmlNode e in add)
                        add.RemoveChild(e);
                    add.InnerXml = shipToBlock;
                    a.SelectSingleNode("Name").InnerXml = streets[0];
                }

                XmlNodeList itemOut = cXML.SelectNodes("//ItemOut");
                foreach (XmlNode n in itemOut)
                {
                    XmlNode itemDetail = n.SelectSingleNode("ItemDetail");

                    XmlNodeList classes = itemDetail.SelectNodes("Classification");
                    foreach (XmlNode c in classes)
                    {
                        if (c.SelectSingleNode("@domain") == null)
                            itemDetail.RemoveChild(c);
                        else if (c.SelectSingleNode("@domain").InnerXml.Length == 0)
                            itemDetail.RemoveChild(c);
                    }

                    if (itemDetail.SelectSingleNode("URL") != null)
                        itemDetail.RemoveChild(itemDetail.SelectSingleNode("URL"));
                    XmlNode url = cXML.CreateElement("URL");
                    itemDetail.AppendChild(url);
                }
            }
            else if (customerId == "LBNL-V PO" && vendorCode == "FISHER SCIENTIFIC")
            {
                cXML.SelectSingleNode("//ShipTo/Address/@addressID").InnerXml = "084351018";
                /*XmlNodeList itemOuts = cXML.SelectNodes("//ItemOut");
                foreach (XmlNode itemOut in itemOuts)
                {
                    XmlNode unitPrice = itemOut.SelectSingleNode("ItemDetail/UnitPrice/Money");
                    decimal unitP = decimal.Parse(unitPrice.InnerXml);
                    unitP = unitP / 0.99M;
                    unitPrice.InnerXml = unitP.ToString("0.00");
                }*/
            }
            else if (customerId == "SLAC" && (vendorCode == "DELL" || vendorCode == "DELL+Overnight" || vendorCode == "DELL IT" || vendorCode == "Dell Ready Stock" || vendorCode == "DELL READY STOCK"))
            {
                if (vendorCode.Contains("+Overnight"))
                    cXML.SelectSingleNode("//OrderRequestHeader/Comments").InnerXml = "Overnight Shipping";

                vendorCode = vendorCode.Replace("+Overnight", "");

                XmlNodeList items = cXML.SelectNodes("//ItemOut");
                foreach (XmlNode item in items)
                {
                    string supplierPartNo = item.SelectSingleNode("ItemID/SupplierPartID").InnerXml;
                    string supplierPartNo2 = item.SelectSingleNode("ItemID/SupplierPartAuxiliaryID").InnerXml;
                    string uom = item.SelectSingleNode("ItemDetail/UnitOfMeasure").InnerXml;
                    decimal unitPrice = decimal.Parse(item.SelectSingleNode("ItemDetail/UnitPrice/Money").InnerXml);
                    decimal price = Database.GetItemListPrice(supplierPartNo, supplierPartNo2, uom, vendorCode);

                    if (price > 0)
                        item.SelectSingleNode("ItemDetail/UnitPrice/Money").InnerXml = price.ToString();
                    else
                        item.SelectSingleNode("ItemDetail/UnitPrice/Money").InnerXml = (unitPrice / 1.0275M).ToString();
                }

                //if (vendorCode == "DELL IT")
                //{
                //    XmlElement extrinsic = cXML.CreateElement("Extrinsic");
                //    extrinsic.SetAttribute("name", "barcodeRequired");
                //    extrinsic.AppendChild(cXML.CreateTextNode("Yes"));
                //    cXML.SelectSingleNode("OrderRequestHeader").AppendChild(extrinsic);
                //}
            }
            else if (customerId == "SLAC.Chem" && vendorCode == "AIRGAS")
            {
                string deliverTo = cXML.SelectSingleNode("//OrderRequestHeader/Extrinsic[@name=\"DELIVER_TO\"]").InnerXml;
                if (deliverTo.Length > 0)
                    cXML.SelectSingleNode("//OrderRequestHeader/ShipTo/Address/@addressID").InnerXml = deliverTo.Trim();
            }
            else if (customerId == "SLAC.Chem" && (vendorCode == "VWR INTERNATIONAL" || vendorCode == "GRAINGER" || vendorCode == "MSC INDUSTRIAL SUPPLY"))
            {
                string shipTo = "<Address addressID=\"GSSCA\">"
                    + "<Name xml:lang=\"en\">Government Scientific Source</Name>"
                    + "<PostalAddress name=\"GSSCA\">"
                    + "<DeliverTo>" + cXML.SelectSingleNode(@"//OrderRequestHeader/@orderID").InnerText + "</DeliverTo>"
                    + "<Street>258 Lindbergh Ave</Street>"
                    + "<City>Livermore</City>"
                    + "<State>CA</State>"
                    + "<PostalCode>94551</PostalCode>"
                    + "<Country isoCountryCode=\"US\">US</Country>"
                    + "</PostalAddress><Email name=\"Recipent\">slac.purchasing@govsci.com</Email>"
                    + "<Phone><TelephoneNumber><CountryCode isoCountryCode=\"\"/><AreaOrCityCode>877</AreaOrCityCode><Number>202-779</Number></TelephoneNumber></Phone></Address>";
                cXML.SelectSingleNode("//ShipTo").InnerXml = shipTo;
            }
            else if ((customerId == "Idaho National Lab" || customerId == "SLAC" || customerId == "JLab") && vendorCode == "MSC")
            {
                foreach (XmlNode item in cXML.SelectNodes("//ItemOut"))
                {
                    string description = item.SelectSingleNode("ItemDetail/Description").InnerXml;
                    if (!description.ToUpper().Contains("PROMO WEBSALE01"))
                    {
                        description = "<![CDATA[Promo WEBSALE01: " + description + "]]>";
                        item.SelectSingleNode("ItemDetail/Description").InnerXml = description;
                    }
                }
            }

            else if (customerId == "Battelle" && vendorCode.ToUpper() == "GRAINGER")
            {
                try
                {
                    XmlNodeList nodes = cXML.SelectNodes("//OrderRequestHeader/Extrinsic");
                    int count = 0;
                    foreach (XmlNode node in nodes)
                    {
                        if (node.SelectSingleNode("@name").InnerXml.Length == 0)
                            node.SelectSingleNode("@name").InnerXml = count > 0 ? "email" + count : "email";
                        if (node.InnerXml.Length == 0)
                            node.InnerXml = "battelle@govsci.com";
                        count++;
                    }


                    nodes = cXML.SelectNodes("//OrderRequest/ItemOut");
                    foreach (XmlNode node in nodes)
                    {
                        XmlNode distribution = node.SelectSingleNode("Distribution");
                        XmlNode accounting = distribution.SelectSingleNode("Accounting");
                        if (accounting.SelectSingleNode("@name").InnerXml.Length == 0)
                            accounting.SelectSingleNode("@name").InnerXml = "DistributionCharge";
                    }
                }
                catch { }
            }

            else if (customerId == "JLab" && vendorCode.ToUpper() == "GLOBAL INDUSTRIAL")
            {
                XmlNode orderRequestHeader = cXML.SelectSingleNode("//OrderRequestHeader");
                if (orderRequestHeader != null)
                {
                    if (orderRequestHeader.SelectSingleNode("Payment") != null)
                        orderRequestHeader.RemoveChild(orderRequestHeader.SelectSingleNode("Payment"));
                }
            }

            if (vendorCode == "Agilent")
            {
                XmlNodeList itemOuts = cXML.SelectNodes("//ItemOut");
                foreach (XmlNode itemOut in itemOuts)
                {
                    string vendorItemNo = itemOut.SelectSingleNode("ItemID/SupplierPartID").InnerXml;
                    string uom = itemOut.SelectSingleNode("ItemDetail/UnitOfMeasure").InnerXml;
                    string disco = Database.GetDiscountCode("Agilent", vendorItemNo, uom);
                    //   output("Agilent, " + vendorItemNo + ", " + uom + ", " + disco);

                    if (disco.Length > 0)
                    {
                        XmlElement extrinsic = cXML.CreateElement("Extrinsic");
                        extrinsic.SetAttribute("name", "productline");
                        extrinsic.AppendChild(cXML.CreateTextNode(disco));
                        itemOut.SelectSingleNode("ItemDetail").AppendChild(extrinsic);
                    }
                }
            }
            return cXML;
        }
    }
}
