namespace BizTalkLibrary.Objects
{
    public class Payment
    {
        public Payment()
        {
            Number = Name = Expiration = "";
        }

        public string Number { get; set; }
        public string Name { get; set; }
        public string Expiration { get; set; }
    }
}
