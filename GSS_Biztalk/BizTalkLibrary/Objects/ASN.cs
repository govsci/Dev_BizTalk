using System.Collections.Generic;

namespace BizTalkLibrary.Objects
{
    public class ASN_Header
    {
        public ASN_Header()
        {
            Credentials = new Credentials();
            ShipmentID = NoticeDate = OrderDate = ShipmentDate = DeliveryDate = CarrierIdentifier =
                CarrierIdentifierDomain = ShipmentIdentifier = OrderID = PayloadID = Timestamp = DeploymentMode = Operation = Type = "";
            Contacts = new List<Address>();
            Lines = new List<ASN_Line>();
            Extrinsics = new List<string>();
        }

        public Credentials Credentials { get; set; }
        public string ShipmentID { get; set; }
        public string NoticeDate { get; set; }
        public string OrderDate { get; set; }
        public string ShipmentDate { get; set; }
        public string DeliveryDate { get; set; }
        public string CarrierIdentifier { get; set; }
        public string CarrierIdentifierDomain { get; set; }
        public string ShipmentIdentifier { get; set; }
        public string OrderID { get; set; }
        public string PayloadID { get; set; }
        public string Timestamp { get; set; }
        public string DeploymentMode { get; set; }
        public string Operation { get; set; }
        public string Type { get; set; }

        public List<Address> Contacts { get; set; }
        public List<ASN_Line> Lines { get; set; }
        public List<string> Extrinsics { get; set; }
    }

    public class ASN_Line
    {
        public ASN_Line()
        {
            LineNumber = Quantity = UnitOfMeasure = ShipLine = DeliveryDate = ShipmentDate = "";
        }

        public string LineNumber { get; set; }
        public string Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public string ShipLine { get; set; }
        public string DeliveryDate { get; set; }
        public string ShipmentDate { get; set; }

    }
}
