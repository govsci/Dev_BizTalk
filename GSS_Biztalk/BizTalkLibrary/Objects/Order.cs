using System;
using System.Collections.Generic;
using BizTalkLibrary.Classes;

namespace BizTalkLibrary.Objects
{
    public class OrderHeader
    {
        public OrderHeader()
        {
            Lines = new List<OrderLine>();
            expedite = false;
            id = customerID = identifier = orderCOnfirmation = OCTemplate = type = mode = identity = date = orderID = total = extrinsics =
                timestamp = fileInfo = comments = salespersonName = salespersonPhone = salespersonEmail = salesTeamEmail =
                salesTeamPhoneNo = subjectPrefix = memberOf = orderEmailTo = extraComments = payloadID = deploymentMode = requisitionID = 
                purchReqNumber = navSellToCustomerNo = navSalesTeamColor = quoteNumber = customerPoNo = paymentTerms = 
                notes = bpaNumber = "";
            extrinsicOptions = 0;
            taxCharged = 0.0M;
            ShipToAddress = new Address();
            BillToAddress = new Address();
            CxmlCredentials = new Credentials();
            PCard = new Payment();
            requestedDeliveryDate = Constants.NAVISION_DEFAULT_DATETIME_VALUE;
            Attachments = "";
        }

        public string id { get; set; }
        public string customerID { get; set; }
        public string identifier { get; set; }
        public string orderCOnfirmation { get; set; }
        public string OCTemplate { get; set; }
        public string type { get; set; }
        public string mode { get; set; }
        public string identity { get; set; }
        public string date { get; set; }
        public string orderID { get; set; }
        public string total { get; set; }
        public Address ShipToAddress { get; set; }
        public Address BillToAddress { get; set; }
        public string extrinsics { get; set; }
        public string timestamp { get; set; }
        public string fileInfo { get; set; }
        public string comments { get; set; }
        public string salespersonName { get; set; }
        public string salespersonPhone { get; set; }
        public string salespersonEmail { get; set; }
        public string salesTeamEmail { get; set; }
        public string salesTeamPhoneNo { get; set; }
        public string subjectPrefix { get; set; }
        public string memberOf { get; set; }
        public string orderEmailTo { get; set; }
        public string extraComments { get; set; }
        public bool expedite { get; set; }
        public string payloadID { get; set; }
        public string deploymentMode { get; set; }
        public string requisitionID { get; set; }
        public string purchReqNumber { get; set; }
        public string navSellToCustomerNo { get; set; }
        public string navSalesTeamColor { get; set; }
        public string quoteNumber { get; set; }
        public string customerPoNo { get; set; }
        public string paymentTerms { get; set; }
        public DateTime requestedDeliveryDate { get; set; }
        public string notes { get; set; }
        public string bpaNumber { get; set; }
        

        public int extrinsicOptions { get; set; }
        public decimal taxCharged { get; set; }
        public Credentials CxmlCredentials { get; set; }
        public Payment PCard { get; set; }

        public List<OrderLine> Lines { get; set; }
        public string Attachments { get; set; }
    }

    public class OrderLine
    {
        public OrderLine()
        {
            unitPrice = quantity = extendedPrice = 0.0m;
            manufacturerName = supplierPartAuxiliaryID = supplierPartID = description = unitOfMeasure = 
                extra = gssPartNumber = originalUnitOfMeasure = classification = classificationDomain =
                manufacturerPartID = vendorCode = quoteNumber = unitCostStr = altNumber = "";
            lineNumber = 0;
            requestedDeliveryDate = Constants.NAVISION_DEFAULT_DATETIME_VALUE;
        }
        
        public OrderLine(decimal unit, decimal quan, string manuName, string partid, string descr, string uom, string auxpartid, string ext)
        {
            unitPrice = unit;
            quantity = quan;
            extendedPrice = unit * quan;
            manufacturerName = manuName;
            supplierPartID = partid;
            description = descr;
            unitOfMeasure = uom;
            supplierPartAuxiliaryID = auxpartid;
            extra = ext;
        }

        public int lineNumber { get; set; }
        public decimal unitPrice { get; set; }
        public decimal quantity { get; set; }
        public decimal extendedPrice { get; set; }
        public string manufacturerName { get; set; }
        public string vendorCode { get; set; }
        public string manufacturerPartID { get; set; }
        public string supplierPartID { get; set; }
        public string description { get; set; }
        public string unitOfMeasure { get; set; }
        public string supplierPartAuxiliaryID { get; set; }
        public string extra { get; set; }
        public string gssPartNumber { get; set; }
        public string originalUnitOfMeasure { get; set; }
        public string classificationDomain { get; set; }
        public string classification { get; set; }
        public string quoteNumber { get; set; }
        public string unitCostStr { get; set; }
        public DateTime requestedDeliveryDate { get; set; }
        public string altNumber { get; set; }
    }
}
