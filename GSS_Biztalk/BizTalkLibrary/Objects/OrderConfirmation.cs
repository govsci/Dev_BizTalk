using System.Collections.Generic;

namespace BizTalkLibrary.Objects
{
    public class OrderConfirmationHeader
    {
        public OrderConfirmationHeader()
        {
            CxmlCredentials = new Credentials();
            Contacts = new List<Address>();
            Extrinsics = new List<string>();
            Emails = new List<string>();
            Lines = new List<OrderConfirmationLine>();

            ConfirmID = OrderID = OrderDate = Timestamp = DeploymentMode = Operation = Type = NoticeDate = Total = PayloadID = "";
        }

        public Credentials CxmlCredentials { get; set; }
        public string ConfirmID { get; set; }
        public string OrderID { get; set; }
        public string OrderDate { get; set; }
        public string Timestamp { get; set; }
        public string DeploymentMode { get; set; }
        public string Operation { get; set; }
        public string Type { get; set; }
        public string NoticeDate { get; set; }
        public string Total { get; set; }
        public string PayloadID { get; set; }

        public List<Address> Contacts { get; set; }
        public List<string> Extrinsics { get; set; }
        public List<string> Emails { get; set; }
        public List<OrderConfirmationLine> Lines { get; set; }
    }

    public class OrderConfirmationLine
    {
        public OrderConfirmationLine()
        {
            LineNumber = Quantity = UnitOfMeasure = ConfirmedUnitOfMeasure = ConfirmedQuantity = ShipmentDate =
                DeliveryDate = ItemType = SupplierPartID = Description = TaxAmount = ShippingDescription = Comments = "";
            Extrinsics = new List<string>();
            ShipTo = new Address();
            Contacts = new List<Address>();
        }

        public string LineNumber { get; set; }
        public string Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public string ConfirmedUnitOfMeasure { get; set; }
        public string ConfirmedQuantity { get; set; }
        public string ConfirmationType { get; set; }
        public string ShipmentDate { get; set; }
        public string DeliveryDate { get; set; }
        public string ItemType { get; set; }
        public string SupplierPartID { get; set; }
        public string UnitPrice { get; set; }
        public string ConfirmedUnitPrice { get; set; }
        public string Description { get; set; }
        public List<string> Extrinsics { get; set; }
        public Address ShipTo { get; set; }
        public List<Address> Contacts { get; set; }
        public string TaxAmount { get; set; }
        public string ShippingDescription { get; set; }
        public string Comments { get; set; }
    }
}
