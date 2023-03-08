using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using BizTalkLibrary.Objects;

namespace BizTalkLibrary.Classes
{
    
    public static class Global
    {
        #region multiple references
        public static string ValidateCustomerPoCreds(XmlDocument xml)
        {
            Credentials creds = GetCredentials(xml);

            return Database.ValidateCustomerPoCreds(creds.FromIdentity, creds.SharedSecret);
        }
        public static string ReturnListStringItem(List<string> list, int pos)
        {
            try
            {
                return list[pos];
            }
            catch
            {
                return "";
            }
        }
        public static string FilterStrings(string i)
        {
            return i.Replace("&amp;", "&").Replace("lt;", "<").Replace("gt;", ">").Replace("& amp", "&");
        }
        public static string GetOrderId(XmlDocument CXML)
        {
            try
            {
                string orderID = CXML.SelectNodes("//Request/OrderRequest/OrderRequestHeader/@orderID").Item(0).InnerXml;
                if (orderID.Contains(":"))
                    orderID = orderID.Remove(orderID.IndexOf(":"));
                return orderID;
            }
            catch
            {
            }
            return "";
        }
        public static DateTime GetDateTime(string value)
        {
            try
            {
                return DateTime.Parse(value);
            }
            catch
            {
                return Constants.NAVISION_DEFAULT_DATETIME_VALUE;
            }
        }
        public static string CutOff(string i, int len)
        {
            if (i.Length > len)
            {
                i = i.Split('/')[0].Trim();
                if (i.Length >= len)
                    i = i.Substring(0, len);
            }
            else
                i.Replace("/", "");
            return i; //.ToUpperInvariant();
        }
        public static string GetTimeFromTimeStamp(string value)
        {
            string year = value.Substring(0, 4);
            string month = value.Substring(4, 2);
            string day = value.Substring(6, 2);
            string hour = value.Substring(8, 2);
            string min = value.Substring(10, 2);
            string sec = value.Substring(12, 2);

            return month + "/" + day + "/" + year + " " + hour + ":" + min + ":" + sec;
        }
        public static string GetCXMLTimeStamp(DateTime value)
        {
            return value.ToString("yyyy-MM-ddTHH:mm:ss");
        }
        public static void CheckDirectory(string dir)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
        public static string GetTimeStamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssfffffff");
        }
        public static string CreateDump(string root, string key, string name, XmlDocument cXML, bool folderCreate)
        {
            if (root.Length == 0) root = Constants.DUMP_FOLDERS.UndefinedDirectory;

            string forceEncoding = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            string path = folderCreate ? $@"{root}\{DateTime.Now.ToString("yyyy")}\{DateTime.Now.ToString("MM")}\{DateTime.Now.ToString("dd")}\" : root;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            string file = key.Length > 0 ? path + $@"\{key}.{name}.xml" : path + $@"\{name}.xml";

            try
            {
                using (FileStream fs = File.Create(file))
                {
                    Byte[] contents = new UTF8Encoding(true).GetBytes(ReplaceSpecialCharacters(cXML.InnerXml.Contains(forceEncoding) ? cXML.InnerXml : forceEncoding + cXML.InnerXml));
                    fs.Write(contents, 0, contents.Length);
                    fs.Close();
                }

                return file;
            }
            catch
            {
                Random randomNum = new Random();
                int n = randomNum.Next(1000000000);
                Byte[] contents = new UTF8Encoding(true).GetBytes(ReplaceSpecialCharacters(cXML.InnerXml.Contains(forceEncoding) ? cXML.InnerXml : forceEncoding + cXML.InnerXml));

                file = key.Length > 0 ? $@"{path}\{key}.{name}.{n}.xml" : $@"{path}\{name}.{n}.xml";

                using (FileStream fs = File.Create(file, contents.Length, FileOptions.Asynchronous))
                {
                    fs.Write(contents, 0, contents.Length);
                    fs.Close();
                }

                return file;
            }
        }
        public static string CreateDump(string root, string key, string name, string cXML, bool folderCreate)
        {
            if (root.Length == 0) root = Constants.DUMP_FOLDERS.UndefinedDirectory;

            string forceEncoding = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            string path = folderCreate ? $@"{root}\{DateTime.Now.ToString("yyyy")}\{DateTime.Now.ToString("MM")}\{DateTime.Now.ToString("dd")}\" : root;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            string file = key.Length > 0 ? path + $@"\{key}.{name}.xml" : path + $@"\{name}.xml";

            try
            {
                using (FileStream fs = File.Create(file))
                {
                    Byte[] contents = new UTF8Encoding(true).GetBytes(ReplaceSpecialCharacters(cXML.Contains(forceEncoding) ? cXML : forceEncoding + cXML));
                    fs.Write(contents, 0, contents.Length);
                    fs.Close();
                }

                return file;
            }
            catch
            {
                Random randomNum = new Random();
                int n = randomNum.Next(1000000000);
                Byte[] contents = new UTF8Encoding(true).GetBytes(ReplaceSpecialCharacters(cXML.Contains(forceEncoding) ? cXML : forceEncoding + cXML));

                file = key.Length > 0 ? $@"{path}\{key}.{name}.{n}.xml" : $@"{path}\{name}.{n}.xml";

                using (FileStream fs = File.Create(file, contents.Length, FileOptions.Asynchronous))
                {
                    fs.Write(contents, 0, contents.Length);
                    fs.Close();
                }

                return file;
            }
        }
        public static string ReplaceSpecialCharacters(string input)
        {
            return input.Replace("®", "&#174;").Replace("©", "&#169;").Replace("™", "&#8482;");
        }
        public static void Output(string message)
        {
            string folder = $@"{Constants.LogFolder}{DateTime.Now.ToString("yyyy")}\{DateTime.Now.ToString("MM")}\{DateTime.Now.ToString("dd")}\";
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string filename = "log.txt";

            File.AppendAllText($"{folder}\\{filename}", $"[{DateTime.Now.ToString("MM/dd/yyyy hh:mm")}] - {message}{Environment.NewLine}");
        }
        public static string RemoveStrings(string i)
        {
            return i.Replace("&amp;", "").Replace("lt;", "").Replace("gt;", "").Replace("& amp", "").Replace("#39;", "");
        }
        public static Credentials GetCredentials(XmlDocument xml)
        {
            Constants.F1 setValue = x => x != null ? x.InnerXml : "";
            Credentials creds = new Credentials();

            creds.FromDomain = setValue(xml.SelectSingleNode("//Header/From/Credential/@domain"));
            creds.FromIdentity = setValue(xml.SelectSingleNode("//Header/From/Credential/Identity"));
            creds.ToDomain = setValue(xml.SelectSingleNode("//Header/To/Credential/@domain"));
            creds.ToIdentity = setValue(xml.SelectSingleNode("//Header/To/Credential/Identity"));
            creds.SenderDomain = setValue(xml.SelectSingleNode("//Header/Sender/Credential/@domain"));
            creds.SenderIdentity = setValue(xml.SelectSingleNode("//Header/Sender/Credential/Identity"));
            creds.SharedSecret = setValue(xml.SelectSingleNode("//Header/Sender/Credential/SharedSecret"));
            creds.UserAgent = setValue(xml.SelectSingleNode("//Header/Sender/UserAgent"));

            return creds;
        }
        public static bool CustomerPoDupCheck(XmlDocument cXML)
        {
            Constants.F1 setValue = x => x == null ? "" : x.InnerXml.Replace("'", "''");

            string salesTeamColor = "";
            Credentials creds = GetCredentials(cXML);
            string sellToCustomerNo = Database.GetNavSellToCustomerNo(ref salesTeamColor
                , creds
                , setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/@addressID"))
                , setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/City"))
                , setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Name")));

            string orderID = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/@orderID"));

            string no = Database.CheckCustomerPoNavision(sellToCustomerNo, orderID);

            return no.Length > 0;
        }
        public static XmlDocument ModifyCxml(XmlDocument cXML, string identifier = "", bool bypassPoFlag = false)
        {
            cXML = InboundUOMConversion(cXML);
            Constants.F1 setValue = x => x == null ? "" : x.InnerXml;
            Credentials creds = GetCredentials(cXML);
            if (identifier.Length == 0) identifier = creds.FromIdentity;
            string orderID = GetOrderId(cXML);

            foreach (XmlNode i in cXML.SelectNodes("//ItemOut"))
            {
                string supplierPartId = i.SelectSingleNode("ItemID/SupplierPartID").InnerXml;
                if (supplierPartId.EndsWith("&amp;lt;!--0--&amp;gt;")) supplierPartId = supplierPartId.Remove(supplierPartId.LastIndexOf("&amp;lt;!--0--&amp;gt;"));
                if (supplierPartId.EndsWith("&amp;LT;!--0--&amp;GT;")) supplierPartId = supplierPartId.Remove(supplierPartId.LastIndexOf("&amp;LT;!--0--&amp;GT;"));
                if (supplierPartId.EndsWith("LT;!--0--GT;")) supplierPartId = supplierPartId.Remove(supplierPartId.LastIndexOf("LT;!--0--GT;"));
                if (supplierPartId.EndsWith("!--0--")) supplierPartId = supplierPartId.Remove(supplierPartId.LastIndexOf("!--0--"));
                i.SelectSingleNode("ItemID/SupplierPartID").InnerXml = supplierPartId;

                if (i.SelectSingleNode("ItemID/SupplierPartID") != null)
                {
                    if (Database.CheckGssPartNo(setValue(i.SelectSingleNode("ItemID/SupplierPartID"))))
                    {
                        if (i.SelectSingleNode("ItemDetail/ManufacturerName") != null)
                            i.SelectSingleNode("ItemDetail/ManufacturerName").InnerXml = "GSS";
                        else
                        {
                            XmlElement manuName = cXML.CreateElement("ManufacturerName");
                            manuName.AppendChild(cXML.CreateTextNode("GSS"));
                            i.SelectSingleNode("ItemDetail").AppendChild(manuName);
                        }
                    }
                }

                if (i.SelectSingleNode("@quantity").InnerXml.Contains(","))
                    i.SelectSingleNode("@quantity").InnerXml = i.SelectSingleNode("@quantity").InnerXml.Replace(",", "");
            }

            if (identifier == "LBNL_Industrial_PO" || identifier == "LBNL_V_PO")
            {
                XmlNodeList lines = cXML.SelectNodes("//ItemOut");
                foreach (XmlNode line in lines)
                {
                    string vendorPartNum = setValue(line.SelectSingleNode("ItemID/SupplierPartID"));                //Vendor Part No
                    string manufactureName = setValue(line.SelectSingleNode("ItemDetail/ManufacturerPartID"));   //Manufacturer Name
                    string unspscCode = setValue(line.SelectSingleNode("ItemDetail/ManufacturerName"));       //UNSPSC Code

                    if (Regex.Match(unspscCode, @"^Q\d+?$").Success)
                        unspscCode = "";

                    XmlNode itemDetail = line.SelectSingleNode("ItemDetail");

                    itemDetail.SelectSingleNode("Classification/@domain").InnerXml = "UNSPSC";
                    itemDetail.SelectSingleNode("Classification").InnerXml = unspscCode;

                    string convertedManuName = Database.GetVendorName(identifier, creds.SharedSecret, manufactureName);
                    itemDetail.SelectSingleNode("ManufacturerName").InnerXml = convertedManuName;
                    string supplierPartAuxID = setValue(line.SelectSingleNode("ItemID/SupplierPartAuxiliaryID"));
                    if (convertedManuName == "GSS" && supplierPartAuxID.Length > 0)
                    {
                        line.SelectSingleNode("ItemID/SupplierPartID").InnerXml = supplierPartAuxID;
                        itemDetail.SelectSingleNode("ManufacturerPartID").InnerXml = setValue(line.SelectSingleNode("ItemID/SupplierPartAuxiliaryID"));
                    }
                    else
                        itemDetail.SelectSingleNode("ManufacturerPartID").InnerXml = vendorPartNum;
                }

                string bldgroom = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Extrinsic[@name=\"DELIVER_TO\"]").InnerXml;
                string shipToBlock = "";
                XmlNode address = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress");
                if (bldgroom.StartsWith("400"))
                {
                    string deliverTo = address.SelectSingleNode("DeliverTo").InnerXml.Split('/')[0].Trim();
                    string country = address.SelectSingleNode("Country/@isoCountryCode").Value;
                    shipToBlock = "<DeliverTo>" + deliverTo + "</DeliverTo>";
                    shipToBlock += "<Street>JOINT GENOME INSTITUTE / LBNL</Street>";
                    shipToBlock += "<Street>2800 MITCHELL DRIVE</Street>";
                    shipToBlock += "<Street>DELIVER TO " + bldgroom + "</Street>";
                    shipToBlock += "<City>WALNUT CREEK</City>";
                    shipToBlock += "<State>CA</State>";
                    shipToBlock += "<PostalCode>94598</PostalCode>";
                    shipToBlock += "<Country isoCountryCode=\"" + country + "\"></Country>";
                }
                else if (bldgroom.CompareTo("BNNL") == 0)
                {
                    string pono = cXML.SelectSingleNode("//OrderRequestHeader/@orderID").InnerXml;
                    string deliverTo = address.SelectSingleNode("DeliverTo").InnerXml.Split('/')[0].Trim();
                    string country = address.SelectSingleNode("Country/@isoCountryCode").Value;
                    shipToBlock = "<DeliverTo>" + deliverTo + "</DeliverTo>";
                    shipToBlock += "<Street>BROOKHAVEN NATIONAL LABORATORY</Street>";
                    shipToBlock += "<Street>30 BELL AVE, MEDICAL DEPT, BLDG 490</Street>";
                    shipToBlock += "<Street>ATTN: " + pono + " / " + deliverTo + "</Street>";
                    shipToBlock += "<City>UPTON</City>";
                    shipToBlock += "<State>NY</State>";
                    shipToBlock += "<PostalCode>11973</PostalCode>";
                    shipToBlock += "<Country isoCountryCode=\"" + country + "\"></Country>";
                }
                else
                {
                    string deliverTo = address.SelectSingleNode("DeliverTo").InnerXml.Split('/')[0].Trim();
                    string[] streets = new string[address.SelectNodes("Street").Count];
                    for (int i = 0; i < address.SelectNodes("Street").Count; i++)
                        streets[i] = address.SelectNodes("Street")[i].InnerXml;
                    string city = address.SelectSingleNode("City").InnerXml;
                    string state = address.SelectSingleNode("State").InnerXml;
                    string postCode = address.SelectSingleNode("PostalCode").InnerXml;
                    string country = address.SelectSingleNode("Country/@isoCountryCode").Value;

                    shipToBlock = "<DeliverTo>" + deliverTo + "</DeliverTo>";
                    if (streets.Length > 0) shipToBlock += "<Street>" + streets[0] + "</Street>";
                    if (streets.Length > 2) shipToBlock += "<Street>" + streets[2].Replace("ROAD", "RD").Replace(".", "") + "</Street>";
                    if (streets.Length > 1)
                    {
                        if (streets[1].Replace(".", "") == "FOR THE US DEPT OF ENERGY")
                            shipToBlock += "<Street>DELIVER TO " + bldgroom + "</Street>";
                        else
                            shipToBlock += "<Street>" + streets[1] + "</Street>";
                    }
                    shipToBlock += "<City>" + city + "</City>";
                    shipToBlock += "<State>" + state + "</State>";
                    shipToBlock += "<PostalCode>" + postCode + "</PostalCode>";
                    shipToBlock += "<Country isoCountryCode=\"" + country + "\"></Country>";
                }
                shipToBlock = shipToBlock.Replace("&", "&amp;");
                XmlNodeList addresses = cXML.SelectNodes("//ShipTo/Address/PostalAddress");
                foreach (XmlNode a in addresses)
                {
                    foreach (XmlNode e in a)
                        a.RemoveChild(e);
                    a.InnerXml = shipToBlock;
                }

                try
                {
                    XmlNode phoneNumber = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address/Phone/TelephoneNumber/Number");
                    if (phoneNumber == null)
                    {
                        XmlNode billTo = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address");
                        XmlNode ePhone = cXML.CreateElement("Phone");
                        billTo.AppendChild(ePhone);

                        XmlNode eTele = cXML.CreateElement("TelephoneNumber");
                        ePhone.AppendChild(eTele);

                        XmlElement eCountryCode = cXML.CreateElement("CountryCode");
                        eCountryCode.SetAttribute("isoCountryCode", "");
                        eTele.AppendChild(eCountryCode);

                        XmlElement eAreaCode = cXML.CreateElement("AreaOrCityCode");
                        eAreaCode.AppendChild(cXML.CreateTextNode("703"));
                        eTele.AppendChild(eAreaCode);

                        XmlElement eNumber = cXML.CreateElement("Number");
                        eNumber.AppendChild(cXML.CreateTextNode("880-5040"));
                        eTele.AppendChild(eNumber);
                    }
                }
                catch
                {
                    XmlNode billTo = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/BillTo/Address");
                    XmlNode ePhone = cXML.CreateElement("Phone");
                    billTo.AppendChild(ePhone);

                    XmlNode eTele = cXML.CreateElement("TelephoneNumber");
                    ePhone.AppendChild(eTele);

                    XmlElement eCountryCode = cXML.CreateElement("CountryCode");
                    eCountryCode.SetAttribute("isoCountryCode", "");
                    eTele.AppendChild(eCountryCode);

                    XmlElement eAreaCode = cXML.CreateElement("AreaOrCityCode");
                    eAreaCode.AppendChild(cXML.CreateTextNode("703"));
                    eTele.AppendChild(eAreaCode);

                    XmlElement eNumber = cXML.CreateElement("Number");
                    eAreaCode.AppendChild(cXML.CreateTextNode("880-5040"));
                    eTele.AppendChild(eNumber);
                }
            }
            else if (identifier == "Battelle")
            {
                if (bypassPoFlag)
                {
                    XmlNode orderRequest = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader");
                    XmlAttribute orderVersion = orderRequest.Attributes["orderVersion"];
                    if (orderVersion != null)
                        orderRequest.Attributes.Remove(orderVersion);
                }
            }
            else if (identifier == "BMEI-T" || identifier == "BMEI")
            {
                XmlNode request = cXML.SelectSingleNode("//Request");
                XmlAttribute attr = cXML.CreateAttribute("deploymentMode");
                attr.Value = "production";
                request.Attributes.SetNamedItem(attr);

                XmlNodeList items = cXML.SelectNodes("//ItemOut");
                foreach (XmlNode item in items)
                {
                    string vendor = "GSS";

                    string supplierPartID = item.SelectSingleNode("ItemID/SupplierPartAuxiliaryID").InnerXml;
                    if (supplierPartID.Contains("|"))
                    {
                        string[] descrs = supplierPartID.Split('|');
                        if (descrs.Length > 1)
                        {
                            vendor = descrs[0].Trim();
                            supplierPartID = descrs[1].Trim();
                        }
                    }

                    XmlElement manuName = cXML.CreateElement("ManufacturerName");
                    manuName.AppendChild(cXML.CreateTextNode(vendor));
                    item.SelectSingleNode("ItemDetail").AppendChild(manuName);
                    item.SelectSingleNode("ItemID/SupplierPartAuxiliaryID").InnerXml = supplierPartID;

                    XmlNodeList extrinsics = item.SelectNodes("ItemDetail/Extrinsic");
                    foreach (XmlNode extr in extrinsics)
                        item.SelectSingleNode("ItemDetail").RemoveChild(extr);
                }

                XmlNode shipTo = cXML.SelectSingleNode("//ShipTo");
                XmlNodeList streets = shipTo.SelectNodes("Address/PostalAddress/Street");
                foreach (XmlNode street in streets)
                    street.InnerXml = street.InnerXml.Trim();
                shipTo.SelectSingleNode("Address/PostalAddress/City").InnerXml = shipTo.SelectSingleNode("Address/PostalAddress/City").InnerXml.Trim();

                try
                {
                    XmlNodeList contacts = cXML.SelectNodes("//OrderRequestHeader/Contact");
                    XmlNode contact = null;
                    foreach (XmlNode c in contacts)
                        if (c.SelectSingleNode("@role").InnerText == "endUser")
                            contact = c;

                    if (contact != null)
                    {
                        string name = contact.SelectSingleNode("Name").InnerText;
                        shipTo.SelectSingleNode("Address/PostalAddress/DeliverTo").InnerXml = name;
                    }
                }
                catch { }
            }
            else if (identifier == "INL" || identifier == "AN01723923616-T" || identifier == "AN01723923616")
            {
                XmlNode shipTo = null;
                XmlNodeList lines = cXML.SelectNodes("cXML/Request/OrderRequest/ItemOut");
                foreach (XmlNode line in lines)
                {
                    string manufacturerName = setValue(line.SelectSingleNode("ItemDetail/ManufacturerName"));
                    if (manufacturerName.Length == 0 && line.SelectSingleNode("ItemDetail/ManufacturerName") == null)
                    {
                        XmlElement manuName = cXML.CreateElement("ManufacturerName");
                        manuName.AppendChild(cXML.CreateTextNode("GSS"));
                        line.SelectSingleNode("ItemDetail").AppendChild(manuName);
                    }
                    else
                    {
                        string custVendor = Database.GetVendorName(identifier, creds.SharedSecret, manufacturerName);
                        if (custVendor.Length > 0)
                            line.SelectSingleNode("ItemDetail/ManufacturerName").InnerXml = custVendor;
                    }

                    if (shipTo == null && line.SelectSingleNode("ShipTo") != null)
                        shipTo = line.SelectSingleNode("ShipTo");
                }

                if (cXML.SelectSingleNode("//OrderRequestHeader/ShipTo") == null && shipTo != null)
                    cXML.SelectSingleNode("//OrderRequestHeader").InsertBefore(shipTo, cXML.SelectSingleNode("//OrderRequestHeader/BillTo"));
            }
            else if (identifier == "SLAC-Chem")
            {
                string bldgroom = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/Extrinsic[@name=\"DELIVER_TO\"]").InnerXml.Trim();
                XmlNode shipTo = cXML.SelectSingleNode("//ShipTo");
                if (bldgroom == "WSU_VRIAN")
                {
                    string addressBlock = "<Address addressID=\"" + bldgroom + "\">"
                    + "<Name xml:lang=\"en\">" + shipTo.SelectSingleNode("Address/Name").InnerXml + "</Name>"
                    + "<PostalAddress name=\"" + bldgroom + "\">"
                    + "<DeliverTo>" + shipTo.SelectSingleNode("Address/PostalAddress/DeliverTo").InnerXml + "</DeliverTo>"
                    + "<Street>" + shipTo.SelectSingleNode("Address/Name").InnerXml + "</Street>"
                    + "<Street>382 Via Pueblo</Street>"
                    + "<Street>Room 0014</Street>"
                    + "<City>Stanford</City>"
                    + "<State>CA</State>"
                    + "<PostalCode>94305</PostalCode>"
                    + "<Country isoCountryCode=\"US\">US</Country>"
                    + "</PostalAddress><Email name=\"Recipent\">" + shipTo.SelectSingleNode("Address/Email").InnerXml + "</Email>"
                    + "<Phone><TelephoneNumber><CountryCode isoCountryCode=\"\"/><AreaOrCityCode/><Number/></TelephoneNumber></Phone></Address>";
                    shipTo.InnerXml = addressBlock;
                }
                else if (bldgroom == "WSU_MCCUL")
                {
                    string addressBlock = "<Address addressID=\"" + bldgroom + "\">"
                    + "<Name xml:lang=\"en\">" + shipTo.SelectSingleNode("Address/Name").InnerXml + "</Name>"
                    + "<PostalAddress name=\"" + bldgroom + "\">"
                    + "<DeliverTo>" + shipTo.SelectSingleNode("Address/PostalAddress/DeliverTo").InnerXml + "</DeliverTo>"
                    + "<Street>" + shipTo.SelectSingleNode("Address/Name").InnerXml + "</Street>"
                    + "<Street>476 Lomita Mall</Street>"
                    + "<Street>Room 114</Street>"
                    + "<City>Stanford</City>"
                    + "<State>CA</State>"
                    + "<PostalCode>94305</PostalCode>"
                    + "<Country isoCountryCode=\"US\">US</Country>"
                    + "</PostalAddress><Email name=\"Recipent\">" + shipTo.SelectSingleNode("Address/Email").InnerXml + "</Email>"
                    + "<Phone><TelephoneNumber><CountryCode isoCountryCode=\"\"/><AreaOrCityCode/><Number/></TelephoneNumber></Phone></Address>";
                    shipTo.InnerXml = addressBlock;
                }
            }
            else if (identifier == "ELPASO")
            {
                string manuName = setValue(cXML.SelectSingleNode("//OrderRequestHeader/Extrinsic[@name=\"ManufacturerName\"]"));
                manuName = manuName.Length == 0 ? manuName = "GSS" : manuName;

                foreach (XmlNode itemOut in cXML.SelectNodes("//ItemOut"))
                    itemOut.SelectSingleNode("ItemDetail/ManufacturerName").InnerXml = manuName;
            }
            else if (identifier == "FredHutch")
            {
                XmlNodeList lines = cXML.SelectNodes("cXML/Request/OrderRequest/ItemOut");
                foreach (XmlNode line in lines)
                {
                    string manufacturerName = setValue(line.SelectSingleNode("ItemDetail/ManufacturerName"));
                    if (manufacturerName.Length == 0)
                        line.SelectSingleNode("ItemDetail/ManufacturerName").InnerXml = "GSS";
                }
            }
            else if (identifier == "gsaadvan")
            {
                Address addr = new Address();
                addr.Name = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/Name"));

                foreach (XmlNode street in cXML.SelectNodes("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/Street"))
                    addr.Streets.Add(setValue(street));

                addr.City = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/City"));
                addr.State = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/State"));
                addr.PostalCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/PostalCode"));
                addr.Country = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/Country"));
                addr.CountryCode = setValue(cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/Country/@isoCountryCode"));

                int ShipToID = Database.GetShipToID(creds, addr, orderID);

                if (ShipToID > 0)
                {
                    XmlNode ShipToAddress = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address");
                    XmlAttribute attr = cXML.CreateAttribute("addressID");
                    attr.Value = ShipToID.ToString();
                    ShipToAddress.Attributes.SetNamedItem(attr);
                }

                List<string> quotes = new List<string>();
                List<string> reqDeliverDate = new List<string>();

                foreach (XmlNode itemOut in cXML.SelectNodes("//ItemOut"))
                {
                    itemOut.SelectSingleNode("ItemDetail/ManufacturerName").InnerXml = "GSS";
                    if (itemOut.SelectSingleNode("ItemDetail/ManufacturerPartID").InnerXml.Contains("RFQ"))
                    {
                        string manuPartID = itemOut.SelectSingleNode("ItemDetail/ManufacturerPartID").InnerXml;
                        Match m = Regex.Match(manuPartID, @"IAW your quote\#(?<quote>RFQ.+?)\-.+?$");
                        if (m.Success)
                            quotes.Add(m.Groups["quote"].Value);
                        reqDeliverDate.Add(setValue(itemOut.SelectSingleNode("@requestedDeliveryDate")));

                        cXML.SelectSingleNode("//OrderRequest").RemoveChild(itemOut);
                    }
                }

                if (quotes.Count > 0)
                {
                    for (int i = 0; i < quotes.Count; i++)
                    {
                        try
                        {
                            SalesQuoteHeader quote = Database.GetSalesQuote(GetOrderId(cXML), quotes[i]);
                            XmlElement deliverTo = cXML.CreateElement("DeliverTo");
                            deliverTo.AppendChild(cXML.CreateTextNode(quote.ContactName));
                            cXML.SelectSingleNode("//ShipTo/Address/PostalAddress").AppendChild(deliverTo);

                            XmlElement shipToEmail = cXML.CreateElement("Email");
                            shipToEmail.SetAttribute("name", "default");
                            shipToEmail.AppendChild(cXML.CreateTextNode(quote.ContactEmail));
                            cXML.SelectSingleNode("//ShipTo/Address").AppendChild(shipToEmail);

                            foreach (SalesQuoteLine line in quote.QuoteLines)
                            {
                                XmlElement itemOut = cXML.CreateElement("ItemOut");
                                itemOut.SetAttribute("quantity", line.Quantity);
                                itemOut.SetAttribute("lineNumber", line.ToString());
                                itemOut.SetAttribute("requestedDeliveryDate", reqDeliverDate[i]);

                                XmlElement itemId = cXML.CreateElement("ItemID");
                                XmlElement supplierPartId = cXML.CreateElement("SupplierPartID");
                                supplierPartId.AppendChild(cXML.CreateTextNode(line.No_));
                                itemId.AppendChild(supplierPartId);
                                itemOut.AppendChild(itemId);

                                XmlElement itemDetail = cXML.CreateElement("ItemDetail");

                                XmlElement unitPrice = cXML.CreateElement("UnitPrice");
                                XmlElement money = cXML.CreateElement("Money");
                                money.SetAttribute("currency", "USD");
                                money.AppendChild(cXML.CreateTextNode(line.Unit_Price));
                                unitPrice.AppendChild(money);
                                itemDetail.AppendChild(unitPrice);

                                XmlElement description = cXML.CreateElement("Description");
                                description.SetAttribute("xml:lang", "en-US");
                                description.AppendChild(cXML.CreateTextNode(line.Description));
                                itemDetail.AppendChild(description);

                                XmlElement unitOfMeasure = cXML.CreateElement("UnitOfMeasure");
                                unitOfMeasure.AppendChild(cXML.CreateTextNode(line.Unit_Of_Measure_Code));
                                itemDetail.AppendChild(unitOfMeasure);

                                XmlElement classification = cXML.CreateElement("Classification");
                                classification.SetAttribute("domain", "SPSC");
                                itemDetail.AppendChild(classification);

                                XmlElement manuPartId = cXML.CreateElement("ManufacturerPartID");
                                manuPartId.AppendChild(cXML.CreateTextNode(line.No_));
                                itemDetail.AppendChild(manuPartId);

                                XmlElement manuName = cXML.CreateElement("ManufacturerName");
                                manuName.AppendChild(cXML.CreateTextNode("GSS"));
                                itemDetail.AppendChild(manuName);

                                XmlElement extrinsic = cXML.CreateElement("Extrinsic");
                                extrinsic.SetAttribute("name", "unitCost");
                                extrinsic.AppendChild(cXML.CreateTextNode(line.Unit_Cost_LCY));
                                itemDetail.AppendChild(extrinsic);

                                itemOut.AppendChild(itemDetail);
                                cXML.SelectSingleNode("//OrderRequest").AppendChild(itemOut);
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }
            else if (identifier == "AN01460290704-T" || identifier == "AN01460290704")
            {
                cXML.SelectSingleNode("//ShipTo/Address/@addressID").InnerXml = "1";
                string deliverTo = "";

                foreach (XmlNode item in cXML.SelectNodes("//ItemOut"))
                {
                    try { if (deliverTo.Length == 0) deliverTo = item.SelectSingleNode("ItemDetail/Extrinsic[@name=\"Requester\"]").InnerXml; }
                    catch { }
                }

                if (deliverTo.Length == 0) deliverTo = Database.GetContactName("LOS ALAMOS NNSA", cXML.SelectSingleNode("//ShipTo/Address/Email").InnerXml);

                string shipto = "<DeliverTo>" + deliverTo + "</DeliverTo>"
                    + "<Street>" + cXML.SelectSingleNode("//ShipTo/Address/PostalAddress/Street").InnerXml + "</Street>"
                    + "<Street>" + cXML.SelectSingleNode("//ShipTo/Address/PostalAddress/DeliverTo").InnerXml + "</Street>"
                    + "<City>" + cXML.SelectSingleNode("//ShipTo/Address/PostalAddress/City").InnerXml + "</City>"
                    + "<State>" + cXML.SelectSingleNode("//ShipTo/Address/PostalAddress/State").InnerXml + "</State>"
                    + "<PostalCode>" + cXML.SelectSingleNode("//ShipTo/Address/PostalAddress/PostalCode").InnerXml + "</PostalCode>"
                    + "<Country isoCountryCode='" + cXML.SelectSingleNode("//ShipTo/Address/PostalAddress/Country/@isoCountryCode").InnerXml + "'>" + cXML.SelectSingleNode("//ShipTo/Address/PostalAddress/Country").InnerXml + "</Country>";

                cXML.SelectSingleNode("//ShipTo/Address/PostalAddress").InnerXml = shipto;
            }
            else if (identifier == "AN01594548150-T" || identifier == "AN01594548150")
            {
                string deliverTo = "", building = "", room = "";

                foreach (XmlNode item in cXML.SelectNodes("//ItemOut"))
                {
                    if (deliverTo.Length == 0)
                        deliverTo = setValue(item.SelectSingleNode("ItemDetail/Extrinsic[@name=\"Requester\"]"));

                    if (building.Length == 0)
                        building = setValue(item.SelectSingleNode("ItemDetail/Extrinsic[@name=\"Building.ID\"]"));

                    if (room.Length == 0)
                        room = setValue(item.SelectSingleNode("ItemDetail/Extrinsic[@name=\"Location/Room.ID\"]"));
                }

                if (deliverTo.Length == 0) deliverTo = Database.GetContactName("OAK RIDGE NTL LAB", setValue(cXML.SelectSingleNode("//ShipTo/Address/Email")));

                string[] streets = new string[1];
                if (cXML.SelectNodes("//ShipTo/Address/PostalAddress/Street") != null && cXML.SelectNodes("//ShipTo/Address/PostalAddress/Street").Count > 0)
                {
                    streets = new string[cXML.SelectNodes("//ShipTo/Address/PostalAddress/Street").Count];
                    for (int i = 0; i < streets.Length; i++)
                        streets[i] = setValue(cXML.SelectNodes("//ShipTo/Address/PostalAddress/Street")[i]);
                }

                string shipto = "<DeliverTo>" + deliverTo + "</DeliverTo>"
                    + "<Street>" + building + " " + room + "</Street>"
                    + "<Street>" + streets[0] + "</Street>"
                    + "<City>" + setValue(cXML.SelectSingleNode("//ShipTo/Address/PostalAddress/City")) + "</City>"
                    + "<State>" + setValue(cXML.SelectSingleNode("//ShipTo/Address/PostalAddress/State")) + "</State>"
                    + "<PostalCode>" + setValue(cXML.SelectSingleNode("//ShipTo/Address/PostalAddress/PostalCode")) + "</PostalCode>"
                    + "<Country isoCountryCode='" + setValue(cXML.SelectSingleNode("//ShipTo/Address/PostalAddress/Country/@isoCountryCode")) + "'>" + setValue(cXML.SelectSingleNode("//ShipTo/Address/PostalAddress/Country")) + "</Country>";

                if (cXML.SelectSingleNode("//ShipTo/Address/Name") != null)
                    cXML.SelectSingleNode("//ShipTo/Address/Name").InnerXml = "DOE / OAK RIDGE NATL LAB";

                if (cXML.SelectSingleNode("//ShipTo/Address/PostalAddress") != null)
                    cXML.SelectSingleNode("//ShipTo/Address/PostalAddress").InnerXml = shipto;
            }
            else if (identifier == "65652314")
            {
                foreach (XmlNode item in cXML.SelectNodes("//ItemOut"))
                {
                    string supplierName = setValue(item.SelectSingleNode("ItemDetail/Extrinsic[@name=\"SupplierName\"]"));
                    if(supplierName.Length>0)
                    {
                        XmlElement manufacturerName = cXML.CreateElement("ManufacturerName");
                        manufacturerName.AppendChild(cXML.CreateTextNode(supplierName));
                        item.SelectSingleNode("ItemDetail").InsertBefore(manufacturerName, item.SelectSingleNode("Extrinsic"));
                    }    
                }
            }
            else if (identifier == "046636614")
            {
                foreach (XmlNode item in cXML.SelectNodes("//ItemOut"))
                {
                    if (item.SelectSingleNode("ItemDetail/ManufacturerName") == null)
                    {
                        XmlElement manufacturerName = cXML.CreateElement("ManufacturerName");
                        manufacturerName.AppendChild(cXML.CreateTextNode("GSS"));
                        item.SelectSingleNode("ItemDetail").AppendChild(manufacturerName);
                    }
                }
            }

            //     output("End of checkPOVendor");

            return cXML;
        }
        public static string CheckLength(string _i, int len)
        {
            if (_i.Length > len)
                _i = _i.Substring(0, len);
            return _i;
        }
        public static string IsWhatTypeOfDocument(XmlDocument xml)
        {
            if (xml.SelectSingleNode("//ShipNoticeRequest") != null)
                return "ASN";
            else if (xml.SelectSingleNode("//InvoiceDetailRequest") != null)
                return "INVOICE";
            else if (xml.SelectSingleNode("//ConfirmationRequest") != null)
                return "ORDERCONFIRMATION";
            else
                return "UNKNOWN";
        }
        public static ASN_Header ExtractAsn(XmlDocument cXML)
        {
            Constants.F1 setValue = x => x != null ? x.InnerXml : "";
            ASN_Header asn = new ASN_Header();

            try
            {
                asn.Credentials = Global.GetCredentials(cXML);
                if (cXML.SelectSingleNode("//Header/From/Credential/DigitalSignature") != null ||
                    cXML.SelectSingleNode("//Header/To/Credential/DigitalSignature") != null ||
                    cXML.SelectSingleNode("//Header/Sender/Credential/DigitalSignature") != null)
                {
                    asn.Credentials.SenderDomain = "SPS";
                }

                if (cXML.SelectSingleNode("//ShipNoticeRequest") != null)
                {
                    asn.ShipmentID = setValue(cXML.SelectSingleNode("//ShipNoticeHeader/@shipmentID"));
                    asn.NoticeDate = setValue(cXML.SelectSingleNode("//ShipNoticeHeader/@noticeDate"));
                    asn.OrderDate = setValue(cXML.SelectSingleNode("//Request/ShipNoticeRequest/ShipNoticePortion/OrderReference/@orderDate"));
                    asn.ShipmentDate = setValue(cXML.SelectSingleNode("//ShipNoticeHeader/@shipmentDate"));
                    if (asn.ShipmentDate.Contains("T"))
                    {
                        asn.ShipmentDate = asn.ShipmentDate.Split('T')[0];
                    }
                    asn.DeliveryDate = setValue(cXML.SelectSingleNode("//ShipNoticeHeader/@deliveryDate"));
                    if (asn.DeliveryDate.Contains("T"))
                    {
                        asn.DeliveryDate = asn.DeliveryDate.Split('T')[0];
                    }

                    /* ################### Extract Contacts information ################### */
                    XmlNodeList contacts = cXML.SelectNodes("//Contact");
                    foreach (XmlNode contact in contacts)
                    {
                        Address addr = new Address();
                        addr.Role = setValue(contact.SelectSingleNode("@role"));
                        addr.Name = setValue(contact.SelectSingleNode("Name"));
                        addr.Name2 = setValue(contact.SelectSingleNode("PostalAddress/@name"));
                        addr.DeliverTo = setValue(contact.SelectSingleNode("PostalAddress/DeliverTo"));

                        if (contact.SelectSingleNode("PostalAddress/DeliverTo") != null)
                            for (int i = 0; i < contact.SelectNodes("PostalAddress/DeliverTo").Count; i++)
                                addr.MultipleDeliverTos.Add(contact.SelectNodes("PostalAddress/DeliverTo")[i].InnerXml);

                        if (contact.SelectSingleNode("PostalAddress/Street") != null)
                            for (int i = 0; i < contact.SelectNodes("PostalAddress/Street").Count; i++)
                                addr.Streets.Add(contact.SelectNodes("PostalAddress/Street")[i].InnerXml);

                        addr.City = setValue(contact.SelectSingleNode("PostalAddress/City"));
                        addr.State = setValue(contact.SelectSingleNode("PostalAddress/State"));
                        addr.PostalCode = setValue(contact.SelectSingleNode("PostalAddress/PostalCode"));
                        addr.Country = setValue(contact.SelectSingleNode("PostalAddress/Country"));
                        addr.CountryCode = setValue(contact.SelectSingleNode("PostalAddress/Country/@isoCountryCode"));
                        addr.EmailAddress = setValue(contact.SelectSingleNode("Email"));

                        addr.Phone = new PhoneObject();
                        addr.Phone.Name = setValue(contact.SelectSingleNode("Phone/@name"));
                        addr.Phone.CountryCode = setValue(contact.SelectSingleNode("Phone/TelephoneNumber/CountryCode/@isoCountryCode"));
                        addr.Phone.Country = setValue(contact.SelectSingleNode("Phone/TelephoneNumber/CountryCode"));

                        addr.Phone.AreaCode = setValue(contact.SelectSingleNode("Phone/TelephoneNumber/AreaOrCityCode"));
                        addr.Phone.Number = setValue(contact.SelectSingleNode("Phone/TelephoneNumber/Number"));
                        addr.Phone.Extension = setValue(contact.SelectSingleNode("Phone/TelephoneNumber/Extension"));

                        asn.Contacts.Add(addr);
                    }

                    foreach (XmlNode node in cXML.SelectNodes("//Request/ShipNoticeRequest/ShipNoticeHeader/Contact/PostalAddress/Extrinsic"))
                        asn.Extrinsics.Add($"{setValue(node.SelectSingleNode("@name"))}:{setValue(node)}");

                    /* ################### Extract ASN ShipControl portion information ################### */
                    asn.CarrierIdentifier = setValue(cXML.SelectSingleNode("//ShipControl/CarrierIdentifier"));
                    if (asn.CarrierIdentifier.Equals(""))
                    {
                        asn.CarrierIdentifier = setValue(cXML.SelectSingleNode("//Request/ShipNoticeRequest/Route/CarrierIdentifier"));
                    }

                    asn.CarrierIdentifierDomain = setValue(cXML.SelectSingleNode("//ShipControl/CarrierIdentifier/@domain"));
                    asn.ShipmentIdentifier = setValue(cXML.SelectSingleNode("//ShipControl/ShipmentIdentifier"));
                    if (asn.ShipmentIdentifier.Equals(""))
                    {
                        asn.ShipmentIdentifier = setValue(cXML.SelectSingleNode("//Request/ShipNoticeRequest/Route/ShipmentIdentifier"));
                    }

                    /* ################### Extract ASN Shipnotice portion information ################### */
                    asn.OrderID = setValue(cXML.SelectSingleNode("//ShipNoticePortion/OrderReference/@orderID"));
                    asn.PayloadID = setValue(cXML.SelectSingleNode("//ShipNoticePortion/OrderReference/DocumentReference/@payloadID"));
                    asn.Timestamp = setValue(cXML.SelectSingleNode("cXML/@timestamp"));
                    asn.DeploymentMode = setValue(cXML.SelectSingleNode("//Request/@deploymentMode"));
                    asn.Operation = setValue(cXML.SelectSingleNode("//Request/ShipNoticeRequest/ShipNoticeHeader/@operation"));
                    asn.Type = setValue(cXML.SelectSingleNode("//Request/ShipNoticeRequest/ShipNoticeHeader/@shipmentType"));

                    XmlNodeList shipNoticeItems = cXML.SelectNodes("//ShipNoticeItem");
                    foreach (XmlNode shipNoticeItem in shipNoticeItems)
                    {
                        ASN_Line line = new ASN_Line();
                        line.LineNumber = setValue(shipNoticeItem.SelectSingleNode("@lineNumber"));
                        line.Quantity = setValue(shipNoticeItem.SelectSingleNode("@quantity"));
                        line.UnitOfMeasure = setValue(shipNoticeItem.SelectSingleNode("//UnitOfMeasure"));
                        line.ShipLine = setValue(shipNoticeItem.SelectSingleNode("@shipNoticeLineNumber"));
                        line.DeliveryDate = asn.DeliveryDate;
                        line.ShipmentDate = asn.ShipmentDate;
                        asn.Lines.Add(line);
                    }

                }

                return asn;
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Inbound_Status_Doc_cXML_Process", "ExtractAsn", asn.OrderID, null);
                return null;
            }
        }
        public static OrderConfirmationHeader ExtractOrderConfirmation(XmlDocument document)
        {
            Constants.F1 setValue = x => x != null ? x.InnerXml : "";
            OrderConfirmationHeader order = new OrderConfirmationHeader();

            try
            {
                order.CxmlCredentials = Global.GetCredentials(document);

                if (order.CxmlCredentials.UserAgent.CompareTo("PeopleSoft eProcurement") == 0 || order.CxmlCredentials.UserAgent.CompareTo("B2B_PO4U") == 0) order.CxmlCredentials.UserAgent = "Newark";

                if (document.SelectSingleNode("//Header/From/Credential/DigitalSignature") != null ||
                    document.SelectSingleNode("//Header/To/Credential/DigitalSignature") != null ||
                    document.SelectSingleNode("//Header/Sender/Credential/DigitalSignature") != null)
                {
                    order.CxmlCredentials.SenderDomain = "SPS";
                }

                order.Timestamp = setValue(document.SelectSingleNode("//@timestamp"));
                order.DeploymentMode = setValue(document.SelectSingleNode("//Request/@deploymentMode"));
                order.Type = setValue(document.SelectSingleNode("//Request/ConfirmationRequest/ConfirmationHeader/@type"));
                order.Operation = setValue(document.SelectSingleNode("//Request/ConfirmationRequest/ConfirmationHeader/@operation"));


                order.ConfirmID = setValue(document.SelectSingleNode("//Request/ConfirmationRequest/ConfirmationHeader/@confirmID"));
                order.OrderID = setValue(document.SelectSingleNode("//Request/ConfirmationRequest/OrderReference/@orderID"));
                if (order.OrderID.Equals(String.Empty))
                {
                    order.OrderID = setValue(document.SelectSingleNode("//Request/ConfirmationRequest/OrderReference/DocumentReference/@payloadID")).Split('@')[0];
                    if (order.OrderID.Contains("-"))
                    {
                        order.OrderID = String.Empty;
                    }
                }

                order.NoticeDate = setValue(document.SelectSingleNode("//Request/ConfirmationRequest/ConfirmationHeader/@noticeDate"));
                order.OrderDate = setValue(document.SelectSingleNode("//Request/ConfirmationRequest/OrderReference/@orderDate"));
                order.PayloadID = setValue(document.SelectSingleNode("//Request/ConfirmationRequest/OrderReference/DocumentReference/@payloadID"));

                XmlNodeList contacts = document.SelectNodes("//Request/ConfirmationRequest/ConfirmationHeader/Contact");
                foreach (XmlNode node in contacts)
                {
                    Address address = new Address();
                    address.Role = setValue(node.Attributes["role"]);
                    address.AddressID = setValue(node.Attributes["addressID"]);
                    address.Name = setValue(node.SelectSingleNode("Name"));
                    address.Name2 = setValue(node.SelectSingleNode("PostalAddress/@name"));
                    address.DeliverTo = setValue(node.SelectSingleNode("PostalAddress/DeliverTo"));

                    if (node.SelectSingleNode("PostalAddress/DeliverTo") != null)
                        for (int i = 0; i < node.SelectNodes("PostalAddress/DeliverTo").Count; i++)
                            address.MultipleDeliverTos.Add(setValue(node.SelectNodes("PostalAddress/DeliverTo")[i]));

                    if (node.SelectSingleNode("PostalAddress/Street") != null)
                        for (int i = 0; i < node.SelectNodes("PostalAddress/Street").Count; i++)
                            address.Streets.Add(setValue(node.SelectNodes("PostalAddress/Street")[i]));

                    address.City = setValue(node.SelectSingleNode("PostalAddress/City"));
                    address.State = setValue(node.SelectSingleNode("PostalAddress/State"));
                    address.PostalCode = setValue(node.SelectSingleNode("PostalAddress/PostalCode"));
                    address.Country = setValue(node.SelectSingleNode("PostalAddress/Country"));

                    order.Contacts.Add(address);
                }

                foreach (XmlNode node in document.SelectNodes("//Request/ConfirmationRequest/ConfirmationHeader/Extrinsic"))
                    order.Extrinsics.Add($"<b>{setValue(node.Attributes["name"])}:</b> {node.InnerXml}<br/>");

                XmlNodeList itemNodes = document.SelectNodes("//Request/ConfirmationRequest/ConfirmationItem");
                foreach (XmlNode node in itemNodes)
                {
                    foreach (XmlNode ConfirmationStatusNode in node.SelectNodes("ConfirmationStatus"))
                    {
                        OrderConfirmationLine line = new OrderConfirmationLine();

                        line.LineNumber = setValue(node.Attributes["lineNumber"]);
                        line.Quantity = setValue(node.Attributes["quantity"]);
                        line.ItemType = setValue(node.Attributes["itemType"]);
                        line.UnitOfMeasure = setValue(node.SelectSingleNode("UnitOfMeasure"));

                        line.ShipmentDate = setValue(ConfirmationStatusNode.SelectSingleNode("@shipmentDate"));
                        if (line.ShipmentDate.Contains('T'))
                        {
                            line.ShipmentDate = line.ShipmentDate.Split('T')[0];
                        }

                        line.DeliveryDate = setValue(ConfirmationStatusNode.SelectSingleNode("@deliveryDate"));
                        if (line.DeliveryDate.Contains('T'))
                        {
                            line.DeliveryDate = line.DeliveryDate.Split('T')[0];
                        }

                        line.ConfirmedQuantity = setValue(ConfirmationStatusNode.SelectSingleNode("@quantity"));
                        line.ConfirmationType = setValue(ConfirmationStatusNode.SelectSingleNode("@type"));
                        if (line.ConfirmationType.Equals("accpet"))
                        {
                            line.ConfirmationType = "accept";
                        }

                        line.ConfirmedUnitOfMeasure = setValue(ConfirmationStatusNode.SelectSingleNode("UnitOfMeasure"));
                        line.SupplierPartID = setValue(ConfirmationStatusNode.SelectSingleNode("ItemIn/ItemID/SupplierPartID"));
                        line.UnitPrice = setValue(ConfirmationStatusNode.SelectSingleNode("ItemIn/ItemDetail/UnitPrice/Money"));
                        line.ConfirmedUnitPrice = setValue(ConfirmationStatusNode.SelectSingleNode("UnitPrice/Money"));
                        line.Description = setValue(ConfirmationStatusNode.SelectSingleNode("ItemIn/ItemDetail/Description"));

                        if (ConfirmationStatusNode.SelectSingleNode("ItemIn/ItemDetail/Extrinsic") != null)
                            foreach (XmlNode extr in ConfirmationStatusNode.SelectNodes("ItemIn/ItemDetail/Extrinsic"))
                                line.Extrinsics.Add($"<b>{setValue(extr.Attributes["name"])}:</b> {setValue(extr)}<br/>");

                        line.ShipTo.AddressID = setValue(ConfirmationStatusNode.SelectSingleNode("ItemIn/ShipTo/Address/@addressID"));
                        line.ShipTo.Name = setValue(ConfirmationStatusNode.SelectSingleNode("ItemIn/ShipTo/Address/Name"));

                        if (ConfirmationStatusNode.SelectSingleNode("ItemIn/ShipTo/Address/PostalAddress/DeliverTo") != null)
                            foreach (XmlNode delTo in ConfirmationStatusNode.SelectNodes("ItemIn/ShipTo/Address/PostalAddress/DeliverTo"))
                                line.ShipTo.MultipleDeliverTos.Add(setValue(delTo));

                        if (ConfirmationStatusNode.SelectSingleNode("ItemIn/ShipTo/Address/PostalAddress/Street") != null)
                            foreach (XmlNode street in ConfirmationStatusNode.SelectNodes("ItemIn/ShipTo/Address/PostalAddress/Street"))
                                line.ShipTo.Streets.Add(setValue(street));

                        line.ShipTo.City = setValue(ConfirmationStatusNode.SelectSingleNode("ItemIn/ShipTo/Address/PostalAddress/City"));
                        line.ShipTo.State = setValue(ConfirmationStatusNode.SelectSingleNode("ItemIn/ShipTo/Address/PostalAddress/State"));
                        line.ShipTo.PostalCode = setValue(ConfirmationStatusNode.SelectSingleNode("ItemIn/ShipTo/Address/PostalAddress/PostalCode"));
                        line.ShipTo.Country = setValue(ConfirmationStatusNode.SelectSingleNode("ItemIn/ShipTo/Address/PostalAddress/Country"));
                        line.ShipTo.CountryCode = setValue(ConfirmationStatusNode.SelectSingleNode("ItemIn/ShipTo/Address/PostalAddress/Country/@isoCountryCode"));

                        line.TaxAmount = setValue(ConfirmationStatusNode.SelectSingleNode("Tax/Money"));
                        line.ShippingDescription = setValue(ConfirmationStatusNode.SelectSingleNode("Shipping/Description"));
                        line.Comments = setValue(ConfirmationStatusNode.SelectSingleNode("Comments"));

                        if (node.SelectSingleNode("Contact") != null)
                        {
                            foreach (XmlNode contactnode in node.SelectNodes("Contact"))
                            {
                                Address address = new Address();
                                address.Role = setValue(contactnode.Attributes["role"]);
                                address.AddressID = setValue(contactnode.Attributes["addressID"]);
                                address.Name = setValue(contactnode.SelectSingleNode("Name"));

                                if (contactnode.SelectSingleNode("PostalAddress/DeliverTo") != null)
                                    for (int i = 0; i < contactnode.SelectNodes("PostalAddress/DeliverTo").Count; i++)
                                        address.MultipleDeliverTos.Add(setValue(contactnode.SelectNodes("PostalAddress/DeliverTo")[i]));

                                if (contactnode.SelectSingleNode("PostalAddress/Street") != null)
                                    for (int i = 0; i < contactnode.SelectNodes("PostalAddress/Street").Count; i++)
                                        address.Streets.Add(setValue(contactnode.SelectNodes("PostalAddress/Street")[i]));

                                address.City = setValue(contactnode.SelectSingleNode("PostalAddress/City"));
                                address.State = setValue(contactnode.SelectSingleNode("PostalAddress/State"));
                                address.PostalCode = setValue(contactnode.SelectSingleNode("PostalAddress/PostalCode"));
                                address.Country = setValue(contactnode.SelectSingleNode("PostalAddress/Country"));
                                line.Contacts.Add(address);
                            }
                        }

                        order.Lines.Add(line);
                    }
                }

                order.Total = setValue(document.SelectSingleNode("//Request/ConfirmationRequest/ConfirmationHeader/Total/Money"));

                return order;
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Inbound_Status_Doc_cXML_Process", "ExtractOrderConfirmation", order.OrderID, null);
                return null;
            }
        }
        public static InvoiceHeader ExtractInvoice(XmlDocument xml)
        {
            InvoiceHeader invoice = new InvoiceHeader();
            string invoiceid = "";
            try
            {
                decimal dtest = 0.0M;
                int itest = 0;
                Constants.F1 setValue = x => x == null ? "" : x.InnerXml.Replace("'", "''");
                Constants.F3 setDecimalValue = x => x != null && decimal.TryParse(x.InnerXml, out dtest) ? decimal.Parse(x.InnerXml) : 0.0M;
                Constants.F4 setIntValue = x => x != null && int.TryParse(x.InnerXml, out itest) ? int.Parse(x.InnerXml) : 0;

                string xmltext = xml.InnerXml;
                if (xmltext.Contains("cXML_Invoice")) xmltext = xmltext.Replace("cXML_Invoice", "cXML");
                if (xmltext.Contains("xmlns:ns0=\"http://www.w3.org/XML/1998/namespace\"")) xmltext = xmltext.Replace("xmlns:ns0=\"http://www.w3.org/XML/1998/namespace\"", "");
                xml.LoadXml(xmltext);

                invoiceid = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailRequestHeader/@invoiceID"));
                string orderid = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailOrder/InvoiceDetailOrderInfo/OrderReference/@orderID"));
                if (orderid.Length == 0) orderid = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailOrder/InvoiceDetailOrderInfo/OrderIDInfo/@orderID"));
                if (Database.CheckInvoice(invoiceid, orderid))
                    return null;

                invoice = new InvoiceHeader();

                //cXML Document Data
                invoice.Timestamp = setValue(xml.SelectSingleNode("cXML/@timestamp"));
                invoice.PayloadID = setValue(xml.SelectSingleNode("cXML/@payloadID"));

                //cXML Header
                invoice.Creds = GetCredentials(xml);

                //cXML InvoiceDetailRequestHeader
                invoice.InvoiceID = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailRequestHeader/@invoiceID"));
                invoice.Purpose = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailRequestHeader/@purpose"));
                invoice.Operation = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailRequestHeader/@operation"));
                invoice.InvoiceDate = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailRequestHeader/@invoiceDate"));

                if (invoice.Creds.UserAgent == "" && (invoice.InvoiceID.IndexOf("IN-") > -1 || invoice.InvoiceID.IndexOf("CM-") > -1)) invoice.Creds.UserAgent = "OfficeCity";
                if (invoice.Creds.UserAgent == "" && invoice.InvoiceID.IndexOf("VANE") > -1) invoice.Creds.UserAgent = "Fastenal";

                XmlNodeList invoicePartners = xml.SelectNodes("cXML/Request/InvoiceDetailRequest/InvoiceDetailRequestHeader/InvoicePartner");
                foreach (XmlNode invoicePartner in invoicePartners)
                {
                    Address address = new Address();

                    address.Role = setValue(invoicePartner.SelectSingleNode("Contact/@role"));
                    address.AddressID = setValue(invoicePartner.SelectSingleNode("Contact/@addressID"));
                    address.Name = setValue(invoicePartner.SelectSingleNode("Contact/Name"));
                    if (address.Name.Length == 0) address.Name = setValue(invoicePartner.SelectSingleNode("Contact/PostalAddress/@name"));
                    address.DeliverTo = setValue(invoicePartner.SelectSingleNode("Contact/PostalAddress/DeliverTo"));

                    string street = "";
                    foreach (XmlNode node in invoicePartner.SelectNodes("Contact/PostalAddress/Street"))
                        if (setValue(node).Length > 0)
                            street = street.Length > 0 ? street + "|" + setValue(node) : setValue(node);
                    address.Streets.Add(street);

                    address.City = setValue(invoicePartner.SelectSingleNode("Contact/PostalAddress/City"));
                    address.State = setValue(invoicePartner.SelectSingleNode("Contact/PostalAddress/State"));
                    address.PostalCode = setValue(invoicePartner.SelectSingleNode("Contact/PostalAddress/PostalCode"));
                    address.CountryCode = setValue(invoicePartner.SelectSingleNode("Contact/PostalAddress/Country/@isoCountryCode"));
                    address.Country = setValue(invoicePartner.SelectSingleNode("Contact/PostalAddress/Country"));

                    invoice.Roles.Add(address);
                }

                XmlNodeList invoiceDetailShippings = xml.SelectNodes("cXML/Request/InvoiceDetailRequest/InvoiceDetailRequestHeader/InvoiceDetailShipping/Contact");
                foreach (XmlNode invoiceDetailShipping in invoiceDetailShippings)
                {
                    Address address = new Address();
                    address.Role = setValue(invoiceDetailShipping.SelectSingleNode("@role"));
                    address.AddressID = setValue(invoiceDetailShipping.SelectSingleNode("@addressID"));
                    address.Name = setValue(invoiceDetailShipping.SelectSingleNode("Name"));
                    if (address.Name.Length == 0) address.Name = setValue(invoiceDetailShipping.SelectSingleNode("PostalAddress/@name"));
                    address.DeliverTo = setValue(invoiceDetailShipping.SelectSingleNode("PostalAddress/DeliverTo"));

                    string street = "";
                    foreach (XmlNode node in invoiceDetailShipping.SelectNodes("PostalAddress/Street"))
                        if (setValue(node).Length > 0)
                            street = street.Length > 0 ? street + "|" + setValue(node) : setValue(node);
                    address.Streets.Add(street);

                    address.City = setValue(invoiceDetailShipping.SelectSingleNode("PostalAddress/City"));
                    address.State = setValue(invoiceDetailShipping.SelectSingleNode("PostalAddress/State"));
                    address.PostalCode = setValue(invoiceDetailShipping.SelectSingleNode("PostalAddress/PostalCode"));
                    address.CountryCode = setValue(invoiceDetailShipping.SelectSingleNode("PostalAddress/Country/@isoCountryCode"));
                    address.Country = setValue(invoiceDetailShipping.SelectSingleNode("PostalAddress/Country"));

                    invoice.Roles.Add(address);
                }

                invoice.PaymentTermNumberOfDays = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailRequestHeader/InvoiceDetailPaymentTerm/@payInNumberOfDays"));
                invoice.PaymentTermPercentRate = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailRequestHeader/InvoiceDetailPaymentTerm/@percentageRate"));

                XmlNodeList extrinsics = xml.SelectNodes("cXML/Request/InvoiceDetailRequest/InvoiceDetailRequestHeader/Extrinsic");
                foreach (XmlNode extrinsic in extrinsics)
                    invoice.Extrinsics.Add(new Extrinsic(setValue(extrinsic.SelectSingleNode("@name")), setValue(extrinsic)));

                //cXML InvoiceDetailOrder
                invoice.OrderID = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailOrder/InvoiceDetailOrderInfo/OrderReference/@orderID"));
                if (invoice.OrderID.Length == 0) invoice.OrderID = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailOrder/InvoiceDetailOrderInfo/OrderIDInfo/@orderID"));

                invoice.OrderDate = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailOrder/InvoiceDetailOrderInfo/OrderReference/@orderDate"));
                invoice.DocumentReferencePayloadID = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailOrder/InvoiceDetailOrderInfo/OrderReference/DocumentReference/@payloadID"));

                if (invoice.Roles.Find(r => r.Role == "shipTo") == null)
                {
                    Address address = Database.GetShippingInformation(invoice.OrderID, invoice.InvoiceID);
                    if (address != null)
                        invoice.Roles.Add(address);
                }

                invoice.InvoiceTotal = 0.0M;
                decimal shippingTotal = 0.0M;
                XmlNodeList invoiceDetailItems = xml.SelectNodes("cXML/Request/InvoiceDetailRequest/InvoiceDetailOrder/InvoiceDetailItem");
                foreach (XmlNode invoiceDetailItem in invoiceDetailItems)
                {
                    InvoiceLine line = new InvoiceLine();
                    line.LineNumber = setIntValue(invoiceDetailItem.SelectSingleNode("@invoiceLineNumber"));
                    line.Quantity = setDecimalValue(invoiceDetailItem.SelectSingleNode("@quantity"));
                    line.UnitOfMeasure = setValue(invoiceDetailItem.SelectSingleNode("UnitOfMeasure"));
                    line.UnitPrice = setDecimalValue(invoiceDetailItem.SelectSingleNode("UnitPrice/Money"));
                    line.ReferenceLineNumber = setIntValue(invoiceDetailItem.SelectSingleNode("InvoiceDetailItemReference/@lineNumber"));
                    line.SupplierPartID = setValue(invoiceDetailItem.SelectSingleNode("InvoiceDetailItemReference/ItemID/SupplierPartID"));
                    line.Description = setValue(invoiceDetailItem.SelectSingleNode("InvoiceDetailItemReference/Description"));
                    line.Tax = setDecimalValue(invoiceDetailItem.SelectSingleNode("Tax/Money"));
                    line.LineTotal = line.Quantity * line.UnitPrice;
                    if (line.UnitPrice == 0.0M) line.LineTotal = line.UnitPrice = setDecimalValue(invoiceDetailItem.SelectSingleNode("SubtotalAmount/Money"));
                    invoice.Lines.Add(line);

                    if (!line.SupplierPartID.ToUpper().Contains("SHIP"))
                        invoice.InvoiceTotal += line.LineTotal;
                    else
                        shippingTotal += line.LineTotal;

                    if (invoiceDetailItem.SelectSingleNode("InvoiceDetailLineShipping") != null)
                    {
                        XmlNodeList shipping = invoiceDetailItem.SelectNodes("InvoiceDetailLineShipping/InvoiceDetailShipping/Contact");
                        foreach (XmlNode ship in shipping)
                        {
                            string role = setValue(ship.SelectSingleNode("@role"));
                            string addressID = setValue(ship.SelectSingleNode("@addressID"));
                            if (invoice.Roles.Find(r => r.Role == role && r.AddressID == addressID) == null)
                            {
                                Address address = new Address();
                                address.Role = role;
                                address.AddressID = addressID;
                                address.Name = setValue(ship.SelectSingleNode("Name"));
                                address.DeliverTo = setValue(ship.SelectSingleNode("PostalAddress/DeliverTo"));
                                address.Streets.Add(setValue(ship.SelectSingleNode("PostalAddress/Street")));
                                address.City = setValue(ship.SelectSingleNode("PostalAddress/City"));
                                address.State = setValue(ship.SelectSingleNode("PostalAddress/State"));
                                address.PostalCode = setValue(ship.SelectSingleNode("PostalAddress/PostalCode"));
                                address.CountryCode = setValue(ship.SelectSingleNode("PostalAddress/Country/@isoCountryCode"));
                                address.Country = setValue(ship.SelectSingleNode("PostalAddress/Country"));

                                invoice.Roles.Add(address);
                            }
                        }
                    }
                }

                invoice.SubTotalAmount = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/SubtotalAmount/Money"));
                if (invoice.SubTotalAmount == 0.0M) invoice.SubTotalAmount = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/SubtotalAmount"));
                if (invoice.InvoiceTotal > invoice.SubTotalAmount) invoice.SubTotalAmount = invoice.InvoiceTotal;

                string taxDescription = setValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/Tax/Description"));
                if (taxDescription.StartsWith("EDI"))
                {
                    invoice.SpecialHandlingAmount = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/Tax/Money"));
                    if (invoice.SpecialHandlingAmount == 0.0M) setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/Tax"));
                }
                else
                {
                    invoice.Tax = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/Tax/Money"));
                    if (invoice.Tax == 0.0M) setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/Tax"));
                }

                if (xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/ShippingAmount") != null)
                {
                    decimal shippingtotal = 0.0M;
                    XmlNodeList shippingNodes = xml.SelectNodes("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/ShippingAmount");
                    for (int i = 0; i < shippingNodes.Count; i++)
                    {
                        int index = i + 1;
                        decimal shipping = setDecimalValue(shippingNodes[i].SelectSingleNode("Money"));
                        if (shipping > 0.0m)
                        {
                            Extrinsic extr = invoice.Extrinsics.Find(e => e.Name == $"shippingAmount{index}");
                            if (extr != null)
                            {
                                InvoiceLine line = new InvoiceLine();
                                line.LineNumber = 0;
                                line.Quantity = 1;
                                line.UnitOfMeasure = "EA";
                                line.UnitPrice = shipping;
                                line.ReferenceLineNumber = 0;
                                line.SupplierPartID = extr.Value;
                                line.Description = extr.Value;
                                line.Tax = 0;
                                line.LineTotal = line.Quantity * line.UnitPrice;
                                line.ShipLine = 1;
                                invoice.Lines.Add(line);
                            }
                            else
                                shippingtotal += shipping;
                        }
                        if (shipping == 0.0M)
                            shippingtotal += setDecimalValue(shippingNodes[i]);
                    }

                    invoice.ShippingAmount = shippingtotal;
                }

                invoice.NetAmount = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/NetAmount/Money"));
                if (invoice.NetAmount == 0.0M) invoice.NetAmount = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/NetAmount"));

                invoice.GrossAmount = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/GrossAmount/Money"));
                if (invoice.GrossAmount == 0.0M) invoice.GrossAmount = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/GrossAmount"));

                invoice.SpecialHandlingAmount = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/SpecialHandlingAmount/Money"));
                if (invoice.SpecialHandlingAmount == 0.0M) invoice.SpecialHandlingAmount = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/SpecialHandlingAmount"));

                invoice.DueAmount = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/DueAmount/Money"));
                if (invoice.DueAmount == 0.0M) invoice.DueAmount = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/DueAmount"));

                if (shippingTotal == invoice.SpecialHandlingAmount) invoice.InvoiceTotal += invoice.Tax + invoice.ShippingAmount + shippingTotal;
                else invoice.InvoiceTotal += invoice.Tax + invoice.ShippingAmount + invoice.SpecialHandlingAmount + shippingTotal;

                invoice.InvoiceDetailDiscount = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/InvoiceDetailDiscount/Money"));
                if (invoice.InvoiceDetailDiscount == 0.0M) invoice.InvoiceDetailDiscount = setDecimalValue(xml.SelectSingleNode("cXML/Request/InvoiceDetailRequest/InvoiceDetailSummary/InvoiceDetailDiscount"));

                Address remitTo = invoice.Roles.Find(a => a.Role == "remitTo");
                Database.GetVendor(ref invoice, remitTo);

                invoice.ReceiveDate = DateTime.Now;
                string[] poarray = invoice.OrderID.Split('/');
                string po = "";
                if (poarray.Length > 1)
                    po = poarray[1];
                else
                    po = poarray[0];
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "Inbound_Status_Doc_cXML_Process", "ExtractInvoice", invoiceid, null);
                return null;
            }

            return invoice;
        }
        #endregion

        public static string GetCxmlPoResponse(XmlDocument xml, bool dup)
        {
            string message = dup ? "OK - Rejected - PO Duplication Detected" : "OK";
            try
            {
                bool toDomainSap = false;

                XmlNodeList tocreds = xml.SelectNodes("//Header/To/Credential");
                foreach (XmlNode tocred in tocreds)
                    if (tocred.SelectSingleNode("@domain").InnerText == "sap")
                        toDomainSap = true;

                if (xml.SelectSingleNode("//Header/Sender/Credential/Identity").InnerXml == "sysadmin@ariba.com" && toDomainSap)
                    return $"<!DOCTYPE cXML SYSTEM \"http://xml.cxml.org/schemas/cXML/1.2.047/cXML.dtd\"><cXML payloadID=\"{xml.SelectSingleNode("//OrderRequestHeader/@orderID").InnerXml}\" xml:lang=\"en\" timestamp=\"{DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss")}+00:00\" ><Response><Status code=\"200\" text=\"OK\"/></Response></cXML>";
                else
                    return $"<cXML version=\"1.2.008\" timestamp=\"{DateTime.Now.ToString("yyyy-MM-dd:hh:mm:sszz")}\" payloadID=\"{DateTime.Now.ToString("yyyyMMddhhmmssffff")}@b2b.govsci.com\"><Response><Status code=\"200\" text=\"Accepted\">{message}</Status></Response></cXML>";
            }
            catch
            {
                return $"<cXML version=\"1.2.008\" timestamp=\"{DateTime.Now.ToString("yyyy-MM-dd:hh:mm:sszz")}\" payloadID=\"{DateTime.Now.ToString("yyyyMMddhhmmssffff")}@b2b.govsci.com\"><Response><Status code=\"200\" text=\"Accepted\">{message}</Status></Response></cXML>";
            }
        }        

        public static string HasKey(XmlDocument xml)
        {
            string key;
            if (xml.SelectSingleNode("//Request/ShipNoticeRequest/ShipNoticeHeader/@shipmentID") != null)
                key = xml.SelectSingleNode("//Request/ShipNoticeRequest/ShipNoticeHeader/@shipmentID").InnerXml;
            else if (xml.SelectSingleNode("//Request/InvoiceDetailRequest/InvoiceDetailRequestHeader/@invoiceID") != null)
                key = xml.SelectSingleNode("//Request/InvoiceDetailRequest/InvoiceDetailRequestHeader/@invoiceID").InnerXml;
            else if (xml.SelectSingleNode("cXML/Request/ConfirmationRequest/ConfirmationHeader/@confirmID") != null)
                key = xml.SelectSingleNode("cXML/Request/ConfirmationRequest/ConfirmationHeader/@confirmID").InnerXml;
            else
            {
                Random randomNum = new Random();
                int n = randomNum.Next(1000000000);
                key = n.ToString();
            }
            return key;
        }

        public static XmlDocument InboundUOMConversion(XmlDocument o)
        {
            Constants.F1 setValue = x => x == null ? "" : x.InnerXml;
            XmlNodeList lines = o.SelectNodes("//ItemOut");

            foreach (XmlNode i in lines)
            {
                string uom = Database.GetUnitOfMeasure(setValue(i.SelectSingleNode("ItemDetail/UnitOfMeasure")));
                if (uom.Length > 0)
                {
                    XmlAttribute extra = o.CreateAttribute("OriginalUOM");
                    extra.Value = setValue(i.SelectSingleNode("ItemDetail/UnitOfMeasure"));

                    // Create Extrinsic field in the line level and store the original UOM and pass to the return object
                    i.SelectSingleNode("ItemDetail/UnitOfMeasure").InnerXml = uom;
                    i.SelectSingleNode("ItemDetail/UnitOfMeasure").Attributes.Append(extra);
                }
            }
            return o;
        }

        public static void OpenReferenceURL(string URL)
        {
            using (WebClient client = new WebClient())
            {
                byte[] arr = client.DownloadData(URL.Replace("&amp;", "&"));
            }
        }

        public static string ConvertNameToNavisionName(string n)
        {
            string[] nameBlock = n.Split(',');
            n = nameBlock.Count() >= 2 ? nameBlock[1].Trim().ToUpper() + " " + nameBlock[0].Trim().ToUpper() : nameBlock[0].Trim().ToUpper();
            return n;
        }

        public static string checkUNSPSC(string i)
        {
            switch (i)
            {
                case "TEST": i = ""; break;
            }

            i = CheckLength(i, Constants.MAX_UNSPSC_CODE_LENGTH);

            return i;
        }

        public static string filterBillTo(string o, string n)
        {
            if (o == "Bill to Address" && n != "")
                return n;
            else
                return o;
        }

        public static CxmlCustomerName GetContactNames(string contactName)
        {
            CxmlCustomerName customer = null;

            if (contactName.Contains(","))
            {
                Match m = Regex.Match(contactName, @"(?<lastName>[A-Za-z'-]+?)(\s(?<suffix>[A-Za-z]*?\.?))?,\s?(?<firstName>[A-Za-z'-]+?)(\s(?<middleName>[A-Za-z' ]*?\.?))?(,\s(?<suffix>[A-Za-z]*?\.?))?$");
                if (m.Success)
                    customer = new CxmlCustomerName("", m.Groups["firstName"].Value, m.Groups["lastName"].Value, m.Groups["middleName"].Value, m.Groups["suffix"].Value);
            }
            else
            {
                Match m = Regex.Match(contactName, @"^((?<prefix>[A-Za-z]{1,3}\.?)\s)?(?<firstName>[A-Za-z'-]+?)\s((?<middleName>[A-Za-z']*?\.?)\s)?(?<lastName>[ A-Za-z'-]+?)(\s(?<suffix>[A-Za-z]{1,3}\.?))?$");
                if (m.Success)
                    customer = new CxmlCustomerName(m.Groups["prefix"].Value, m.Groups["firstName"].Value, m.Groups["lastName"].Value, m.Groups["middleName"].Value, m.Groups["suffix"].Value);
            }

            if (customer == null)
            {
                customer = new CxmlCustomerName("", contactName, contactName, "", "");
            }

            return customer;
        }

        public static CxmlCustomerPhone GetPhoneNumber(string areacode, string phoneNumber)
        {
            string tempphoneNumber = phoneNumber.Replace("(", "")
                .Replace(")", "")
                .Replace(":", "")
                .Replace("DSN", "")
                .Replace("/", "")
                .Replace("-", "")
                .Replace(" ", "");

            CxmlCustomerPhone phone = new CxmlCustomerPhone();

            if (areacode.Length > 0)
            {
                phone.AreaCode = int.Parse(areacode);
                Match m = Regex.Match(tempphoneNumber, @"(?<phone>\d{3})(?<number>\d{4})");
                if (m.Success)
                {
                    try
                    {
                        phone.Prefix = int.Parse(m.Groups["phone"].Value);
                        phone.Number = int.Parse(m.Groups["number"].Value);
                    }
                    catch { }
                }
            }
            else
            {
                Match m = Regex.Match(tempphoneNumber, @"(?<area>\d{3})(?<phone>\d{3})(?<number>\d{4})");
                if (m.Success)
                {
                    try
                    {
                        phone.AreaCode = int.Parse(m.Groups["area"].Value);
                        phone.Prefix = int.Parse(m.Groups["phone"].Value);
                        phone.Number = int.Parse(m.Groups["number"].Value);
                    }
                    catch { }
                }

            }

            if (phone.AreaCode == 0 && phone.Prefix == 0 && phone.Number == 0)
                phone.InternationalPhoneNumber = phoneNumber;

            return phone;
        }

        public static string CheckOrderID(string i)
        {
            i = i.Replace("PO-16-1080-OSD03-SRC3-", "");
            if (i.Length > 20)
                i = i.Right(20);
            return i;
        }

        public static string Right(this string value, int length)
        {
            return value.Substring(value.Length - length);
        }

        public static string GetConfirmationStatusCode(XmlDocument xml)
        {
            try { return xml.SelectNodes("//cXML/Response/Status/@code").Item(0).InnerXml; }
            catch { return "906"; }
        }

        public static string GetOrderRequestType(XmlDocument xml)
        {
            try
            {
                return xml.SelectSingleNode("//OrderRequestHeader/@type").InnerXml;
            }
            catch
            {
                return "new";
            }
        }

        public static string GetX12DocId(XmlDocument cXML)
        {
            string id = "";
            try { id = cXML.SelectSingleNode("//BIG02").InnerText; }
            catch { }

            if (id.Length == 0)
            {
                try { id = cXML.SelectSingleNode("//BSN02").InnerText; }
                catch { }
            }

            if (id.Length == 0)
            {
                try
                {
                    string st = cXML.SelectSingleNode("//ST02").InnerText;
                    string bak = cXML.SelectSingleNode("//BAK03").InnerText;
                    int dd = Database.GetSqlTableID(st, bak);
                    if (dd > 0)
                        id = dd.ToString();
                    else
                        throw new Exception("ID is 0!");
                }
                catch
                {
                    System.Threading.Thread.Sleep(1234);
                    id = GetTimeStamp(DateTime.Now);
                }
            }

            return id;
        }

        public static string GetEdiDocumentType(XmlDocument xml)
        {
            return xml.SelectSingleNode("//ST01").InnerXml;
        }

        public static void Create997(string identifier, XmlDocument cXML)
        {
            string type = cXML.SelectSingleNode("//AK201").InnerXml; // root.Attributes["ST01"].Value;
            string st = cXML.SelectSingleNode("//ST02").InnerXml;
            string po = cXML.SelectSingleNode("//AK202").InnerXml;
            string cxmlString = cXML.InnerXml;

            cxmlString = Database.GetSegments(type, st, po, cxmlString);

            CreateDump(Constants.DUMP_FOLDERS.PORT_SEND_CXML_PO_ERP_X12_PICKUP, "", identifier, cxmlString, false);
            CreateDump(Constants.DUMP_FOLDERS.OUT_STATUS_OUTGOING_ACKNOWLEDGEMENT, "", identifier, cxmlString, true);
        }

        public static void CreateStatusDocFromEdi(XmlDocument cXML, string type)
        {
            string cxmlString = cXML.InnerXml;

            //xmlns:ns0="http://www.w3.org/XML/1998/namespace"
            cxmlString = cxmlString.Replace("xmlns:ns0=\"http://www.w3.org/XML/1998/namespace\"", "xml:lang=\"en-US\"");
            cxmlString = cxmlString.Replace("cXML_Fulfill", "cXML");
            cxmlString = cxmlString.Replace("cXML_Invoice", "cXML");
            string removeTag = "";
            if (type == "855")
            {
                removeTag = "<ShipNoticeRequest(.*?)ShipNoticeRequest>";
            }
            else if (type == "856")
            {
                cxmlString = Regex.Replace(cxmlString, "<ShipNoticeItem quantity=\"\"><UnitOfMeasure></UnitOfMeasure></ShipNoticeItem>", "");
                removeTag = "<ConfirmationRequest(.*?)ConfirmationRequest>";
            }
            else if (type == "810")
            {
                string isa = Database.GetISA(cxmlString);

                cxmlString = Regex.Replace(cxmlString, "<Identity>(.*?)</Identity>", "<Identity>" + isa + "</Identity>");
                cxmlString = Regex.Replace(cxmlString, "<UserAgent>(.*?)/UserAgent>", "<UserAgent>" + isa + "</UserAgent>");

                

                Regex coder = new Regex("<ShippingAmount><Money currency=\"(?<code>.*?)\">(?<value>.*?)</Money>");
                MatchCollection codem = coder.Matches(cxmlString);
                string ex = "";
                int shipcount = 1;

                foreach (Match m in codem)
                {
                    string tmp = m.Value.ToString();
                    string val = m.Groups["value"].Value.ToString().Replace(".", "").Replace(",", "");
                    try
                    {
                        double a = Double.Parse(val);
                        a = a / 100.0;
                        val = Convert.ToDecimal(a).ToString("0.00");
                    }
                    catch
                    {
                        val = m.Groups["value"].Value.ToString().Replace(".", "").Replace(",", "");
                    }

                    cxmlString = Regex.Replace(cxmlString, "<ShippingAmount><Money currency=\"" + m.Groups["code"].Value.ToString() + "\">" + m.Groups["value"].Value.ToString() + "</Money>", "<ShippingAmount><Money currency=\"" + m.Groups["code"].Value.ToString() + "\">" + val + "</Money>");
                    ex += "<Extrinsic name=\"shippingAmount" + shipcount.ToString() + "\">" + GetChargeCode(m.Groups["code"].Value.ToString()) + "</Extrinsic>";
                    shipcount++;
                }
                cxmlString = Regex.Replace(cxmlString, "<ShippingAmount><Money currency=\"(?<code>.*?)\">", "<ShippingAmount><Money currency=\"USD\">");
                cxmlString = Regex.Replace(cxmlString, "</InvoicePartner></InvoiceDetailRequestHeader>", "</InvoicePartner>" + ex + "</InvoiceDetailRequestHeader>");
            }
            cxmlString = Regex.Replace(cxmlString, removeTag, "");
            XmlDocument cXML2 = new XmlDocument();
            cXML2.LoadXml(cxmlString);

            string identity = GetTimeStamp(DateTime.Now);

            CreateDump(Constants.DUMP_FOLDERS.IN_STATUS_ARRIVED, type, identity, cXML2.InnerXml, true);
            CreateDump(Constants.DUMP_FOLDERS.PORT_RECEIVE_CXML_STATUS_ARRIVE, type, identity, cXML2.InnerXml, false);
        }

        public static string GetChargeCode(string code)
        {
            switch (code)
            {
                case "A010": return "Absolute Minimum Charge";
                case "A020": return "Access Charge – Federal";
                case "A030": return "Access Charge – State";
                case "A040": return "Access Charges";
                case "A050": return "Account Number Correction Charge";
                case "A060": return "Acid (Battery)";
                case "A070": return "Acknowledgment of Delivery Fee (AOD)";
                case "A080": return "Activation of Carnet";
                case "A090": return "Ad Valorem";
                case "A100": return "Add on – Destination";
                case "A110": return "Add on – Origin";
                case "A112": return "Add to Make Market Value";
                case "A120": return "Additional Copies of Freight Bill";
                case "A121": return "Additional Commercial Invoices";
                case "A122": return "Additional Tariff Classifications";
                case "A130": return "Additional Material";
                case "A140": return "Address Correction";
                case "A150": return "Adjustment for Maximum Charges Billing";
                case "A160": return "Adjustment for Minimum Average Time Requirement Billing";
                case "A170": return "Adjustments";
                case "A172": return "Administrative";
                case "A180": return "Advance Charges Handling";
                case "A190": return "Advance Destination Amount";
                case "A200": return "Advance Destination Fee";
                case "A210": return "Advance Fee";
                case "A220": return "Advance Lading Charge";
                case "A230": return "Advance Origin Amount";
                case "A240": return "Advance Origin Fee";
                case "A250": return "Advances";
                case "A260": return "Advertising Allowance";
                case "A270": return "Affidavit";
                case "A280": return "Agent Disbursement – Destination";
                case "A290": return "Agent Disbursement – Origin";
                case "A300": return "Air Export Certificate";
                case "A310": return "Air Express Charge";
                case "A320": return "Air Transportation Charge";
                case "A330": return "Aircraft On Ground (AOG)";
                case "A340": return "Airline Opening Fee";
                case "A350": return "Airport Terminal Handling Charge";
                case "A360": return "Alcoholic Beverage Report Charge";
                case "A370": return "Allegheny County, PA Delivery Charge";
                case "A380": return "Allowance Advance";
                case "A390": return "Allowance for Consignment Merchandise";
                case "A400": return "Allowance Non-performance";
                case "A410": return "“Alterations”";
                case "A420": return "Amending Export Documentation";
                case "A430": return "Anneal/Heat (Steel or Glass Treatment)";
                case "A440": return "Anodizing Charge";
                case "A445": return "Anti-dumping Duty";
                case "A450": return "Appointment (Notification)";
                case "A460": return "Arbitrary (In Addition to Through Rates and Charges)";
                case "A470": return "Art Work";
                case "A480": return "Assembly";
                case "A485": return "Assist Amount";
                case "A490": return "Attachments to Bill of Lading Charge";
                case "A500": return "Bad Debt";
                case "A510": return "Banking Drafts";
                case "A520": return "Base Charge";
                case "A530": return "Basic Reorder Allowance";
                case "A540": return "Beaming Charge";
                case "A550": return "Bedding/Feeding/Disinfecting";
                case "A555": return "Beef Fee";
                case "A560": return "Beyond Charge";
                case "A570": return "Beyond Freight Charges";
                case "A580": return "Bill and Hold";
                case "A590": return "Bill of Lading Attendancy";
                case "A600": return "Bill of Lading Charge";
                case "A610": return "Billed Demand";
                case "A620": return "Black Lung Tax";
                case "A630": return "Blocking and Bracing Charge";
                case "A640": return "Blower Charge";
                case "A650": return "Bobtail Charges";
                case "A658": return "Bond Amount";
                case "A660": return "Bond Charge";
                case "A670": return "Bordeaux Arbitraries";
                case "A680": return "Both-Flat";
                case "A690": return "Break Bulk Surface Charge";
                case "A691": return "Breakbulk Services";
                case "A700": return "Bridge Toll";
                case "A710": return "Broken Lot";
                case "A720": return "Broken Package Charge";
                case "A721": return "Brokerage";
                case "A730": return "Brokerage or Duty";
                case "A740": return "Bunker Surcharge";
                case "A750": return "Burning";
                case "A760": return "Buyer Hand Carry";
                case "A770": return "Buyers Car Allowance";
                case "A780": return "Cable Pressurization";
                case "A790": return "Cables (sending of)";
                case "A800": return "Call Tag";
                case "A810": return "Camp Arbitrary";
                case "A820": return "Canada Great Lakes Additionals";
                case "A830": return "Canadian C.Q.Customs Clearance";
                case "A840": return "Canadian Currency Exchange";
                case "A850": return "Canadian Import Termination Fee";
                case "A860": return "Canadian Reconsignment Fee";
                case "A870": return "Canadian Remanifest Fee";
                case "A880": return "Cancellation Charge";
                case "A890": return "Cancelled Order, Heavy Duty Flatcar";
                case "A900": return "Capping";
                case "A910": return "Car Loading";
                case "A920": return "Car Rental";
                case "A930": return "Carrier Credit Allowance";
                case "A940": return "Carrier Debit Allowance";
                case "A950": return "Carrier Notification Charge";
                case "A960": return "Carrier";
                case "A970": return "Cartage Charge";
                case "A980": return "Cartage";
                case "A990": return "Cataloging Services";
                case "ADOW": return "Payroll Additives, Overtime Labor";
                case "ADRW": return "Payroll Additives, Straight Time Labor";
                case "AFEE": return "Fee";
                case "ALPT": return "Port Changes";
                case "B000": return "Central Buy";
                case "B010": return "Cents Off";
                case "B015": return "Bop Sheet";
                case "B020": return "Certificate of Conformance";
                case "B030": return "Certificate of Origin";
                case "B040": return "Certificate of Registration";
                case "B050": return "Certification";
                case "B060": return "Chain and Binders";
                case "B070": return "Chamber of Commerce Service Charge";
                case "B080": return "Change of Airbill – Service Fee";
                case "B090": return "Charges Forward/Advance Charge";
                case "B091": return "Charter Services";
                case "B100": return "Chassis Transfer";
                case "B110": return "Chemical Milling Charge";
                case "B120": return "Chicago Loop Charge";
                case "B130": return "Cigarette Stamping";
                case "B140": return "City Delivery";
                case "B150": return "City maintenance fee";
                case "B160": return "City Pickup";
                case "B170": return "City Terminal Charge";
                case "B180": return "Cleaning Charge";
                case "B190": return "Closing & Sealing";
                case "B200": return "Co-manufacturing Discount";
                case "B210": return "Co-op Credit";
                case "B220": return "Coating (Dip, Rustproof, EDP)";
                case "B230": return "COD Amount";
                case "B240": return "COD Charges";
                case "B250": return "Collect on Delivery Alteration Charge";
                case "B260": return "Collect on Delivery Deletion Charge";
                case "B270": return "Collect Surcharge";
                case "B280": return "Combination Performance and Non-performance";
                case "B290": return "Combination";
                case "B300": return "Combine All Same Day Shipment";
                case "B310": return "Commission Amount";
                case "B320": return "Competitive Allowance";
                case "B330": return "Competitive Car Allowance";
                case "B340": return "Competitive Price";
                case "B350": return "Compressor Charge";
                case "B360": return "Concession Credit";
                case "B370": return "Concession Money";
                case "B380": return "Congestion Surcharge";
                case "B390": return "Connect Charge";
                case "B400": return "Conservation research fee";
                case "B500": return "Consignee Unload";
                case "B510": return "Consolidation";
                case "B520": return "Constant Surveillance Service – Armed";
                case "B530": return "Constant Surveillance Service";
                case "B540": return "Consular Legalization Service";
                case "B550": return "Consularization Fee";
                case "B551": return "Consulting Service";
                case "B555": return "Consumer Service Provider Charge";
                case "B560": return "Container Allowance";
                case "B570": return "Container Deposits";
                case "B580": return "Container Destuffing";
                case "B581": return "Container Discount";
                case "B590": return "Container Leasing";
                case "B600": return "Container Service Charge UK/EUR";
                case "B610": return "Container Service Charge USA/Canada";
                case "B620": return "Container Stuffing";
                case "B630": return "Container/Trailer Allowance";
                case "B650": return "Continuous Mileage";
                case "B660": return "Contract Allowance";
                case "B670": return "Contract Escalation";
                case "B680": return "Contract Service Charge";
                case "B690": return "Controlled Atmosphere";
                case "B700": return "Converting";
                case "B720": return "Cooperative Advertising/Merchandising Allowance (Performance)";
                case "B730": return "Copy of Bill of Lading Charge";
                case "B740": return "Copy of Delivery Receipt Charge";
                case "B742": return "Copying";
                case "B750": return "Core Charge";
                case "B760": return "Cost Recovery Factor";
                case "B770": return "Cost recovery/adjustment";
                case "B775": return "Cotton Fee";
                case "B780": return "Count and Recount";
                case "B785": return "Coupon Reimbursement";
                case "B787": return "Countervailing Duty";
                case "B790": return "Crafting";
                case "B791": return "Crating";
                case "B800": return "Credit";
                case "B801": return "Credit Card Processing Fee";
                case "B802": return "Credit Card Processing Fee – Automated Dial-up Line";
                case "B803": return "Credit Card Processing Fee – Leased Line";
                case "B804": return "Credit Card Processing Fee – Fleet Cards";
                case "B810": return "Currency Adjustment Factor";
                case "B820": return "Currency Adjustment";
                case "B830": return "Currency Discount";
                case "B840": return "Customer Account Identification";
                case "B850": return "Customer Equipment Allowance";
                case "B860": return "Customs Broker Fee";
                case "B870": return "Customs Charge";
                case "B872": return "Customs Duty";
                case "B880": return "Customs Entry";
                case "B881": return "Customs Exam";
                case "B890": return "Customs Formalities";
                case "B900": return "Customs Invoice – Additional Page";
                case "B910": return "Customs Invoice";
                case "B911": return "Customs Penalty";
                case "B920": return "Cut and Parallel";
                case "B930": return "Cut";
                case "B940": return "Cutting Charge";
                case "B950": return "Damaged Merchandise";
                case "B960": return "Data/Drawing Charge";
                case "B970": return "De-Installation";
                case "B980": return "Deadhead Mileage Charge";
                case "B990": return "Deaf and Disabled Surcharge";
                case "B992": return "Declared Value for Carriage";
                case "B994": return "Declared Value for Customs";
                case "B996": return "Declared Value for Insurance";
                case "B998": return "Deduct to Make Market Value";
                case "BU2T": return "Bunker Adjustment – 20 Foot Container";
                case "BU4T": return "Bunker Adjustment – 40 Foot Container";
                case "BUAT": return "Bunker Adjustment";
                case "BURD": return "Burden, Overhead, or Allowance for Indirect Costs";
                case "C000": return "Defective Allowance";
                case "C010": return "Deficit Freight";
                case "C020": return "Delay Furnishing Destination Weights";
                case "C030": return "Delivery Surcharge";
                case "C040": return "Delivery";
                case "C050": return "Demand charge";
                case "C060": return "Demurrage – Average Agreement";
                case "C070": return "Demurrage – Special";
                case "C080": return "Demurrage";
                case "C090": return "Deposit Charges";
                case "C100": return "Deposit in Lieu of Order";
                case "C110": return "Deposit";
                case "C120": return "Deramping";
                case "C130": return "Derrick Charge";
                case "C140": return "Designated Supplier Inspection";
                case "C150": return "Destination Charge";
                case "C160": return "Detention – Special Type Flat Car";
                case "C170": return "Detention Loading";
                case "C180": return "Detention of Power Units";
                case "C190": return "Detention of Trailers";
                case "C200": return "Detention Unloading";
                case "C210": return "Determined Freight";
                case "C220": return "Development Charge";
                case "C230": return "Die Service Charge";
                case "C231": return "Disbursement";
                case "C240": return "Disconnect Charge";
                case "C250": return "Discount – Drop Box/Convenience Ctr.";
                case "C260": return "Discount – Incentive";
                case "C270": return "Discount – Multiple Shipment";
                case "C280": return "Discount – Service Option (Delivery)";
                case "C290": return "Discount – Service Option (Pickup)";
                case "C300": return "Discount – Special";
                case "C310": return "Discount";
                case "C320": return "Display Allowance";
                case "C330": return "Distribution Fee";
                case "C340": return "Distribution Service";
                case "C350": return "Distributor Discount/Allowance";
                case "C360": return "Diversion and Reconsignment";
                case "C370": return "Diversion Charge";
                case "C380": return "Diversion to Air Charge";
                case "C390": return "Dockage – Boat Detention";
                case "C400": return "Documentation Charge";
                case "C401": return "Document Handling";
                case "C402": return "Door-to-Door";
                case "C410": return "Dowel Pin Charge";
                case "C420": return "Drayage";
                case "C430": return "Drayage/Line Haul";
                case "C440": return "Driver Assisted Unloading";
                case "C450": return "Driver’s Wages";
                case "C460": return "Drop Dock";
                case "C470": return "Drop Yard";
                case "C480": return "Drum Cost";
                case "C490": return "Drum Deposit";
                case "C500": return "Drum Up Charge";
                case "C510": return "Dry Ice";
                case "C520": return "Dryer Charge";
                case "C530": return "Duty Charge";
                case "C531": return "Duty Drawback";
                case "C540": return "Early Buy Allowance";
                case "C550": return "Early Payment Allowance";
                case "C560": return "Early Ship Allowance";
                case "C570": return "Emergency Port Charge";
                case "C580": return "Emergency Service";
                case "C590": return "Emergency Surcharge";
                case "C600": return "Empty Weighing Charge";
                case "C610": return "Enclosure";
                case "C630": return "Endorsement Fee";
                case "C640": return "Energy charge";
                case "C650": return "Energy Surcharge (Fuel Adjustment Factor)";
                case "C660": return "Engineering Charge";
                case "C670": return "Engraving";
                case "C675": return "Entered Value";
                case "C680": return "Environmental Protection Service";
                case "C690": return "Escalation";
                case "C700": return "Escort Service";
                case "C710": return "Eur1 Presentation Fee";
                case "C720": return "European Port Charges";
                case "C730": return "Excess Mileage Charge";
                case "C740": return "Excess Periods";
                case "C750": return "Excess Value Fee";
                case "C760": return "Excess Weight";
                case "C770": return "Excessive Value Charge";
                case "C780": return "Exchange Access Credit";
                case "C790": return "Exclusive Use Of Equipment";
                case "C800": return "Exclusive Use";
                case "C810": return "Exhibition Delivery Charge";
                case "C820": return "Exhibition Pickup Charge";
                case "C830": return "Expanded Service";
                case "C840": return "Expedited One Day Consular Service";
                case "C850": return "Expedited Service Charge";
                case "C860": return "Expedited Shipments";
                case "C870": return "Expediting Fee";
                case "C880": return "Expediting Premium";
                case "C890": return "Export Customs Clearance";
                case "C900": return "Export Declarations – Automated";
                case "C910": return "Export Declarations – U.S. Shippers";
                case "C920": return "Export License Application";
                case "C930": return "Export Shipping Charge";
                case "C940": return "Export/Import Charge";
                case "C950": return "Extra Copies and Mailings";
                case "C960": return "Extra Labor (Helper Service)";
                case "C970": return "Extra Length";
                case "C980": return "Extra Service – Counter-to-Counter";
                case "C990": return "Fabrication Charge";
                case "CA2T": return "Currency Adjustment – 20 Foot Container";
                case "CA4T": return "Currency Adjustment – 40 Foot Container";
                case "CFCT": return "Customs Fees – Container Level";
                case "CFLT": return "Customs Fees – Lift Level";
                case "CGTT": return "Cargo Taxes";
                case "CLDT": return "Container Loss/Damage";
                case "COMM": return "Communications Charges";
                case "CONC": return "Container Charge";
                case "CRLT": return "Container Lease";
                case "CUFT": return "Currency Adjustment – Break Bulk";
                case "D000": return "Facsimile Charges – Additional Pages";
                case "D010": return "Facsimile Charges";
                case "D015": return "Dunnage";
                case "D020": return "Failed Lamp Panel Charge";
                case "D025": return "Fax Pre-alert";
                case "D030": return "Federal Transfer Surcharge";
                case "D040": return "Finance Charge";
                case "D050": return "First Article Charge";
                case "D060": return "First Flight Out";
                case "D070": return "Flat Rate";
                case "D080": return "Floor Stock Protection";
                case "D100": return "Food and Lodging";
                case "D101": return "Foreign Office Advance";
                case "D103": return "Foreign Customs Duty";
                case "D110": return "Foreign Military Sales (FMS) Rental";
                case "D120": return "Foreign Military Sales (FMS) Special Charge";
                case "D130": return "Forwarding Agent Commission";
                case "D140": return "Forwarding Charge";
                case "D141": return "Forward Coupons";
                case "D142": return "Capture Additional Data";
                case "D143": return "Provide Name and Address";
                case "D144": return "Provide Household Identifier";
                case "D150": return "Franchise fee";
                case "D160": return "Free Domicile Shipment Processing";
                case "D170": return "Free Goods";
                case "D180": return "Freight Based on Dollar Minimum";
                case "D190": return "Freight Charges to Border";
                case "D200": return "Freight Charges to Destination";
                case "D210": return "Freight Equalization";
                case "D220": return "Freight Passthrough";
                case "D230": return "Freight Surcharge";
                case "D240": return "Freight";
                case "D242": return "Freight, International";
                case "D244": return "Freight, International, U.S. Dollars";
                case "D246": return "Freight, International, Non-U.S. Dollars";
                case "D250": return "Freshness/Leaker Allowance";
                case "D260": return "Fuel Charge";
                case "D270": return "Fuel Surcharge";
                case "D280": return "Full Service";
                case "D290": return "Full Truckload Allowance";
                case "D292": return "Fumigation";
                case "D300": return "Garment District";
                case "D301": return "Gateway Fee";
                case "D310": return "Gas Pressure";
                case "D320": return "Glaze";
                case "D330": return "Gold Factor";
                case "D340": return "Goods and Services Charge";
                case "D350": return "Goods and Services Credit Allowance";
                case "D360": return "Goods and Services Tax Charge";
                case "D370": return "Government Inspection";
                case "D380": return "Government Warehouse Fee – Destination";
                case "D390": return "Government Warehouse Fee – Origin";
                case "D400": return "Grain Doors";
                case "D410": return "Grain Flow Charge";
                case "D420": return "Grinding";
                case "D430": return "Gross Receipts Surcharge";
                case "D440": return "Groupage Discount";
                case "D450": return "Grouped Items";
                case "D460": return "Guaranteed Inspection Technical Service";
                case "D470": return "Gulf Port Delivery Charge";
                case "D480": return "Handling Charges on Distribution Freight Forwarded Beyond";
                case "D490": return "Handling Freight At Positions Not Immediately Adjacent To Vehicle Charge";
                case "D500": return "Handling";
                case "D501": return "Harbor Maintenance Report";
                case "D502": return "Harbor Maintenance Fee";
                case "D510": return "Hauling and Hoisting to be Direct Billed";
                case "D520": return "Hauling and Hoisting";
                case "D530": return "Hazardous Cargo Charge";
                case "D540": return "Hazardous Materials Handling Fee – Domestic";
                case "D550": return "Hazardous Materials Handling Fee – International";
                case "D560": return "Hazardous Storage";
                case "D570": return "Heat in Transit Charges";
                case "D580": return "Heat Treat Charge";
                case "D590": return "Heavy Duty Flat Car Charge";
                case "D600": return "Heavy Lift";
                case "D610": return "High Security Red In-bond Seal Charge";
                case "D620": return "Highway Interchange";
                case "D630": return "Hointins and Hauling";
                case "D640": return "Holding Charge";
                case "D650": return "Home Line Freight Charge";
                case "D655": return "Honey Fee";
                case "D660": return "Hook-up charge";
                case "D670": return "Hose Charge Special";
                case "D680": return "Hose Charge";
                case "D690": return "Household Goods Pickup or Delivery";
                case "D700": return "IATA Airbill Preparation";
                case "D701": return "International Air Transport Association (IATA) Commission";
                case "D710": return "IATA Fee";
                case "D711": return "International Air Transport Association (IATA) Markup";
                case "D720": return "Identification";
                case "D730": return "Import Service Fee";
                case "D740": return "In Transit Price Protection";
                case "D750": return "Inbound Freight Charges";
                case "D760": return "Income Freight (Manufacturing to Shipping Point)";
                case "D770": return "Incorrect Billing Account Charge";
                case "D780": return "Industry Price Allowance";
                case "D790": return "Initial License Fee";
                case "D800": return "Inland Transportation";
                case "D810": return "Inside Cable Connectors";
                case "D820": return "Inside Delivery";
                case "D830": return "Inside Pickup";
                case "D840": return "Inspect at Destination";
                case "D850": return "Inspect at Origin";
                case "D870": return "Inspection";
                case "D880": return "Installation & Warranty";
                case "D890": return "Installation and Training";
                case "D900": return "Installation";
                case "D910": return "Insulated Tank Charge";
                case "D920": return "Insurance Fee";
                case "D930": return "Insurance Placement Cost Charge";
                case "D940": return "Insurance Premium";
                case "D950": return "Insurance Provided by Lessee";
                case "D960": return "Insurance Provided by Lessor";
                case "D970": return "Insurance Surcharge";
                case "D980": return "Insurance";
                case "D990": return "Interdivision Profit";
                case "D995": return "Interest Amount";
                case "DCET": return "Damage to Carrier Equipment";
                case "DCVT": return "Damage to Carrier Vessel";
                case "DDZT": return "Drayage at Port of Debarkation (Rate Zone)";
                case "DEZT": return "Drayage at Port of Embarkation (Rate Zone)";
                case "DFDT": return "Keep From Freezing Percent Differential";
                case "DGET": return "Damage to Government Equipment";
                case "DOVT": return "Container Diversion";
                case "DPDT": return "Drayage at Port of Debarkation";
                case "DPET": return "Drayage at Port of Embarkation";
                case "E000": return "Interest on refund";
                case "E010": return "Interest on Security Deposit";
                case "E020": return "Interim Use Permitted at Special Rate";
                case "E022": return "International Courier";
                case "E030": return "International Door-to-Door Handling Fee";
                case "E040": return "Interplant Charge";
                case "E050": return "Interstate/Highway Toll";
                case "E060": return "Intra-plant Charge";
                case "E063": return "Invoice Additional Amount";
                case "E065": return "Invoice Adjustment";
                case "E067": return "Invoice At-Cost Amount";
                case "E068": return "Invoice Delivery Terms Amount";
                case "E069": return "Invoice No-Charge Amount";
                case "E070": return "Invoice Services";
                case "E080": return "Invoice with Goods";
                case "E090": return "Irish Arbitraries";
                case "E100": return "Island Delivery Charge";
                case "E110": return "Island Pickup Charge";
                case "E120": return "Italian Release Charge";
                case "E130": return "Item Percentage";
                case "E140": return "Item-Unit";
                case "E150": return "Koshering";
                case "E160": return "Label Allowance";
                case "E170": return "Labeling";
                case "E180": return "Labor (Repair and Return Orders)";
                case "E190": return "Labor Charges";
                case "E191": return "Labor, Straight-time";
                case "E192": return "Labor, Overtime";
                case "E193": return "Labor, Premium Overtime";
                case "E200": return "Labor Cost of Removal";
                case "E210": return "Labor Service";
                case "E220": return "Labor, Modify";
                case "E230": return "Labor, No Trouble Found";
                case "E240": return "Labor, Test and Calibrate";
                case "E250": return "Lading Adjustment Charge";
                case "E260": return "Lashing";
                case "E270": return "Late Order Charge";
                case "E280": return "Late Payment Charge";
                case "E290": return "Layout/Design";
                case "E300": return "Layover Charges";
                case "E310": return "Lead Factor";
                case "E320": return "Leaking Underground Storage Tax (LUST)";
                case "E330": return "Lease Shortfall Consideration";
                case "E340": return "Less Than Truckload (LTL) Charge";
                case "E350": return "Letter of Credit Processing";
                case "E360": return "License and Title";
                case "E370": return "Lifeline Surcharge";
                case "E380": return "Lift Gate (Truck) or Forklift Service at Pickup/Delivery";
                case "E381": return "Lime Fee";
                case "E382": return "Liquidation Anti-Dumping Duty";
                case "E384": return "Liquidation Countervailing Duty";
                case "E386": return "Liquidation Tax Amount";
                case "E388": return "Liquidation Total Due U.S. Customs and Border Protection (CBP)";
                case "E389": return "Liquidation Total Fees";
                case "E390": return "Load Weighing Charge";
                case "E400": return "Loading (Labor Charges)";
                case "E410": return "Loading";
                case "E420": return "Loan Fee";
                case "E430": return "Local Delivery/Drayage";
                case "E440": return "Locomotive Delayed in Switching Service";
                case "E450": return "Locomotive Under Own Power";
                case "E460": return "Lot Charge";
                case "E470": return "Lump Sum";
                case "E480": return "Machining Charge";
                case "E485": return "Mail Fee";
                case "E490": return "Mail Invoice to Each Location";
                case "E500": return "Mail Invoice";
                case "E510": return "Mailing – Postage Cost";
                case "E520": return "Mailing – Service Fee";
                case "E530": return "Manifest Charge";
                case "E540": return "Manufacturing";
                case "E550": return "Market Development Funds";
                case "E560": return "Marking or Tagging Charge";
                case "E565": return "Markdown Allowance";
                case "E570": return "Marriage Rule";
                case "E580": return "Memo Returnable Container";
                case "E585": return "Merchandise Processing Fee";
                case "E590": return "Message Charge";
                case "E600": return "Message Rate Adjustment";
                case "E610": return "Messenger Service";
                case "E620": return "Metals Surcharge";
                case "E630": return "Meter Charge";
                case "E640": return "Mileage Fee (For Repair and Return)";
                case "E650": return "Mileage or Travel";
                case "E660": return "Monthly Rental";
                case "E670": return "Mount/Demount";
                case "E680": return "Mounting";
                case "E690": return "Municipal Surcharge";
                case "E695": return "Mushroom Fee";
                case "E700": return "N.H.D. Wharfage";
                case "E710": return "New Discount";
                case "E720": return "New Distribution Allowance";
                case "E730": return "New Item Allowance";
                case "E740": return "New Store Allowance";
                case "E750": return "New Store Discount";
                case "E760": return "New Warehouse Discount";
                case "E770": return "New Warehouse";
                case "E780": return "New York Delivery Charge";
                case "E790": return "New York Pickup Charge";
                case "E800": return "No Return Credit Allowance";
                case "E805": return "Non-Dutiable Charges";
                case "E810": return "Non Generated Freight";
                case "E820": return "Non-returnable Containers";
                case "E830": return "Normal Pump Charge";
                case "E840": return "Notarized Affidavit";
                case "E850": return "Notify Consignee Before Delivery";
                case "E860": return "Notify Consignee";
                case "E870": return "Nozzle Charge";
                case "E880": return "Ocean Charges – Hazardous";
                case "E890": return "Ocean Freight";
                case "E900": return "Offshore – Alaska/Hawaii";
                case "E910": return "On Carriage";
                case "E920": return "On Hand Service";
                case "E930": return "One – Day Service";
                case "E940": return "One Time Engineering Charge";
                case "E950": return "One-Time License Fee";
                case "E960": return "One-Time-Only Charge";
                case "E970": return "Onetime Tooling";
                case "E980": return "Operator Credit";
                case "E990": return "Option Charge (Color Fabric Office Furniture)";
                case "ENGA": return "Engineering Supplies";
                case "EXLT": return "Extra Length Surcharge";
                case "F000": return "Optional Charge";
                case "F010": return "Optional Software Support for Operational Support Systems";
                case "F020": return "Optional Software Support for Switching Systems";
                case "F030": return "Order Notify Charge";
                case "F040": return "Order-Flat";
                case "F050": return "Other (See related description)";
                case "F060": return "Other Accessorial Service Charge";
                case "F061": return "Other Advances";
                case "F062": return "Other Export Charges";
                case "F063": return "Other Government Agency Declaration";
                case "F065": return "Other Government Agency Exam";
                case "F067": return "Other Import Charge";
                case "F070": return "Out of Route Miles";
                case "F080": return "Out of Zone Pickup or Delivery";
                case "F090": return "Outside Cable Connectors";
                case "F100": return "Over Dimension";
                case "F110": return "Overrun Charge";
                case "F120": return "Oversized Premium";
                case "F130": return "Overtime Loading";
                case "F140": return "Pack Invoice with Shipment";
                case "F150": return "Packaging Service";
                case "F155": return "Packaging";
                case "F160": return "Painting (Primer or Finish)";
                case "F170": return "Pallet Exchange Charge";
                case "F180": return "Pallet";
                case "F190": return "Palletizing";
                case "F200": return "Paralleling";
                case "F210": return "Parish/County Sales Tax (only)";
                case "F220": return "Passing Shippers Export Entry";
                case "F225": return "Pecan Fee";
                case "F230": return "Penalty Charge";
                case "F240": return "Per Item Charge";
                case "F250": return "Per Order Charge";
                case "F260": return "Per Pound Charge";
                case "F270": return "Percent of Product";
                case "F271": return "Percent of Shipped Quantity that is Returnable";
                case "F272": return "Percent of Shipment Value that is Returnable";
                case "F280": return "Performance Allowance";
                case "F290": return "Performance Award";
                case "F300": return "Permit Charge";
                case "F310": return "Permits Bonds Escort Attendant";
                case "F320": return "Phosphatizing (Steel Treatment)";
                case "F330": return "Pickup and Delivery";
                case "F340": return "Pick/Up";
                case "F350": return "Pickle and Oil";
                case "F360": return "Pickup – Out of Area";
                case "F370": return "Pickup Surcharge";
                case "F380": return "Pier Charges – Wharfage";
                case "F390": return "Pier Charges Other Than Wharfage";
                case "F400": return "Pier Pickup and/or Delivery";
                case "F401": return "Pier Unloading";
                case "F410": return "Pilot Inspection";
                case "F420": return "Placement and/or Removal Charge";
                case "F430": return "Plating";
                case "F440": return "Pole, Wood-service Charge";
                case "F445": return "Pork Fee";
                case "F450": return "Positioning at Origin";
                case "F460": return "Postage";
                case "F465": return "Potato Fee";
                case "F470": return "Power Factor Adjustment";
                case "F480": return "Pre-carriage Excess";
                case "F490": return "Pre-carriage";
                case "F500": return "Pre-Positioned Inventory Service";
                case "F510": return "Precious Metal Content";
                case "F520": return "Preloading Charge";
                case "F530": return "Prelodge Charge";
                case "F540": return "Premise Use";
                case "F550": return "Premium Charge";
                case "F560": return "Premium Transportation";
                case "F570": return "Prepaid Usage Allowance";
                case "F580": return "Preparation and Delivery";
                case "F590": return "Preparation of Air Waybill – Origin";
                case "F600": return "Preparation of Canadian Customs Invoice";
                case "F610": return "Preparation of Commercial Invoice";
                case "F620": return "Preparation of Export Entry";
                case "F630": return "Preparation of Insurance Certificate";
                case "F640": return "Preparation of U.S. Export Documentation";
                case "F650": return "Preparation";
                case "F660": return "Previous Billing";
                case "F670": return "Price and Marketing Allowance";
                case "F680": return "Price Deviation";
                case "F690": return "Prior Balance";
                case "F700": return "Prior Billing Amount";
                case "F710": return "Prior Delivery Of Bill Charge";
                case "F720": return "Prior Month Credit";
                case "F730": return "Priority Service";
                case "F740": return "Process in Transit Privilege";
                case "F750": return "Processing Charge";
                case "F760": return "Processing";
                case "F765": return "Procurement Charge";
                case "F770": return "Professional Fees";
                case "F780": return "Proforma Invoice";
                case "F790": return "Progress Payment Requirement";
                case "F800": return "Promotional Allowance";
                case "F810": return "Promotional Discount";
                case "F820": return "Proof & Composition";
                case "F830": return "Proof of Delivery";
                case "F840": return "Protective Service – Cold";
                case "F850": return "Protective Service – Heat";
                case "F860": return "Protective Service Charge";
                case "F870": return "Pulling Eyes";
                case "F880": return "Pump Air Charge";
                case "F890": return "Pump Charge";
                case "F900": return "Purchase Option";
                case "F910": return "Quantity Discount";
                case "F920": return "Quantity Surcharge";
                case "F930": return "Equipment Manufacturer Restoration Audit";
                case "F940": return "Ramping";
                case "F950": return "Rate Code";
                case "F955": return "Rate Reduction Bond";
                case "F960": return "Re-Bill Charge";
                case "F970": return "Rebate";
                case "F980": return "Rebilled Drayage – Destination";
                case "F990": return "Rebilled Drayage – Origin";
                case "F991": return "Receiving";
                case "FAKT": return "Barge Freight All Kinds Service";
                case "FLST": return "Flatrack Surcharge";
                case "G000": return "Recipient Address Correction";
                case "G010": return "Reclamation, Federal";
                case "G020": return "Reclamation, State";
                case "G025": return "Reconciliation";
                case "G030": return "Reconnect charge";
                case "G040": return "Reconsign Consignee Charge";
                case "G050": return "Reconsign Delivery Charge";
                case "G060": return "Reconsignment Charge";
                case "G070": return "Recoopering (at Owner’s or Shipper’s Expense)";
                case "G080": return "Record/Filing";
                case "G090": return "Recovery Fee";
                case "G100": return "Recovery";
                case "G110": return "Recrating/Recoopering – Destination";
                case "G120": return "Recrating/Recoopering – Origin";
                case "G130": return "Recurring Hardware Maintenance Charge";
                case "G140": return "Recurring License Fee";
                case "G150": return "Recurring Software Maintenance Charge";
                case "G160": return "Redelivery";
                case "G170": return "Redistribution Allowance";
                case "G180": return "Reduction Prepalletized Cargo";
                case "G190": return "Reel Cable";
                case "G200": return "Reel Deposit";
                case "G210": return "Reel";
                case "G220": return "Refrigeration";
                case "G230": return "Refrigeration/Mechanical Detention";
                case "G240": return "Refund";
                case "G250": return "Refurbishing Charge";
                case "G260": return "Regain";
                case "G270": return "Registration of Export for Reentry";
                case "G280": return "Registration of Export Shipments";
                case "G290": return "Regulatory Fee";
                case "G300": return "Regulatory required refund";
                case "G310": return "Reliability Charge";
                case "G320": return "Relinquishment Charge";
                case "G322": return "Reliquidation Anti-Dumping Duty";
                case "G324": return "Reliquidation Countervailing Duty";
                case "G326": return "Reliquidation Tax Amount";
                case "G328": return "Reliquidation Total Due U.S. Customs and Border Protection (CBP)";
                case "G329": return "Reliquidation Total Fees";
                case "G330": return "Rental Charge";
                case "G340": return "Rental Deduction";
                case "G350": return "Rents and Leases";
                case "G360": return "Repack Charge";
                case "G370": return "Repair at Buyers Expense Charge";
                case "G380": return "Repair at Customer Expense Charge";
                case "G390": return "Repair at Government Expense Charge";
                case "G400": return "Repair";
                case "G410": return "Repickup";
                case "G420": return "Request Via Canada";
                case "G430": return "Research & Development Fee";
                case "G440": return "Resellers Discount";
                case "G450": return "Residential Delivery";
                case "G460": return "Residential Pickup";
                case "G470": return "Restocking Charge";
                case "G480": return "Restricted Article Fee";
                case "G490": return "Retainer";
                case "G500": return "Return Cargo Charge";
                case "G510": return "Returnable Container";
                case "G520": return "Returned Load";
                case "G530": return "Rework";
                case "G540": return "Riding Attendant Charge";
                case "G550": return "Rocky Mountain Bureau 583 Item 1100 Arbitrary Charge";
                case "G560": return "Roll Out Adjustment";
                case "G570": return "Roll Rebate";
                case "G580": return "Royalties";
                case "G590": return "Salvage";
                case "G600": return "Same – Day Service";
                case "G610": return "Saturday Delivery";
                case "G620": return "Saturday Pickup or Delivery Charge";
                case "G630": return "Saturday Pickup";
                case "G640": return "Scale Charge Unloading";
                case "G650": return "Scale Charge";
                case "G660": return "Scrap Allowance";
                case "G670": return "Security Signature Service";
                case "G680": return "Segregating (Sorting)";
                case "G690": return "Select Charge";
                case "G700": return "Self Unloader";
                case "G710": return "Seller Hand Carry";
                case "G720": return "Service Assistance Program Surcharge";
                case "G730": return "Service Charge (with Cash Discount)";
                case "G740": return "Service Charge";
                case "G750": return "Service Upgrade";
                case "G760": return "Set-up";
                case "G770": return "Shearing";
                case "G775": return "Sheep Fee";
                case "G780": return "Ship to Stock Quality Audit";
                case "G790": return "Shipper Load and Count";
                case "G800": return "Shipper Load Carrier Count";
                case "G810": return "Shipper Load Consignee Unload";
                case "G820": return "Shipper Load";
                case "G821": return "Shipping";
                case "G830": return "Shipping and Handling";
                case "G840": return "Shipside Pickup";
                case "G850": return "Shotblasting";
                case "G860": return "Shrink Allowance";
                case "G870": return "Shrink-Wrap Charge";
                case "G880": return "Shrinkage Allowance";
                case "G890": return "Single Invoice Allowance";
                case "G900": return "Single Pickup";
                case "G910": return "Single Shipment Fee";
                case "G920": return "Sleeving";
                case "G930": return "Slip Sheet Unloading Allowance";
                case "G940": return "Slip Sheet, Rail";
                case "G950": return "Slip Sheet, Truck";
                case "G960": return "Slotting Allowance";
                case "G970": return "Small Order Charge";
                case "G980": return "Software Support Service";
                case "G990": return "Source Inspection";
                case "GMST": return "Garment Surcharge";
                case "H000": return "Special Allowance";
                case "H010": return "Special Buy";
                case "H020": return "Special Circus Trains";
                case "H030": return "Special Credit";
                case "H040": return "Special Delivery";
                case "H050": return "Special Detention Charge";
                case "H060": return "Special Equipment Charge";
                case "H070": return "Special Finish Charge";
                case "H080": return "Special Freight Supplements";
                case "H090": return "Special Handling";
                case "H100": return "Special Mileage Movements";
                case "H110": return "Special Packaging";
                case "H120": return "Special Permits";
                case "H130": return "Special Pickup";
                case "H140": return "Special Pump Charge";
                case "H150": return "Special Seal Charge";
                case "H151": return "Special Services";
                case "H160": return "Special Test Equipment Charge";
                case "H170": return "Special Tooling Charge";
                case "H180": return "Special Tooling rework charge";
                case "H190": return "Special Train Movement";
                case "H200": return "Special Use";
                case "H210": return "Special Vehicle Rent";
                case "H215": return "Specific Duty";
                case "H220": return "Specification Review";
                case "H230": return "Split Delivery";
                case "H240": return "Split Pickup at Pier Charge";
                case "H250": return "Split Pickup";
                case "H260": return "Spool Charge";
                case "H270": return "Spotting of Trailer";
                case "H280": return "Spreader Charge";
                case "H290": return "Stamp Fee";
                case "H300": return "Stamping";
                case "H310": return "Standby Charge";
                case "H320": return "State Motor Fuel";
                case "H330": return "State Sales Charge";
                case "H340": return "State Surcharge";
                case "H350": return "State/Metropolitan Transit Authority Surcharge";
                case "H360": return "Steaming Charge";
                case "H370": return "Stenciling Charge";
                case "H380": return "Stop-off at Pier Charge";
                case "H390": return "Stop-off Charge";
                case "H400": return "Stopcharge";
                case "H410": return "Stopping in Transit";
                case "H420": return "Storage in Transit";
                case "H430": return "Storage";
                case "H440": return "Straightening Charge";
                case "H450": return "Strapping";
                case "H460": return "Street lamps charge";
                case "H470": return "Stripping, Sorting, and Consolidation";
                case "H480": return "Subject to Cooperative Advertising Allowance";
                case "H490": return "Subject To Tax On Resale";
                case "H500": return "Sufferance Warehouse Charge (Export or Import)";
                case "H505": return "Sugar Fee";
                case "H507": return "Sum of Adds and Deducts to Make Market Value";
                case "H510": return "Sunday or Holiday Pickup or Delivery";
                case "H520": return "Super Bag Charge";
                case "H530": return "Supervisor Charge";
                case "H535": return "Supplemental Duty";
                case "H540": return "Supplemental Items";
                case "H550": return "Surcharge";
                case "H551": return "Surety Bond";
                case "H560": return "Swell";
                case "H570": return "Switch Charge";
                case "H580": return "Switching Charge";
                case "H590": return "Tank Car Allowance";
                case "H600": return "Tank Rental";
                case "H605": return "Tarping";
                case "H610": return "Tax – Airport Tax, Destination";
                case "H620": return "Tax – Airport Tax, Origin";
                case "H625": return "Tax – Beverage Tax";
                case "H630": return "Tax – City Sales Tax (Only)";
                case "H640": return "Tax – Excise Tax – Destination";
                case "H650": return "Tax – Excise Tax – Origin";
                case "H660": return "Tax – Federal Excise Tax, FET";
                case "H670": return "Tax – Federal Excise Tax, FET, on Tires";
                case "H680": return "Tax – Governmental";
                case "H690": return "Tax – Handling Charge Tax";
                case "H700": return "Tax – Local Tax";
                case "H710": return "Tax – Metropolitan Transit Tax";
                case "H720": return "Tax – Regulatory Tax";
                case "H730": return "Tax – Local Sales Tax";
                case "H740": return "Tax – Sales and Use";
                case "H750": return "Tax – Sales Tax (State and Local)";
                case "H760": return "Tax – State Hazardous Substance";
                case "H770": return "Tax – State Tax";
                case "H780": return "Tax – Super Fund Excise Tax";
                case "H790": return "Tax – Use Tax";
                case "H800": return "Tax – Value Added Tax (VAT)";
                case "H806": return "Tax Credit";
                case "H810": return "Tax Liability – Amortized";
                case "H820": return "Tax Liability – One Time";
                case "H830": return "Tax on Miscellaneous Charges";
                case "H840": return "Tax on Transportation";
                case "H850": return "Tax";
                case "H855": return "Tea Fee";
                case "H860": return "Technology Exchange";
                case "H870": return "Telegram Chargeback";
                case "H880": return "Telephone – Destination";
                case "H890": return "Telephone – Origin";
                case "H900": return "Telephone Charge";
                case "H910": return "Temperature Protection";
                case "H920": return "Temporary Allowance";
                case "H930": return "Temporary Voluntary Allowance";
                case "H935": return "Tendered as Truckload";
                case "H940": return "Terminal Charge";
                case "H950": return "Terminal Differential";
                case "H960": return "Terminal Service Fee";
                case "H970": return "Terms Allowance";
                case "H980": return "Test/Qualification Charge";
                case "H990": return "Testing Services Charge";
                case "HZDT": return "Hazardous Cargo on Deck";
                case "I000": return "Testing";
                case "I010": return "Third Party Allowance";
                case "I020": return "Third Party Pallets";
                case "I030": return "Throughput Allowance";
                case "I040": return "Throughput Container Charge";
                case "I050": return "Thruway Charge";
                case "I060": return "Ticketing Service";
                case "I070": return "Tobacco Products Report Charge";
                case "I080": return "TOFC Service Charge";
                case "I090": return "Tool Charge";
                case "I100": return "Tooling Rework Charge";
                case "I110": return "Tooling";
                case "I120": return "Tools for Printing";
                case "I130": return "Total Assessorial Charges";
                case "I131": return "Total Fees";
                case "I132": return "Total Invoice Amount";
                case "I133": return "Total Due U.S. Customs and Border Protection (CBP)";
                case "I134": return "Total Invoice Amount, U.S. Dollars";
                case "I136": return "Total Invoice Amount, Non-U.S. Dollars";
                case "I138": return "Total Material Invoice Amount";
                case "I140": return "Tracing Inbound Via Other Carriers";
                case "I150": return "Tracing Service Fee";
                case "I160": return "Track Storage";
                case "I170": return "Trade Discount";
                case "I180": return "Trade In";
                case "I190": return "Trailer Rental Charge";
                case "I200": return "Transfer Charge";
                case "I210": return "Transfer of Lading Charge";
                case "I220": return "Transferred Charges";
                case "I230": return "Transit";
                case "I235": return "Transmission Charge";
                case "I240": return "Transportation And Setup";
                case "I250": return "Transportation Charge (Minimum Rate)";
                case "I260": return "Transportation Direct Billing";
                case "I270": return "Transportation Third Party Billing";
                case "I280": return "Transportation Vendor Provided";
                case "I290": return "Trimming Charge";
                case "I300": return "Truck Detention";
                case "I310": return "Truckload Discount";
                case "I320": return "Turning Charge";
                case "I330": return "Two – Day Service";
                case "I340": return "Two Door Pickup";
                case "I350": return "U.S. Vehicles";
                case "I360": return "Unabsorbed Switching";
                case "I370": return "Unitized";
                case "I380": return "Unloading (Labor Charges)";
                case "I390": return "Unloading";
                case "I400": return "Unloading/Reloading Charge";
                case "I410": return "Unsaleable Merchandise Allowance";
                case "I411": return "Unscheduled Fee";
                case "I420": return "Up Charge";
                case "I430": return "Usage Plan Detail Charge";
                case "I431": return "U.S. Customs and Border Protection (CBP) Flat Assist Amount";
                case "I432": return "U.S. Customs and Border Protection (CBP) Maximum Assist Amount";
                case "I440": return "USDA Inspected, Stamping Certification";
                case "I450": return "Use – Special Type Flat Car";
                case "I460": return "Use Charge Tooling/Personnel";
                case "I470": return "Valuation Fee";
                case "I480": return "Vehicle Ordered but Not Used";
                case "I490": return "Vehicle Prep Charge (Courtesy Delivery)";
                case "I495": return "Vehicle Road Charge";
                case "I500": return "Vendor Freight";
                case "I510": return "Venting Instructions";
                case "I520": return "Virgin Island Transfer Charge";
                case "I530": return "Volume Discount";
                case "I540": return "Voluntary Contribution Charge";
                case "I550": return "Waiting Time";
                case "I560": return "War Risk Surcharge";
                case "I570": return "Warehouse";
                case "I580": return "Warehousing";
                case "I590": return "Warranties";
                case "I595": return "Watermelon Fee";
                case "I600": return "Waybill and Invoice Distribution";
                case "I610": return "Weather Protection";
                case "I620": return "Weight Verification Charge";
                case "I630": return "Wharfage & Handling";
                case "I640": return "Wharfage Charge";
                case "I650": return "Wide Area Telephone Service (WATS) Usage Credit";
                case "I660": return "Will Call Charge";
                case "I670": return "Written Proof of Delivery";
                case "I680": return "X-ray Charge";
                case "I690": return "Gratuity";
                case "I700": return "Escrow";
                case "I710": return "Payment";
                case "I720": return "Direct Product Handling (DPC)";
                case "I730": return "Price Adjustment Percent (PCT)";
                case "I740": return "Post Damaged Handling (PDC)";
                case "I750": return "Reclamation Center Handling (Chute)";
                case "I760": return "Reclamation Shared Responsibility (SRS)";
                case "I770": return "Mid-Tier Lottery Winners";
                case "I780": return "Mid-Tier Lottery Cashing Bonus";
                case "I790": return "Lottery Cross Redeemed";
                case "I800": return "Low-Tier Lottery Winners";
                case "I810": return "Low-Tier Lottery Cashing Bonus";
                case "I820": return "Lottery Charge Back";
                case "I830": return "Tote";
                case "I840": return "Extra Hour Charges";
                case "I850": return "Refused Delivery Charge";
                case "I860": return "Reimbursement for Online Cashing Bonus";
                case "I870": return "Reimbursement for Online Winners";
                case "I880": return "Online Sales Bonus";
                case "I890": return "Instant Sales Bonus";
                case "IDCT": return "Improper Documentation";
                case "LC2T": return "Land Currency Adjustment Factor – 20 Foot Container";
                case "LC4T": return "Land Currency Adjustment Factor – 40 Foot Container";
                case "LCLT": return "Percent Differential – Less Than Container";
                case "LECT": return "Less Than Container";
                case "LFDT": return "Linehaul from Port of Debarkation";
                case "LMDT": return "Liner Terms at Port of Embarkation";
                case "LNDT": return "Liner Terms at Port of Debarkation";
                case "LPDT": return "Linehaul Percent Differential";
                case "LQDT": return "Liquidated Damages";
                case "LTET": return "Linehaul to Port of Embarkation";
                case "MATT": return "Modified Atmosphere";
                case "OCNT": return "Over Height Container";
                case "OFFA": return "Office Supplies";
                case "OODT": return "On Deck Break Bulk Differential";
                case "OTHR": return "Other Miscellaneous Earning or Additive";
                case "OWCT": return "Over Width Container";
                case "PFCH": return "Prepared Food Charge";
                case "PRST": return "Stuffing Charge";
                case "PTAX": return "Payroll Taxes";
                case "PVPT": return "Private Owned Vehicle Processing";
                case "R020": return "Personal Property, Member";
                case "R030": return "Personal Property, Spouse";
                case "R040": return "Port Handling and Unloading";
                case "R060": return "Packing, Crating, and Handling Charge";
                case "R080": return "Packing, Crating, Handling, and Transportation Charge";
                case "RDHT": return "Railhead Handling";
                case "RFEE": return "Recycling Fee";
                case "RFMT": return "Reefer Maintenance";
                case "RPDT": return "Reefer Cargo Percent Differential";
                case "RSTT": return "Respotting";
                case "SFBT": return "Single Factor Origination/Destination";
                case "SFDT": return "Single Factor Origination/Port of Debarkation";
                case "SFET": return "Single Factor Port of Embarkation/Destination";
                case "SSCT": return "Stripping, Sorting and Consolidation";
                case "SSUT": return "Pole Lashing Equipment (PLE) Surcharge";
                case "STDT": return "Stop-off at Destination";
                case "STFT": return "Stuffing";
                case "STOT": return "Stop-off at Origination";
                case "TERT": return "Terminal Handling Charges";
                case "VCLT": return "Van Cleaning";
                case "WBBT": return "Wharfage – Breakbulk";
                case "WCFT": return "Wharfage – Container";
                case "WFTT": return "Wasted/Futile Trip";
                case "WRBT": return "War Risk Crew Insurance";
                case "WRIT": return "War Risk Insurance";
                case "X001": return "Auto Towing";
                case "X002": return "Late Return";
                case "X003": return "One Way/Drop Off";
                case "X004": return "Passenger Facility Charge";
                case "X005": return "Lodging";
                case "X006": return "Business Center";
                case "X007": return "Gift Shop";
                case "X008": return "Health Club";
                case "X009": return "Laundry/Dry Cleaning";
                case "X010": return "In-room Movie";
                case "X011": return "In-room Mini-bar";
                case "X012": return "Meals";
                case "X013": return "Parking";
                case "X014": return "Prepaid Amount";
                case "X015": return "Liquor Charge";
                case "ZZZZ": return "Mutually Defined";

                default: return "Misc.";
            }
        }

        public static string GetToIdentity(XmlDocument cXML)
        {
            Credentials creds = GetCredentials(cXML);
            return creds.ToIdentity;
        }

        public static decimal GetDecimalFromString(string str) 
        {
            if (decimal.TryParse(str, out decimal result)) 
            {
                return result;
            }

            return 0;
        }

        public static int GetIntFromString(string str)
        {
            if (int.TryParse(str, out int result))
            {
                return result;
            }

            return 0;
        }
    }
}
