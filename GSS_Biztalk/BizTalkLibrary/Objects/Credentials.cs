namespace BizTalkLibrary.Objects
{
    public class Credentials
    {
        public Credentials()
        {
            FromDomain
                = FromIdentity
                = ToDomain
                = ToIdentity
                = SenderDomain
                = SenderIdentity
                = SharedSecret
                = UserAgent
                = Url = "";
        }
        public string FromDomain { get; set; }
        public string FromIdentity { get; set; }
        public string ToDomain { get; set; }
        public string ToIdentity { get; set; }
        public string SenderDomain { get; set; }
        public string SenderIdentity { get; set; }
        public string SharedSecret { get; set; }
        public string UserAgent { get; set; }
        public string Url { get; set; }
    }
}
