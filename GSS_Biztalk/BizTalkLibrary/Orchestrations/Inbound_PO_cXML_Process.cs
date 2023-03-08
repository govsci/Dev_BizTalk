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
    public class Inbound_PO_cXML_Process
    {
        public Inbound_PO_cXML_Process(XmlDocument xml, string timestamp, string orderID)
        {
            xml = Global.ModifyCxml(xml);
            ProcessCustomerPo(xml, timestamp, orderID);
        }

        public static void ProcessCustomerPo(XmlDocument xml, string timestamp, string orderId)
        {
            Constants.F1 setValue = x => x == null ? "" : x.InnerXml;

            Credentials creds = Global.GetCredentials(xml);

            Global.CreateDump(Constants.DUMP_FOLDERS.IN_PO_PROCESSED, orderId, timestamp, xml, true);

            Customer customer = Database.GetCustomerConfig(creds.FromIdentity, creds.SharedSecret);
            customer.CxmlCredentials = creds;

            string manuName = "";
            Database.RecordCxmlData("PO", xml, timestamp, ref manuName);

            if (customer.ImportSo > 0)
                Global.CreateDump(Constants.DUMP_FOLDERS.PORT_RECEIVE_CXML_PO_TO_ERP, orderId, timestamp, xml, false);

            if (customer.OrderConfirmation > 0)
                MailNotification.SendOrderConfirmationEmail(timestamp);

            if (customer.BypassPo > 0)
            {
                Global.CreateDump(Constants.DUMP_FOLDERS.OUT_PO_ARRIVED, orderId, timestamp, xml, true);
                Create_Cxml bypass = new Build702Xml();
                bypass.BuildXml(xml, timestamp, customer);
            }
        }
    }
}
