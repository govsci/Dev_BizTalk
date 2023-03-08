namespace BizTalkLibrary.Objects
{
    public class AutoResponder
    {
        public AutoResponder(string header, string footer, string style, string subject, string bodystyle, string body, string cart)
        {
            Header = header;
            Footer = footer;
            Style = style;
            Subject = subject;
            BodyStyle = bodystyle;
            Body = body;
            Cart = cart;
        }

        public string Header { get; set; }
        public string Footer { get; set; }
        public string Style { get; set; }
        public string Subject { get; set; }
        public string BodyStyle { get; set; }
        public string Body { get; set; }
        public string Cart { get; set; }
    }
}
