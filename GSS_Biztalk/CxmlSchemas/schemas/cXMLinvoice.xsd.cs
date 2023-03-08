namespace CxmlSchemas.schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"cXML_Invoice")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"cXML_Invoice"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CxmlSchemas.schemas.xml", typeof(global::CxmlSchemas.schemas.xml))]
    public sealed class cXMLinvoice : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""CxmlSchemas.schemas.xml"" namespace=""http://www.w3.org/XML/1998/namespace"" />
  <xs:annotation>
    <xs:appinfo>
      <schemaInfo root_reference=""cXML_Invoice"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" document_type=""http://xml.cxml.org/schemas/cXML/1.1.010/cXML.dtd"" version=""1.1.010"" is_envelope=""no"" />
      <b:references>
        <b:reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""cXML_Invoice"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Header"" />
        <xs:element ref=""Request"" />
      </xs:sequence>
      <xs:attribute name=""payloadID"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""timestamp"" type=""xs:NMTOKEN"" use=""required"" />
      <xs:attribute name=""version"" type=""xs:decimal"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Header"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""From"" />
        <xs:element ref=""To"" />
        <xs:element ref=""Sender"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""From"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Credential"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""To"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" ref=""Credential"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Sender"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Credential"" />
        <xs:element ref=""UserAgent"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""UserAgent"" type=""xs:string"" />
  <xs:element name=""Request"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""InvoiceDetailRequest"" />
      </xs:sequence>
      <xs:attribute name=""deploymentMode"" type=""xs:NCName"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceDetailRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""InvoiceDetailRequestHeader"" />
        <xs:choice>
          <xs:element maxOccurs=""unbounded"" ref=""InvoiceDetailHeaderOrder"" />
          <xs:element maxOccurs=""unbounded"" ref=""InvoiceDetailOrder"" />
        </xs:choice>
        <xs:element ref=""InvoiceDetailSummary"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceDetailRequestHeader"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""InvoiceDetailHeaderIndicator"" />
        <xs:element ref=""InvoiceDetailLineIndicator"" />
        <xs:sequence minOccurs=""0"">
          <xs:element maxOccurs=""unbounded"" ref=""InvoicePartner"" />
          <xs:element maxOccurs=""unbounded"" ref=""InvoiceDetailShipping"" />
          <xs:element maxOccurs=""unbounded"" ref=""InvoiceDetailPaymentTerm"" />
        </xs:sequence>
      </xs:sequence>
      <xs:attribute name=""invoiceDate"" type=""xs:NMTOKEN"" use=""required"" />
      <xs:attribute name=""invoiceID"" type=""xs:integer"" use=""required"" />
      <xs:attribute name=""operation"" type=""xs:NCName"" use=""required"" />
      <xs:attribute name=""purpose"" type=""xs:NCName"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceDetailHeaderIndicator"">
    <xs:complexType>
      <xs:attribute name=""isHeaderInvoice"" type=""xs:NCName"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceDetailLineIndicator"">
    <xs:complexType>
      <xs:attribute name=""isAccountingInLine"" type=""xs:NCName"" />
      <xs:attribute name=""isShippingInLine"" type=""xs:NCName"" />
      <xs:attribute name=""isTaxInLine"" type=""xs:NCName"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoicePartner"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Contact"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""IdReference"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""IdReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Creator"" />
      </xs:sequence>
      <xs:attribute name=""domain"" type=""xs:NCName"" use=""required"" />
      <xs:attribute name=""identifier"" type=""xs:NMTOKEN"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Creator"">
    <xs:complexType mixed=""true"">
      <xs:attribute ref=""xml:lang"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceDetailPaymentTerm"">
    <xs:complexType>
      <xs:attribute name=""payInNumberOfDays"" type=""xs:integer"" use=""required"" />
      <xs:attribute name=""percentageRate"" type=""xs:integer"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceDetailHeaderOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""InvoiceDetailOrderInfo"" />
        <xs:element ref=""InvoiceDetailOrderSummary"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceDetailOrderSummary"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""SubtotalAmount"" />
      </xs:sequence>
      <xs:attribute name=""invoiceLineNumber"" type=""xs:integer"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceDetailOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""InvoiceDetailOrderInfo"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""InvoiceDetailItem"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceDetailItem"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""UnitOfMeasure"" />
        <xs:element ref=""UnitPrice"" />
        <xs:element ref=""InvoiceDetailItemReference"" />
        <xs:element ref=""SubtotalAmount"" />
        <xs:element ref=""Tax"" />
        <xs:element ref=""InvoiceDetailLineShipping"" />
        <xs:element ref=""GrossAmount"" />
        <xs:element ref=""NetAmount"" />
        <xs:element maxOccurs=""unbounded"" ref=""Distribution"" />
      </xs:sequence>
      <xs:attribute name=""invoiceLineNumber"" type=""xs:integer"" use=""required"" />
      <xs:attribute name=""quantity"" type=""xs:integer"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""UnitOfMeasure"" type=""xs:NCName"" />
  <xs:element name=""UnitPrice"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceDetailItemReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ItemID"" />
        <xs:element ref=""Description"" />
      </xs:sequence>
      <xs:attribute name=""lineNumber"" type=""xs:integer"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""ItemID"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""SupplierPartID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SupplierPartID"" type=""xs:NMTOKEN"" />
  <xs:element name=""InvoiceDetailLineShipping"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""InvoiceDetailShipping"" />
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceDetailShipping"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" ref=""Contact"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Distribution"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Accounting"" />
        <xs:element ref=""Charge"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Accounting"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""AccountingSegment"" />
      </xs:sequence>
      <xs:attribute name=""name"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""AccountingSegment"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Name"" />
        <xs:element ref=""Description"" />
      </xs:sequence>
      <xs:attribute name=""id"" type=""xs:NCName"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Charge"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceDetailSummary"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""SubtotalAmount"" />
        <xs:element ref=""Tax"" />
        <xs:sequence minOccurs=""0"">
          <xs:element ref=""ShippingAmount"" />
          <xs:element ref=""GrossAmount"" />
        </xs:sequence>
        <xs:element ref=""NetAmount"" />
        <xs:element ref=""DueAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ShippingAmount"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DueAmount"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Credential"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Identity"" />
        <xs:element minOccurs=""0"" ref=""SharedSecret"" />
      </xs:sequence>
      <xs:attribute name=""domain"" type=""xs:NCName"" use=""required"" />
      <xs:attribute name=""type"" type=""xs:NCName"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Identity"" type=""xs:string"" />
  <xs:element name=""SharedSecret"" type=""xs:NCName"" />
  <xs:element name=""Contact"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Name"" />
        <xs:element ref=""PostalAddress"" />
        <xs:element ref=""Email"" />
        <xs:element ref=""Phone"" />
        <xs:element minOccurs=""0"" ref=""Fax"" />
      </xs:sequence>
      <xs:attribute name=""addressID"" type=""xs:NMTOKEN"" use=""required"" />
      <xs:attribute name=""role"" type=""xs:NCName"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""PostalAddress"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""DeliverTo"" />
        <xs:element ref=""Street"" />
        <xs:element ref=""City"" />
        <xs:element ref=""State"" />
        <xs:element ref=""PostalCode"" />
        <xs:element ref=""Country"" />
      </xs:sequence>
      <xs:attribute name=""name"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""DeliverTo"" type=""xs:string"" />
  <xs:element name=""Street"" type=""xs:string"" />
  <xs:element name=""City"" type=""xs:string"" />
  <xs:element name=""State"" type=""xs:NCName"" />
  <xs:element name=""PostalCode"" type=""xs:integer"" />
  <xs:element name=""Country"">
    <xs:complexType mixed=""true"">
      <xs:attribute name=""isoCountryCode"" type=""xs:NCName"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Email"">
    <xs:complexType mixed=""true"">
      <xs:attribute name=""name"" type=""xs:NCName"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Phone"">
    <xs:complexType>
      <xs:complexContent mixed=""false"">
        <xs:extension base=""TelephoneNumber"">
          <xs:attribute name=""name"" type=""xs:NCName"" use=""required"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Fax"">
    <xs:complexType>
      <xs:complexContent mixed=""false"">
        <xs:extension base=""TelephoneNumber"">
          <xs:attribute name=""name"" type=""xs:NCName"" use=""required"" />
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceDetailOrderInfo"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""OrderReference"" />
        <xs:element ref=""MasterAgreementReference"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OrderReference"" type=""DocumentReference"" />
  <xs:element name=""MasterAgreementReference"" type=""DocumentReference"" />
  <xs:element name=""SubtotalAmount"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Money"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:integer"">
          <xs:attribute name=""currency"" type=""xs:NCName"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Description"">
    <xs:complexType mixed=""true"">
      <xs:attribute ref=""xml:lang"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Tax"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
        <xs:element ref=""Description"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""TaxDetail"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxDetail"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""TaxableAmount"" />
        <xs:element ref=""TaxAmount"" />
        <xs:element minOccurs=""0"" ref=""TaxLocation"" />
      </xs:sequence>
      <xs:attribute name=""category"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""percentageRate"" type=""xs:integer"" use=""required"" />
      <xs:attribute name=""purpose"" type=""xs:NCName"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxableAmount"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxAmount"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxLocation"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:NCName"">
          <xs:attribute ref=""xml:lang"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""GrossAmount"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""NetAmount"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Name"">
    <xs:complexType mixed=""true"">
      <xs:attribute ref=""xml:lang"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""TelephoneNumber"">
    <xs:sequence>
      <xs:element ref=""TelephoneNumber"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""TelephoneNumber"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""CountryCode"" />
        <xs:element ref=""AreaOrCityCode"" />
        <xs:element ref=""Number"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CountryCode"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:integer"">
          <xs:attribute name=""isoCountryCode"" type=""xs:NCName"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AreaOrCityCode"" type=""xs:integer"" />
  <xs:element name=""Number"" type=""xs:integer"" />
  <xs:complexType name=""DocumentReference"">
    <xs:sequence>
      <xs:element ref=""DocumentReference"" />
    </xs:sequence>
    <xs:attribute name=""orderID"" type=""xs:string"" />
  </xs:complexType>
  <xs:element name=""DocumentReference"">
    <xs:complexType>
      <xs:attribute name=""payloadID"" type=""xs:NMTOKEN"" use=""required"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public cXMLinvoice() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "cXML_Invoice";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
