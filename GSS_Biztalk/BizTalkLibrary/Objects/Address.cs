using System.Collections.Generic;

namespace BizTalkLibrary.Objects
{
    public class Address
    {
        public Address()
        {
            Streets = new List<string>();
            MultipleDeliverTos = new List<string>();
            Role = AddressID = Name = Name2 = DeliverTo = City = State = PostalCode = CountryCode = Country = EmailAddress = Contact = "";
            Phone = new PhoneObject();
            Fax = new PhoneObject();
            Contact_ID = 0;
        }

        public string Role { get; set; }
        public string AddressID { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string DeliverTo { get; set; }
        public string Contact { get; set; }
        public List<string> Streets { get; set; }
        public List<string> MultipleDeliverTos { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string EmailAddress { get; set; }
        public PhoneObject Phone { get; set; }
        public PhoneObject Fax { get; set; }
        public int Contact_ID { get; set; }
    }
}
