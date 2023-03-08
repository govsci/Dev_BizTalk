using System;
using System.Xml;

namespace BizTalkLibrary.Objects
{
    public struct XMLItemBlock : IComparable
    {
        private string vendorName;
        private string qty;
        private string price;
        private double total;
        private XmlNode x;

        public XMLItemBlock(string v, string i, string q, XmlNode n)
        {
            vendorName = v;
            price = i;
            qty = q;
            x = n;
            total = Convert.ToDouble(price) * int.Parse(qty.Replace(".0", ""));
        }

        public override string ToString()
        {
            return vendorName + ":" + price + ":" + qty + ":" + total;// +x.InnerXml;
        }

        public double GetTotal()
        {
            return total;
        }

        public XmlNode ToNode()
        {
            return x;
        }

        public string ToNodeToString()
        {
            return x.OuterXml;
        }

        public string GetVendorCode()
        {
            return vendorName;
        }

        public int CompareTo(object obj)
        {
            XMLItemBlock c = (XMLItemBlock)obj;
            return String.Compare(vendorName, c.vendorName);
        }
    }
}
