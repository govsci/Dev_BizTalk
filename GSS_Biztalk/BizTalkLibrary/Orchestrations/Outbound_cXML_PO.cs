using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using BizTalkLibrary.Objects;
using BizTalkLibrary.Classes;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text.RegularExpressions;

namespace BizTalkLibrary.Orchestrations
{
    public class Outbound_cXML_PO
    {
        public Outbound_cXML_PO(XmlDocument xml, string timestamp, string poType)
        {
            Credentials creds = Global.GetCredentials(xml);
            xml = finalAddressChecking(xml, creds);
            Vendor vendor = Database.GetVendorConfiguration(creds, poType);

            if (!Database.CheckBypassPo(vendor, xml))
            {
                string manufacturerName = "";
                Database.RecordCxmlData("VENDOR.PO", xml, timestamp, ref manufacturerName, vendor.CxmlCredentials.Url);

                Global.CreateDump(Constants.DUMP_FOLDERS.OUT_PO_SENT, timestamp, "", xml, true);

                XmlDocument response = sendPO(xml, vendor, timestamp, poType, creds);
                string orderid = Global.GetOrderId(xml);
                string status = Global.GetConfirmationStatusCode(response);

                Global.CreateDump(Constants.DUMP_FOLDERS.OUT_PO_CONFIRMED, $"{status}.{orderid}", timestamp, response, true);
                Database.Insert702OrderStatus(orderid, status, vendor.CxmlCredentials.Url);
                if (status != "200")
                {
                    if (poType == Constants.CXML_PO_TYPE.NAV)
                    {
                        string poNumber = Database.GetPurchaseOrderNumber(orderid, false);
                        if (poNumber.Length > 0)
                            ERP_Web_Service_Functions.UpdatePurchaseOrder(poNumber, false);
                    }
                    Email.SendErrorMessage(new Exception($"{poType} order {orderid} sent to {vendor.CxmlCredentials.Url} failed with status code {status}")
                        , ""
                        , "Outbound_cXML_PO"
                        , "Outbound_cXML_PO"
                        , orderid
                        , null);
                }
                else
                {
                    if (poType == Constants.CXML_PO_TYPE.NAV)
                    {
                        string poNumber = Database.GetPurchaseOrderNumber(orderid, true);
                        if (poNumber.Length > 0)
                            ERP_Web_Service_Functions.UpdatePurchaseOrder(poNumber, true);
                    }
                    else if (poType == Constants.CXML_PO_TYPE.BYPASS)
                    {
                        string navSONUM = "", sellToNo = "";
                        Database.GetNavisionSOdata(orderid, ref navSONUM, ref sellToNo);
                        MailNotification.Send702Confirmation(navSONUM, sellToNo, manufacturerName, orderid);
                    }
                }
            }
            else
                throw new Exception($"Order {Global.GetOrderId(xml)} was already sent to {vendor.CxmlCredentials.Url}");
        }

        public XmlDocument sendPO(XmlDocument xml, Vendor vendor, string timestamp, string poType, Credentials creds)
        {
            string result = "";
            try
            {
                string cXml = "";

                if (vendor.IncludeDocType == 1)
                    xml = ConvertToCXML_1_2_0_24_DTD(xml, creds);

                if (creds.FromIdentity == "J3ffLabG33") // VWR
                    xml = modifyShippingBlock(xml, "VWR");

                Global.CreateDump(Constants.DUMP_FOLDERS.OUT_PO_DEBUG, "", timestamp, xml, true);

                if (vendor.CxmlCredentials.Url.Contains("mscdirect"))
                    cXml = xml.InnerXml.Replace("[]", "").Replace(".cXML.", ".cxml.");
                else
                    cXml = xml.InnerXml;

                Global.CreateDump(Constants.DUMP_FOLDERS.OUT_PO_DEBUG, "", timestamp + "_raw", cXml, true);

                byte[] requestBytes = System.Text.Encoding.ASCII.GetBytes(cXml);

                switch (vendor.TlsVersion)
                {
                    case "SSL3": //outdated---server does not support
                        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender2, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                        break;
                    case "1.1": //outdated---server does not support
                        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender2, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                        break;
                    case "1.0": //outdated---server does not support
                        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender2, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                        break;

                    case "1.2":
                        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender2, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                        break;
                    case "Bypass":
                        // Force bypassing SSL handshake
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                | SecurityProtocolType.Tls11
                                | SecurityProtocolType.Tls12
                                | SecurityProtocolType.Ssl3;
                        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender2, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                        break;
                }

                if (vendor.CxmlCredentials.Url.IndexOf("Username=sigma_direct") > 0)
                {
                    using (var client = new WebClient())
                    {
                        if (vendor.HttpUserName.Length > 0 && vendor.HttpPassword.Length > 0)
                            client.Credentials = new NetworkCredential(vendor.HttpUserName, vendor.HttpPassword);
                        else
                            client.UseDefaultCredentials = true;
                        byte[] response = client.UploadData(vendor.CxmlCredentials.Url, "POST", requestBytes);
                        result = client.Encoding.GetString(response);
                    }
                }
                else
                {
                    HttpWebRequest wreq = (HttpWebRequest)WebRequest.Create(vendor.CxmlCredentials.Url);
                    if (vendor.CxmlCredentials.Url.Contains("thorlabs.com"))
                    {
                        wreq.UseDefaultCredentials = true;
                        wreq.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                    }
                    else if (vendor.HttpUserName.Length > 0 && vendor.HttpPassword.Length > 0)
                        wreq.Credentials = new System.Net.NetworkCredential(vendor.HttpUserName, vendor.HttpPassword);

                    wreq.Timeout = 300000;
                    wreq.Method = "POST";
                    //  wreq.KeepAlive = true;
                    wreq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                    wreq.ContentType = "text/xml";
                    wreq.ContentLength = requestBytes.Length;

                    if (vendor.Hash.Length > 0)
                    {
                        X509Store store = new X509Store(StoreLocation.LocalMachine);
                        store.Open(OpenFlags.ReadOnly);
                        foreach (X509Certificate2 myCert in store.Certificates)
                            if (myCert.Thumbprint.ToLower() == vendor.Hash)
                                wreq.ClientCertificates.Add(myCert);
                    }

                    System.IO.Stream rs = wreq.GetRequestStream();
                    rs.Write(requestBytes, 0, requestBytes.Length);
                    rs.Close();

                    HttpWebResponse wr = (HttpWebResponse)wreq.GetResponse();

                    // If the app send cXML to navision OK, //
                    if (wr.StatusCode == HttpStatusCode.OK)
                    {
                        Stream s = wr.GetResponseStream();
                        StreamReader readStream = new StreamReader(s);
                        result = readStream.ReadToEnd();

                        if (result.StartsWith("200 Ok") || result.Length == 0)
                            result = "<cXML payloadID=\"" + Global.GetTimeFromTimeStamp(timestamp) + "\" timestamp=\""
                                + Global.GetTimeFromTimeStamp(timestamp) + "\" version=\"1.1.008\">"
                                + "<Response><Status code=\"200\" text=\"" + result + "\"/></Response></cXML>";
                    }

                    wr.Close();
                }
            }
            catch (Exception err)
            {
                result = $"<cXML payloadID=\"{Global.GetTimeFromTimeStamp(timestamp)}\" timestamp=\"{Global.GetTimeFromTimeStamp(timestamp)}\" version=\"1.1.008\">"
                    + $"<Response><Status code=\"406\" text=\"Vendor Server Connection Failed\"/><Extrinsic name='Description'><![CDATA[{err}]]></Extrinsic></Response></cXML>";
            }

            XmlDocument returnXML = new XmlDocument();
            returnXML.XmlResolver = null;

            try
            {
                result = RemoveXMLNamespace(result);
                result = result.Replace("UTF-8", "utf-8");
                returnXML.LoadXml(result);
            }
            catch (Exception err)
            {
                result = $"<cXML payloadID=\"{Global.GetTimeFromTimeStamp(timestamp)}\" timestamp=\"{Global.GetTimeFromTimeStamp(timestamp)}\" version=\"1.1.008\">" +
                    $"<Response><Status code=\"999\" text=\"{err.Message}\"/><Extrinsic name='Description'><![CDATA[{err}]]></Extrinsic>" +
                    $"<Extrinsic name='response'><![CDATA[{result}]]></Extrinsic></Response></cXML>";
                returnXML.LoadXml(result);
            }
            return returnXML;
        }

        public static XmlDocument finalAddressChecking(XmlDocument cXML, Credentials creds)
        {
            //     string xmlHeader = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n";

            if (creds.FromIdentity == "Battelle-T" || creds.FromIdentity == "Battelle" || creds.FromIdentity == "INL-T" || creds.FromIdentity == "INL")
                return cXML;
            else
            {
                if (creds.FromIdentity == "785807611" && creds.ToIdentity == "114712842")
                {
                    XmlNode shipTo = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress");
                    string deliverTo = cXML.SelectSingleNode("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/DeliverTo").InnerXml;
                    deliverTo = deliverTo.Replace("eBuyer ", "");
                    XmlNodeList shipToStreet = cXML.SelectNodes("cXML/Request/OrderRequest/OrderRequestHeader/ShipTo/Address/PostalAddress/Street");

                    for (int i = 0; i < shipToStreet.Count; i++)
                    {
                        if (i == 0) shipToStreet[i].InnerXml = deliverTo;
                        if (i == 1) shipToStreet[i].InnerXml = "2575 SAND HILL ROAD CNTRL RECE";
                        if (i > 1) shipTo.RemoveChild(shipToStreet[i]);
                    }

                }
                return cXML;
            }
        }


        private XmlDocument ConvertToCXML_1_2_0_24_DTD(XmlDocument xml, Credentials creds)
        {

            XmlDocument xmlWithDocType = new XmlDocument();
            xmlWithDocType.XmlResolver = null;


            if (xml.FirstChild.NodeType == XmlNodeType.XmlDeclaration
                || (creds.FromIdentity.Equals("LBNL2")
                    && creds.ToIdentity.Equals("19-395-3726")))
            {
                XmlDocumentType docType = xml.CreateDocumentType("cXML", null, "http://xml.cXML.org/schemas/cXML/1.2.024/cXML.dtd", null);
                if (xml.FirstChild.NodeType == XmlNodeType.Element)
                    xml.InsertBefore(docType, xml.FirstChild);
                else
                    xml.InsertAfter(docType, xml.FirstChild);
                xmlWithDocType = xml;
            }
            else
            {
                //Create an XML declaration. 
                XmlDeclaration xmldecl = xmlWithDocType.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlWithDocType.AppendChild(xmldecl);

                XmlDocumentType docType = xmlWithDocType.CreateDocumentType("cXML", null, "http://xml.cXML.org/schemas/cXML/1.2.024/cXML.dtd", null);
                xmlWithDocType.AppendChild(docType);
                xmlWithDocType.InnerXml += xml.SelectSingleNode("cXML").OuterXml;
            }


            /* ################################ Add user agent block ############################# */
            XmlNode parent = xmlWithDocType.SelectSingleNode("cXML/Header/Sender");
            XmlElement userAgent = xmlWithDocType.CreateElement("UserAgent");
            userAgent.InnerXml = "GSS";
            parent.AppendChild(userAgent);

            /* ################################ Check if there is a shipComplete attribute ############################# */
            XmlNode requestHeader = xmlWithDocType.SelectSingleNode("//OrderRequestHeader");
            if (requestHeader.Attributes["shipComplete"] != null)
                requestHeader.Attributes.RemoveNamedItem("shipComplete");

            /* ################################ Check all name blocks ############################# */
            XmlNodeList names = xmlWithDocType.SelectNodes("//Name");
            foreach (XmlNode name in names)
            {
                if (name.Attributes["xml:lang"] == null)
                {
                    XmlAttribute att = xmlWithDocType.CreateAttribute("xml:lang");
                    att.Value = "en";
                    name.Attributes.Append(att);
                }
            }

            /* ################################ Check all description blocks ############################# */
            XmlNodeList descriptions = xmlWithDocType.SelectNodes("//Description");
            foreach (XmlNode description in descriptions)
            {
                if (description.Attributes["xml:lang"] == null)
                {
                    XmlAttribute att = xmlWithDocType.CreateAttribute("xml:lang");
                    att.Value = "en";
                    description.Attributes.Append(att);
                }
            }

            /* ################################ Check all telephonenumber blocks ############################# */
            XmlNodeList telephoneNumbers = xmlWithDocType.SelectNodes("//TelephoneNumber");
            foreach (XmlNode telephoneNumber in telephoneNumbers)
            {
                if (telephoneNumber.SelectSingleNode("CountryCode") == null)
                {
                    XmlNode countryCode = xmlWithDocType.CreateElement("CountryCode");
                    XmlElement countryElement = (XmlElement)countryCode;
                    countryElement.SetAttribute("isoCountryCode", "");
                    telephoneNumber.InsertBefore(countryCode, telephoneNumber.FirstChild);
                }
            }

            /* ################################ Check all telephonenumber blocks ############################# */
            XmlNodeList ItemOuts = xmlWithDocType.SelectNodes("//ItemOut");
            foreach (XmlNode ItemOut in ItemOuts)
            {
                if (ItemOut.SelectSingleNode("ShipTo") != null)
                {
                    XmlNode shipTo = ItemOut.SelectSingleNode("ShipTo");
                    ItemOut.RemoveChild(shipTo);
                }
            }

            return xmlWithDocType;
        }

        private XmlDocument modifyShippingBlock(XmlDocument cXML, string vendor)
        {
            if (vendor == "VWR")
            {
                XmlNode shipToAddressID = cXML.SelectSingleNode("//ShipTo/Address/@addressID");
                XmlNode shipToName = cXML.SelectSingleNode("//ShipTo/Address/Name");
                XmlNode shipToDeliverTo = cXML.SelectSingleNode("//ShipTo/Address/PostalAddress/DeliverTo");

                string shipToAddressIDValue = shipToAddressID.InnerXml;
                string shipToNameValue = shipToName.InnerXml;

                shipToAddressID.Value = "JSA1";
                shipToName.InnerXml = shipToDeliverTo.InnerXml;
                shipToDeliverTo.InnerXml = shipToNameValue;
            }

            return cXML;

        }

        private string RemoveXMLNamespace(string response)
        {
            string filter = @"xmlns(:\w+)?=""([^""]+)""|xsi(:\w+)?=""([^""]+)""";
            response = Regex.Replace(response, filter, "");
            filter = @"\</ns\d{1,}\:";
            response = Regex.Replace(response, filter, @"</");
            filter = @"\<ns\d{1,}\:";
            response = Regex.Replace(response, filter, @"<");

            return response;
        }
    }
}
