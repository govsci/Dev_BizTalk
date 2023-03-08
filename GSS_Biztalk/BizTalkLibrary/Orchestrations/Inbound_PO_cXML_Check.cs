using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using BizTalkLibrary.Classes;
using BizTalkLibrary.Objects;

namespace BizTalkLibrary.Orchestrations
{
    public class Inbound_PO_cXML_Check
    {
        public Inbound_PO_cXML_Check(XmlDocument cXML, string timestamp, string orderID)
        {
            Constants.F1 setValue = x => x == null ? "" : x.InnerXml;
            Global.CreateDump(Constants.DUMP_FOLDERS.IN_PO_CHECKED, orderID, timestamp, cXML, true);
            Credentials creds = Global.GetCredentials(cXML);

            string dumpFolder = Database.ValidateCustomerPoCreds(creds.FromIdentity, creds.SharedSecret);
            if (dumpFolder.Length > 0)
            {
                string type = setValue(cXML.SelectSingleNode("//OrderRequestHeader/@type"));
                if (type.ToUpper() == "DELETE")
                {
                    Global.CreateDump(Constants.DUMP_FOLDERS.IN_PO_CANCELLED, orderID, timestamp, cXML, true);
                    string comments = setValue(cXML.SelectSingleNode("//OrderRequestHeader/Comments"));
                    MailNotification.SendOrderCancellationNotice(orderID, comments);
                }
                else if (!Global.CustomerPoDupCheck(cXML))
                    ProcessCustomerPoLog(cXML, timestamp, orderID, dumpFolder);
            }
            else
            {
                Global.CreateDump(Constants.DUMP_FOLDERS.IN_PO_FAILED, $"{orderID}.Check", timestamp, cXML, true);
            }
        }

        public static void ProcessCustomerPoLog(XmlDocument xml, string timestamp, string orderId, string dumpFolder)
        {
            if (dumpFolder.Length > 0 && dumpFolder != "PASS")
                Global.CreateDump(dumpFolder, orderId, timestamp, xml, false);
            else
            {
                CheckCxmlForMissingPartNumbers(ref xml);
                Global.CreateDump(Constants.DUMP_FOLDERS.PORT_RECEIVE_CXML_PO_PROCESS, orderId, timestamp, xml, false);
            }
        }

        public static void CheckCxmlForMissingPartNumbers(ref XmlDocument cXML)
        {
            Constants.F1 setValue = x => x == null ? "" : x.InnerXml.Replace("'", "''");

            XmlNodeList lines = cXML.SelectNodes("//ItemOut");

            string partNumber, mfcPartID;

            foreach (XmlNode i in lines)
            {
                partNumber = setValue(i.SelectSingleNode("ItemID/SupplierPartID"));
                mfcPartID = setValue(i.SelectSingleNode("ItemDetail/ManufacturerPartID"));

                if (partNumber == "") i.SelectSingleNode("ItemID/SupplierPartID").InnerXml = mfcPartID;
            }
        }
    }
}
