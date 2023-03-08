using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BizTalkLibrary.Classes
{
    public static class Constants
    {
        public static bool DEBUG = true;
        public static string systemEmail = "ecommercesystem@govsci.com";
        public static string adminEmail = "gss-it-development@govsci.com";

        public static string EcommerceConnection = "Data Source=TST-ECOM-DB;Initial Catalog=TST-ECOM-DB;Integrated Security=SSPI;MultipleActiveResultSets=true;Asynchronous Processing=true;";
        public static string NavConnection = "Data Source=TST-NAV-DB;Initial Catalog=GSS;Integrated Security=SSPI;MultipleActiveResultSets=true;Asynchronous Processing=true;";

        public static string LogFolder = @"R:\logs\";

        public static string PDF_Path = $@"R:\documents\OUT\Status\Created\OrderAcknowledgement\{DateTime.Now.ToString("yyyy")}\{DateTime.Now.ToString("MM")}\{DateTime.Now.ToString("dd")}\";
        public static string PicturesPath = @"R:\documents\pictures\";

        public static string WebColumnSplit = "<COL_S|>";
        public static string WebRowSplit = "<ROW_S|>";

        public static int maxDeliveryToLength = 25;
        public static int MAX_PARTNUMBER_LENGTH = 15;
        public static int MAX_VENDORPARTNUMBER_LENGTH = 20;
        public static int MAX_DESCRIPTION_LENGTH = 50;
        public static int MAX_UNSPSC_CODE_LENGTH = 8;
        public static int MAX_CONTACTNAME_LENGTH = 20;
        public static int MAX_NAME_LENGTH = 50;

        public static string NAVISION_SHIPPING_GLCODE = "42100";
        public static string NAVISION_SHIPPING_GLCODE_PREPAY = "42110";
        public static string NAVISION_SHIPPING_GLCODE_FEDERAL_EXCISE_TAX = "42150";
        public static string NAVISION_SHIPPING_GLCODE_SHIPPING_EXPEDITED_DELIVERY = "42140";
        public static string NAVISION_SHIPPING_GLCODE_UNISON = "69250";
        public static DateTime NAVISION_DEFAULT_DATETIME_VALUE = new DateTime(1753, 1, 1);

        [Serializable]
        public class CXML_PO_TYPE
        {
            public const string BYPASS = "BYPASS";
            public const string NAV = "NAV";

            public string ReturnBypass()
            {
                return BYPASS;
            }

            public string ReturnNav()
            {
                return NAV;
            }
        }

        [Serializable]
        public class DUMP_FOLDERS
        {
            public const string UndefinedDirectory = @"R:\documents\Undefined\";

            public const string IN_PO_ARRIVED = @"R:\documents\IN\PO\Arrived\";
            public const string IN_PO_RESPONSE = @"R:\documents\IN\PO\Response\";
            public const string IN_PO_CHECKED = @"R:\documents\IN\PO\Checked\";
            public const string IN_PO_CANCELLED = @"R:\documents\IN\PO\Cancelled\";
            public const string IN_PO_FAILED = @"R:\documents\IN\PO\Failed\";
            public const string IN_PO_RETRY = @"R:\documents\IN\PO\Retry\";
            public const string IN_PO_IMPORTED = @"R:\documents\IN\PO\Imported\";
            public const string IN_PO_PROCESSED = @"R:\documents\IN\PO\Processed\";

            public const string IN_STATUS_ARRIVED = @"R:\documents\IN\Status\Arrived\";
            public const string IN_STATUS_FAILED = @"R:\documents\IN\Status\Failed\";
            public const string IN_STATUS_RESPONSE = @"R:\documents\IN\Status\Response\";
            public const string IN_STATUS_PROCESSED_INCOMING = @"R:\documents\IN\Status\Processed\Incoming\";
            public const string IN_STATUS_PROCESSED_INVOICE = @"R:\documents\IN\Status\Processed\Invoice\";
            public const string IN_STATUS_PROCESSED_ASN = @"R:\documents\IN\Status\Processed\ASN\";
            public const string IN_STATUS_PROCESSED_ORDERCONFIRMATION = @"R:\documents\IN\Status\Processed\OrderConfirmation\";
            public const string IN_STATUS_PROCESSED_UNKNOWN = @"R:\documents\IN\Status\Unknown\";

            public const string OUT_PO_CREATED = @"R:\documents\OUT\PO\Created\";
            public const string OUT_PO_ARRIVED = @"R:\documents\OUT\PO\Arrived\";
            public const string OUT_PO_CONFIRMED = @"R:\documents\OUT\PO\Confirmed\";
            public const string OUT_PO_DEBUG = @"R:\documents\OUT\PO\Debug\";
            public const string OUT_PO_FAILED = @"R:\documents\OUT\PO\Failed\";
            public const string OUT_PO_OUTGOING = @"R:\documents\OUT\PO\Outgoing\";
            public const string OUT_PO_SENT = @"R:\documents\OUT\PO\Sent\";
            public const string OUT_PO_SKIPPED = @"R:\documents\OUT\PO\Skipped\";

            public const string OUT_STATUS_CONFIRMED = @"R:\documents\OUT\Status\Confirmed\";
            public const string OUT_STATUS_FAILED = @"R:\documents\OUT\Status\Failed\";
            public const string OUT_STATUS_OUTGOING_ASN = @"R:\documents\OUT\Status\Outgoing\ASN\";
            public const string OUT_STATUS_OUTGOING_INVOICE = @"R:\documents\OUT\Status\Outgoing\Invoice\";
            public const string OUT_STATUS_OUTGOING_ORDERCONFIRMATION = @"R:\documents\OUT\Status\Outgoing\OrderConfirmation\";
            public const string OUT_STATUS_OUTGOING_ACKNOWLEDGEMENT = @"R:\documents\OUT\Status\Outgoing\Acknowledgement\";
            public const string OUT_STATUS_OUTGOING_UNKNOWN = @"R:\documents\OUT\Status\Outgoing\Unknown\";
            public const string OUT_STATUS_SENT = @"R:\documents\OUT\Status\Sent\";

            public const string PORT_RECEIVE_CXML_PO_CHECK = @"R:\ports\Receive_cXML_PO_Check\";
            public const string PORT_RECEIVE_CXML_PO_PROCESS = @"R:\ports\Receive_cXML_PO_Process\";
            public const string PORT_RECEIVE_CXML_PO_TO_ERP = @"R:\ports\Receive_cXML_PO_To_ERP\";
            public const string PORT_RECEIVE_CXML_STATUS_ARRIVE = @"R:\ports\Receive_cXML_Status_Process\";
            public const string PORT_RECEIVE_X12_STATUS_TO_CXML = @"R:\ports\Receive_X12_Status_To_cXML\";
            public const string PORT_SEND_CXML_BYPASS_PO_WAITING = @"R:\ports\Send_cXML_PO_Bypass_Waiting\";
            public const string PORT_SEND_CXML_BYPASS_PO = @"R:\ports\Send_cXML_PO_Bypass\";
            public const string PORT_SEND_CXML_ERP_PO = @"R:\ports\Send_cXML_PO_ERP\";
            public const string PORT_SEND_CXML_ERP_PO_TO_X12 = @"R:\ports\Send_cXML_PO_ERP_To_X12\";
            public const string PORT_SEND_CXML_PO_ERP_X12_PICKUP = @"R:\ports\Send_cXML_PO_ERP_X12_Pickup\";

            public string INBOUND_PO_FAILED() { return IN_PO_FAILED; }
            public string INBOUND_PO_ARRIVED() { return IN_PO_ARRIVED; }
            public string INBOUND_PORT_RECEIVE_CXML_PO_CHECK() { return PORT_RECEIVE_CXML_PO_CHECK; }
            public string INBOUND_PORT_RECEIVE_CXML_PO_RETRY() { return IN_PO_RETRY; }
            public string INBOUND_PO_RESPONSE() { return IN_PO_RESPONSE; }
            public string INBOUND_PO_IMPORTED() { return IN_PO_IMPORTED; }
            public string INBOUND_PO_RETRY() { return IN_PO_RETRY; }
            public string INBOUND_STATUS_PROCESSED_INCOMING() { return IN_STATUS_PROCESSED_INCOMING; }
            public string INBOUND_STATUS_FAILED() { return IN_STATUS_FAILED; }
            public string INBOUND_STATUS_ARRIVED() { return IN_STATUS_ARRIVED; }
            public string INBOUND_PORT_RECEIVE_CXML_STATUS_ARRIVE() { return PORT_RECEIVE_CXML_STATUS_ARRIVE; }
            public string INBOUND_PORT_RECEIVE_X12_STATUS_ARRIVE() { return PORT_RECEIVE_X12_STATUS_TO_CXML; }
            public string INBOUND_STATUS_RESPONSE() { return IN_STATUS_RESPONSE; }
            public string OUTBOUND_PO_FAILED() { return OUT_PO_FAILED; }
            public string OUTBOUND_PO_OUTGOING() { return OUT_PO_OUTGOING; }
            public string OUTBOUND_PO_DEBUG() { return OUT_PO_DEBUG; }
            public string OUTBOUND_PO_ARRIVED() { return OUT_PO_ARRIVED; }
            public string OUTBOUND_PORT_SEND_CXML_PO_ERP_X12_PICKUP() { return PORT_SEND_CXML_PO_ERP_X12_PICKUP; }
        }

        public delegate string F1(XmlNode x);
        public delegate decimal F3(XmlNode x);
        public delegate int F4(XmlNode x);
    }
}
