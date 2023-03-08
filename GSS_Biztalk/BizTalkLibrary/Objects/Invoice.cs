using System;
using System.Collections.Generic;

namespace BizTalkLibrary.Objects
{
    public class InvoiceHeader
    {
        public InvoiceHeader()
        {
            Roles = new List<Address>();
            Extrinsics = new List<Extrinsic>();
            Lines = new List<InvoiceLine>();
            ShipLines = new List<InvoiceLine>();
            Errors = new List<string>();
            PurchaseOrderNo = "";
            CalculatedInvoiceTotal = 0.0M;
            PurchaseOrder_LineNos = new List<int>();
            PurchaseOrderPostedInvoice = false;
            PurchaseOrderPostedReceipt = false;
            PurchaseOrderPostedTotal = 0.0M;
            BuyFromVendorNo = "";
            PO_NAV_Status = "";
            ShipType = "";
            dABatchID = "";
            PO_Found = false;
            Notes = "";
            InvoiceRetry = false;
            Document_ID = "";
            //ErrorCode = "";
            Creds = new Credentials();
        }

        public string Timestamp { get; set; }
        public string PayloadID { get; set; }
        public Credentials Creds { get; set; }
        public string InvoiceID { get; set; }
        public string Purpose { get; set; }
        public string Operation { get; set; }
        public string InvoiceDate { get; set; }

        public List<Address> Roles { get; set; }

        public string PaymentTermNumberOfDays { get; set; }
        public string PaymentTermPercentRate { get; set; }

        public List<Extrinsic> Extrinsics { get; }

        public string OrderID { get; set; }
        public string DocumentReferencePayloadID { get; set; }
        public string OrderDate { get; set; }

        public List<InvoiceLine> Lines { get; set; }
        public List<InvoiceLine> ShipLines { get; set; }

        public decimal SubTotalAmount { get; set; }
        public decimal Tax { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal DueAmount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal SpecialHandlingAmount { get; set; }
        public decimal InvoiceTotal { get; set; }
        public decimal InvoiceDetailDiscount { get; set; }
        public string TrackingNo { get; set; }

        public DateTime ReceiveDate { get; set; }
        public string PDFFileName { get; set; }
        public string Vendor { get; set; }
        public bool PO_Found { get; set; }
        public string PO_NAV_Status { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<string> Errors { get; }
        //public string ErrorCode { get; set; }
        public string PurchaseOrderNo { get; set; }
        public string BuyFromVendorNo { get; set; }
        public string BuyFromVendorName { get; set; }
        public decimal CalculatedInvoiceTotal { get; set; }
        public List<int> PurchaseOrder_LineNos { get; set; }
        public bool PurchaseOrderPostedReceipt { get; set; }
        public bool PurchaseOrderPostedInvoice { get; set; }
        public decimal PurchaseOrderPostedTotal { get; set; }
        public string ShipType { get; set; }
        public string dABatchID { get; set; }
        public bool Kwiktagged { get; set; }
        public string Notes { get; set; }
        public bool InvoiceRetry { get; set; }
        public string Document_ID { get; set; }
    }
    public class InvoiceLine
    {
        public InvoiceLine()
        {
            ShipLine = 0;
            GSS_Part_Number = "";
            PurchLine_LineNumber = 0;
        }

        public int LineNumber { get; set; }
        public decimal Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal UnitPrice { get; set; }
        public int ReferenceLineNumber { get; set; }
        public string SupplierPartID { get; set; }
        public string Description { get; set; }
        public decimal LineTotal { get; set; }
        public decimal Tax { get; set; }
        public int ShipLine { get; set; }
        public string GSS_Part_Number { get; set; }
        public int PurchLine_LineNumber { get; set; }
    }
    public class Extrinsic
    {
        public Extrinsic(string name, string value)
        {
            Name = name;
            Value = value;
        }
        public string Name { get; }
        public string Value { get; }
    }
}
