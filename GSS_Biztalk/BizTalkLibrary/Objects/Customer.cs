namespace BizTalkLibrary.Objects
{
    public class Customer
    {
        public Customer()
        {
            ImportSo = OrderConfirmation = BypassPo = Parent = 0;
            OrganizationDesc = "";
            CxmlCredentials = new Credentials();
        }

        public int ImportSo { get; set; }
        public int OrderConfirmation { get; set; }
        public int BypassPo { get; set; }
        public int Parent { get; set; }
        public string OrganizationDesc { get; set; }
        public Credentials CxmlCredentials { get; set; }

        public string SellToCustomerNo { get; }
        public string EncryptionKey { get; }
        public string FTP_Server { get; }
        public string FTP_Port { get; }
        public string FTP_Username { get; }
        public string FTP_Password { get; }
        public string ConnectionMethod { get; }
        public string SQL_Condition { get; }
        public string Schedule { get; }
        public string FileExtension { get; }
        public string FTP_Folder { get; }
        public int ShipHeader { get; }
        public int NegativeQty { get; }
        public string CxmlDocumentType { get; }
        public string Credit_Memo_Org_Inv_Reference { get; }
        public string MasterAgreementReference { get; }
        public string TextDelimiter { get; }
        public string CsvString { get; set; }
        public string CsvFileName { get; set; }
        public string FTP_HostKey { get; set; }
    }
}
