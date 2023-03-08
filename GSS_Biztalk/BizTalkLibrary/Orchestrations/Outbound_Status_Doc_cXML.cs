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
    public class Outbound_Status_Doc_cXML
    {
        public Outbound_Status_Doc_cXML(XmlDocument xml, string key, string timestamp)
        {
            switch (Global.IsWhatTypeOfDocument(xml))
            {
                case "ASN":
                    Global.CreateDump(Constants.DUMP_FOLDERS.OUT_STATUS_OUTGOING_ASN, key, timestamp, xml, true);
                    ASN_Header asn = Global.ExtractAsn(xml);
                    if (asn != null)
                    {
                        Database.UploadVendorAsn(asn, "Outbound");
                    }
                    break;
                case "INVOICE":
                    Global.CreateDump(Constants.DUMP_FOLDERS.OUT_STATUS_OUTGOING_INVOICE, key, timestamp, xml, true);
                    InvoiceHeader invoice = Global.ExtractInvoice(xml);
                    if (invoice != null)
                    {
                        Database.UploadInvoice(invoice, "Outbound");
                    }
                    break;
                case "ORDERCONFIRMATION":
                    Global.CreateDump(Constants.DUMP_FOLDERS.OUT_STATUS_OUTGOING_ORDERCONFIRMATION, key, timestamp, xml, true);
                    OrderConfirmationHeader orderConfirm = Global.ExtractOrderConfirmation(xml);
                    if (orderConfirm != null)
                    {
                        Database.UploadVendorOrderConfirmation(orderConfirm, "Outbound");
                    }
                    break;
                default:
                    Global.CreateDump(Constants.DUMP_FOLDERS.IN_STATUS_PROCESSED_UNKNOWN, key, timestamp, xml, true);
                    break;
            }
        }

        
    }
}
