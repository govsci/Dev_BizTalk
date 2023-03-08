using System.Collections.Generic;

namespace BizTalkLibrary.Objects
{
    public class SalesQuoteHeader
    {
        public SalesQuoteHeader()
        {
            ContactName = ContactEmail = "";
            QuoteLines = new List<SalesQuoteLine>();
        }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public List<SalesQuoteLine> QuoteLines { get; set; }
    }

    public class SalesQuoteLine
    {
        public SalesQuoteLine()
        {
            Quantity = No_ = Unit_Price = Description = Unit_Of_Measure_Code = Unit_Cost_LCY = "";
            Line_No = 0;
        }

        public string Quantity { get; set; }
        public string No_ { get; set; }
        public string Unit_Price { get; set; }
        public string Description { get; set; }
        public string Unit_Of_Measure_Code { get; set; }
        public string Unit_Cost_LCY { get; set; }
        public int Line_No { get; set; }
    }
}
