using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using BizTalkLibrary.Classes;

namespace BizTalkLibrary.Orchestrations
{
    [Serializable]
    public class OrchestrationFunctions
    {
        public string GetTimeStamp(DateTime value)
        {
            return Global.GetTimeStamp(value);
        }

        public string GetOrderId(XmlDocument CXML)
        {
            return Global.GetOrderId(CXML);
        }

        public string CreateDump(string root, string key, string name, XmlDocument cXML, bool folderCreate)
        {
            return Global.CreateDump(root, key, name, cXML, folderCreate);
        }

        public string GetCxmlPoResponse(XmlDocument xml, bool dup)
        {
            return Global.GetCxmlPoResponse(xml, dup);
        }

        public void sendExceptionEmail(Exception ex, string orchestration, string theclass, string function, string orderID)
        {
            Email.SendErrorMessage(ex, orchestration, theclass, function, orderID, null);
        }

        public string HasKey(XmlDocument xml)
        {
            return Global.HasKey(xml);
        }

        public XmlDocument ModifyCxml(XmlDocument cXML)
        {
            return Global.ModifyCxml(cXML, "", false);
        }

        public void ProcessCustomerPo(XmlDocument cXML, string timestamp, string orderID)
        {
            new Inbound_PO_cXML_Process(cXML, timestamp, orderID);
        }

        public void cXMLtoNavisionItemTable(XmlDocument cXML)
        {
            ERP_Item_Functions.cXMLtoNavisionItemTable(cXML);
        }

        public void CxmlToSalesOrder(XmlDocument cXML)
        {
            Inbound_PO_cXML_To_ERP.CxmlToSalesOrder(cXML);
        }

        public void ProcessIncomingStatusDocument(XmlDocument cXML, string timestamp, string key)
        {
            new Inbound_Status_Doc_cXML_Process(cXML, timestamp, key);
        }

        public void ProcessCxmlPo(XmlDocument xml, string timestamp, string poType)
        {
            new Outbound_cXML_PO(xml, timestamp, poType);
        }

        public void CheckIncomingPo(XmlDocument xml, string timestamp, string orderID)
        {
            new Inbound_PO_cXML_Check(xml, timestamp, orderID);
        }

        public string GetOrderRequestType(XmlDocument xml)
        {
            return Global.GetOrderRequestType(xml);
        }

        public string GetX12DocId(XmlDocument xml)
        {
            return Global.GetX12DocId(xml);
        }

        public string GetEdiDocumentType(XmlDocument xml)
        {
            return Global.GetEdiDocumentType(xml);
        }

        public void Create997(string timestamp, XmlDocument cXML)
        {
            Global.Create997(timestamp, cXML);
        }

        public void CreateStatusDocFromEdi(XmlDocument cXML, string type)
        {
            Global.CreateStatusDocFromEdi(cXML, type);
        }

        public string GetToIdentity(XmlDocument cXML)
        {
            return Global.GetToIdentity(cXML);
        }

        public bool CheckOutboundPoDuplicate(string orderID, string vendorURL)
        {
            return Database.CheckOutboundPODuplicate(orderID, vendorURL);
        }
    }
}
