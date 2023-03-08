using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using BizTalkLibrary.Objects;
using BizTalkLibrary.Classes;

namespace BizTalkLibrary.Orchestrations
{
    public class Inbound_Status_Doc_cXML_Process
    {
        public Inbound_Status_Doc_cXML_Process(XmlDocument xml, string timestamp, string key)
        {
            switch (Global.IsWhatTypeOfDocument(xml))
            {
                case "ASN":
                    Global.CreateDump(Constants.DUMP_FOLDERS.IN_STATUS_PROCESSED_ASN, key, timestamp, xml, true);
                    ASN_Header asn = Global.ExtractAsn(xml);
                    if (asn != null)
                    {
                        MailNotification.SendVendorAsn(asn);
                        Database.UploadVendorAsn(asn, "Inbound");
                    }
                    break;
                case "INVOICE":
                    Global.CreateDump(Constants.DUMP_FOLDERS.IN_STATUS_PROCESSED_INVOICE, key, timestamp, xml, true);
                    InvoiceHeader invoice = Global.ExtractInvoice(xml);
                    if (invoice != null)
                        Database.UploadInvoice(invoice, "Inbound");
                    break;
                case "ORDERCONFIRMATION":
                    Global.CreateDump(Constants.DUMP_FOLDERS.IN_STATUS_PROCESSED_ORDERCONFIRMATION, key, timestamp, xml, true);
                    OrderConfirmationHeader oc = Global.ExtractOrderConfirmation(xml);
                    if (oc != null)
                    {
                        MailNotification.SendVendorOC(oc);
                        Database.UploadVendorOrderConfirmation(oc, "Inbound");
                    }
                    break;
                default:
                    Global.CreateDump(Constants.DUMP_FOLDERS.IN_STATUS_PROCESSED_UNKNOWN, key, timestamp, xml, true);
                    break;
            }
        }
    }
}
