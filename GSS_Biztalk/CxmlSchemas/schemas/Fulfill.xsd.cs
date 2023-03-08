namespace CxmlSchemas.schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Email", @"ShipNoticeItem", @"Payment", @"PunchOutOrderMessage", @"UnitPrice", @"Address", @"OrderMethod", @"PostalCode", @"ManufacturerName", @"ItemOut", @"Distribution", @"CopyRequest", @"City", @"ConfirmationRequest", @"State", @"ConfirmationItem", @"ItemID", @"OrderReference", @"Accounting", @"Credential", @"CarrierIdentifier", @"AccountingSegment", @"OrderMethods", @"Street", @"DeliverTo", @"DigitalSignature", @"Total", @"ShipNoticeHeader", @"SupplierLocation", 
@"Segment", @"UnitOfMeasure", @"SupplierSetup", @"Supplier", @"Attachment", @"Charge", @"Classification", @"Identity", @"SupplierID", @"PunchOutOrderMessageHeader", @"Country", @"OrderRequestHeader", @"PCard", @"ConfirmationHeader", @"From", @"Money", @"ItemIn", @"Followup", @"Status", @"ShortName", @"BrowserFormPost", @"TelephoneNumber", @"ShipmentIdentifier", @"StatusUpdateRequest", @"ConfirmationStatus", @"StartPage", @"ShipTo", @"Description", @"Tax", @"SharedSecret", 
@"Response", @"Name", @"OtherOrderTarget", @"SupplierPartAuxiliaryID", @"Request", @"PunchOutSetupRequest", @"Fax", @"BuyerCookie", @"Sender", @"Shipping", @"Number", @"CountryCode", @"Message", @"DocumentReference", @"Contact", @"Hazard", @"Comments", @"ItemDetail", @"PunchOutSetupResponse", @"Extension", @"Header", @"SelectedItem", @"PostalAddress", @"Phone", @"SupplierPartID", @"OrderProtocol", @"UserAgent", @"To", @"OrderRequest", @"Extrinsic", @"ShipNoticeRequest", 
@"ShipNoticePortion", @"Route", @"BillTo", @"cXML_Fulfill", @"OrderTarget", @"ManufacturerPartID", @"URL", @"AreaOrCityCode"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CxmlSchemas.schemas.xml", typeof(global::CxmlSchemas.schemas.xml))]
    public sealed class Fulfill : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""CxmlSchemas.schemas.xml"" namespace=""http://www.w3.org/XML/1998/namespace"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Email"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""name"" type=""xs:string"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ShipNoticeItem"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""UnitOfMeasure"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Hazard"" />
      </xs:sequence>
      <xs:attribute name=""quantity"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""lineNumber"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:group name=""cxml.payment"">
    <xs:sequence>
      <xs:element ref=""PCard"" />
    </xs:sequence>
  </xs:group>
  <xs:element name=""Payment"">
    <xs:complexType>
      <xs:sequence>
        <xs:group ref=""cxml.payment"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PunchOutOrderMessage"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""BuyerCookie"" />
        <xs:element ref=""PunchOutOrderMessageHeader"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ItemIn"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""UnitPrice"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Address"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Name"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""PostalAddress"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Email"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Phone"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Fax"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""URL"" />
      </xs:sequence>
      <xs:attribute name=""isoCountryCode"" type=""xs:string"" />
      <xs:attribute name=""addressID"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""OrderMethod"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""OrderTarget"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""OrderProtocol"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PostalCode"" type=""xs:string"" />
  <xs:element name=""ManufacturerName"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute ref=""xml:lang"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ItemOut"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ItemID"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ItemDetail"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""SupplierID"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ShipTo"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Shipping"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Tax"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Distribution"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Contact"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Comments"" />
      </xs:sequence>
      <xs:attribute name=""requisitionID"" type=""xs:string"" />
      <xs:attribute name=""quantity"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""lineNumber"" type=""xs:string"" />
      <xs:attribute name=""requestedDeliveryDate"" type=""xs:string"" />
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
  <xs:element name=""CopyRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""cXML_Fulfill"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""City"" type=""xs:string"" />
  <xs:element name=""ConfirmationRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ConfirmationHeader"" />
        <xs:element ref=""OrderReference"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ConfirmationItem"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""State"" type=""xs:string"" />
  <xs:element name=""ConfirmationItem"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""UnitOfMeasure"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""ConfirmationStatus"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Contact"" />
      </xs:sequence>
      <xs:attribute name=""quantity"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""lineNumber"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""ItemID"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""SupplierPartID"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""SupplierPartAuxiliaryID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OrderReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""DocumentReference"" />
      </xs:sequence>
      <xs:attribute name=""orderID"" type=""xs:string"" />
      <xs:attribute name=""orderDate"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:group name=""cxml.accounting"">
    <xs:sequence>
      <xs:choice>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Segment"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""AccountingSegment"" />
      </xs:choice>
    </xs:sequence>
  </xs:group>
  <xs:element name=""Accounting"">
    <xs:complexType>
      <xs:sequence>
        <xs:group ref=""cxml.accounting"" />
      </xs:sequence>
      <xs:attribute name=""name"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:group name=""cxml.authentication"">
    <xs:choice>
      <xs:element ref=""SharedSecret"" />
      <xs:element ref=""DigitalSignature"" />
    </xs:choice>
  </xs:group>
  <xs:element name=""Credential"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Identity"" />
        <xs:sequence minOccurs=""0"" maxOccurs=""1"">
          <xs:group ref=""cxml.authentication"" />
        </xs:sequence>
      </xs:sequence>
      <xs:attribute name=""domain"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""type"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""marketplace"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CarrierIdentifier"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""domain"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AccountingSegment"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Name"" />
        <xs:element ref=""Description"" />
      </xs:sequence>
      <xs:attribute name=""id"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""OrderMethods"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""OrderMethod"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Contact"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Street"" type=""xs:string"" />
  <xs:element name=""DeliverTo"" type=""xs:string"" />
  <xs:element name=""DigitalSignature"">
    <xs:complexType mixed=""true"">
      <xs:sequence>
        <xs:any minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:sequence>
      <xs:attribute default=""Base64"" name=""encoding"" type=""xs:string"" />
      <xs:attribute default=""PK7 self-contained"" name=""type"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Total"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ShipNoticeHeader"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Hazard"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Contact"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Comments"" />
      </xs:sequence>
      <xs:attribute name=""deliveryDate"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""noticeDate"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""shipmentDate"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""shipmentID"" type=""xs:string"" />
      <xs:attribute default=""new"" name=""operation"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""new"" />
            <xs:enumeration value=""update"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SupplierLocation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Address"" />
        <xs:element ref=""OrderMethods"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Segment"">
    <xs:complexType>
      <xs:attribute name=""id"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""description"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""UnitOfMeasure"" type=""xs:string"" />
  <xs:element name=""SupplierSetup"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""URL"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Supplier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Name"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Comments"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""SupplierID"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""SupplierLocation"" />
      </xs:sequence>
      <xs:attribute name=""storeFrontURL"" type=""xs:string"" />
      <xs:attribute name=""corporateURL"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Attachment"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""URL"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Charge"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Classification"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""domain"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Identity"">
    <xs:complexType mixed=""true"">
      <xs:sequence>
        <xs:any minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:sequence>
      <xs:attribute name=""lastChangedTimestamp"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""SupplierID"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""domain"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PunchOutOrderMessageHeader"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Total"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ShipTo"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Shipping"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Tax"" />
      </xs:sequence>
      <xs:attribute name=""operationAllowed"" use=""required"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""create"" />
            <xs:enumeration value=""inspect"" />
            <xs:enumeration value=""edit"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Country"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""isoCountryCode"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OrderRequestHeader"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Total"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ShipTo"" />
        <xs:element ref=""BillTo"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Shipping"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Tax"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Payment"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Contact"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Comments"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Followup"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""DocumentReference"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Extrinsic"" />
      </xs:sequence>
      <xs:attribute default=""new"" name=""type"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""new"" />
            <xs:enumeration value=""update"" />
            <xs:enumeration value=""delete"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
      <xs:attribute name=""orderDate"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""requisitionID"" type=""xs:string"" />
      <xs:attribute name=""orderID"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""shipComplete"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""yes"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCard"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""PostalAddress"" />
      </xs:sequence>
      <xs:attribute name=""expiration"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""number"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""name"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""ConfirmationHeader"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Total"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Shipping"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Tax"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Contact"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Comments"" />
      </xs:sequence>
      <xs:attribute name=""noticeDate"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""type"" use=""required"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""accept"" />
            <xs:enumeration value=""detail"" />
            <xs:enumeration value=""except"" />
            <xs:enumeration value=""reject"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
      <xs:attribute default=""new"" name=""operation"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""new"" />
            <xs:enumeration value=""update"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
      <xs:attribute name=""confirmID"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""From"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Credential"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Money"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""alternateAmount"" type=""xs:string"" />
          <xs:attribute name=""currency"" type=""xs:string"" use=""required"" />
          <xs:attribute name=""alternateCurrency"" type=""xs:string"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ItemIn"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ItemID"" />
        <xs:element ref=""ItemDetail"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""SupplierID"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ShipTo"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Shipping"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Tax"" />
      </xs:sequence>
      <xs:attribute name=""quantity"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""lineNumber"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Followup"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""URL"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Status"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute ref=""xml:lang"" />
          <xs:attribute name=""code"" type=""xs:string"" use=""required"" />
          <xs:attribute name=""text"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ShortName"" type=""xs:string"" />
  <xs:element name=""BrowserFormPost"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""URL"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TelephoneNumber"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""CountryCode"" />
        <xs:element ref=""AreaOrCityCode"" />
        <xs:element ref=""Number"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Extension"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ShipmentIdentifier"" type=""xs:string"" />
  <xs:element name=""StatusUpdateRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""DocumentReference"" />
        <xs:element ref=""Status"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ConfirmationStatus"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""UnitOfMeasure"" />
        <xs:choice>
          <xs:element ref=""ItemIn"" />
          <xs:sequence>
            <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""UnitPrice"" />
            <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Tax"" />
            <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Shipping"" />
          </xs:sequence>
        </xs:choice>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Comments"" />
      </xs:sequence>
      <xs:attribute name=""quantity"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""type"" use=""required"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""accept"" />
            <xs:enumeration value=""detail"" />
            <xs:enumeration value=""reject"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
      <xs:attribute name=""deliveryDate"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""StartPage"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""URL"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ShipTo"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Address"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Description"">
    <xs:complexType mixed=""true"">
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element ref=""ShortName"" />
      </xs:choice>
      <xs:attribute ref=""xml:lang"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Tax"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
        <xs:element ref=""Description"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SharedSecret"">
    <xs:complexType mixed=""true"">
      <xs:sequence>
        <xs:any minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:group name=""cxml.responses"">
    <xs:sequence>
      <xs:element ref=""PunchOutSetupResponse"" />
    </xs:sequence>
  </xs:group>
  <xs:element name=""Response"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Status"" />
        <xs:sequence minOccurs=""0"" maxOccurs=""1"">
          <xs:group ref=""cxml.responses"" />
        </xs:sequence>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Name"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute ref=""xml:lang"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OtherOrderTarget"">
    <xs:complexType mixed=""true"">
      <xs:sequence>
        <xs:any minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:sequence>
      <xs:attribute name=""name"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""SupplierPartAuxiliaryID"">
    <xs:complexType mixed=""true"">
      <xs:sequence>
        <xs:any minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:group name=""cxml.requests"">
    <xs:sequence>
      <xs:choice>
        <xs:element ref=""ConfirmationRequest"" />
        <xs:element ref=""ShipNoticeRequest"" />
      </xs:choice>
    </xs:sequence>
  </xs:group>
  <xs:element name=""Request"">
    <xs:complexType>
      <xs:sequence>
        <xs:group ref=""cxml.requests"" />
      </xs:sequence>
      <xs:attribute default=""production"" name=""deploymentMode"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""production"" />
            <xs:enumeration value=""test"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PunchOutSetupRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""BuyerCookie"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Extrinsic"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""BrowserFormPost"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Contact"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""SupplierSetup"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ShipTo"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""SelectedItem"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ItemOut"" />
      </xs:sequence>
      <xs:attribute name=""operation"" use=""required"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""create"" />
            <xs:enumeration value=""inspect"" />
            <xs:enumeration value=""edit"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Fax"">
    <xs:complexType>
      <xs:choice>
        <xs:element ref=""TelephoneNumber"" />
        <xs:element ref=""URL"" />
        <xs:element ref=""Email"" />
      </xs:choice>
      <xs:attribute name=""name"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""BuyerCookie"">
    <xs:complexType mixed=""true"">
      <xs:sequence>
        <xs:any minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Sender"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Credential"" />
        <xs:element ref=""UserAgent"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Shipping"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
        <xs:element ref=""Description"" />
      </xs:sequence>
      <xs:attribute name=""tracking"" type=""xs:string"" />
      <xs:attribute name=""trackingDomain"" type=""xs:string"" />
      <xs:attribute name=""trackingId"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Number"" type=""xs:string"" />
  <xs:element name=""CountryCode"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""isoCountryCode"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:group name=""cxml.messages"">
    <xs:sequence>
      <xs:element ref=""PunchOutOrderMessage"" />
    </xs:sequence>
  </xs:group>
  <xs:element name=""Message"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Status"" />
        <xs:group ref=""cxml.messages"" />
      </xs:sequence>
      <xs:attribute name=""inReplyTo"" type=""xs:string"" />
      <xs:attribute default=""production"" name=""deploymentMode"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""production"" />
            <xs:enumeration value=""test"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DocumentReference"">
    <xs:complexType>
      <xs:attribute name=""payloadID"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Contact"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Name"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostalAddress"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Email"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Phone"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Fax"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""URL"" />
      </xs:sequence>
      <xs:attribute name=""role"" type=""xs:NMTOKEN"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Hazard"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Description"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Classification"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Comments"">
    <xs:complexType mixed=""true"">
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element ref=""Attachment"" />
      </xs:choice>
      <xs:attribute ref=""xml:lang"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""ItemDetail"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""UnitPrice"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Description"" />
        <xs:element ref=""UnitOfMeasure"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Classification"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ManufacturerPartID"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ManufacturerName"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""URL"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Extrinsic"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PunchOutSetupResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""StartPage"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Extension"" type=""xs:string"" />
  <xs:element name=""Header"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""From"" />
        <xs:element ref=""To"" />
        <xs:element ref=""Sender"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SelectedItem"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ItemID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PostalAddress"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""DeliverTo"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Street"" />
        <xs:element ref=""City"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""State"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""PostalCode"" />
        <xs:element ref=""Country"" />
      </xs:sequence>
      <xs:attribute name=""name"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Phone"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""TelephoneNumber"" />
      </xs:sequence>
      <xs:attribute name=""name"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""SupplierPartID"" type=""xs:string"" />
  <xs:element name=""OrderProtocol"" type=""xs:string"" />
  <xs:element name=""UserAgent"" type=""xs:string"" />
  <xs:element name=""To"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Credential"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OrderRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""OrderRequestHeader"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""ItemOut"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Extrinsic"">
    <xs:complexType mixed=""true"">
      <xs:sequence>
        <xs:any minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:sequence>
      <xs:attribute name=""name"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""ShipNoticeRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ShipNoticeHeader"" />
        <xs:element ref=""Route"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""ShipNoticePortion"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ShipNoticePortion"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""OrderReference"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ShipNoticeItem"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Contact"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Route"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""CarrierIdentifier"" />
        <xs:element ref=""ShipmentIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ShipmentIdentifier"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Contact"" />
      </xs:sequence>
      <xs:attribute name=""method"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""air"" />
            <xs:enumeration value=""motor"" />
            <xs:enumeration value=""rail"" />
            <xs:enumeration value=""ship"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""BillTo"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Address"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""cXML_Fulfill"">
    <xs:complexType>
      <xs:choice>
        <xs:sequence>
          <xs:element ref=""Header"" />
          <xs:choice>
            <xs:element ref=""Message"" />
            <xs:element ref=""Request"" />
          </xs:choice>
        </xs:sequence>
        <xs:element ref=""Response"" />
      </xs:choice>
      <xs:attribute name=""payloadID"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""timestamp"" type=""xs:string"" use=""required"" />
      <xs:attribute default=""1.1.010"" name=""version"" type=""xs:string"" />
      <xs:attribute ref=""xml:lang"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""OrderTarget"">
    <xs:complexType>
      <xs:choice>
        <xs:element ref=""Phone"" />
        <xs:element ref=""Email"" />
        <xs:element ref=""Fax"" />
        <xs:element ref=""URL"" />
        <xs:element ref=""OtherOrderTarget"" />
      </xs:choice>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ManufacturerPartID"" type=""xs:string"" />
  <xs:element name=""URL"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""name"" type=""xs:string"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AreaOrCityCode"" type=""xs:string"" />
</xs:schema>";
        
        public Fulfill() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [98];
                _RootElements[0] = "Email";
                _RootElements[1] = "ShipNoticeItem";
                _RootElements[2] = "Payment";
                _RootElements[3] = "PunchOutOrderMessage";
                _RootElements[4] = "UnitPrice";
                _RootElements[5] = "Address";
                _RootElements[6] = "OrderMethod";
                _RootElements[7] = "PostalCode";
                _RootElements[8] = "ManufacturerName";
                _RootElements[9] = "ItemOut";
                _RootElements[10] = "Distribution";
                _RootElements[11] = "CopyRequest";
                _RootElements[12] = "City";
                _RootElements[13] = "ConfirmationRequest";
                _RootElements[14] = "State";
                _RootElements[15] = "ConfirmationItem";
                _RootElements[16] = "ItemID";
                _RootElements[17] = "OrderReference";
                _RootElements[18] = "Accounting";
                _RootElements[19] = "Credential";
                _RootElements[20] = "CarrierIdentifier";
                _RootElements[21] = "AccountingSegment";
                _RootElements[22] = "OrderMethods";
                _RootElements[23] = "Street";
                _RootElements[24] = "DeliverTo";
                _RootElements[25] = "DigitalSignature";
                _RootElements[26] = "Total";
                _RootElements[27] = "ShipNoticeHeader";
                _RootElements[28] = "SupplierLocation";
                _RootElements[29] = "Segment";
                _RootElements[30] = "UnitOfMeasure";
                _RootElements[31] = "SupplierSetup";
                _RootElements[32] = "Supplier";
                _RootElements[33] = "Attachment";
                _RootElements[34] = "Charge";
                _RootElements[35] = "Classification";
                _RootElements[36] = "Identity";
                _RootElements[37] = "SupplierID";
                _RootElements[38] = "PunchOutOrderMessageHeader";
                _RootElements[39] = "Country";
                _RootElements[40] = "OrderRequestHeader";
                _RootElements[41] = "PCard";
                _RootElements[42] = "ConfirmationHeader";
                _RootElements[43] = "From";
                _RootElements[44] = "Money";
                _RootElements[45] = "ItemIn";
                _RootElements[46] = "Followup";
                _RootElements[47] = "Status";
                _RootElements[48] = "ShortName";
                _RootElements[49] = "BrowserFormPost";
                _RootElements[50] = "TelephoneNumber";
                _RootElements[51] = "ShipmentIdentifier";
                _RootElements[52] = "StatusUpdateRequest";
                _RootElements[53] = "ConfirmationStatus";
                _RootElements[54] = "StartPage";
                _RootElements[55] = "ShipTo";
                _RootElements[56] = "Description";
                _RootElements[57] = "Tax";
                _RootElements[58] = "SharedSecret";
                _RootElements[59] = "Response";
                _RootElements[60] = "Name";
                _RootElements[61] = "OtherOrderTarget";
                _RootElements[62] = "SupplierPartAuxiliaryID";
                _RootElements[63] = "Request";
                _RootElements[64] = "PunchOutSetupRequest";
                _RootElements[65] = "Fax";
                _RootElements[66] = "BuyerCookie";
                _RootElements[67] = "Sender";
                _RootElements[68] = "Shipping";
                _RootElements[69] = "Number";
                _RootElements[70] = "CountryCode";
                _RootElements[71] = "Message";
                _RootElements[72] = "DocumentReference";
                _RootElements[73] = "Contact";
                _RootElements[74] = "Hazard";
                _RootElements[75] = "Comments";
                _RootElements[76] = "ItemDetail";
                _RootElements[77] = "PunchOutSetupResponse";
                _RootElements[78] = "Extension";
                _RootElements[79] = "Header";
                _RootElements[80] = "SelectedItem";
                _RootElements[81] = "PostalAddress";
                _RootElements[82] = "Phone";
                _RootElements[83] = "SupplierPartID";
                _RootElements[84] = "OrderProtocol";
                _RootElements[85] = "UserAgent";
                _RootElements[86] = "To";
                _RootElements[87] = "OrderRequest";
                _RootElements[88] = "Extrinsic";
                _RootElements[89] = "ShipNoticeRequest";
                _RootElements[90] = "ShipNoticePortion";
                _RootElements[91] = "Route";
                _RootElements[92] = "BillTo";
                _RootElements[93] = "cXML_Fulfill";
                _RootElements[94] = "OrderTarget";
                _RootElements[95] = "ManufacturerPartID";
                _RootElements[96] = "URL";
                _RootElements[97] = "AreaOrCityCode";
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
        
        [Schema(@"",@"Email")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Email"})]
        public sealed class Email : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Email() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Email";
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
        
        [Schema(@"",@"ShipNoticeItem")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ShipNoticeItem"})]
        public sealed class ShipNoticeItem : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ShipNoticeItem() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ShipNoticeItem";
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
        
        [Schema(@"",@"Payment")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Payment"})]
        public sealed class Payment : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Payment() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Payment";
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
        
        [Schema(@"",@"PunchOutOrderMessage")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PunchOutOrderMessage"})]
        public sealed class PunchOutOrderMessage : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PunchOutOrderMessage() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PunchOutOrderMessage";
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
        
        [Schema(@"",@"UnitPrice")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"UnitPrice"})]
        public sealed class UnitPrice : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public UnitPrice() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "UnitPrice";
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
        
        [Schema(@"",@"Address")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Address"})]
        public sealed class Address : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Address() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Address";
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
        
        [Schema(@"",@"OrderMethod")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderMethod"})]
        public sealed class OrderMethod : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderMethod() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderMethod";
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
        
        [Schema(@"",@"PostalCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PostalCode"})]
        public sealed class PostalCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PostalCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PostalCode";
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
        
        [Schema(@"",@"ManufacturerName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ManufacturerName"})]
        public sealed class ManufacturerName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ManufacturerName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ManufacturerName";
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
        
        [Schema(@"",@"ItemOut")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ItemOut"})]
        public sealed class ItemOut : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ItemOut() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ItemOut";
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
        
        [Schema(@"",@"Distribution")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Distribution"})]
        public sealed class Distribution : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Distribution() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Distribution";
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
        
        [Schema(@"",@"CopyRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CopyRequest"})]
        public sealed class CopyRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CopyRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CopyRequest";
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
        
        [Schema(@"",@"City")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"City"})]
        public sealed class City : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public City() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "City";
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
        
        [Schema(@"",@"ConfirmationRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ConfirmationRequest"})]
        public sealed class ConfirmationRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ConfirmationRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ConfirmationRequest";
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
        
        [Schema(@"",@"State")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"State"})]
        public sealed class State : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public State() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "State";
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
        
        [Schema(@"",@"ConfirmationItem")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ConfirmationItem"})]
        public sealed class ConfirmationItem : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ConfirmationItem() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ConfirmationItem";
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
        
        [Schema(@"",@"ItemID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ItemID"})]
        public sealed class ItemID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ItemID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ItemID";
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
        
        [Schema(@"",@"OrderReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderReference"})]
        public sealed class OrderReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderReference";
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
        
        [Schema(@"",@"Accounting")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Accounting"})]
        public sealed class Accounting : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Accounting() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Accounting";
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
        
        [Schema(@"",@"Credential")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Credential"})]
        public sealed class Credential : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Credential() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Credential";
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
        
        [Schema(@"",@"CarrierIdentifier")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CarrierIdentifier"})]
        public sealed class CarrierIdentifier : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CarrierIdentifier() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CarrierIdentifier";
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
        
        [Schema(@"",@"AccountingSegment")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AccountingSegment"})]
        public sealed class AccountingSegment : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AccountingSegment() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AccountingSegment";
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
        
        [Schema(@"",@"OrderMethods")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderMethods"})]
        public sealed class OrderMethods : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderMethods() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderMethods";
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
        
        [Schema(@"",@"Street")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Street"})]
        public sealed class Street : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Street() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Street";
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
        
        [Schema(@"",@"DeliverTo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DeliverTo"})]
        public sealed class DeliverTo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DeliverTo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DeliverTo";
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
        
        [Schema(@"",@"DigitalSignature")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DigitalSignature"})]
        public sealed class DigitalSignature : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DigitalSignature() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DigitalSignature";
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
        
        [Schema(@"",@"Total")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Total"})]
        public sealed class Total : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Total() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Total";
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
        
        [Schema(@"",@"ShipNoticeHeader")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ShipNoticeHeader"})]
        public sealed class ShipNoticeHeader : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ShipNoticeHeader() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ShipNoticeHeader";
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
        
        [Schema(@"",@"SupplierLocation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SupplierLocation"})]
        public sealed class SupplierLocation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SupplierLocation() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SupplierLocation";
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
        
        [Schema(@"",@"Segment")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Segment"})]
        public sealed class Segment : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Segment() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Segment";
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
        
        [Schema(@"",@"UnitOfMeasure")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"UnitOfMeasure"})]
        public sealed class UnitOfMeasure : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public UnitOfMeasure() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "UnitOfMeasure";
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
        
        [Schema(@"",@"SupplierSetup")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SupplierSetup"})]
        public sealed class SupplierSetup : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SupplierSetup() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SupplierSetup";
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
        
        [Schema(@"",@"Supplier")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Supplier"})]
        public sealed class Supplier : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Supplier() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Supplier";
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
        
        [Schema(@"",@"Attachment")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Attachment"})]
        public sealed class Attachment : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Attachment() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Attachment";
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
        
        [Schema(@"",@"Charge")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Charge"})]
        public sealed class Charge : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Charge() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Charge";
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
        
        [Schema(@"",@"Classification")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Classification"})]
        public sealed class Classification : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Classification() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Classification";
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
        
        [Schema(@"",@"Identity")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Identity"})]
        public sealed class Identity : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Identity() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Identity";
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
        
        [Schema(@"",@"SupplierID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SupplierID"})]
        public sealed class SupplierID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SupplierID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SupplierID";
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
        
        [Schema(@"",@"PunchOutOrderMessageHeader")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PunchOutOrderMessageHeader"})]
        public sealed class PunchOutOrderMessageHeader : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PunchOutOrderMessageHeader() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PunchOutOrderMessageHeader";
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
        
        [Schema(@"",@"Country")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Country"})]
        public sealed class Country : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Country() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Country";
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
        
        [Schema(@"",@"OrderRequestHeader")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderRequestHeader"})]
        public sealed class OrderRequestHeader : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderRequestHeader() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderRequestHeader";
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
        
        [Schema(@"",@"PCard")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PCard"})]
        public sealed class PCard : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PCard() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PCard";
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
        
        [Schema(@"",@"ConfirmationHeader")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ConfirmationHeader"})]
        public sealed class ConfirmationHeader : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ConfirmationHeader() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ConfirmationHeader";
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
        
        [Schema(@"",@"From")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"From"})]
        public sealed class From : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public From() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "From";
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
        
        [Schema(@"",@"Money")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Money"})]
        public sealed class Money : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Money() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Money";
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
        
        [Schema(@"",@"ItemIn")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ItemIn"})]
        public sealed class ItemIn : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ItemIn() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ItemIn";
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
        
        [Schema(@"",@"Followup")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Followup"})]
        public sealed class Followup : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Followup() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Followup";
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
        
        [Schema(@"",@"Status")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Status"})]
        public sealed class Status : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Status() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Status";
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
        
        [Schema(@"",@"ShortName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ShortName"})]
        public sealed class ShortName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ShortName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ShortName";
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
        
        [Schema(@"",@"BrowserFormPost")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BrowserFormPost"})]
        public sealed class BrowserFormPost : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BrowserFormPost() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BrowserFormPost";
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
        
        [Schema(@"",@"TelephoneNumber")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TelephoneNumber"})]
        public sealed class TelephoneNumber : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TelephoneNumber() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TelephoneNumber";
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
        
        [Schema(@"",@"ShipmentIdentifier")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ShipmentIdentifier"})]
        public sealed class ShipmentIdentifier : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ShipmentIdentifier() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ShipmentIdentifier";
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
        
        [Schema(@"",@"StatusUpdateRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StatusUpdateRequest"})]
        public sealed class StatusUpdateRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StatusUpdateRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StatusUpdateRequest";
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
        
        [Schema(@"",@"ConfirmationStatus")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ConfirmationStatus"})]
        public sealed class ConfirmationStatus : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ConfirmationStatus() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ConfirmationStatus";
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
        
        [Schema(@"",@"StartPage")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StartPage"})]
        public sealed class StartPage : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StartPage() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StartPage";
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
        
        [Schema(@"",@"ShipTo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ShipTo"})]
        public sealed class ShipTo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ShipTo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ShipTo";
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
        
        [Schema(@"",@"Description")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Description"})]
        public sealed class Description : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Description() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Description";
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
        
        [Schema(@"",@"Tax")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Tax"})]
        public sealed class Tax : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Tax() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Tax";
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
        
        [Schema(@"",@"SharedSecret")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SharedSecret"})]
        public sealed class SharedSecret : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SharedSecret() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SharedSecret";
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
        
        [Schema(@"",@"Response")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Response"})]
        public sealed class Response : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Response() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Response";
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
        
        [Schema(@"",@"Name")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Name"})]
        public sealed class Name : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Name() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Name";
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
        
        [Schema(@"",@"OtherOrderTarget")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OtherOrderTarget"})]
        public sealed class OtherOrderTarget : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OtherOrderTarget() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OtherOrderTarget";
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
        
        [Schema(@"",@"SupplierPartAuxiliaryID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SupplierPartAuxiliaryID"})]
        public sealed class SupplierPartAuxiliaryID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SupplierPartAuxiliaryID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SupplierPartAuxiliaryID";
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
        
        [Schema(@"",@"Request")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Request"})]
        public sealed class Request : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Request() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Request";
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
        
        [Schema(@"",@"PunchOutSetupRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PunchOutSetupRequest"})]
        public sealed class PunchOutSetupRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PunchOutSetupRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PunchOutSetupRequest";
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
        
        [Schema(@"",@"Fax")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Fax"})]
        public sealed class Fax : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Fax() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Fax";
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
        
        [Schema(@"",@"BuyerCookie")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BuyerCookie"})]
        public sealed class BuyerCookie : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BuyerCookie() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BuyerCookie";
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
        
        [Schema(@"",@"Sender")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Sender"})]
        public sealed class Sender : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Sender() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Sender";
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
        
        [Schema(@"",@"Shipping")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Shipping"})]
        public sealed class Shipping : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Shipping() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Shipping";
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
        
        [Schema(@"",@"Number")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Number"})]
        public sealed class Number : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Number() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Number";
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
        
        [Schema(@"",@"CountryCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CountryCode"})]
        public sealed class CountryCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CountryCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CountryCode";
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
        
        [Schema(@"",@"Message")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Message"})]
        public sealed class Message : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Message() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Message";
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
        
        [Schema(@"",@"DocumentReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DocumentReference"})]
        public sealed class DocumentReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DocumentReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DocumentReference";
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
        
        [Schema(@"",@"Contact")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Contact"})]
        public sealed class Contact : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Contact() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Contact";
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
        
        [Schema(@"",@"Hazard")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Hazard"})]
        public sealed class Hazard : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Hazard() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Hazard";
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
        
        [Schema(@"",@"Comments")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Comments"})]
        public sealed class Comments : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Comments() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Comments";
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
        
        [Schema(@"",@"ItemDetail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ItemDetail"})]
        public sealed class ItemDetail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ItemDetail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ItemDetail";
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
        
        [Schema(@"",@"PunchOutSetupResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PunchOutSetupResponse"})]
        public sealed class PunchOutSetupResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PunchOutSetupResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PunchOutSetupResponse";
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
        
        [Schema(@"",@"Extension")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Extension"})]
        public sealed class Extension : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Extension() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Extension";
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
        
        [Schema(@"",@"Header")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Header"})]
        public sealed class Header : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Header() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Header";
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
        
        [Schema(@"",@"SelectedItem")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SelectedItem"})]
        public sealed class SelectedItem : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SelectedItem() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SelectedItem";
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
        
        [Schema(@"",@"PostalAddress")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PostalAddress"})]
        public sealed class PostalAddress : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PostalAddress() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PostalAddress";
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
        
        [Schema(@"",@"Phone")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Phone"})]
        public sealed class Phone : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Phone() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Phone";
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
        
        [Schema(@"",@"SupplierPartID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SupplierPartID"})]
        public sealed class SupplierPartID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SupplierPartID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SupplierPartID";
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
        
        [Schema(@"",@"OrderProtocol")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderProtocol"})]
        public sealed class OrderProtocol : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderProtocol() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderProtocol";
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
        
        [Schema(@"",@"UserAgent")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"UserAgent"})]
        public sealed class UserAgent : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public UserAgent() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "UserAgent";
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
        
        [Schema(@"",@"To")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"To"})]
        public sealed class To : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public To() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "To";
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
        
        [Schema(@"",@"OrderRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderRequest"})]
        public sealed class OrderRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderRequest";
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
        
        [Schema(@"",@"Extrinsic")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Extrinsic"})]
        public sealed class Extrinsic : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Extrinsic() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Extrinsic";
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
        
        [Schema(@"",@"ShipNoticeRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ShipNoticeRequest"})]
        public sealed class ShipNoticeRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ShipNoticeRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ShipNoticeRequest";
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
        
        [Schema(@"",@"ShipNoticePortion")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ShipNoticePortion"})]
        public sealed class ShipNoticePortion : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ShipNoticePortion() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ShipNoticePortion";
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
        
        [Schema(@"",@"Route")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Route"})]
        public sealed class Route : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Route() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Route";
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
        
        [Schema(@"",@"BillTo")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BillTo"})]
        public sealed class BillTo : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BillTo() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BillTo";
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
        
        [Schema(@"",@"cXML_Fulfill")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"cXML_Fulfill"})]
        public sealed class cXML_Fulfill : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public cXML_Fulfill() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "cXML_Fulfill";
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
        
        [Schema(@"",@"OrderTarget")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderTarget"})]
        public sealed class OrderTarget : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderTarget() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderTarget";
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
        
        [Schema(@"",@"ManufacturerPartID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ManufacturerPartID"})]
        public sealed class ManufacturerPartID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ManufacturerPartID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ManufacturerPartID";
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
        
        [Schema(@"",@"URL")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"URL"})]
        public sealed class URL : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public URL() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "URL";
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
        
        [Schema(@"",@"AreaOrCityCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AreaOrCityCode"})]
        public sealed class AreaOrCityCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AreaOrCityCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AreaOrCityCode";
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
}
