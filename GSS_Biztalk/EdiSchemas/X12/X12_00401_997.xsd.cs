namespace EdiSchemas.X12 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.microsoft.com/BizTalk/EDI/X12/2006",@"X12_00401_997")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"X12_00401_997"})]
    public sealed class X12_00401_997 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" xmlns:btsedi=""http://schemas.microsoft.com/BizTalk/2005/EdiSchemaEditorExtension"" targetNamespace=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <schemaEditorExtension:schemaInfo namespaceAlias=""btsedi"" extensionClass=""Microsoft.BizTalk.Edi.SchemaEditorExtension.EdiSchemaExtension"" standardName=""EDI"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
      <b:schemaInfo version=""1.0"" document_type=""997"" standard=""EDI"" standards_version=""00401"" root_reference=""X12_00401_997"" displayroot_reference=""X12_00401_997"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" X12ConditionDesignator_Check=""No"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:annotation>
    <xs:documentation xml:lang=""en"">copyright © Microsoft Corporation. All rights reserved.</xs:documentation>
  </xs:annotation>
  <xs:annotation>
    <xs:documentation>Schema name: X12_4010_997</xs:documentation>
  </xs:annotation>
  <xs:element name=""X12_00401_997"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""postfix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Functional Acknowledgment"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""ST"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo notes=""Transaction Set Header"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ST01"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Transaction Set Identifier Code_143"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""X12_AN"">
                    <xs:minLength value=""3"" />
                    <xs:maxLength value=""3"" />
                    <xs:enumeration value=""997"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""ST02"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Transaction Set Control Number_329"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""X12_AN"">
                    <xs:minLength value=""4"" />
                    <xs:maxLength value=""9"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""ST03"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Implementation Convention Preference_1705"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""X12_AN"">
                    <xs:minLength value=""1"" />
                    <xs:maxLength value=""9"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element ref=""AK1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AK1"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Functional Group Response Header"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""999999"" ref=""AK2Loop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Transaction Set Response Header"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""AK9"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AK9"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Functional Group Response Trailer"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""SE"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo notes=""Transaction Set Trailer"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""SE01"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Number of Included Segments_96"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""X12_AN"">
                    <xs:minLength value=""1"" />
                    <xs:maxLength value=""10"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""SE02"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo notes=""Transaction Set Control Number_329"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:simpleType>
                  <xs:restriction base=""X12_AN"">
                    <xs:minLength value=""4"" />
                    <xs:maxLength value=""9"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AK3Loop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Data Segment Note"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""AK3"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AK3"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Data Segment Note"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""99"" ref=""AK4"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AK4"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Data Element Note"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AK2Loop1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Transaction Set Response Header"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""AK2"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AK2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Transaction Set Response Header"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""999999"" ref=""AK3Loop1"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_record"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Loop for Data Segment Note"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""AK5"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AK5"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Transaction Set Response Trailer"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AK1"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AK1"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Functional Group Response Header"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""AK101"" type=""X12_ID_479"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Functional Identifier Code_479"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""AK102"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Group Control Number_28"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AK2"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AK2"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Transaction Set Response Header"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""AK201"" type=""X12_ID_143"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transaction Set Identifier Code_143"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""AK202"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transaction Set Control Number_329"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""4"" />
              <xs:maxLength value=""9"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AK3"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AK3"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Data Segment Note"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""AK301"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Segment ID Code_721"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_ID"">
              <xs:minLength value=""2"" />
              <xs:maxLength value=""3"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element name=""AK302"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Segment Position in Transaction Set_719"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK303"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Loop Identifier Code_447"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK304"" type=""X12_ID_720"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Segment Syntax Error Code_720"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AK4"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AK4"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Data Element Note"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""C030"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Position in Segment"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK402"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Data Element Reference Number_725"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""4"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element name=""AK403"" type=""X12_ID_723"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Data Element Syntax Error Code_723"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK404"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Copy of Bad Data Element_724"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_AN"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""99"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AK5"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AK5"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Transaction Set Response Trailer"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""AK501"" type=""X12_ID_717"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transaction Set Acknowledgment Code_717"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK502"" type=""X12_ID_718"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transaction Set Syntax Error Code_718"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK503"" type=""X12_ID_718"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transaction Set Syntax Error Code_718"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK504"" type=""X12_ID_718"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transaction Set Syntax Error Code_718"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK505"" type=""X12_ID_718"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transaction Set Syntax Error Code_718"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK506"" type=""X12_ID_718"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Transaction Set Syntax Error Code_718"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AK9"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""prefix"" tag_name=""AK9"" delimiter_type=""inherit_field"" count_ignore=""no"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Functional Group Response Trailer"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""AK901"" type=""X12_ID_715"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Functional Group Acknowledge Code_715"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""AK902"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of Transaction Sets Included_97"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element name=""AK903"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of Received Transaction Sets_123"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element name=""AK904"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Number of Accepted Transaction Sets_2"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""6"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK905"" type=""X12_ID_716"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Functional Group Syntax Error Code_716"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK906"" type=""X12_ID_716"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Functional Group Syntax Error Code_716"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK907"" type=""X12_ID_716"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Functional Group Syntax Error Code_716"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK908"" type=""X12_ID_716"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Functional Group Syntax Error Code_716"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" name=""AK909"" type=""X12_ID_716"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Functional Group Syntax Error Code_716"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""C030"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" field_order=""infix"" delimiter_type=""inherit_subfield"" count_ignore=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" notes=""Position in Segment"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""C03001"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Element Position in Segment_722"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""2"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""C03002"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""Component Data Element Position in Composite_1528"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:simpleType>
            <xs:restriction base=""X12_N0"">
              <xs:minLength value=""1"" />
              <xs:maxLength value=""2"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:simpleType name=""X12_ID_479"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""AG"" />
      <xs:enumeration value=""AH"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AO"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BF"" />
      <xs:enumeration value=""BL"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CB"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CI"" />
      <xs:enumeration value=""CJ"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CV"" />
      <xs:enumeration value=""D3"" />
      <xs:enumeration value=""D4"" />
      <xs:enumeration value=""D5"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""DX"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""EV"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FB"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FG"" />
      <xs:enumeration value=""FH"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""GB"" />
      <xs:enumeration value=""GC"" />
      <xs:enumeration value=""GE"" />
      <xs:enumeration value=""GF"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""GP"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""GT"" />
      <xs:enumeration value=""HB"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HN"" />
      <xs:enumeration value=""HP"" />
      <xs:enumeration value=""HR"" />
      <xs:enumeration value=""HS"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IE"" />
      <xs:enumeration value=""IG"" />
      <xs:enumeration value=""II"" />
      <xs:enumeration value=""IJ"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IO"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IR"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""KM"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MF"" />
      <xs:enumeration value=""MG"" />
      <xs:enumeration value=""MH"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MJ"" />
      <xs:enumeration value=""MK"" />
      <xs:enumeration value=""MM"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MQ"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MT"" />
      <xs:enumeration value=""MV"" />
      <xs:enumeration value=""MW"" />
      <xs:enumeration value=""MX"" />
      <xs:enumeration value=""MY"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""NL"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""OG"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""OW"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PB"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PJ"" />
      <xs:enumeration value=""PK"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PQ"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PU"" />
      <xs:enumeration value=""PV"" />
      <xs:enumeration value=""PY"" />
      <xs:enumeration value=""QG"" />
      <xs:enumeration value=""QM"" />
      <xs:enumeration value=""QO"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RJ"" />
      <xs:enumeration value=""RK"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RU"" />
      <xs:enumeration value=""RV"" />
      <xs:enumeration value=""RW"" />
      <xs:enumeration value=""RX"" />
      <xs:enumeration value=""RY"" />
      <xs:enumeration value=""RZ"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SB"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SG"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SJ"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SM"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SQ"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""SW"" />
      <xs:enumeration value=""TA"" />
      <xs:enumeration value=""TC"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TF"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TO"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UB"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UD"" />
      <xs:enumeration value=""UI"" />
      <xs:enumeration value=""UP"" />
      <xs:enumeration value=""UW"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VB"" />
      <xs:enumeration value=""VC"" />
      <xs:enumeration value=""VD"" />
      <xs:enumeration value=""VE"" />
      <xs:enumeration value=""VH"" />
      <xs:enumeration value=""VI"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WB"" />
      <xs:enumeration value=""WG"" />
      <xs:enumeration value=""WI"" />
      <xs:enumeration value=""WL"" />
      <xs:enumeration value=""WR"" />
      <xs:enumeration value=""WT"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_143"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""100"" />
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""104"" />
      <xs:enumeration value=""105"" />
      <xs:enumeration value=""106"" />
      <xs:enumeration value=""107"" />
      <xs:enumeration value=""108"" />
      <xs:enumeration value=""109"" />
      <xs:enumeration value=""110"" />
      <xs:enumeration value=""112"" />
      <xs:enumeration value=""120"" />
      <xs:enumeration value=""121"" />
      <xs:enumeration value=""124"" />
      <xs:enumeration value=""125"" />
      <xs:enumeration value=""126"" />
      <xs:enumeration value=""127"" />
      <xs:enumeration value=""128"" />
      <xs:enumeration value=""129"" />
      <xs:enumeration value=""130"" />
      <xs:enumeration value=""131"" />
      <xs:enumeration value=""135"" />
      <xs:enumeration value=""138"" />
      <xs:enumeration value=""139"" />
      <xs:enumeration value=""140"" />
      <xs:enumeration value=""141"" />
      <xs:enumeration value=""142"" />
      <xs:enumeration value=""143"" />
      <xs:enumeration value=""144"" />
      <xs:enumeration value=""146"" />
      <xs:enumeration value=""147"" />
      <xs:enumeration value=""148"" />
      <xs:enumeration value=""149"" />
      <xs:enumeration value=""150"" />
      <xs:enumeration value=""151"" />
      <xs:enumeration value=""152"" />
      <xs:enumeration value=""153"" />
      <xs:enumeration value=""154"" />
      <xs:enumeration value=""155"" />
      <xs:enumeration value=""157"" />
      <xs:enumeration value=""159"" />
      <xs:enumeration value=""160"" />
      <xs:enumeration value=""161"" />
      <xs:enumeration value=""163"" />
      <xs:enumeration value=""170"" />
      <xs:enumeration value=""175"" />
      <xs:enumeration value=""176"" />
      <xs:enumeration value=""180"" />
      <xs:enumeration value=""185"" />
      <xs:enumeration value=""186"" />
      <xs:enumeration value=""188"" />
      <xs:enumeration value=""189"" />
      <xs:enumeration value=""190"" />
      <xs:enumeration value=""191"" />
      <xs:enumeration value=""194"" />
      <xs:enumeration value=""195"" />
      <xs:enumeration value=""196"" />
      <xs:enumeration value=""197"" />
      <xs:enumeration value=""198"" />
      <xs:enumeration value=""199"" />
      <xs:enumeration value=""200"" />
      <xs:enumeration value=""201"" />
      <xs:enumeration value=""202"" />
      <xs:enumeration value=""203"" />
      <xs:enumeration value=""204"" />
      <xs:enumeration value=""205"" />
      <xs:enumeration value=""206"" />
      <xs:enumeration value=""210"" />
      <xs:enumeration value=""211"" />
      <xs:enumeration value=""212"" />
      <xs:enumeration value=""213"" />
      <xs:enumeration value=""214"" />
      <xs:enumeration value=""215"" />
      <xs:enumeration value=""216"" />
      <xs:enumeration value=""217"" />
      <xs:enumeration value=""218"" />
      <xs:enumeration value=""219"" />
      <xs:enumeration value=""220"" />
      <xs:enumeration value=""222"" />
      <xs:enumeration value=""223"" />
      <xs:enumeration value=""224"" />
      <xs:enumeration value=""225"" />
      <xs:enumeration value=""242"" />
      <xs:enumeration value=""244"" />
      <xs:enumeration value=""248"" />
      <xs:enumeration value=""249"" />
      <xs:enumeration value=""250"" />
      <xs:enumeration value=""251"" />
      <xs:enumeration value=""252"" />
      <xs:enumeration value=""255"" />
      <xs:enumeration value=""256"" />
      <xs:enumeration value=""260"" />
      <xs:enumeration value=""261"" />
      <xs:enumeration value=""262"" />
      <xs:enumeration value=""263"" />
      <xs:enumeration value=""264"" />
      <xs:enumeration value=""265"" />
      <xs:enumeration value=""266"" />
      <xs:enumeration value=""267"" />
      <xs:enumeration value=""268"" />
      <xs:enumeration value=""270"" />
      <xs:enumeration value=""271"" />
      <xs:enumeration value=""272"" />
      <xs:enumeration value=""273"" />
      <xs:enumeration value=""275"" />
      <xs:enumeration value=""276"" />
      <xs:enumeration value=""277"" />
      <xs:enumeration value=""278"" />
      <xs:enumeration value=""280"" />
      <xs:enumeration value=""285"" />
      <xs:enumeration value=""286"" />
      <xs:enumeration value=""288"" />
      <xs:enumeration value=""290"" />
      <xs:enumeration value=""300"" />
      <xs:enumeration value=""301"" />
      <xs:enumeration value=""303"" />
      <xs:enumeration value=""304"" />
      <xs:enumeration value=""306"" />
      <xs:enumeration value=""309"" />
      <xs:enumeration value=""310"" />
      <xs:enumeration value=""311"" />
      <xs:enumeration value=""312"" />
      <xs:enumeration value=""313"" />
      <xs:enumeration value=""315"" />
      <xs:enumeration value=""317"" />
      <xs:enumeration value=""319"" />
      <xs:enumeration value=""321"" />
      <xs:enumeration value=""322"" />
      <xs:enumeration value=""323"" />
      <xs:enumeration value=""324"" />
      <xs:enumeration value=""325"" />
      <xs:enumeration value=""326"" />
      <xs:enumeration value=""350"" />
      <xs:enumeration value=""352"" />
      <xs:enumeration value=""353"" />
      <xs:enumeration value=""354"" />
      <xs:enumeration value=""355"" />
      <xs:enumeration value=""356"" />
      <xs:enumeration value=""357"" />
      <xs:enumeration value=""358"" />
      <xs:enumeration value=""361"" />
      <xs:enumeration value=""362"" />
      <xs:enumeration value=""404"" />
      <xs:enumeration value=""410"" />
      <xs:enumeration value=""411"" />
      <xs:enumeration value=""414"" />
      <xs:enumeration value=""417"" />
      <xs:enumeration value=""418"" />
      <xs:enumeration value=""419"" />
      <xs:enumeration value=""420"" />
      <xs:enumeration value=""421"" />
      <xs:enumeration value=""422"" />
      <xs:enumeration value=""423"" />
      <xs:enumeration value=""425"" />
      <xs:enumeration value=""426"" />
      <xs:enumeration value=""429"" />
      <xs:enumeration value=""431"" />
      <xs:enumeration value=""432"" />
      <xs:enumeration value=""433"" />
      <xs:enumeration value=""434"" />
      <xs:enumeration value=""435"" />
      <xs:enumeration value=""436"" />
      <xs:enumeration value=""437"" />
      <xs:enumeration value=""440"" />
      <xs:enumeration value=""451"" />
      <xs:enumeration value=""452"" />
      <xs:enumeration value=""453"" />
      <xs:enumeration value=""455"" />
      <xs:enumeration value=""456"" />
      <xs:enumeration value=""460"" />
      <xs:enumeration value=""463"" />
      <xs:enumeration value=""466"" />
      <xs:enumeration value=""468"" />
      <xs:enumeration value=""470"" />
      <xs:enumeration value=""475"" />
      <xs:enumeration value=""485"" />
      <xs:enumeration value=""486"" />
      <xs:enumeration value=""490"" />
      <xs:enumeration value=""492"" />
      <xs:enumeration value=""494"" />
      <xs:enumeration value=""500"" />
      <xs:enumeration value=""501"" />
      <xs:enumeration value=""503"" />
      <xs:enumeration value=""504"" />
      <xs:enumeration value=""511"" />
      <xs:enumeration value=""517"" />
      <xs:enumeration value=""521"" />
      <xs:enumeration value=""527"" />
      <xs:enumeration value=""536"" />
      <xs:enumeration value=""540"" />
      <xs:enumeration value=""561"" />
      <xs:enumeration value=""567"" />
      <xs:enumeration value=""568"" />
      <xs:enumeration value=""601"" />
      <xs:enumeration value=""602"" />
      <xs:enumeration value=""620"" />
      <xs:enumeration value=""622"" />
      <xs:enumeration value=""625"" />
      <xs:enumeration value=""650"" />
      <xs:enumeration value=""715"" />
      <xs:enumeration value=""805"" />
      <xs:enumeration value=""806"" />
      <xs:enumeration value=""810"" />
      <xs:enumeration value=""811"" />
      <xs:enumeration value=""812"" />
      <xs:enumeration value=""813"" />
      <xs:enumeration value=""814"" />
      <xs:enumeration value=""815"" />
      <xs:enumeration value=""816"" />
      <xs:enumeration value=""818"" />
      <xs:enumeration value=""819"" />
      <xs:enumeration value=""820"" />
      <xs:enumeration value=""821"" />
      <xs:enumeration value=""822"" />
      <xs:enumeration value=""823"" />
      <xs:enumeration value=""824"" />
      <xs:enumeration value=""826"" />
      <xs:enumeration value=""827"" />
      <xs:enumeration value=""828"" />
      <xs:enumeration value=""829"" />
      <xs:enumeration value=""830"" />
      <xs:enumeration value=""831"" />
      <xs:enumeration value=""832"" />
      <xs:enumeration value=""833"" />
      <xs:enumeration value=""834"" />
      <xs:enumeration value=""835"" />
      <xs:enumeration value=""836"" />
      <xs:enumeration value=""837"" />
      <xs:enumeration value=""838"" />
      <xs:enumeration value=""839"" />
      <xs:enumeration value=""840"" />
      <xs:enumeration value=""841"" />
      <xs:enumeration value=""842"" />
      <xs:enumeration value=""843"" />
      <xs:enumeration value=""844"" />
      <xs:enumeration value=""845"" />
      <xs:enumeration value=""846"" />
      <xs:enumeration value=""847"" />
      <xs:enumeration value=""848"" />
      <xs:enumeration value=""849"" />
      <xs:enumeration value=""850"" />
      <xs:enumeration value=""851"" />
      <xs:enumeration value=""852"" />
      <xs:enumeration value=""853"" />
      <xs:enumeration value=""854"" />
      <xs:enumeration value=""855"" />
      <xs:enumeration value=""856"" />
      <xs:enumeration value=""857"" />
      <xs:enumeration value=""858"" />
      <xs:enumeration value=""859"" />
      <xs:enumeration value=""860"" />
      <xs:enumeration value=""861"" />
      <xs:enumeration value=""862"" />
      <xs:enumeration value=""863"" />
      <xs:enumeration value=""864"" />
      <xs:enumeration value=""865"" />
      <xs:enumeration value=""866"" />
      <xs:enumeration value=""867"" />
      <xs:enumeration value=""868"" />
      <xs:enumeration value=""869"" />
      <xs:enumeration value=""870"" />
      <xs:enumeration value=""871"" />
      <xs:enumeration value=""872"" />
      <xs:enumeration value=""875"" />
      <xs:enumeration value=""876"" />
      <xs:enumeration value=""877"" />
      <xs:enumeration value=""878"" />
      <xs:enumeration value=""879"" />
      <xs:enumeration value=""880"" />
      <xs:enumeration value=""881"" />
      <xs:enumeration value=""882"" />
      <xs:enumeration value=""883"" />
      <xs:enumeration value=""884"" />
      <xs:enumeration value=""885"" />
      <xs:enumeration value=""886"" />
      <xs:enumeration value=""887"" />
      <xs:enumeration value=""888"" />
      <xs:enumeration value=""889"" />
      <xs:enumeration value=""891"" />
      <xs:enumeration value=""893"" />
      <xs:enumeration value=""894"" />
      <xs:enumeration value=""895"" />
      <xs:enumeration value=""896"" />
      <xs:enumeration value=""920"" />
      <xs:enumeration value=""924"" />
      <xs:enumeration value=""925"" />
      <xs:enumeration value=""926"" />
      <xs:enumeration value=""928"" />
      <xs:enumeration value=""940"" />
      <xs:enumeration value=""943"" />
      <xs:enumeration value=""944"" />
      <xs:enumeration value=""945"" />
      <xs:enumeration value=""947"" />
      <xs:enumeration value=""980"" />
      <xs:enumeration value=""990"" />
      <xs:enumeration value=""994"" />
      <xs:enumeration value=""996"" />
      <xs:enumeration value=""997"" />
      <xs:enumeration value=""998"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_720"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_723"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_717"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""X"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_718"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_715"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""X"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_ID_716"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""date"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d*-\d\d-\d\d"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""time"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d\d:\d\d(:\d\d)?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""X12_N"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_R"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_AN"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_ID"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_DT"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_TM"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N0"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N1"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N2"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N3"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N4"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N5"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N6"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N7"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N8"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""X12_N9"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
</xs:schema>";
        
        public X12_00401_997() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "X12_00401_997";
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
