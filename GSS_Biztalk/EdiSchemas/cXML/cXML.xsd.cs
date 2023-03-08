namespace EdiSchemas.cXML {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"cXML")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"cXML"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EdiSchemas.cXML.xml", typeof(global::EdiSchemas.cXML.xml))]
    public sealed class cXML : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""EdiSchemas.cXML.xml"" namespace=""http://www.w3.org/XML/1998/namespace"" />
  <xs:annotation>
    <xs:appinfo>
      <schemaInfo root_reference=""cXML"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" document_type=""http://xml.cxml.org/schemas/cXML/1.1.010/cXML.dtd"" version=""1.1.010"" is_envelope=""no"" />
      <b:references>
        <b:reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""StatusUpdateRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""DocumentReference"" />
        <xs:element ref=""Status"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Followup"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""URL"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PCard"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""PostalAddress"" />
      </xs:sequence>
      <xs:attribute name=""name"" type=""xs:string"" />
      <xs:attribute name=""expiration"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""number"" type=""xs:string"" use=""required"" />
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
  <xs:element name=""DocumentReference"">
    <xs:complexType>
      <xs:attribute name=""payloadID"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""DeliverTo"" type=""xs:string"" />
  <xs:element name=""BuyerCookie"">
    <xs:complexType mixed=""true"">
      <xs:sequence>
        <xs:any minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OrderProtocol"" type=""xs:string"" />
  <xs:element name=""ProfileResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Option"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Transaction"" />
      </xs:sequence>
      <xs:attribute name=""effectiveDate"" type=""xs:string"" use=""required"" />
      <xs:attribute fixed=""effectiveDate dateTime"" name=""a-dtype"" type=""xs:NMTOKENS"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Charge"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""EffectiveDate"" type=""xs:string"" />
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
  <xs:element name=""ItemID"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""SupplierPartID"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""SupplierPartAuxiliaryID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SearchAttribute"">
    <xs:complexType>
      <xs:attribute name=""type"" type=""xs:string"" />
      <xs:attribute name=""name"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""GetPendingResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""cXML"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ItemSegment"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""ContractItem"" />
      </xs:sequence>
      <xs:attribute name=""segmentKey"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""ManufacturerPartID"" type=""xs:string"" />
  <xs:element name=""Classification"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""domain"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ShipTo"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Address"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""IndexItemPunchout"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ItemID"" />
        <xs:element ref=""PunchoutDetail"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Status"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""code"" type=""xs:string"" use=""required"" />
          <xs:attribute ref=""xml:lang"" />
          <xs:attribute name=""text"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Format"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""version"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TerritoryAvailable"" type=""xs:string"" />
  <xs:element name=""Extension"" type=""xs:string"" />
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
  <xs:element name=""AccountingSegment"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Name"" />
        <xs:element ref=""Description"" />
      </xs:sequence>
      <xs:attribute name=""id"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""SelectedItem"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ItemID"" />
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
  <xs:element name=""Index"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""SupplierID"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Comments"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""SearchGroup"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""IndexItem"" />
      </xs:sequence>
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
  <xs:element name=""SubscriptionListRequest"">
    <xs:complexType />
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
  <xs:element name=""DigitalSignature"">
    <xs:complexType mixed=""true"">
      <xs:sequence>
        <xs:any minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:sequence>
      <xs:attribute default=""Base64"" name=""encoding"" type=""xs:string"" />
      <xs:attribute default=""PK7 self-contained"" name=""type"" type=""xs:string"" />
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
  <xs:element name=""Shipping"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
        <xs:element ref=""Description"" />
      </xs:sequence>
      <xs:attribute name=""trackingId"" type=""xs:string"" />
      <xs:attribute name=""tracking"" type=""xs:string"" />
      <xs:attribute name=""trackingDomain"" type=""xs:string"" />
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
  <xs:element name=""UserAgent"" type=""xs:string"" />
  <xs:element name=""SubscriptionContent"">
    <xs:complexType>
      <xs:choice>
        <xs:element ref=""CIFContent"" />
        <xs:element ref=""Index"" />
        <xs:element ref=""Contract"" />
      </xs:choice>
      <xs:attribute name=""filename"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Contract"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""SupplierID"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Comments"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""ItemSegment"" />
      </xs:sequence>
      <xs:attribute name=""effectiveDate"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""expirationDate"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""StartPage"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""URL"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""cXML"">
    <xs:complexType>
      <xs:choice>
        <xs:sequence>
          <xs:element ref=""Header"" />
          <xs:choice minOccurs=""0"" maxOccurs=""1"">
            <xs:element ref=""Message"" />
            <xs:element ref=""Request"" />
          </xs:choice>
        </xs:sequence>
        <xs:element ref=""Response"" />
      </xs:choice>
      <xs:attribute default=""1.1.010"" name=""version"" type=""xs:string"" />
      <xs:attribute ref=""xml:lang"" />
      <xs:attribute name=""timestamp"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""payloadID"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""PunchoutDetail"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Description"" />
        <xs:element ref=""URL"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Classification"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ManufacturerName"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ManufacturerPartID"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ExpirationDate"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""EffectiveDate"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""SearchGroupData"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""TerritoryAvailable"" />
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
  <xs:element name=""Email"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""name"" type=""xs:string"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""City"" type=""xs:string"" />
  <xs:element name=""SupplierPartID"" type=""xs:string"" />
  <xs:element name=""OtherOrderTarget"">
    <xs:complexType mixed=""true"">
      <xs:sequence>
        <xs:any minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:sequence>
      <xs:attribute name=""name"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""UnitPrice"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
      </xs:sequence>
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
  <xs:element name=""AreaOrCityCode"" type=""xs:string"" />
  <xs:element name=""Supplier"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Name"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Comments"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""SupplierID"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""SupplierLocation"" />
      </xs:sequence>
      <xs:attribute name=""corporateURL"" type=""xs:string"" />
      <xs:attribute name=""storeFrontURL"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""GetPendingRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""MessageType"" />
      </xs:sequence>
      <xs:attribute name=""lastReceivedTimestamp"" type=""xs:string"" />
      <xs:attribute name=""maxMessages"" type=""xs:string"" />
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
  <xs:element name=""SubscriptionContentResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Subscription"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""SubscriptionContent"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SupplierPartAuxiliaryID"">
    <xs:complexType mixed=""true"">
      <xs:sequence>
        <xs:any minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:group name=""cxml.responses"">
    <xs:sequence>
      <xs:choice>
        <xs:element ref=""ProfileResponse"" />
        <xs:element ref=""PunchOutSetupResponse"" />
        <xs:element ref=""GetPendingResponse"" />
        <xs:element ref=""SubscriptionListResponse"" />
        <xs:element ref=""SubscriptionContentResponse"" />
        <xs:element ref=""SupplierListResponse"" />
        <xs:element ref=""SupplierDataResponse"" />
      </xs:choice>
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
  <xs:element name=""LeadTime"" type=""xs:string"" />
  <xs:element name=""SupplierChangeMessage"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Supplier"" />
      </xs:sequence>
      <xs:attribute name=""type"" use=""required"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""new"" />
            <xs:enumeration value=""update"" />
            <xs:enumeration value=""delete"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""From"">
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
  <xs:element name=""Subscription"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""InternalID"" />
        <xs:element ref=""Name"" />
        <xs:element ref=""Changetime"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""SupplierID"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Format"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Description"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Changetime"" type=""xs:string"" />
  <xs:element name=""Identity"">
    <xs:complexType mixed=""true"">
      <xs:sequence>
        <xs:any minOccurs=""0"" maxOccurs=""unbounded"" />
      </xs:sequence>
      <xs:attribute name=""lastChangedTimestamp"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""IndexItemAdd"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ItemID"" />
        <xs:element ref=""ItemDetail"" />
        <xs:element ref=""IndexItemDetail"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""IndexItemDelete"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ItemID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""URL"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""name"" type=""xs:string"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Option"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute fixed=""name string"" name=""a-dtype"" type=""xs:NMTOKENS"" />
          <xs:attribute name=""name"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SearchGroupData"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Name"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""SearchDataElement"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SearchGroup"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Name"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""SearchAttribute"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CIFContent"" type=""xs:string"" />
  <xs:element name=""SupplierListResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Supplier"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""State"" type=""xs:string"" />
  <xs:element name=""Country"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""isoCountryCode"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
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
  <xs:element name=""ExpirationDate"" type=""xs:string"" />
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
  <xs:element name=""PostalCode"" type=""xs:string"" />
  <xs:element name=""ContractItem"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ItemID"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""UnitPrice"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Extrinsic"" />
      </xs:sequence>
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
  <xs:element name=""Number"" type=""xs:string"" />
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
  <xs:element name=""BillTo"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Address"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""To"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Credential"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Transaction"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""URL"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Option"" />
      </xs:sequence>
      <xs:attribute name=""requestName"" type=""xs:string"" use=""required"" />
      <xs:attribute fixed=""requestName NMTOKEN"" name=""a-dtype"" type=""xs:NMTOKENS"" />
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
      <xs:attribute name=""addressID"" type=""xs:string"" />
      <xs:attribute name=""isoCountryCode"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""UnitOfMeasure"" type=""xs:string"" />
  <xs:element name=""SubscriptionContentRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""InternalID"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""SupplierID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SupplierListRequest"">
    <xs:complexType />
  </xs:element>
  <xs:element name=""CopyRequest"">
    <xs:complexType>
      <xs:sequence minOccurs=""0"">
        <xs:element ref=""cXML"" />
      </xs:sequence>
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
  <xs:element name=""Attachment"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""URL"" />
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
      <xs:attribute name=""lineNumber"" type=""xs:string"" />
      <xs:attribute name=""requestedDeliveryDate"" type=""xs:string"" />
      <xs:attribute name=""quantity"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""SupplierDataResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Supplier"" />
      </xs:sequence>
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
      <xs:attribute name=""requisitionID"" type=""xs:string"" />
      <xs:attribute name=""orderID"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""shipComplete"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""yes"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
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
    </xs:complexType>
  </xs:element>
  <xs:element name=""SearchDataElement"">
    <xs:complexType>
      <xs:attribute name=""value"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""name"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""SubscriptionListResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Subscription"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""IndexItem"">
    <xs:complexType>
      <xs:choice>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""IndexItemAdd"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""IndexItemDelete"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""IndexItemPunchout"" />
      </xs:choice>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Total"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Money"" />
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
  <xs:element name=""InternalID"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""domain"" type=""xs:string"" />
        </xs:extension>
      </xs:simpleContent>
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
  <xs:element name=""Phone"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""TelephoneNumber"" />
      </xs:sequence>
      <xs:attribute name=""name"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""BrowserFormPost"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""URL"" />
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
  <xs:element name=""PunchOutSetupResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""StartPage"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SubscriptionChangeMessage"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""Subscription"" />
      </xs:sequence>
      <xs:attribute name=""type"" use=""required"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""new"" />
            <xs:enumeration value=""update"" />
            <xs:enumeration value=""delete"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""IndexItemDetail"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""LeadTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""ExpirationDate"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""EffectiveDate"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""SearchGroupData"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""TerritoryAvailable"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SupplierSetup"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""URL"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:group name=""cxml.requests"">
    <xs:sequence>
      <xs:choice minOccurs=""0"" maxOccurs=""1"">
        <xs:element ref=""ProfileRequest"" />
        <xs:element ref=""OrderRequest"" />
        <xs:element ref=""PunchOutSetupRequest"" />
        <xs:element ref=""StatusUpdateRequest"" />
        <xs:element ref=""GetPendingRequest"" />
        <xs:element ref=""SubscriptionListRequest"" />
        <xs:element ref=""SubscriptionContentRequest"" />
        <xs:element ref=""SupplierListRequest"" />
        <xs:element ref=""SupplierDataRequest"" />
        <xs:element minOccurs=""0"" ref=""CopyRequest"" />
      </xs:choice>
    </xs:sequence>
  </xs:group>
  <xs:element name=""Request"">
    <xs:complexType>
      <xs:sequence>
        <xs:group minOccurs=""0"" ref=""cxml.requests"" />
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
  <xs:element name=""Money"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""currency"" type=""xs:string"" use=""required"" />
          <xs:attribute name=""alternateAmount"" type=""xs:string"" />
          <xs:attribute name=""alternateCurrency"" type=""xs:string"" />
        </xs:extension>
      </xs:simpleContent>
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
      <xs:attribute name=""type"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""marketplace"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
      <xs:attribute name=""domain"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""CountryCode"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""isoCountryCode"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
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
  <xs:element name=""ManufacturerName"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute ref=""xml:lang"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:group name=""cxml.messages"">
    <xs:sequence>
      <xs:choice>
        <xs:element ref=""PunchOutOrderMessage"" />
        <xs:element ref=""SubscriptionChangeMessage"" />
        <xs:element ref=""SupplierChangeMessage"" />
      </xs:choice>
    </xs:sequence>
  </xs:group>
  <xs:element name=""Message"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" ref=""Status"" />
        <xs:group ref=""cxml.messages"" />
      </xs:sequence>
      <xs:attribute default=""production"" name=""deploymentMode"">
        <xs:simpleType>
          <xs:restriction base=""xs:NMTOKEN"">
            <xs:enumeration value=""production"" />
            <xs:enumeration value=""test"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
      <xs:attribute name=""inReplyTo"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""Street"" type=""xs:string"" />
  <xs:element name=""MessageType"" type=""xs:string"" />
  <xs:element name=""SupplierDataRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""SupplierID"" />
      </xs:sequence>
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
  <xs:element name=""ProfileRequest"">
    <xs:complexType />
  </xs:element>
  <xs:element name=""Comments"">
    <xs:complexType mixed=""true"">
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element ref=""Attachment"" />
      </xs:choice>
      <xs:attribute ref=""xml:lang"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""ShortName"" type=""xs:string"" />
  <xs:element name=""Segment"">
    <xs:complexType>
      <xs:attribute name=""id"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""description"" type=""xs:string"" use=""required"" />
      <xs:attribute name=""type"" type=""xs:string"" use=""required"" />
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
      <xs:attribute name=""lineNumber"" type=""xs:string"" />
      <xs:attribute name=""quantity"" type=""xs:string"" use=""required"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public cXML() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "cXML";
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
