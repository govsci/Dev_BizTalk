namespace BizTalkLibrary.Objects
{
    public class PhoneObject
    {
        public PhoneObject()
        {
            Name = AreaCode = Number = CountryCode = Country = Extension = "";
        }

        public string Name { get; set; }
        public string AreaCode { get; set; }
        public string Number { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string Extension { get; set; }
    }
}
