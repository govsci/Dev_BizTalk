namespace BizTalkLibrary.Objects
{
    public class Vendor
    {
        public Vendor()
        {
            CxmlCredentials = new Credentials();
            ShipToCode = TlsVersion = Hash = "";
            ExpediteShippingAllowed = Active = IncludeDocType = 0;
        }
       
        public Credentials CxmlCredentials { get; set; }
        public string ShipToCode { get; set; }
        public int ExpediteShippingAllowed { get; set; }
        public int Active { get; set; }
        public string TlsVersion { get; set; }
        public string Hash { get; set; }
        public int IncludeDocType { get; set; }
        public string HttpUserName { get; set; }
        public string HttpPassword { get; set; }
    }
}
