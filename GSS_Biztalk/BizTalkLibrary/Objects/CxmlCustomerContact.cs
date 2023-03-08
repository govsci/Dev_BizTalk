namespace BizTalkLibrary.Objects
{
    public class CxmlCustomerName
    {
        public CxmlCustomerName(string prfx, string fname, string lname, string mname, string suffix)
        {
            Prefix = prfx;
            FirstName = fname;
            LastName = lname;
            MiddleName = mname;
            Suffix = suffix;

            if (FirstName.Length > 0 && LastName.Length == 0)
                LastName = FirstName;
        }

        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
    }

    public class CxmlCustomerPhone
    {
        public CxmlCustomerPhone()
        {
            AreaCode = 0;
            Prefix = 0;
            Number = 0;
            InternationalPhoneNumber = "";
        }

        public int AreaCode { get; set; }
        public int Prefix { get; set; }
        public int Number { get; set; }
        public string InternationalPhoneNumber { get; set; }
    }
}
