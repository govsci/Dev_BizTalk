using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using BizTalkLibrary.Objects;
using System.Text.RegularExpressions;

namespace BizTalkLibrary.Classes
{
    public static class Database
    {
        public static string ValidateCustomerPoCreds(string customerID, string sharedSecret)
        {
            using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("[Ecommerce.Biztalk.Control]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@method", "CHECK CREDS"));
                cmd.Parameters.Add(new SqlParameter("@fromIdentity", customerID));
                cmd.Parameters.Add(new SqlParameter("@sharedSecret", sharedSecret));
                using (SqlDataReader rs = cmd.ExecuteReader())
                {
                    if (rs.Read())
                    {
                        string dumpFolder = GetString(rs, "dumpFolder");
                        if (dumpFolder.Length == 0) dumpFolder = "PASS";
                        return dumpFolder;
                    }
                }
            }
            return "";
        }

        public static string GetNavSellToCustomerNo(ref string salesTeamColor, Credentials creds, string shipToCode, string shipToCity, string shipToName)
        {
            string SellToCustomerNo = "", query = "[Ecommerce.Biztalk.Control]";
            using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@method", "GetNavSellToCustomerNo"));
                    cmd.Parameters.Add(new SqlParameter("@fromIdentity", creds.FromIdentity));
                    cmd.Parameters.Add(new SqlParameter("@sharedSecret", creds.SharedSecret));
                    cmd.Parameters.Add(new SqlParameter("@shipToCode", shipToCode));
                    cmd.Parameters.Add(new SqlParameter("@shipToCity", shipToCity));
                    cmd.Parameters.Add(new SqlParameter("@shipToName", shipToName));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (GetString(reader, "customerShipTo") != "") // Handles multiple SellToCustomerNo for one credential, especially LLNL
                            {
                                if (shipToCode == GetString(reader, "customerShipTo"))
                                {
                                    SellToCustomerNo = GetString(reader, "navSellToCustomerNo");
                                    salesTeamColor = GetString(reader, "salesTeamColor");
                                    break;
                                }
                            }
                            else
                            {
                                SellToCustomerNo = GetString(reader, "navSellToCustomerNo");
                                salesTeamColor = GetString(reader, "salesTeamColor");
                            }
                        }
                    }
                }
            }
            return SellToCustomerNo;
        }

        public static string CheckCustomerPoNavision(string customerNo, string orderId)
        {
            string no = "";

            using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand("[Ecommerce.Biztalk.Functions.Control]", dbcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@method", "CHECK CUSTOMER PO NAV"));
                cmd.Parameters.Add(new SqlParameter("@customerNo", customerNo));
                cmd.Parameters.Add(new SqlParameter("@orderId", orderId));
                using (SqlDataReader rs = cmd.ExecuteReader())
                    if (rs.Read())
                        no = GetString(rs, 0);
            }

            return no;
        }

        public static bool CheckGssPartNo(string no)
        {
            string query = "SELECT [No_] FROM [dbo].[Government Scientific Source$Item] WHERE [No_] = '" + no + "'";
            using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
            {
                dbcon.Open();
                using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                    if (rs.Read() && GetString(rs,0) == no)
                        return true;
            }

            return false;
        }
        
        public static string GetVendorName(string fromIdentity, string sharedSecret, string customerVendorCode)
        {
            string vendor = "";

            string query = "SELECT [vendorName] FROM [dbo].[Ecommerce$Bypass Customer Vendor Code Convert] WHERE "
                + "[fromIdentity] = '" + fromIdentity + "' AND [sharedSecret] = '" + sharedSecret + "' AND [customerVendorCode] = '" + customerVendorCode.Replace("'", "''") + "'";

            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                    if (rs.Read())
                        vendor = GetString(rs, 0);
            }

            if (vendor.Length == 0)
                vendor = customerVendorCode;

            return vendor;
        }

        public static int GetShipToID(Credentials creds, Address addr, string orderID)
        {
            int id = 0;
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
                {
                    dbcon.Open();
                    cmd = new SqlCommand("[dbo].[Ecommerce.Inbound.PO.Control]", dbcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@method", "CHECK SHIP TO"));
                    cmd.Parameters.Add(new SqlParameter("@FromIdentity", creds.FromIdentity));
                    cmd.Parameters.Add(new SqlParameter("@SharedSecret", creds.SharedSecret));
                    cmd.Parameters.Add(new SqlParameter("@ShipToName", addr.Name));

                    cmd.Parameters.Add(new SqlParameter("@ShipToStreet1", addr.Streets.Count > 0 ? addr.Streets[0] : ""));
                    cmd.Parameters.Add(new SqlParameter("@ShipToStreet2", addr.Streets.Count > 1 ? addr.Streets[1] : ""));
                    cmd.Parameters.Add(new SqlParameter("@ShipToStreet3", addr.Streets.Count > 2 ? addr.Streets[2] : ""));

                    cmd.Parameters.Add(new SqlParameter("@ShipToCity", addr.City));
                    cmd.Parameters.Add(new SqlParameter("@ShipToState", addr.State));
                    cmd.Parameters.Add(new SqlParameter("@ShipToPostalCode", addr.PostalCode));
                    cmd.Parameters.Add(new SqlParameter("@ShipToCountry", addr.Country));
                    cmd.Parameters.Add(new SqlParameter("@ShipToCountryCode", addr.CountryCode));

                    using (SqlDataReader rs = cmd.ExecuteReader())
                        if (rs.Read())
                            id = GetInteger(rs, 0);
                }

            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Database", "GetShipToID", orderID, cmd);
            }

            return id;
        }

        public static SalesQuoteHeader GetSalesQuote(string orderid, string salesQuoteNo)
        {
            SalesQuoteHeader quote = new SalesQuoteHeader();
            SqlCommand cmd = null;

            using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
            {
                dbcon.Open();

                cmd = new SqlCommand("[dbo].[Ecommerce.Biztalk.In.Control]", dbcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@method", "GET SALES QUOTE"));
                cmd.Parameters.Add(new SqlParameter("@quoteNo", salesQuoteNo));
                using (SqlDataReader rs = cmd.ExecuteReader())
                {
                    if (rs.Read())
                    {
                        try
                        {
                            quote = new SalesQuoteHeader();
                            quote.ContactEmail = GetString(rs,"Contact E-Mail");
                            quote.ContactName = GetString(rs, "Contact Name");
                        }
                        catch (Exception ex)
                        {
                            Email.SendErrorMessage(ex, "", "Database", "GetSalesQuote", orderid, cmd);
                        }
                    }

                    rs.NextResult();
                    int line = 1;
                    while (rs.Read())
                    {
                        try
                        {
                            SalesQuoteLine salesLine = new SalesQuoteLine();
                            salesLine.Quantity = GetString(rs, "Quantity");
                            salesLine.No_ = GetString(rs, "No_");
                            salesLine.Unit_Cost_LCY = GetString(rs, "Unit Cost (LCY)");
                            salesLine.Unit_Of_Measure_Code = GetString(rs, "Unit Of Measure Code");
                            salesLine.Unit_Price = GetString(rs, "Unit Price");
                            salesLine.Description = GetString(rs, "Description");
                            salesLine.Line_No = line;
                            line += 1;
                            quote.QuoteLines.Add(salesLine);
                        }
                        catch (Exception ex)
                        {
                            Email.SendErrorMessage(ex, "", "Database", "GetSalesQuote", orderid, cmd);
                        }
                    }
                }
            }

            return quote;
        }

        public static string GetContactName(string sellTo, string email)
        {
            string query = "SELECT [Contact Name] FROM [dbo].[Government Scientific Source$Customer Contacts] WHERE [Sell-to Customer No_] = '" + sellTo + "' AND [Contact E-Mail] = '" + email + "'";
            using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
            {
                dbcon.Open();
                using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                    if (rs.Read())
                        return GetString(rs,0);
            }

            return email.Remove(email.IndexOf("@"));
        }

        public static string GetUnitOfMeasure(string xmluom)
        {
            string uom = "";

            using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
            {
                string uomQuery = $"SELECT [navisionUOM] FROM [Ecommerce$Bypass Inbound UOM] WHERE [customerUOM] = '{xmluom}'";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(uomQuery, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        if (reader.Read())
                            uom = GetString(reader, "navisionUOM");
            }

            return uom;
        }

        public static string GetUnitOfMeasure(string uom, string mfcName)
        {
            string vendorUom = "";

            using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
            {
                string uomQuery = $"SELECT [vendorUOM] FROM [Ecommerce$Unit of Measure Vendor Conversion] WHERE [uom] = '{uom}' AND [mfcName]='{mfcName}'";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(uomQuery, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                        vendorUom = reader["vendorUOM"].ToString();
                }
            }

            return vendorUom;
        }

        public static Customer GetCustomerConfig(string customerId, string sharedSecret)
        {
            Customer customer = new Customer();
            using(SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                using(SqlDataReader rs = new SqlCommand($"SELECT [bypassPO],[importSO],[orderConfirmation],[parent],[organizationDesc] FROM [dbo].[Ecommerce$Punchout Setup] WHERE [customerID]='{customerId}' AND [sharedSecret]='{sharedSecret}'", dbcon).ExecuteReader())
                {
                    if(rs.Read())
                    {
                        customer.BypassPo = GetInteger(rs, "bypassPO");
                        customer.ImportSo = GetInteger(rs, "importSO");
                        customer.OrderConfirmation = GetInteger(rs, "orderConfirmation");
                        customer.Parent = GetInteger(rs, "parent");
                        customer.OrganizationDesc = GetString(rs, "organizationDesc");
                    }
                }
            }
            return customer;
        }

        public static void RecordCxmlData(string type, XmlDocument cXML, string timestamp, ref string manufacturerName, string vendorURL = "")
        {
            Constants.F1 setValue = x => x == null ? "" : x.InnerXml.Replace("'", "''");
            Constants.F1 retreiveValue = x => x.InnerXml ?? "";

            /* ################################# cXML Header extractor ################################## */

            string deploymentMode, date, orderID, total, query = "";
            string shipToAddressID, shipToName, shipToPostalName, shipToDeliverTo, shipToCity, shipToState, shipToPostalCode, shipToCountry;
            string[] shipToStreet = { "", "", "", "" };
            string[] billToStreet = { "", "", "", "" };
            string shipToEmail, shipToPhoneName, shipToPhoneCountryCode, shipToPhoneAreaCode, shipToPhoneNumber, extra = "";
            string shipToFaxName, shipToFaxCountryCode, shipToFaxAreaCode, shipToFaxNumber;
            string billToAddressID, billToName, billToPostalName, billToCity, billToState, billToPostalCode, billToCountry, billToDeliverTo;
            string pcardnumber, pcardname, pcardexpiration, paymentTerms;
            Credentials creds = Global.GetCredentials(cXML);

            deploymentMode = setValue(cXML.SelectSingleNode("cXML/Request/@deploymentMode"));
            date = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/@orderDate"));
            orderID = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/@orderID"));
            total = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Total/Money"));
            total = total.Replace(",", "").Replace("$", "");
            total = total.Length == 0 ? "0" : total;
            shipToAddressID = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/@addressID"));
            shipToName = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Name"));
            shipToPostalName = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/@name"));
            shipToDeliverTo = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/DeliverTo"));
            billToDeliverTo = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/DeliverTo"));

            XmlNodeList extrinsics = cXML.SelectNodes("//OrderRequestHeader/Extrinsic");
            foreach (XmlNode e in extrinsics)
            {
                string eName = e.SelectSingleNode("@name").Value;
                string eValue = e.InnerXml;
                extra += eName + ":" + eValue + "|";
            }

            for (int i = 0; i < cXML.SelectNodes("//cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/Street").Count; i++)
                shipToStreet[i] = cXML.SelectNodes("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/Street").Item(i).InnerXml.Replace("'", "''") ?? "";

            shipToCity = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/City"));
            shipToState = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/State"));
            shipToPostalCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/PostalCode"));
            shipToCountry = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/Country"));

            shipToEmail = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Email"));
            shipToPhoneName = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Phone/@name"));
            shipToPhoneCountryCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Phone/TelephoneNumber/CountryCode/@isoCountryCode"));
            shipToPhoneAreaCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Phone/TelephoneNumber/AreaOrCityCode"));
            shipToPhoneNumber = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Phone/TelephoneNumber/Number"));

            shipToFaxName = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Fax/@name"));
            shipToFaxCountryCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Fax/TelephoneNumber/CountryCode/@isoCountryCode"));
            shipToFaxAreaCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Fax/TelephoneNumber/AreaOrCityCode"));
            shipToFaxNumber = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Fax/TelephoneNumber/Number"));

            billToAddressID = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/@addressID"));
            billToName = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/Name"));
            billToPostalName = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/@name"));

            for (int i = 0; i < cXML.SelectNodes("//cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/Street").Count; i++)
                billToStreet[i] = cXML.SelectNodes("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/Street").Item(i).InnerXml ?? "";

            billToCity = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/City"));
            billToState = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/State"));
            billToPostalCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/PostalCode"));
            billToCountry = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/PostalAddress/Country"));

            pcardnumber = setValue(cXML.SelectSingleNode("//cXML/Request/OrderRequest/OrderRequestHeader/Payment/PCard/@number"));
            pcardexpiration = setValue(cXML.SelectSingleNode("//cXML/Request/OrderRequest/OrderRequestHeader/Payment/PCard/@expiration"));
            pcardname = setValue(cXML.SelectSingleNode("//cXML/Request/OrderRequest/OrderRequestHeader/Payment/PCard/@name"));

            paymentTerms = setValue(cXML.SelectSingleNode("//PaymentTerm/@payInNumberOfDays"));

            if (pcardnumber.Length > 0) pcardnumber = CustomTextEncrypt.Encode(pcardnumber);
            if (pcardexpiration.Length > 0) pcardexpiration = CustomTextEncrypt.Encode(pcardexpiration);
            if (pcardname.Length > 0) pcardname = CustomTextEncrypt.Encode(pcardname);

            // ##################### JLAB Requirement ################
            string comments = "", followUpURL, attachments = "";
            try
            {
                XmlNode xmlComments = cXML.SelectSingleNode("//OrderRequestHeader/Comments");
                if (xmlComments != null)
                    comments = xmlComments.InnerText;

                foreach(XmlNode attachment in xmlComments.SelectNodes("Attachment"))
                    if (attachment.SelectSingleNode("URL") != null)
                        attachments += attachments.Length>0 ? ";" + attachment.SelectSingleNode("URL").InnerText : attachment.SelectSingleNode("URL").InnerText;
            }
            catch { comments = ""; }

            try
            {
                followUpURL = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Followup/URL"));
                Global.OpenReferenceURL(followUpURL);  // JLAB Click
            }
            catch { followUpURL = ""; }
            // ##################### JLAB Requirement ################

            int id = 0;
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Ecommerce.Biztalk.Control]", dbcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@method", "INSERT BYPASS HEADER"));
                cmd.Parameters.Add(new SqlParameter("@type", type));
                cmd.Parameters.Add(new SqlParameter("@mode", deploymentMode));
                cmd.Parameters.Add(new SqlParameter("@identity", creds.FromIdentity));
                cmd.Parameters.Add(new SqlParameter("@date", date));
                cmd.Parameters.Add(new SqlParameter("@orderID", orderID));
                cmd.Parameters.Add(new SqlParameter("@total", total));
                cmd.Parameters.Add(new SqlParameter("@shipToAddressID", shipToAddressID));
                cmd.Parameters.Add(new SqlParameter("@shipToName", shipToName));
                cmd.Parameters.Add(new SqlParameter("@shipToPostalName", shipToPostalName));
                cmd.Parameters.Add(new SqlParameter("@shipToDeliverTo", shipToDeliverTo));
                cmd.Parameters.Add(new SqlParameter("@shipToStreet1", shipToStreet[0]));
                cmd.Parameters.Add(new SqlParameter("@shipToStreet2", shipToStreet[1]));
                cmd.Parameters.Add(new SqlParameter("@shipToStreet3", shipToStreet[2]));
                cmd.Parameters.Add(new SqlParameter("@shipToCity", shipToCity));
                cmd.Parameters.Add(new SqlParameter("@shipToState", shipToState));
                cmd.Parameters.Add(new SqlParameter("@shipToPostalCode", shipToPostalCode));
                cmd.Parameters.Add(new SqlParameter("@shipToCountry", shipToCountry));
                cmd.Parameters.Add(new SqlParameter("@shipToEmail", shipToEmail));
                cmd.Parameters.Add(new SqlParameter("@shipToPhoneName", shipToPhoneName));
                cmd.Parameters.Add(new SqlParameter("@shipToPhoneCountryCode", shipToPhoneCountryCode));
                cmd.Parameters.Add(new SqlParameter("@shipToPhoneAreaCode", shipToPhoneAreaCode));
                cmd.Parameters.Add(new SqlParameter("@shipToPhoneNumber", shipToPhoneNumber));
                cmd.Parameters.Add(new SqlParameter("@shipToFaxName", shipToFaxName));
                cmd.Parameters.Add(new SqlParameter("@shipToFaxCountryCode", shipToFaxCountryCode));
                cmd.Parameters.Add(new SqlParameter("@shipToFaxAreaCode", shipToFaxAreaCode));
                cmd.Parameters.Add(new SqlParameter("@shipToFaxNumber", shipToFaxNumber));
                cmd.Parameters.Add(new SqlParameter("@billToAddressID", billToAddressID));
                cmd.Parameters.Add(new SqlParameter("@billToName", billToName));
                cmd.Parameters.Add(new SqlParameter("@billToDeliverTo", billToDeliverTo));
                cmd.Parameters.Add(new SqlParameter("@billToPostalName", billToPostalName));
                cmd.Parameters.Add(new SqlParameter("@billToStreet1", billToStreet[0]));
                cmd.Parameters.Add(new SqlParameter("@billToStreet2", billToStreet[1]));
                cmd.Parameters.Add(new SqlParameter("@billToStreet3", billToStreet[2]));
                cmd.Parameters.Add(new SqlParameter("@billToCity", billToCity));
                cmd.Parameters.Add(new SqlParameter("@billToState", billToState));
                cmd.Parameters.Add(new SqlParameter("@billToPostalCode", billToPostalCode));
                cmd.Parameters.Add(new SqlParameter("@billToCountry", billToCountry));
                cmd.Parameters.Add(new SqlParameter("@extrinsics", extra));
                cmd.Parameters.Add(new SqlParameter("@timestamp", timestamp));
                cmd.Parameters.Add(new SqlParameter("@fileInfo", timestamp + ".xml"));
                cmd.Parameters.Add(new SqlParameter("@vendorURL", vendorURL));
                cmd.Parameters.Add(new SqlParameter("@comments", comments));
                cmd.Parameters.Add(new SqlParameter("@followUpURL", followUpURL));
                cmd.Parameters.Add(new SqlParameter("@sharedSecret", creds.SharedSecret));
                cmd.Parameters.Add(new SqlParameter("@pcardnumber", pcardnumber));
                cmd.Parameters.Add(new SqlParameter("@pcardname", pcardname));
                cmd.Parameters.Add(new SqlParameter("@pcardexpiration", pcardexpiration));
                cmd.Parameters.Add(new SqlParameter("@paymentTerms", paymentTerms));
                cmd.Parameters.Add(new SqlParameter("@attachments", attachments));
                using (SqlDataReader rs = cmd.ExecuteReader())
                    if (rs.Read())
                        id = int.Parse(rs[0].ToString());
            }

            /* ################################# cXML Body extractor ################################## */

            string qty, vendorPartNum, supplierPartAuxiliaryID, unitPrice, description, UOM, classificationDomain, classification, manufacturerPartID, reqDelDate;

            XmlNode lines = cXML.SelectSingleNode("cXML/Request/OrderRequest");

            foreach (XmlNode line in lines.ChildNodes)
            {
                switch (line.Name)
                {
                    case "ItemOut":
                        //         output("In the Line\r\n");
                        qty = setValue(line.SelectSingleNode("@quantity"));
                        reqDelDate = setValue(line.SelectSingleNode("@requestedDeliveryDate"));
                        vendorPartNum = setValue(line.SelectSingleNode("ItemID/SupplierPartID"));
                        supplierPartAuxiliaryID = setValue(line.SelectSingleNode("ItemID/SupplierPartAuxiliaryID"));
                        unitPrice = setValue(line.SelectSingleNode("ItemDetail/UnitPrice/Money"));
                        unitPrice = unitPrice.Replace(",", "");
                        description = setValue(line.SelectSingleNode("ItemDetail/Description"));
                        description = description.Replace("'", "''");

                        UOM = setValue(line.SelectSingleNode("ItemDetail/UnitOfMeasure"));
                        classificationDomain = setValue(line.SelectSingleNode("ItemDetail/Classification/@domain"));
                        classification = setValue(line.SelectSingleNode("ItemDetail/Classification"));
                        manufacturerPartID = setValue(line.SelectSingleNode("ItemDetail/ManufacturerPartID"));
                        manufacturerName = setValue(line.SelectSingleNode("ItemDetail/ManufacturerName"));

                        using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
                        {
                            dbcon.Open();
                            SqlCommand cmd = new SqlCommand("[dbo].[Ecommerce.Biztalk.Control]", dbcon);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@method", "INSERT BYPASS LINE"));
                            cmd.Parameters.Add(new SqlParameter("@parent", id));
                            cmd.Parameters.Add(new SqlParameter("@supplierPartID", vendorPartNum));
                            cmd.Parameters.Add(new SqlParameter("@supplierPartAuxiliaryID", supplierPartAuxiliaryID));
                            cmd.Parameters.Add(new SqlParameter("@qty", qty));
                            cmd.Parameters.Add(new SqlParameter("@unitPrice", unitPrice));
                            cmd.Parameters.Add(new SqlParameter("@description", description));
                            cmd.Parameters.Add(new SqlParameter("@unitOfMeasure", UOM));
                            cmd.Parameters.Add(new SqlParameter("@classificationDomain", classificationDomain));
                            cmd.Parameters.Add(new SqlParameter("@classification", classification));
                            cmd.Parameters.Add(new SqlParameter("@manufacturerPartID", manufacturerPartID));
                            cmd.Parameters.Add(new SqlParameter("@manufacturerName", manufacturerName));
                            cmd.Parameters.Add(new SqlParameter("@extrinsics", ""));
                            cmd.Parameters.Add(new SqlParameter("@timestamp", timestamp));
                            cmd.Parameters.Add(new SqlParameter("@reqDelDate", reqDelDate));
                            cmd.ExecuteNonQuery();
                        }

                        break;
                }
            }
        }

        public static void GetNavisionSOdata(string orderID, ref string navSONUM, ref string sellToNo)
        {
            string query = "SELECT sh.[No_],[Sell-to Customer No_] = ISNULL(sh.[Sell-to Customer No_],ps.[navSellToCustomerNo]) FROM [dbo].[Ecommerce$Bypass Header] bh "
                    + "JOIN [dbo].[Ecommerce$Punchout Setup] ps ON bh.[identity] = ps.[customerID] LEFT JOIN [PRD-NAV-DB].[GSS].[dbo].[Government Scientific Source$Sales Header] sh "
                    + "ON sh.[External Document No_] = bh.[orderid] collate SQL_Latin1_General_CP1_CI_AI WHERE bh.[orderid] = '" + orderID + "' AND bh.[type] = 'PO'";
            using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            navSONUM = reader["No_"].ToString();
                            sellToNo = reader["Sell-to Customer No_"].ToString();
                        }
                    }
                }
            }
        }

        public static EmailConfig GetEmailConfig()
        {
            try
            {
                using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
                {
                    dbcon.Open();
                    SqlCommand cmd = new SqlCommand("[dbo].[Ecommerce.Get.Email.Configuration]", dbcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader rs = cmd.ExecuteReader())
                        if (rs.Read())
                            return new EmailConfig(rs["host"].ToString(), rs["username"].ToString(), rs["password"].ToString(), rs["domain"].ToString(), rs["admin"].ToString());
                }
            }
            catch (Exception)
            {
            }

            return new EmailConfig("webmail.govsci.com", "ecommercesystem", "Secure1", "GSS1", "dev_error@govsci.com");
        }

        public static OrderHeader GetOrder(string identifier)
        {
            OrderHeader order = new OrderHeader();
            order.identifier = identifier;

            string query1 = $"SELECT * FROM [dbo].[Ecommerce$Bypass Header] WHERE [timestamp]='{identifier}' AND [confirmationSent] IS NULL";
            string query2 = "SELECT [orderConfirmation],[OCTemplate],[navSellToCustomerNo],[parent] AS [memberOf] FROM [dbo].[Ecommerce$Punchout Setup] WHERE [customerID] = '[identity]'";

            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                using (SqlDataReader rs = new SqlCommand(query1, dbcon).ExecuteReader())
                {
                    if (rs.Read())
                    {
                        order.id = rs["id"].ToString();
                        order.customerID = identifier;

                        order.type = rs["type"].ToString();
                        order.mode = rs["mode"].ToString();
                        order.identity = rs["identity"].ToString();
                        order.date = rs["date"].ToString();
                        order.orderID = rs["orderID"].ToString();
                        order.total = rs["total"].ToString();

                        order.ShipToAddress = new Address();
                        order.ShipToAddress.AddressID = rs["shipToAddressID"].ToString();
                        order.ShipToAddress.Name = Global.FilterStrings(rs["shipToName"].ToString());
                        order.ShipToAddress.Name2 = rs["shipToPostalName"].ToString();
                        order.ShipToAddress.DeliverTo = rs["shipToDeliverTo"].ToString();

                        order.ShipToAddress.Streets.Add(Global.FilterStrings(rs["shipToStreet1"].ToString()));
                        order.ShipToAddress.Streets.Add(Global.FilterStrings(rs["shipToStreet2"].ToString()));
                        order.ShipToAddress.Streets.Add(Global.FilterStrings(rs["shipToStreet3"].ToString()));
                        order.ShipToAddress.City = rs["shipToCity"].ToString();
                        order.ShipToAddress.State = rs["shipToState"].ToString();
                        order.ShipToAddress.PostalCode = rs["shipToPostalCode"].ToString();
                        order.ShipToAddress.Country = rs["shipToCountry"].ToString();

                        order.ShipToAddress.EmailAddress = rs["shipToEmail"].ToString();
                        order.ShipToAddress.Phone.Name = rs["shipToPhoneName"].ToString();
                        order.ShipToAddress.Phone.CountryCode = rs["shipToPhoneCountryCode"].ToString();
                        order.ShipToAddress.Phone.AreaCode = rs["shipToPhoneAreaCode"].ToString();
                        order.ShipToAddress.Phone.Number = rs["shipToPhoneNumber"].ToString();

                        order.ShipToAddress.Fax.Name = rs["shipToFaxName"].ToString();
                        order.ShipToAddress.Fax.CountryCode = rs["shipToFaxCountryCode"].ToString();
                        order.ShipToAddress.Fax.AreaCode = rs["shipToFaxAreaCode"].ToString();
                        order.ShipToAddress.Fax.Number = rs["shipToFaxNumber"].ToString();

                        order.BillToAddress = new Address();
                        order.BillToAddress.AddressID = rs["billToAddressID"].ToString();
                        order.BillToAddress.Name = Global.FilterStrings(rs["billToName"].ToString());
                        order.BillToAddress.Name2 = rs["billToPostalName"].ToString();
                        order.BillToAddress.DeliverTo = rs["billToDeliverTo"].ToString();
                        order.BillToAddress.Streets.Add(Global.FilterStrings(rs["billToStreet1"].ToString()));
                        order.BillToAddress.Streets.Add(Global.FilterStrings(rs["billToStreet2"].ToString()));
                        order.BillToAddress.Streets.Add(Global.FilterStrings(rs["billToStreet3"].ToString()));
                        order.BillToAddress.City = rs["billToCity"].ToString();
                        order.BillToAddress.State = rs["billToState"].ToString();
                        order.BillToAddress.PostalCode = rs["billToPostalCode"].ToString();
                        order.BillToAddress.Country = rs["billToCountry"].ToString();

                        order.extrinsics = rs["extrinsics"].ToString();
                        if (order.extrinsics.Contains("deliverTo:"))
                            order.ShipToAddress.Streets[1] = order.extrinsics.Replace("deliverTo:", "").Replace("|", "");
                        else if (order.extrinsics.Contains("DELIVER_TO") && order.identity == "LBNL_Industrial_PO")
                        {
                            Match match = Regex.Match(order.extrinsics, @"\|DELIVER_TO:(?<delTo>.+?)\|");
                            if (match.Success && match.Groups["delTo"].Value.Length > 0)
                                order.ShipToAddress.Streets[2] = "DELIVER TO: " + match.Groups["delTo"].Value;
                        }

                        order.timestamp = rs["timestamp"].ToString();
                        order.fileInfo = rs["fileInfo"].ToString();
                        order.comments = rs["comments"].ToString();

                        string attachments = rs["attachments"].ToString();
                        string[] attachArray = attachments.Split(';');
                        foreach (string att in attachArray)
                            if (System.IO.File.Exists(att))
                                order.Attachments += order.Attachments.Length > 0 ? ";" + att : att;
                    }
                }

                query1 = "SELECT * FROM [dbo].[Ecommerce$Bypass Lines] l WHERE [parent]='" + order.id + "'";
                using (SqlDataReader rs = new SqlCommand(query1, dbcon).ExecuteReader())
                {
                    while (rs.Read())
                    {
                        OrderLine line = new OrderLine(
                            decimal.Parse(rs["unitPrice"].ToString())
                            , decimal.Parse(rs["qty"].ToString())
                            , rs["manufacturerName"].ToString()
                            , rs["supplierPartID"].ToString()
                            , rs["description"].ToString()
                            , rs["unitOfMeasure"].ToString()
                            , rs["supplierPartAuxiliaryID"].ToString()
                            , rs["extra"].ToString());

                        if (line.supplierPartID.ToUpper() == "GSSTRANS" && line.description != "SHIPPING CHARGE")
                            order.expedite = true;
                        order.Lines.Add(line);
                    }
                }
            }

            using (SqlConnection ecomCon = new SqlConnection(Constants.EcommerceConnection))
            {
                ecomCon.Open();
                using (SqlDataReader rs = new SqlCommand(query2.Replace("[identity]", order.identity), ecomCon).ExecuteReader())
                {
                    if (rs.Read())
                    {
                        order.orderCOnfirmation = rs["orderConfirmation"].ToString();
                        order.OCTemplate = rs["OCTemplate"].ToString();
                        order.navSellToCustomerNo = rs["navSellToCustomerNo"].ToString();
                        order.memberOf = rs["memberOf"].ToString();
                    }
                }
            }

            string query = "SELECT [sellToCustomerNo],[orderEmailTo] FROM [dbo].[Ecommerce$Customers Group] WHERE [id] = " + order.memberOf;
            using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
            {
                conn.Open();
                using (SqlDataReader rs = new SqlCommand(query, conn).ExecuteReader())
                {
                    if (rs.Read())
                    {
                        string extraComments1 = "<br><br>To view your order status, please go to the GSS Catalog within eBuy and click on the Order link in the main navigation bar. Then select a <b>Customer Order Number</b> link "
                                + "or enter your criteria into the search fields to filter the results. Please allow 45 minutes after you have received this order acknowledgement.";
                        order.orderEmailTo = rs["orderEmailTo"].ToString();
                        if (order.orderEmailTo.Length > 0)
                            extraComments1 += " You may also contact <a href='mailTo:" + order.orderEmailTo + "'>" + order.orderEmailTo + "</a> for all order statuses.";
                        if (rs["sellToCustomerNo"].ToString().Length > 0)
                            order.extraComments = extraComments1;
                    }
                }
            }

            query = "SELECT sp.[Name] AS [SalespersonName],sp.[E-Mail] AS [SalespersonEmailAddress],sp.[Phone No_] AS [SalespersonPhoneNumber],st.[Sales Team Email] AS [SalesTeamEmail],st.[Sales Team Phone No_] "
                        + "FROM [GSS].[dbo].[Government Scientific Source$Customer] c JOIN [GSS].[dbo].[Government Scientific Source$Salesperson_Purchaser] sp ON c.[Salesperson Code] = sp.[Code] "
                        + "JOIN [GSS].[dbo].[Government Scientific Source$SalesTeam] st ON sp.[Sales Team] = st.[SalesTeamCode] WHERE [No_] = '" + order.navSellToCustomerNo + "'";
            using (SqlConnection conn = new SqlConnection(Constants.NavConnection))
            {
                conn.Open();
                using (SqlDataReader rs = new SqlCommand(query, conn).ExecuteReader())
                {
                    if (rs.Read())
                    {
                        order.salespersonName = rs["SalespersonName"].ToString();
                        order.salespersonEmail = rs["SalespersonEmailAddress"].ToString();
                        order.salespersonPhone = rs["SalespersonPhoneNumber"].ToString();
                        order.salesTeamEmail = rs["SalesTeamEmail"].ToString();
                        order.salesTeamPhoneNo = rs["Sales Team Phone No_"].ToString();
                    }
                }
            }

            return order;
        }

        public static void UpdateOrderConfirmation(string identifier)
        {
            string query = $"UPDATE [dbo].[Ecommerce$Bypass Header] SET [confirmationSent] =1 WHERE [timestamp]='{identifier}'";

            using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                    cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static bool CheckOrderConfirmation(string orderID)
        {
            using (SqlConnection conn = new SqlConnection(Constants.NavConnection))
            {
                conn.Open();
                using (SqlDataReader rs = new SqlCommand($"SELECT [id] FROM [dbo].[Ecommerce$Automated Customer Notifications Header] WHERE [customerPONo] = '{orderID}' AND [documentType] = 'Order Acknowledgement'", conn).ExecuteReader())
                    if (rs.Read() && rs["id"].ToString().Length > 0)
                        return true;
                conn.Close();
            }

            return false;
        }

        public static AutoResponder GetAutoResponderConfig(int id)
        {
            AutoResponder auto = null;

            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Ecommerce.AutoResponder.New.Control]", dbcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.Parameters.Add(new SqlParameter("@autoType", "GET RESPONDER BY ID"));
                using (SqlDataReader rs = cmd.ExecuteReader())
                {
                    rs.Read();
                    rs.NextResult();
                    if (rs.Read())
                    {
                        auto = new AutoResponder(rs["emailHeader"].ToString()
                            , rs["emailFooter"].ToString()
                            , rs["emailStyle"].ToString()
                            , rs["subject"].ToString()
                            , rs["style"].ToString()
                            , rs["body"].ToString()
                            , rs["cart"].ToString());
                    }
                }
            }

            return auto;
        }

        public static string GetExtraComments(string auxPartNo)
        {
            string extraComments = "";
            string query = "SELECT [cartExtrinsics] FROM [dbo].[Ecommerce$cXML Cart Out Lines] l JOIN [dbo].[Ecommerce$cXML Cart Out Header] h ON l.[parent] = h.[id] "
                                + "JOIN [dbo].[Ecommerce$Punchout Session] p ON p.[buyerCookie] = 'ARIBA-' + h.[buyerCookie] where l.[supplierPartAuxiliaryID] = '" + auxPartNo + "'";
            using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
            {
                conn.Open();
                using (SqlDataReader rs = new SqlCommand(query, conn).ExecuteReader())
                {
                    if (rs.Read())
                    {
                        string[] rows = rs["cartExtrinsics"].ToString().Split(new string[] { Constants.WebRowSplit }, StringSplitOptions.None);
                        foreach (string row in rows)
                        {
                            string[] cols = row.Split(new string[] { Constants.WebColumnSplit }, StringSplitOptions.None);
                            if (cols.Length > 1)
                                extraComments += extraComments.Length > 0 ? "<br>" + cols[0] + ": " + cols[1] : cols[0] + ": " + cols[1];
                        }

                    }
                }
            }

            return extraComments;
        }

        public static string InsertOrderAck(string orderId, string subject, string body, StringBuilder toEmails, StringBuilder bccEmails, string lineQuery)
        {
            string insertedid = "";
            string query = "INSERT INTO [dbo].[Ecommerce$Automated Customer Notifications Header] ([documentType],[customerPONo],[emailTo],[emailCc],[emailBcc],[subject],[body],[dateSent]) OUTPUT Inserted.ID VALUES "
                + "('Order Acknowledgement','" + orderId.Replace("'", "''") + "','" + toEmails.ToString().Replace("'", "''") + "','','" + bccEmails.ToString().Replace("'", "''") + "','" + subject.Replace("'", "''") + "','" + body.Replace("'", "''") + "',GETDATE())";
            using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
            {
                dbcon.Open();
                using (SqlCommand cmd = new SqlCommand(query, dbcon))
                using (SqlDataReader rs = cmd.ExecuteReader())
                    if (rs.Read())
                        insertedid = rs[0].ToString();
            }

            if (insertedid.Length > 0)
            {
                query = "INSERT INTO [dbo].[Ecommerce$Automated Customer Notifications Line] ([parentID],[gssPartNo],[vendorNo],[uom],[qty]) VALUES "
                                        + lineQuery.Replace("[insertedid]", insertedid);
                using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
                {
                    dbcon.Open();
                    using (SqlCommand cmd = new SqlCommand(query, dbcon))
                        cmd.ExecuteNonQuery();
                }
            }

            return insertedid;
        }

        public static Vendor GetVendorConfiguration(string poOwner, string v)
        {
            Vendor vendor = new Vendor();
            using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
            {
                string query = "SELECT * FROM [dbo].[Ecommerce$Bypass PO Vendor Credentials] WHERE [customerID]=" + poOwner + " AND [vendorCode]=";
                query += "(SELECT TOP 1 [vendorCode] FROM [dbo].[Ecommerce$Customers Punchout Setup] WHERE [vendorName]='" + v + "')";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        vendor.CxmlCredentials.FromDomain = reader["fromDomain"].ToString();
                        vendor.CxmlCredentials.FromIdentity = reader["fromIdentity"].ToString();
                        vendor.CxmlCredentials.ToDomain = reader["toDomain"].ToString();
                        vendor.CxmlCredentials.ToIdentity = reader["toIdentity"].ToString();
                        vendor.CxmlCredentials.SenderDomain = reader["senderDomain"].ToString();
                        vendor.CxmlCredentials.SenderIdentity = reader["senderIdentity"].ToString();
                        vendor.CxmlCredentials.SharedSecret = reader["sharedSecret"].ToString();
                        vendor.CxmlCredentials.UserAgent = reader["userAgent"].ToString();
                        vendor.CxmlCredentials.Url = reader["url"].ToString();
                        vendor.ExpediteShippingAllowed = int.Parse(reader["sendExpedite"].ToString());
                        vendor.ShipToCode = reader["addressID"].ToString();
                        vendor.Active = int.Parse(reader["active"].ToString());
                    }
                    reader.Dispose();
                }
                conn.Close();
            }

            return vendor;
        }

        public static Vendor GetVendorConfiguration(Credentials creds, string poType)
        {
            Vendor vendor = new Vendor();
            using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
            {
                string query = "";
                switch(poType)
                {
                    case Constants.CXML_PO_TYPE.BYPASS:
                        query = $"SELECT * FROM [dbo].[Ecommerce$Bypass PO Vendor Credentials] WHERE [fromIdentity]='{creds.FromIdentity}' AND [toIdentity]='{creds.ToIdentity}' AND [sharedSecret]='{creds.SharedSecret}'";
                        break;
                    case Constants.CXML_PO_TYPE.NAV:
                        query = $"SELECT * FROM [dbo].[Ecommerce$NAVPO Vendor Credentials] WHERE [fromIdentity]='{creds.FromIdentity}' AND [toIdentity]='{creds.ToIdentity}' AND [sharedSecret]='{creds.SharedSecret}'";
                        break;
                }
                
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        creds.Url = GetString(reader, "url");
                        vendor.CxmlCredentials = creds;
                        vendor.ExpediteShippingAllowed = GetInteger(reader, "sendExpedite");
                        vendor.ShipToCode = GetString(reader, "addressID");
                        vendor.Active = GetInteger(reader, "active");
                        vendor.Hash = GetString(reader, "certificateHash");
                        vendor.IncludeDocType = GetInteger(reader, "includeDoctype");
                        vendor.TlsVersion = GetString(reader, "tlsVersion");
                        vendor.HttpUserName = GetString(reader, "http_username");
                        vendor.HttpPassword = GetString(reader, "http_password");
                    }
                    reader.Dispose();
                }
                conn.Close();
            }

            return vendor;
        }

        public static Address GetShipToAddress(string addressID)
        {
            Address ship = new Address();

            using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
            {
                string query = $"SELECT * FROM [dbo].[Ecommerce$Bypass Shipping Address] WHERE [customerID]=13 AND [customerAddressID]='{addressID}'";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ship.AddressID = reader["shiptoCode"].ToString();
                        ship.Streets.Add(reader["Street1"].ToString());
                        ship.Streets.Add(reader["Street2"].ToString());
                        ship.Streets.Add(reader["Street3"].ToString());
                        ship.City = reader["City"].ToString();
                        ship.State = reader["State"].ToString();
                        ship.PostalCode = reader["Zipcode"].ToString();
                        ship.CountryCode = reader["countryCode"].ToString();
                    }
                }
            }
            return ship;
        }

        public static decimal GetItemListPrice(string supplierPartNo, string supplierPartNo2, string uom, string vendorCode)
        {
            decimal price = 0.0m;

            string query = "SELECT ISNULL([price],0) FROM [dbo].[Ecommerce$Item List Price] WHERE [sku] = '" + supplierPartNo + "' AND [sku2] = '" + supplierPartNo2 + "' "
                        + "AND [uom] = '" + uom + "' AND [vendor]='" + vendorCode + "'";
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                    if (rs.Read())
                        price = decimal.Parse(rs[0].ToString());
            }

            return price;
        }

        public static string GetDiscountCode(string vendor, string vendorItemNo, string uom)
        {
            string discocode = "";

            string query = "SELECT TOP 1 [Discount Code] FROM [dbo].[Ecommerce$Item Discount Code] WHERE ([Vendor Code] = '" + vendor + "' OR [Vendor Name] = '" + vendor + "') AND [Vendor Item No] = '" + vendorItemNo + "'";
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                    if (rs.Read()) discocode = rs[0].ToString();
            }

            return discocode;
        }

        public static bool CheckBypassPo(Vendor vendor, XmlDocument cXML)
        {
            Constants.F1 setValue = x => x != null ? x.InnerXml : "";

            string vendorURL = vendor.CxmlCredentials.Url;
            string orderid = setValue(cXML.SelectSingleNode("//OrderRequestHeader/@orderID"));

            string query = $"SELECT [id] FROM [dbo].[Ecommerce$Inbound Sales 702 Status] WHERE [customerPONo] = '{orderid}' AND [url] = '{vendorURL}' AND ISNULL([resend],0) = 0";
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                    if (rs.Read() && rs[0].ToString().Length > 0)
                        return true;
            }

            return false;
        }

        public static bool CheckOutboundPODuplicate(string orderid, string URL)
        {
            string query = "SELECT [id] FROM [dbo].[Ecommerce$Inbound Sales 702 Status] WHERE [customerPONo] = '" + orderid + "' AND [url] = '" + URL + "' AND ISNULL([resend],0) = 0";
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                    if (rs.Read() && rs[0].ToString().Length > 0)
                        return true;
            }
            return false;
        }

        public static string GetAddressID(string customerId, string vendorCode, string street1, string street2, string city, string state, string postcode)
        {
            string addressId = "";
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();

                string query = "SELECT [addressId] FROM [dbo].[Ecommerce$Bypass Vendor Shipping Address] WHERE [customerId] = '" + customerId + "' AND [vendorName] = '" + vendorCode + "' "
                    + "AND [Address1] LIKE '%" + street1.Replace("'", "''") + "%' AND [Address2] LIKE '%" + street2.Replace("'", "''") + "%' "
                    + "AND [City] = '" + city.Replace("'", "''") + "' AND [State] = '" + state.Replace("'", "''") + "' AND [PostCode] LIKE '%" + postcode.Replace("'", "''") + "%'";
                //         output(query);
                using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                    if (rs.Read()) addressId = rs[0].ToString();

                if (addressId.Length == 0)
                {
                    query = "SELECT [addressId] FROM [dbo].[Ecommerce$Bypass Vendor Shipping Address] WHERE [customerId] = '" + customerId + "' AND [vendorName] = '" + vendorCode + "' AND [defaultShipTo] = 1";
                    using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                        if (rs.Read()) addressId = rs[0].ToString();
                }
            }
            return addressId;
        }

        public static string GetAddressID(Address shipToAddress, string navSellToCustomerNo)
        {
            string addressID = "";
            using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand("[Ecommerce.Biztalk.Functions.Control]", dbcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@method", "CHECK SHIP TO"));
                cmd.Parameters.Add(new SqlParameter("@customerNo", navSellToCustomerNo));
                cmd.Parameters.Add(new SqlParameter("@name", shipToAddress.Name));
                cmd.Parameters.Add(new SqlParameter("@name2", shipToAddress.Name2));
                cmd.Parameters.Add(new SqlParameter("@address", Global.ReturnListStringItem(shipToAddress.Streets,0)));
                cmd.Parameters.Add(new SqlParameter("@address2", Global.ReturnListStringItem(shipToAddress.Streets,1)));
                cmd.Parameters.Add(new SqlParameter("@city", shipToAddress.City));
                cmd.Parameters.Add(new SqlParameter("@postCode", shipToAddress.PostalCode));
                cmd.Parameters.Add(new SqlParameter("@state", shipToAddress.State));
                using (SqlDataReader rs = cmd.ExecuteReader())
                    if (rs.Read())
                        addressID = rs[0].ToString();
            }
            return addressID;
        }

        public static string GetAsnEmailForward(Credentials creds)
        {
            string email = "";
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Ecommerce.Biztalk.Control]", dbcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@method", "GET ASN EMAIL"));
                cmd.Parameters.Add(new SqlParameter("@fromIdentity", creds.FromIdentity));
                cmd.Parameters.Add(new SqlParameter("@identity", creds.ToIdentity));
                cmd.Parameters.Add(new SqlParameter("@sharedSecret", creds.SharedSecret));
                using(SqlDataReader rs = cmd.ExecuteReader())
                    if (rs.Read())
                        email = rs[0].ToString();
            }

            return email;
        }

        public static void Insert702OrderStatus(string po, string status, string url)
        {
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                string query = "INSERT INTO [dbo].[Ecommerce$Inbound Sales 702 Status] ([customerPONo],[url],[statusCode],[flag],[dateAdded]) VALUES "
                    + "('" + po + "','" + url + "','" + status + "',0,GETDATE()); "
                    + "UPDATE [dbo].[Ecommerce$Inbound Sales 702 Status] SET [resend] = 0 WHERE [customerPONo] = '" + po + "' AND [url] = '" + url + "'";
                new SqlCommand(query, dbcon).ExecuteNonQuery();
            }
        }

        public static int GetSqlTableID(string st, string bak)
        {
            string query = "INSERT INTO [dbo].[Ecommerce$EDI Document Segment IDs] ([st],[bak],[dateAdded]) OUTPUT inserted.id VALUES ('" + st + "','" + bak + "',GETDATE())";
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand(query, dbcon);
                using (SqlDataReader rs = cmd.ExecuteReader())
                    if (rs.Read())
                        return rs.GetInt32(0);
            }

            return 0;
        }

        public static string GetSegments(string type, string st, string po, string cxmlString)
        {
            SqlCommand cmd = null;
         
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();

                cmd = new SqlCommand("[dbo].[Ecommerce$EDI Document Segments.Control]", dbcon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.AddWithValue("@task", "GET EDI SEGMENTS");
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@st", st);
                    cmd.Parameters.AddWithValue("@po", po);

                    using (SqlDataReader rsedi = cmd.ExecuteReader())
                    {
                        while (rsedi.Read())
                        {
                            cxmlString = Regex.Replace(cxmlString, "<AK102>(.*?)</AK102>", "<AK102>" + rsedi["segmentGS"].ToString() + "</AK102>");                       
                            cxmlString = Regex.Replace(cxmlString, "<AK202>(.*?)</AK202>", "<AK202>" + rsedi["segmentST"].ToString() + "</AK202>");                       
                            cxmlString = Regex.Replace(cxmlString, "<AK301>(.*?)</AK301>", "<AK301>" + rsedi["isa"].ToString() + "</AK301>");                            
                        }
                    }
                }
                catch (Exception e)
                {
                    Email.SendErrorMessage(e, "", "Database", "GetSegments", $"{type}, {st}, {po}", cmd);
                }

            }

            return cxmlString;
        }

        public static string GetISA(string cxmlString)
        {
            string isa = "";
            SqlCommand cmd = null;
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();

                cmd = new SqlCommand("[dbo].[Ecommerce$EDI Document Segments.Control]", dbcon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    Regex invr = new Regex("invoiceID=\"(?<inv>.*?)\"><");
                    Match invm = invr.Match(cxmlString);
                    string inv = invm.Groups["inv"].Value.ToString();

                    invr = new Regex("purpose=\"(?<code>.*?)\"");
                    invm = invr.Match(cxmlString);
                    string chrageCode = invm.Groups["code"].Value.ToString();

                    cmd.Parameters.AddWithValue("@task", "GET 810 SEGMENTS");
                    cmd.Parameters.AddWithValue("@po", inv);

                    using (SqlDataReader rsedi = cmd.ExecuteReader())
                    {
                        while (rsedi.Read())
                        {
                            //[segmentGS],[segmentISA]
                            isa = rsedi["segmentISA"].ToString();

                        }
                    }
                }
                catch (Exception e)
                {
                    Email.SendErrorMessage(e, "", "Database", "temp", "", cmd);
                }
            }
            return isa;
        }

        //public static void UpdatePurchaseOrderSent(string poNum)
        //{
        //    string query = "[dbo].[Ecommerce.BiztalkPurchaseOrders.Control]";
        //    using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
        //    {
        //        dbcon.Open();
        //        SqlCommand cmd = new SqlCommand(query, dbcon);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add(new SqlParameter("@method", "UPDATE BIZTALK SENT"));
        //        cmd.Parameters.Add(new SqlParameter("@PurchOrderNo", poNum));
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //public static void UpdatePurchaseOrderFail(string poNum)
        //{
        //    string query = "[dbo].[Ecommerce.BiztalkPurchaseOrders.Control]";
        //    using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
        //    {
        //        dbcon.Open();
        //        SqlCommand cmd = new SqlCommand(query, dbcon);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add(new SqlParameter("@method", "UPDATE BIZTALK FAIL"));
        //        cmd.Parameters.Add(new SqlParameter("@PurchOrderNo", poNum));
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        public static string GetPurchaseOrderNumber(string documentID, bool sent)
        {
            string poNumber = "";
            string query = "[dbo].[Ecommerce.BiztalkPurchaseOrders.Control]";
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
                {
                    dbcon.Open();
                    cmd = new SqlCommand(query, dbcon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (sent)
                        cmd.Parameters.Add(new SqlParameter("@method", "GET PO SENT"));
                    else
                        cmd.Parameters.Add(new SqlParameter("@method", "GET PO FAIL"));
                    cmd.Parameters.Add(new SqlParameter("@PurchOrderNo", documentID));
                    using (SqlDataReader rs = cmd.ExecuteReader())
                        if (rs.Read())
                            poNumber = rs[0].ToString();
                }

                if (poNumber.Length == 0)
                    throw new Exception("PO Number is empty!");
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Database", "GetPurchaseOrderNumber", documentID, cmd);
            }

            return poNumber;
        }

        #region ERP_ITEMS
        public static string GetVendorName(string customerVendorCode)
        {
            string vendor = "";

            string query = $"SELECT [vendorName] FROM [dbo].[Ecommerce$Bypass Customer Vendor Code Convert] WHERE [customerVendorCode] = '{customerVendorCode.Replace("'", "''")}'";
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                    if (rs.Read())
                        vendor = rs[0].ToString();
            }

            if (vendor.Length == 0)
                vendor = customerVendorCode;

            return vendor;
        }
        public static string GetVendorCode(string vendorNum)
        {
            string[] suppliersolutions = { "SIGMA", "INVITROGEN", "LSS", "MILLIPORE", "THOR", "OPERON", "NEWELL RUBBERMAID INC", "IDT", "BIO", "DIGI", "MARKETBASKET" };
            string[] navisionVendorCode = { "SIG", "IVT", "LAB", "MIL", "TOL", "OPP", "NEW", "IYY", "BRD", "DGK", "MARKETBASKET" };
            string query;
            int pos = -1;

            var selectedItems = suppliersolutions.Select((Item, index) => new { Item = Item, Position = index }).Where(x => x.Item == vendorNum);
            foreach (var a in selectedItems) pos = a.Position;

            if (pos < 0)
            {
                using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT [vendorCode] FROM [dbo].[Ecommerce$Customers Punchout Setup] WHERE [vendorName]='" + vendorNum + "'", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        vendorNum = reader.Read() ? reader["vendorCode"].ToString() : vendorNum;
                }
            }
            else
                vendorNum = navisionVendorCode[pos];

            return vendorNum;
            // THOR,SIGMA,GSS,VWR,INVITROGEN,QIA,LSS(Lab Safety - LAB ),OPERON,MILLIPORE - nik's system  - LBL user
            // TOL,SIG,GSS,VWR,IVT,QIA,LAB,OPP
        }
        public static string GetSigmaUnitOfMeasure(string queryPartNum, string UM)
        {
            string uom = "";

            string query = "SELECT [Base Unit of Measure] FROM [dbo].[Government Scientific Source$Item] WHERE [Vendor Item No_]='" + queryPartNum + "'";
            query += " AND [Vendor No_]='SIG'";

            using (SqlConnection conn = new SqlConnection(Constants.NavConnection))
            {
                conn.Open();
                using (SqlDataReader reader = new SqlCommand(query, conn).ExecuteReader())
                {
                    uom = reader.Read() ? reader[0].ToString() : UM;
                    reader.Dispose();
                }
            }

            return uom;
        }
        public static string GetUnitOfMeasure(string navVendorID, string vendorPartNum, string UM)
        {
            string uom = "", query = "";

            if (navVendorID == "GSS") // && vendorPartNum.Substring(0, 3).ToUpper() == "SIG" )
                query = "SELECT [Base Unit of Measure] AS [uom] FROM [dbo].[Government Scientific Source$Item] WHERE [No_]='" + vendorPartNum + "'";
            else
                query = "SELECT [navUOM] AS [uom] FROM [dbo].[Ecommerce$Unit of Measure Look Up] WHERE [vendorUOM]='" + UM + "'";

            using (SqlConnection conn = new SqlConnection(Constants.NavConnection))
            {
                conn.Open();
                using (SqlDataReader reader = new SqlCommand(query, conn).ExecuteReader())
                    uom = reader.Read() ? reader["uom"].ToString() : UM;
            }

            return uom;
        }
        public static string ValidateGssPartNumber(string vendorPartNum, string unitOfMeasure, string navVendorID)
        {
            string val = "";
            using (SqlConnection conn = new SqlConnection(Constants.NavConnection))
            {
                conn.Open();

                // Added another table for long part number handling
                string query = "SELECT [No_] FROM [GSS].[dbo].[Ecommerce$Inbound Sales Part Number Reference] WHERE ([Vendor Item No_]='" + vendorPartNum + "' ";
                query += "AND [Unit of Measure]='" + unitOfMeasure + "' AND [Vendor No_]='" + navVendorID + "')";
                query += " UNION ";

                query += "SELECT [No_] FROM [dbo].[Government Scientific Source$Item] WHERE ([Vendor Item No_]='" + vendorPartNum + "'";

                if (navVendorID == "SIG")
                    query += " AND [Vendor No_]='" + navVendorID + "'";
                else    // All the other vendors 
                    query += " AND [Base Unit of Measure]='" + unitOfMeasure + "' AND [Vendor No_]='" + navVendorID + "'";

                string vendorPartNumSpecialCharFiltered = Regex.Replace(vendorPartNum, @"[^A-Za-z0-9]", "");

                query += ") OR [No_]='";

                if (navVendorID == "SIG")
                    query += navVendorID + vendorPartNum + "' OR [No_] = '" + navVendorID + vendorPartNum + unitOfMeasure + "'";
                else if (navVendorID == "DGK")
                    query += navVendorID + vendorPartNum + unitOfMeasure + "'";
                else
                    query += navVendorID + vendorPartNumSpecialCharFiltered + unitOfMeasure + "'";

                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        val = reader["No_"].ToString();
                    else
                        val = "FALSE";
                }
            }

            return val;
        }
        public static string getShortGSSPartNumber(string vendorPartNum)
        {
            string query = "SELECT [prefix]+CONVERT(VARCHAR,[number]) AS [No_] FROM [dbo].[Ecommerce$Inbound Sales Part Number Setup]";
            string partNumber = "";
            using (SqlConnection conn = new SqlConnection(Constants.NavConnection))
            {
                conn.Open();

                using (SqlDataReader rs = new SqlCommand(query, conn).ExecuteReader())
                    if (rs.Read())
                        partNumber = rs["No_"].ToString();
            }

            return partNumber;
        }
        public static void GetSigmaGssPartNumber(string vendorPartNum, string UM, ref string gssPartNum, ref string altNumber)
        {
            string query = "SELECT [No_],[Base Unit of Measure] FROM [dbo].[Government Scientific Source$Item] WHERE [No_]='SIG" + vendorPartNum + "' ";
            query += "OR ([Vendor Item No_]='" + vendorPartNum + "' AND [Vendor No_] IN ('SIG','MIL') AND [Base Unit of Measure]='" + UM + "') ORDER BY [No_]";

            using (SqlConnection conn = new SqlConnection(Constants.NavConnection))
            {
                SqlCommand cmd;
                SqlDataReader reader;

                conn.Open();
                cmd = new SqlCommand(query, conn);
                using (reader = cmd.ExecuteReader())
                {
                    int count = 0;

                    while (reader.Read())
                    {
                        if (count == 0)
                        {
                            gssPartNum = reader["No_"].ToString();
                            UM = reader["Base Unit of Measure"].ToString();
                            count++;
                        }
                        else if (reader["No_"].ToString().Length > 0)
                            altNumber = reader["No_"].ToString();
                    }
                }
            }
        }
        public static void InsertReferenceGssPartNumber(string gssPartNum, string vendorName, string vendorPartNum, string uom)
        {
            string query = "INSERT INTO [dbo].[Ecommerce$Inbound Sales Part Number Reference] ([No_],[Vendor No_],[Vendor Item No_],[Unit of Measure]) VALUES ";
            query += "('" + gssPartNum + "','" + vendorName + "','" + vendorPartNum + "','" + uom + "')";

            // output("here:"+query);

            using (SqlConnection conn = new SqlConnection(Constants.NavConnection))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                    cmd.ExecuteNonQuery();

                query = "UPDATE [dbo].[Ecommerce$Inbound Sales Part Number Setup] SET [number]=[number]+1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                    cmd.ExecuteNonQuery();
            }
        }
        public static string findMarketBasketPartNumber(OrderHeader order, OrderLine line)
        {
            string partNumber = line.supplierPartID;
            if (partNumber == "")
                partNumber = line.manufacturerPartID;

            if (order.navSellToCustomerNo == "SLAC")
            {
                using (SqlConnection conn = new SqlConnection(Constants.NavConnection))
                {
                    conn.Open();

                    string query = "SELECT [GSSPartNum] FROM [Ecommerce$SLAC JIT Inventory] WHERE [Item] = '" + partNumber + "'";

                    using (SqlDataReader rs = new SqlCommand(query, conn).ExecuteReader())
                        if (rs.Read())
                            partNumber = rs["GSSPartNum"].ToString();
                }
            }
            return partNumber;
        }
        #endregion

        #region ERP_SALES
        public static bool IsNavisionSalesQuoteImport(XmlDocument cXML)
        {
            bool rtnVal = false;
            Credentials creds = Global.GetCredentials(cXML);

            using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
            {
                string query = $"SELECT [importSalesQuote] FROM [dbo].[Ecommerce$Punchout Setup] WHERE [customerID]='{creds.FromIdentity}' AND [sharedSecret]='{creds.SharedSecret}'";
                conn.Open();
                using (SqlDataReader reader = new SqlCommand(query, conn).ExecuteReader())
                {
                    if (reader.Read())
                        rtnVal = reader["importSalesQuote"].ToString() == "1" ? true : false;
                }
            }

            return rtnVal;
        }
        public static decimal GetTaxAmount(string orderID)
        {
            try
            {
                using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
                {
                    dbcon.Open();
                    string query = "SELECT ISNULL([tax],0) FROM [dbo].[Ecommerce$Ariba Order Header] WHERE [orderID] = '" + orderID + "'";
                    using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                        if (rs.Read())
                            return decimal.Parse(rs[0].ToString());
                }
            }
            catch { }

            return 0.0M;
        }
        public static void RecordCxmlData(OrderHeader order)
        {
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Ecommerce.Biztalk.Control]", dbcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@method", "INSERT INBOUND HEADER"));
                cmd.Parameters.Add(new SqlParameter("@type", order.type));
                cmd.Parameters.Add(new SqlParameter("@mode", order.deploymentMode));
                cmd.Parameters.Add(new SqlParameter("@identity", order.CxmlCredentials.FromIdentity));
                cmd.Parameters.Add(new SqlParameter("@ss", order.CxmlCredentials.SharedSecret));
                cmd.Parameters.Add(new SqlParameter("@date", order.date));
                cmd.Parameters.Add(new SqlParameter("@orderID", order.orderID));
                cmd.Parameters.Add(new SqlParameter("@total", order.total));
                cmd.Parameters.Add(new SqlParameter("@shipToAddressID", order.ShipToAddress.AddressID));
                cmd.Parameters.Add(new SqlParameter("@shipToName", order.ShipToAddress.Name));
                cmd.Parameters.Add(new SqlParameter("@shipToPostalName", order.ShipToAddress.Name2));
                cmd.Parameters.Add(new SqlParameter("@shipToDeliverTo", order.ShipToAddress.DeliverTo));
                cmd.Parameters.Add(new SqlParameter("@shipToStreet1", Global.ReturnListStringItem(order.ShipToAddress.Streets,0)));
                cmd.Parameters.Add(new SqlParameter("@shipToStreet2", Global.ReturnListStringItem(order.ShipToAddress.Streets,1)));
                cmd.Parameters.Add(new SqlParameter("@shipToStreet3", Global.ReturnListStringItem(order.ShipToAddress.Streets,2)));
                cmd.Parameters.Add(new SqlParameter("@shipToCity", order.ShipToAddress.City));
                cmd.Parameters.Add(new SqlParameter("@shipToState", order.ShipToAddress.State));
                cmd.Parameters.Add(new SqlParameter("@shipToPostalCode", order.ShipToAddress.PostalCode));
                cmd.Parameters.Add(new SqlParameter("@shipToCountry", order.ShipToAddress.Country));
                cmd.Parameters.Add(new SqlParameter("@shipToEmail", order.ShipToAddress.EmailAddress));
                cmd.Parameters.Add(new SqlParameter("@shipToPhoneName", order.ShipToAddress.Phone.Name));
                cmd.Parameters.Add(new SqlParameter("@shipToPhoneCountryCode", order.ShipToAddress.Phone.CountryCode));
                cmd.Parameters.Add(new SqlParameter("@shipToPhoneAreaCode", order.ShipToAddress.Phone.AreaCode));
                cmd.Parameters.Add(new SqlParameter("@shipToPhoneNumber", order.ShipToAddress.Phone.Number));
                cmd.Parameters.Add(new SqlParameter("@shipToFaxName", order.ShipToAddress.Fax.Name));
                cmd.Parameters.Add(new SqlParameter("@shipToFaxCountryCode", order.ShipToAddress.Fax.CountryCode));
                cmd.Parameters.Add(new SqlParameter("@shipToFaxAreaCode", order.ShipToAddress.Fax.AreaCode));
                cmd.Parameters.Add(new SqlParameter("@shipToFaxNumber", order.ShipToAddress.Fax.Number));
                cmd.Parameters.Add(new SqlParameter("@billToAddressID", order.BillToAddress.AddressID));
                cmd.Parameters.Add(new SqlParameter("@billToName", order.BillToAddress.Name));
                cmd.Parameters.Add(new SqlParameter("@billToPostalName", order.BillToAddress.Name2));
                cmd.Parameters.Add(new SqlParameter("@billToDeliverTo", order.BillToAddress.DeliverTo));
                cmd.Parameters.Add(new SqlParameter("@billToStreet1", Global.ReturnListStringItem(order.BillToAddress.Streets,0)));
                cmd.Parameters.Add(new SqlParameter("@billToStreet2", Global.ReturnListStringItem(order.BillToAddress.Streets,1)));
                cmd.Parameters.Add(new SqlParameter("@billToStreet3", Global.ReturnListStringItem(order.BillToAddress.Streets,2)));
                cmd.Parameters.Add(new SqlParameter("@billToCity", order.BillToAddress.City));
                cmd.Parameters.Add(new SqlParameter("@billToState", order.BillToAddress.State));
                cmd.Parameters.Add(new SqlParameter("@billToPostalCode", order.BillToAddress.PostalCode));
                cmd.Parameters.Add(new SqlParameter("@billToCountry", order.BillToAddress.Country));
                cmd.Parameters.Add(new SqlParameter("@extrinsics", order.extrinsics));
                cmd.Parameters.Add(new SqlParameter("@timestamp", order.timestamp));
                cmd.Parameters.Add(new SqlParameter("@fileInfo", order.timestamp + ".xml"));
                cmd.Parameters.Add(new SqlParameter("@requisitionID", order.requisitionID));
                cmd.Parameters.Add(new SqlParameter("@pcardNumber", (order.PCard.Number.Length > 0 ? CustomTextEncrypt.Encode(order.PCard.Number) : "")));
                cmd.Parameters.Add(new SqlParameter("@pcardExpiration", (order.PCard.Expiration.Length > 0 ? CustomTextEncrypt.Encode(order.PCard.Expiration) : "")));
                cmd.Parameters.Add(new SqlParameter("@pcardName", (order.PCard.Name.Length > 0 ? CustomTextEncrypt.Encode(order.PCard.Name) : "")));
                cmd.Parameters.Add(new SqlParameter("@payloadId", order.payloadID));
                cmd.Parameters.Add(new SqlParameter("@paymentTerms", order.paymentTerms));
                cmd.Parameters.Add(new SqlParameter("@sellToCustomerNo", order.navSellToCustomerNo));

                cmd.ExecuteNonQuery();
            }
        }
        public static void RecordCxmlData(OrderHeader order, OrderLine orderLine)
        {
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Ecommerce.Biztalk.Control]", dbcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@method", "INSERT INBOUND LINE"));
                cmd.Parameters.Add(new SqlParameter("@orderID", order.orderID));
                cmd.Parameters.Add(new SqlParameter("@timestamp", order.timestamp));
                cmd.Parameters.Add(new SqlParameter("@lineNumber", orderLine.lineNumber));
                cmd.Parameters.Add(new SqlParameter("@supplierPartID", orderLine.supplierPartID));
                cmd.Parameters.Add(new SqlParameter("@supplierPartAuxiliaryID", orderLine.supplierPartAuxiliaryID));
                cmd.Parameters.Add(new SqlParameter("@gssPartNumber", orderLine.gssPartNumber));
                cmd.Parameters.Add(new SqlParameter("@qty", orderLine.quantity));
                cmd.Parameters.Add(new SqlParameter("@unitPrice", orderLine.unitPrice));
                cmd.Parameters.Add(new SqlParameter("@description", orderLine.description));
                cmd.Parameters.Add(new SqlParameter("@unitOfMeasure", orderLine.unitOfMeasure));
                cmd.Parameters.Add(new SqlParameter("@originalUOM", orderLine.originalUnitOfMeasure));
                cmd.Parameters.Add(new SqlParameter("@classificationDomain", orderLine.classificationDomain));
                cmd.Parameters.Add(new SqlParameter("@classification", orderLine.classification));
                cmd.Parameters.Add(new SqlParameter("@manufacturerPartID", orderLine.manufacturerPartID));
                cmd.Parameters.Add(new SqlParameter("@manufacturerName", orderLine.manufacturerName));
                cmd.Parameters.Add(new SqlParameter("@extrinsics", orderLine.extra));
                cmd.ExecuteNonQuery();
            }
        }
        public static string GetTaxAreaCode(string city, string state, string locationCode)
        {
            string code = "";
            try
            {
                using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
                {
                    dbcon.Open();
                    string query = "SELECT [Code] FROM [GSS].[dbo].[Government Scientific Source$Tax Area] WHERE ([Code] LIKE '" + state + "%' and [Code] LIKE '%" + city + "%') OR code = '" + state + "'";
                    using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                        if (rs.Read())
                            code = rs[0].ToString();
                }
            }
            catch { }

            if (locationCode == "VA") locationCode = "VA";
            if (code.Length == 0) code = "GSS, " + locationCode;

            return code;
        }
        public static decimal getVendorRebate(string identity, string manufacturerName)
        {
            using (SqlConnection conn = new SqlConnection(Constants.EcommerceConnection))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[Ecommerce.Biztalk.VendorRebate.Control]", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CustomerID", identity));
                cmd.Parameters.Add(new SqlParameter("@Vendor", manufacturerName));
                cmd.Parameters.Add(new SqlParameter("@method", "GET REBATE"));
                using (SqlDataReader rs = cmd.ExecuteReader())
                    if (rs.Read())
                        return decimal.Parse(rs[0].ToString());
            }

            return 0.0M;
        }
        public static decimal CalculateUnitCost(string sellToCustomerNo, string vendorCode, decimal unitPrice)
        {
            string query = "";
            decimal amount = 0.0M;
            string operation = "";

            try
            {
                query = "SELECT [operation],[amount] FROM [dbo].[Ecommerce$Unit Cost Calculation] WHERE [sellToCustomerNo] = '" + sellToCustomerNo + "' AND ([vendorNo] = '" + vendorCode + "' OR [vendorNo] IS NULL)";
                using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
                {
                    dbcon.Open();
                    using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                    {
                        if (rs.Read())
                        {
                            operation = rs["operation"].ToString();
                            amount = decimal.Parse(rs["amount"].ToString());
                        }
                    }
                }
            }
            catch
            {

            }

            switch (operation)
            {
                case "=": return unitPrice;

                case "/":
                    if (amount > 0.00M)
                        return unitPrice / amount;
                    else
                        return 0.0M;

                case "- (*)": return unitPrice - (unitPrice * amount);

                case "*": return unitPrice * amount;

                default: return 0.00M;
            }
        }
        public static string GetEcatTCN(string orderId)
        {
            string tcn = "";

            try
            {
                string query = "SELECT [markTcn] FROM [GSS].[dbo].[Ecommerce$ECAT Order Header] WHERE orderNumber = '" + orderId + "'";
                using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
                {
                    dbcon.Open();
                    using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                        if (rs.Read())
                            tcn = rs[0].ToString();
                }
            }
            catch
            {

            }

            return tcn;
        }
        public static void UpdateEcat(string salesOrderNumber, string orderID)
        {
            string query = $"UPDATE [Ecommerce$ECAT Order Header] SET [navSO]='{salesOrderNumber}' WHERE [orderNumber]='{orderID}'";

            using (SqlConnection conn = new SqlConnection(Constants.NavConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                    cmd.ExecuteNonQuery();
            }
        }
        public static void UpdateSalesOrderLine(OrderLine line, decimal unitCost, int lineNo, string sNo)
        {
            string upquery = "UPDATE [dbo].[Government Scientific Source$Sales Line] SET "
                            + "[Unit Price] = " + line.unitPrice
                            + ",[Amount] = ([Quantity] * " + line.unitPrice + ")"
                            + ",[Amount Including VAT] = ([Quantity] * " + line.unitPrice + ")"
                            + ",[Outstanding Amount] = ([Quantity] * " + line.unitPrice + ")"
                            + ",[Outstanding Amount (LCY)] = ([Quantity] * " + line.unitPrice + ")"
                            + ",[VAT Base Amount] = ([Quantity] * " + line.unitPrice + ")"
                            + ",[Line Amount] = ([Quantity] * " + line.unitPrice + ")"
                            + ",[Net Each] = " + line.unitPrice
                            + ",[Pricing Qty_] = ([Quantity] * " + line.unitPrice + ")"
                            + (unitCost > 0.00M ? ",[Unit Cost (LCY)] = " + unitCost : "")
                            + " WHERE [Document No_] = '" + sNo + "' AND [Line No_] = " + lineNo;
            using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
            {
                dbcon.Open();
                new SqlCommand(upquery, dbcon).ExecuteNonQuery();
            }
        }
        public static void UpdateSalesOrderCreditCard(OrderHeader order, string navisionSalesOrderNumber)
        {
            try
            {
                string query = "UPDATE [dbo].[Government Scientific Source$Sales Header] SET [Expiration Month]='" + DateTime.Parse(order.PCard.Expiration).ToString("MM")
                    + "',[Expiration Year]='" + DateTime.Parse(order.PCard.Expiration).ToString("yy")
                    + "' WHERE [No_] = '" + navisionSalesOrderNumber + "'";
                using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
                {
                    dbcon.Open();
                    new SqlCommand(query, dbcon).ExecuteNonQuery();
                }
            }
            catch { }
        }
        #endregion

        #region Status_Documents
        public static bool CheckInvoice(string invoiceid, string orderid)
        {
            bool rVal = false;
            using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
            {
                dbcon.Open();
                string query = $"SELECT [invoiceID] FROM [dbo].[Ecommerce$Electronic Document Header] WHERE [documentType] = 'Invoice' AND [invoiceID]='{invoiceid}' AND [orderID] = '{orderid}'";
                using (SqlDataReader rs = new SqlCommand(query, dbcon).ExecuteReader())
                    if (rs.Read())
                        rVal = true;
            }
            return rVal;
        }
        public static Address GetShippingInformation(string orderID, string invoiceId)
        {
            Address address = null;
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection dbcon = new SqlConnection(Constants.NavConnection))
                {
                    dbcon.Open();

                    cmd = new SqlCommand("[dbo].[Applications.NAV.Process.cXML.Documents.Control]", dbcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@method", "GET SHIP TO ADDRESS"));
                    cmd.Parameters.Add(new SqlParameter("@documentID", orderID));
                    using (SqlDataReader rs = cmd.ExecuteReader())
                    {
                        if (rs.Read())
                        {
                            address = new Address();
                            address.Role = "shipTo";
                            address.AddressID = rs["Ship-To Code"].ToString();
                            address.Name = rs["Ship-to Name"].ToString() + "|" + rs["Ship-to Name 2"].ToString();
                            address.DeliverTo = rs["Ship-to Contact"].ToString();
                            address.Streets.Add(rs["Ship-to Address"].ToString() + "|" + rs["Ship-to Address 2"].ToString());
                            address.City = rs["Ship-to City"].ToString();
                            address.State = rs["Ship-to County"].ToString();
                            address.PostalCode = rs["Ship-to Post Code"].ToString();
                            address.CountryCode = rs["Ship-to Country_Region Code"].ToString();
                            address.Country = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Database", "GetShippingInformation", invoiceId, cmd);
            }

            return address;
        }
        public static void GetVendor(ref InvoiceHeader invoice, Address remitTo)
        {
            SqlCommand cmd = null;

            try
            {
                using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
                {
                    dbcon.Open();
                    cmd = new SqlCommand("[dbo].[Ecommerce.ElectronicInvoice.Control]", dbcon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@method", "GET VENDOR"));
                    cmd.Parameters.Add(new SqlParameter("@userAgent", invoice.Creds.UserAgent));
                    cmd.Parameters.Add(new SqlParameter("@name", remitTo != null ? remitTo.Name : ""));
                    cmd.Parameters.Add(new SqlParameter("@fromIdentity", invoice.Creds.FromIdentity));
                    cmd.Parameters.Add(new SqlParameter("@sharedSecret", invoice.Creds.SharedSecret));
                    using (SqlDataReader rs = cmd.ExecuteReader())
                    {
                        if (rs.Read())
                        {
                            invoice.Vendor = rs["vendor"].ToString();
                            if (invoice.Vendor == "Invitrogen") invoice.SpecialHandlingAmount = 0.00M;
                            if (invoice.Vendor == "Staples") invoice.SubTotalAmount = invoice.SubTotalAmount - invoice.Tax;
                            if (invoice.Vendor == "Office City" && invoice.OrderDate.Length == 0) invoice.OrderDate = DateTime.Now.ToShortDateString();
                        }
                    }
                }

                if (invoice.Vendor == null)
                    invoice.Vendor = "";
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Database", "GetVendor", invoice.InvoiceID, cmd);
            }
        }

        public static void UploadVendorAsn(ASN_Header asn, string direction)
        {
            if (VendorAsnExistsInDB(asn)) { return; }

            try
            {
                SqlCommand cmd = null;
                int ID = 0;

                using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
                {
                    string extrinsics = "";
                    foreach (string extrinsic in asn.Extrinsics)
                        extrinsics += extrinsic + "|";
                    if (extrinsics.Length > 0)
                        extrinsics = extrinsics.Remove(extrinsics.LastIndexOf("|"));

                    dbcon.Open();
                    cmd = new SqlCommand("[dbo].[Ecommerce.OrderConfirmation.Control]", dbcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@method", "INSERT HEADER"));
                    cmd.Parameters.Add(new SqlParameter("@documentType", "ASN"));
                    cmd.Parameters.Add(new SqlParameter("@timestamp", asn.Timestamp));
                    cmd.Parameters.Add(new SqlParameter("@payloadID", asn.PayloadID));
                    cmd.Parameters.Add(new SqlParameter("@fromDomain", asn.Credentials.FromDomain));
                    cmd.Parameters.Add(new SqlParameter("@fromIdentity", asn.Credentials.FromIdentity));
                    cmd.Parameters.Add(new SqlParameter("@toDomain", asn.Credentials.ToDomain));
                    cmd.Parameters.Add(new SqlParameter("@toIdentity", asn.Credentials.ToIdentity));
                    cmd.Parameters.Add(new SqlParameter("@senderDomain", asn.Credentials.SenderDomain));
                    cmd.Parameters.Add(new SqlParameter("@senderIdentity", asn.Credentials.SenderIdentity));
                    cmd.Parameters.Add(new SqlParameter("@sharedSecret", asn.Credentials.SharedSecret));
                    cmd.Parameters.Add(new SqlParameter("@userAgent", asn.Credentials.UserAgent));
                    cmd.Parameters.Add(new SqlParameter("@invoiceID", asn.ShipmentID));
                    cmd.Parameters.Add(new SqlParameter("@purpose", asn.DeploymentMode));
                    cmd.Parameters.Add(new SqlParameter("@operation", asn.Operation));
                    cmd.Parameters.Add(new SqlParameter("@invoiceDate", asn.NoticeDate));
                    cmd.Parameters.Add(new SqlParameter("@paymentTermDays", ""));
                    cmd.Parameters.Add(new SqlParameter("@paymentTermPercent", ""));
                    cmd.Parameters.Add(new SqlParameter("@extrinsics", extrinsics));
                    cmd.Parameters.Add(new SqlParameter("@orderID", asn.OrderID));
                    cmd.Parameters.Add(new SqlParameter("@documentRefrPayloadID", ""));
                    cmd.Parameters.Add(new SqlParameter("@orderDate", asn.OrderDate));
                    cmd.Parameters.Add(new SqlParameter("@type", asn.Type));
                    cmd.Parameters.Add(new SqlParameter("@trackingNumber", asn.ShipmentIdentifier));
                    cmd.Parameters.Add(new SqlParameter("@trackingCarrier", asn.CarrierIdentifier));
                    cmd.Parameters.Add(new SqlParameter("@deliveryDate", asn.DeliveryDate));
                    cmd.Parameters.Add(new SqlParameter("@direction", direction));
                    using (SqlDataReader rs = cmd.ExecuteReader())
                        if (rs.Read())
                            ID = rs.GetInt32(0);
                }

                if (ID > 0)
                {
                    foreach (Address address in asn.Contacts)
                    {
                        UploadRole(address, ID, 0);
                    }

                    foreach (ASN_Line line in asn.Lines)
                    {
                        UploadVendorAsnLine(line, ID, asn.ShipmentID);
                    }
                }
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Database", "UploadVendorAsn", asn.OrderID, null);
            }
        }

        public static void UploadVendorAsnLine(ASN_Line line, int parent, string shipmentID)
        {
            SqlCommand cmd = null;
            try
            {
                int lineID = 0;
                using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
                {
                    dbcon.Open();
                    cmd = new SqlCommand("[dbo].[Ecommerce.OrderConfirmation.Control]", dbcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@method", "INSERT LINE"));
                    cmd.Parameters.Add(new SqlParameter("@parent", parent));
                    cmd.Parameters.Add(new SqlParameter("@invoiceID", shipmentID));
                    cmd.Parameters.Add(new SqlParameter("@lineNumber", Global.GetIntFromString(line.LineNumber)));
                    cmd.Parameters.Add(new SqlParameter("@quantity", Global.GetDecimalFromString(line.Quantity)));
                    cmd.Parameters.Add(new SqlParameter("@unitOfMeasure", line.UnitOfMeasure));
                    cmd.Parameters.Add(new SqlParameter("@shipLineNumber", Global.GetIntFromString(line.ShipLine)));
                    cmd.Parameters.Add(new SqlParameter("@shipmentDate", line.ShipmentDate));
                    cmd.Parameters.Add(new SqlParameter("@lineDeliveryDate", line.DeliveryDate));

                    using (SqlDataReader rs = cmd.ExecuteReader())
                        if (rs.Read())
                            lineID = rs.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Database", "UploadVendorAsnLine", "Parent ID: " + parent.ToString(), null);
            }
        }

        public static void UploadInvoice(InvoiceHeader invoice, string direction)
        {
            SqlCommand cmd = null;
            if (!CheckInvoice(invoice.InvoiceID,invoice.OrderID))
            {
                try
                {
                    string extrinsics = "";
                    foreach (Extrinsic extrinsic in invoice.Extrinsics)
                        extrinsics += extrinsic.Name + ":" + extrinsic.Value + "|";
                    using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
                    {
                        dbcon.Open();
                        cmd = new SqlCommand("[dbo].[Ecommerce.ElectronicInvoice.Control]", dbcon);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@method", "INSERT INVOICE HEADER"));
                        cmd.Parameters.Add(new SqlParameter("@timestamp", invoice.Timestamp));
                        cmd.Parameters.Add(new SqlParameter("@payloadID", invoice.PayloadID));
                        cmd.Parameters.Add(new SqlParameter("@fromDomain", invoice.Creds.FromDomain));
                        cmd.Parameters.Add(new SqlParameter("@fromIdentity", invoice.Creds.FromIdentity));
                        cmd.Parameters.Add(new SqlParameter("@toDomain", invoice.Creds.ToDomain));
                        cmd.Parameters.Add(new SqlParameter("@toIdentity", invoice.Creds.ToIdentity));
                        cmd.Parameters.Add(new SqlParameter("@senderDomain", invoice.Creds.SenderDomain));
                        cmd.Parameters.Add(new SqlParameter("@senderIdentity", invoice.Creds.SenderIdentity));
                        cmd.Parameters.Add(new SqlParameter("@sharedSecret", invoice.Creds.SharedSecret));
                        cmd.Parameters.Add(new SqlParameter("@userAgent", invoice.Creds.UserAgent));
                        cmd.Parameters.Add(new SqlParameter("@invoiceID", invoice.InvoiceID));
                        cmd.Parameters.Add(new SqlParameter("@purpose", invoice.Purpose));
                        cmd.Parameters.Add(new SqlParameter("@operation", invoice.Operation));
                        cmd.Parameters.Add(new SqlParameter("@invoiceDate", invoice.InvoiceDate));
                        cmd.Parameters.Add(new SqlParameter("@paymentTermDays", invoice.PaymentTermNumberOfDays));
                        cmd.Parameters.Add(new SqlParameter("@paymentTermPercent", invoice.PaymentTermPercentRate));
                        cmd.Parameters.Add(new SqlParameter("@extrinsics", extrinsics));
                        cmd.Parameters.Add(new SqlParameter("@orderID", invoice.OrderID));
                        cmd.Parameters.Add(new SqlParameter("@documentRefrPayloadID", invoice.DocumentReferencePayloadID));
                        cmd.Parameters.Add(new SqlParameter("@orderDate", invoice.OrderDate));
                        cmd.Parameters.Add(new SqlParameter("@subtotalAmount", invoice.SubTotalAmount));
                        cmd.Parameters.Add(new SqlParameter("@tax", invoice.Tax));
                        cmd.Parameters.Add(new SqlParameter("@grossAmount", invoice.GrossAmount));
                        cmd.Parameters.Add(new SqlParameter("@netAmount", invoice.NetAmount));
                        cmd.Parameters.Add(new SqlParameter("@dueAmount", invoice.DueAmount));
                        cmd.Parameters.Add(new SqlParameter("@shippingAmount", invoice.ShippingAmount));
                        cmd.Parameters.Add(new SqlParameter("@specialHandlingAmount", invoice.SpecialHandlingAmount));
                        cmd.Parameters.Add(new SqlParameter("@invoiceDetailDiscount", invoice.InvoiceDetailDiscount));
                        cmd.Parameters.Add(new SqlParameter("@invoiceTotal", invoice.InvoiceTotal));
                        cmd.Parameters.Add(new SqlParameter("@vendor", invoice.Vendor));
                        cmd.Parameters.Add(new SqlParameter("@direction", direction));

                        int id = 0;
                        using (SqlDataReader rs = cmd.ExecuteReader()) if (rs.Read()) id = rs.GetInt32(0);

                        if (id > 0)
                        {

                            foreach (Address role in invoice.Roles)
                            {
                                cmd = new SqlCommand(cmd.CommandText, cmd.Connection);
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@method", "INSERT INVOICE ROLE"));
                                cmd.Parameters.Add(new SqlParameter("@parent", id));
                                cmd.Parameters.Add(new SqlParameter("@role", role.Role));
                                cmd.Parameters.Add(new SqlParameter("@addressID", role.AddressID));
                                cmd.Parameters.Add(new SqlParameter("@name", role.Name));
                                cmd.Parameters.Add(new SqlParameter("@deliverTo", role.DeliverTo));
                                cmd.Parameters.Add(new SqlParameter("@street", role.Streets.Count > 0 ? role.Streets[0] : ""));
                                cmd.Parameters.Add(new SqlParameter("@city", role.City));
                                cmd.Parameters.Add(new SqlParameter("@state", role.State));
                                cmd.Parameters.Add(new SqlParameter("@postalCode", role.PostalCode));
                                cmd.Parameters.Add(new SqlParameter("@countryCode", role.CountryCode));
                                cmd.Parameters.Add(new SqlParameter("@country", role.Country));
                                cmd.ExecuteNonQuery();
                            }

                            foreach (InvoiceLine line in invoice.Lines)
                            {
                                cmd = new SqlCommand(cmd.CommandText, cmd.Connection);
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@method", "INSERT INVOICE LINE"));
                                cmd.Parameters.Add(new SqlParameter("@parent", id));
                                cmd.Parameters.Add(new SqlParameter("@invoiceID", invoice.InvoiceID));
                                cmd.Parameters.Add(new SqlParameter("@lineNumber", line.LineNumber));
                                cmd.Parameters.Add(new SqlParameter("@quantity", line.Quantity));
                                cmd.Parameters.Add(new SqlParameter("@unitOfMeasure", line.UnitOfMeasure));
                                cmd.Parameters.Add(new SqlParameter("@unitPrice", line.UnitPrice));
                                cmd.Parameters.Add(new SqlParameter("@refrLineNumber", line.ReferenceLineNumber));
                                cmd.Parameters.Add(new SqlParameter("@supplierPartId", line.SupplierPartID));
                                cmd.Parameters.Add(new SqlParameter("@description", line.Description));
                                cmd.Parameters.Add(new SqlParameter("@lineTotal", line.LineTotal));
                                cmd.Parameters.Add(new SqlParameter("@shipLine", line.ShipLine));
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Email.SendErrorMessage(ex, "", "Database", "UploadInvoice", invoice.InvoiceID, cmd);
                }
            }
        }

        public static void UploadVendorOrderConfirmation(OrderConfirmationHeader oc, string direction)
        {
            if (VendorOrderConfirmationExistsInDB(oc)) { return; }

            try
            {
                SqlCommand cmd = null;
                int ID = 0;

                using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
                {
                    string extrinsics = "";
                    foreach (string extrinsic in oc.Extrinsics)
                        extrinsics += extrinsic;

                    dbcon.Open();
                    cmd = new SqlCommand("[dbo].[Ecommerce.OrderConfirmation.Control]", dbcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@method", "INSERT HEADER"));
                    cmd.Parameters.Add(new SqlParameter("@documentType", "Order Confirmation"));
                    cmd.Parameters.Add(new SqlParameter("@timestamp", oc.Timestamp));
                    cmd.Parameters.Add(new SqlParameter("@payloadID", oc.PayloadID));
                    cmd.Parameters.Add(new SqlParameter("@fromDomain", oc.CxmlCredentials.FromDomain));
                    cmd.Parameters.Add(new SqlParameter("@fromIdentity", oc.CxmlCredentials.FromIdentity));
                    cmd.Parameters.Add(new SqlParameter("@toDomain", oc.CxmlCredentials.ToDomain));
                    cmd.Parameters.Add(new SqlParameter("@toIdentity", oc.CxmlCredentials.ToIdentity));
                    cmd.Parameters.Add(new SqlParameter("@senderDomain", oc.CxmlCredentials.SenderDomain));
                    cmd.Parameters.Add(new SqlParameter("@senderIdentity", oc.CxmlCredentials.SenderIdentity));
                    cmd.Parameters.Add(new SqlParameter("@sharedSecret", oc.CxmlCredentials.SharedSecret));
                    cmd.Parameters.Add(new SqlParameter("@userAgent", oc.CxmlCredentials.UserAgent));
                    cmd.Parameters.Add(new SqlParameter("@invoiceID", oc.ConfirmID));
                    cmd.Parameters.Add(new SqlParameter("@purpose", oc.DeploymentMode));
                    cmd.Parameters.Add(new SqlParameter("@operation", oc.Operation));
                    cmd.Parameters.Add(new SqlParameter("@invoiceDate", oc.NoticeDate));
                    cmd.Parameters.Add(new SqlParameter("@paymentTermDays", ""));
                    cmd.Parameters.Add(new SqlParameter("@paymentTermPercent", ""));
                    cmd.Parameters.Add(new SqlParameter("@extrinsics", extrinsics));
                    cmd.Parameters.Add(new SqlParameter("@orderID", oc.OrderID));
                    cmd.Parameters.Add(new SqlParameter("@documentRefrPayloadID", ""));
                    cmd.Parameters.Add(new SqlParameter("@orderDate", oc.OrderDate));
                    cmd.Parameters.Add(new SqlParameter("@type", oc.Type));
                    cmd.Parameters.Add(new SqlParameter("@direction", direction));

                    using (SqlDataReader rs = cmd.ExecuteReader())
                    {
                        if (rs.Read())
                        {
                            ID = rs.GetInt32(0);
                        }
                    }
                }

                if (ID > 0)
                {
                    foreach (Address address in oc.Contacts)
                    {
                        UploadRole(address, ID, 0);
                    }

                    foreach (OrderConfirmationLine line in oc.Lines)
                    {
                        UploadVendorOrderConfirmationLine(line, ID, oc.ConfirmID);
                    }
                }
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Database", "UploadVendorOrderConfirmation", oc.OrderID, null);
            }
        }

        public static void UploadRole(Address role, int parent, int docLineID)
        {
            SqlCommand cmd = null;
            try
            {
                string streets = "";
                foreach (string street in role.Streets)
                {
                    if (!street.Equals(String.Empty))
                        streets += street + "|";
                }
                if (streets.Length > 0)
                    streets = streets.Remove(streets.LastIndexOf("|"));

                using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
                {
                    dbcon.Open();
                    cmd = new SqlCommand("[dbo].[Ecommerce.OrderConfirmation.Control]", dbcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@method", "INSERT ROLE"));
                    cmd.Parameters.Add(new SqlParameter("@parent", parent));
                    cmd.Parameters.Add(new SqlParameter("@role", role.Role));
                    cmd.Parameters.Add(new SqlParameter("@addressID", role.AddressID));
                    cmd.Parameters.Add(new SqlParameter("@name", role.Name));
                    cmd.Parameters.Add(new SqlParameter("@deliverTo", role.DeliverTo));
                    cmd.Parameters.Add(new SqlParameter("@street", streets));
                    cmd.Parameters.Add(new SqlParameter("@city", role.City));
                    cmd.Parameters.Add(new SqlParameter("@state", role.State));
                    cmd.Parameters.Add(new SqlParameter("@postalCode", role.PostalCode));
                    cmd.Parameters.Add(new SqlParameter("@countryCode", role.CountryCode));
                    cmd.Parameters.Add(new SqlParameter("@country", role.Country));
                    cmd.Parameters.Add(new SqlParameter("@documentLineID", docLineID));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Database", "UploadRole", "Parent ID: " + parent.ToString(), null);
            }
        }

        public static void UploadVendorOrderConfirmationLine(OrderConfirmationLine line, int parent, string confirmID)
        {
            SqlCommand cmd = null;
            try
            {
                int lineID = 0;
                using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
                {
                    dbcon.Open();
                    cmd = new SqlCommand("[dbo].[Ecommerce.OrderConfirmation.Control]", dbcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@method", "INSERT LINE"));
                    cmd.Parameters.Add(new SqlParameter("@parent", parent));
                    cmd.Parameters.Add(new SqlParameter("@invoiceID", confirmID));
                    cmd.Parameters.Add(new SqlParameter("@lineNumber", Global.GetIntFromString(line.LineNumber)));
                    cmd.Parameters.Add(new SqlParameter("@quantity", Global.GetDecimalFromString(line.Quantity)));
                    cmd.Parameters.Add(new SqlParameter("@supplierPartId", line.SupplierPartID));
                    cmd.Parameters.Add(new SqlParameter("@unitOfMeasure", line.UnitOfMeasure));
                    cmd.Parameters.Add(new SqlParameter("@unitPrice", Global.GetDecimalFromString(line.ConfirmedUnitPrice)));
                    cmd.Parameters.Add(new SqlParameter("@confirmQty", Global.GetDecimalFromString(line.ConfirmedQuantity)));
                    cmd.Parameters.Add(new SqlParameter("@type", line.ConfirmationType));
                    cmd.Parameters.Add(new SqlParameter("@shipmentDate", line.ShipmentDate));
                    cmd.Parameters.Add(new SqlParameter("@lineDeliveryDate", line.DeliveryDate));
                    cmd.Parameters.Add(new SqlParameter("@confirmUom", line.ConfirmedUnitOfMeasure));
                    cmd.Parameters.Add(new SqlParameter("@backOrderQty", 0));
                    using (SqlDataReader rs = cmd.ExecuteReader())
                        if (rs.Read())
                            lineID = rs.GetInt32(0);
                }

                if (lineID > 0)
                {
                    foreach (Address contact in line.Contacts)
                        UploadRole(contact, parent, lineID);
                }
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Database", "UploadVendorOrderConfirmationLine", "Parent ID: " + parent.ToString(), null);
            }
        }

        public static bool VendorAsnExistsInDB(ASN_Header asn)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
                {
                    dbcon.Open();
                    cmd = new SqlCommand("[dbo].[Ecommerce.OrderConfirmation.Control]", dbcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@method", "CHECK TABLE"));
                    cmd.Parameters.Add(new SqlParameter("@fromIdentity", asn.Credentials.FromIdentity));
                    cmd.Parameters.Add(new SqlParameter("@invoiceID", asn.ShipmentID));
                    cmd.Parameters.Add(new SqlParameter("@payloadID", asn.PayloadID));
                    cmd.Parameters.Add(new SqlParameter("@orderID", asn.OrderID));
                    cmd.Parameters.Add(new SqlParameter("@timestamp", asn.Timestamp));
                    using (SqlDataReader rs = cmd.ExecuteReader())
                        return rs.Read();
                }
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Database", "VendorAsnExistsInDB", asn.OrderID, null);
            }

            return false;
        }

        public static bool VendorOrderConfirmationExistsInDB(OrderConfirmationHeader oc)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection dbcon = new SqlConnection(Constants.EcommerceConnection))
                {
                    dbcon.Open();
                    cmd = new SqlCommand("[dbo].[Ecommerce.OrderConfirmation.Control]", dbcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@method", "CHECK TABLE"));
                    cmd.Parameters.Add(new SqlParameter("@fromIdentity", oc.CxmlCredentials.FromIdentity));
                    cmd.Parameters.Add(new SqlParameter("@invoiceID", oc.ConfirmID));
                    cmd.Parameters.Add(new SqlParameter("@payloadID", oc.PayloadID));
                    cmd.Parameters.Add(new SqlParameter("@orderID", oc.OrderID));
                    cmd.Parameters.Add(new SqlParameter("@timestamp", oc.Timestamp));
                    using (SqlDataReader rs = cmd.ExecuteReader())
                        return rs.Read();
                }
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Database", "VendorOrderConfirmationExistsInDB", oc.OrderID, null);
            }

            return false;
        }
        #endregion

        private static int GetInteger(SqlDataReader rs, string column)
        {
            try { return int.Parse(rs[column].ToString()); }
            catch { return 0; }
        }

        private static int GetInteger(SqlDataReader rs, int column)
        {
            try { return int.Parse(rs[column].ToString()); }
            catch { return 0; }
        }

        private static string GetString(SqlDataReader rs, string column)
        {
            try { return rs[column].ToString(); }
            catch { return ""; }
        }

        private static string GetString(SqlDataReader rs, int column)
        {
            try { return rs[column].ToString(); }
            catch { return ""; }
        }
    }
}
