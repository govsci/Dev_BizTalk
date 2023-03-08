namespace CxmlSchemas.schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Kemlab.Medrpt",@"Root")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Root"})]
    public sealed class EDI : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Kemlab.Medrpt"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Kemlab.Medrpt"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo count_positions_by_byte=""false"" standard=""Flat File"" parser_optimization=""complexity"" codepage=""1252"" escape_char_type=""hex"" default_escape_char=""0x3F"" root_reference=""Root"" allow_early_termination=""true"" lookahead_depth=""0"" default_pad_char="" "" pad_char_type=""char"" suppress_empty_nodes=""false"" generate_empty_nodes=""true"" early_terminate_optional_fields=""false"" allow_message_breakup_of_infix_root=""false"" compile_parse_tables=""false"" />
      <schemaEditorExtension:schemaInfo namespaceAlias=""b"" extensionClass=""Microsoft.BizTalk.FlatFileExtension.FlatFileExtension"" standardName=""Flat File"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Root"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" sequence_number=""1"" child_delimiter_type=""hex"" child_delimiter=""0x27"" child_order=""postfix"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:annotation>
          <xs:appinfo>
            <b:groupInfo sequence_number=""0"" />
          </xs:appinfo>
        </xs:annotation>
        <xs:element minOccurs=""0"" name=""UNA"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""positional"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" tag_name=""UNA"" sequence_number=""1"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:attribute name=""Data"" type=""xs:string"" use=""required"">
              <xs:annotation>
                <xs:appinfo>
                  <b:fieldInfo sequence_number=""1"" justification=""left"" pos_length=""5"" pos_offset=""3"" />
                </xs:appinfo>
              </xs:annotation>
            </xs:attribute>
          </xs:complexType>
        </xs:element>
        <xs:element name=""UNB"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" child_delimiter_type=""hex"" child_delimiter=""0x2B"" child_order=""prefix"" tag_name=""UNB"" sequence_number=""2"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:annotation>
                <xs:appinfo>
                  <b:groupInfo sequence_number=""0"" />
                </xs:appinfo>
              </xs:annotation>
              <xs:element minOccurs=""0"" name=""S001"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo sequence_number=""1"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" child_delimiter_type=""hex"" child_delimiter=""0x3A"" child_order=""infix"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:attribute name=""M0001"" type=""xs:string"" use=""required"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""1"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                  <xs:attribute name=""M0002"" type=""xs:string"" use=""required"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""2"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""S002"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo sequence_number=""2"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" child_delimiter_type=""hex"" child_delimiter=""0x3A"" child_order=""infix"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:attribute name=""M0004"" type=""xs:string"" use=""required"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""1"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                  <xs:attribute name=""C0007"" type=""xs:string"" use=""optional"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""2"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                  <xs:attribute name=""C0008"" type=""xs:string"" use=""optional"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""3"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""S003"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo sequence_number=""3"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" child_delimiter_type=""hex"" child_delimiter=""0x3A"" child_order=""infix"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:attribute name=""M0010"" type=""xs:string"" use=""required"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""1"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                  <xs:attribute name=""C0007"" type=""xs:string"" use=""optional"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""2"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                  <xs:attribute name=""C0014"" type=""xs:string"" use=""optional"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""3"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""S004"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo sequence_number=""4"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" child_delimiter_type=""hex"" child_delimiter=""0x3A"" child_order=""infix"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:attribute name=""M0017"" type=""xs:string"" use=""required"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""1"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                  <xs:attribute name=""M0019"" type=""xs:string"" use=""required"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""2"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""S0020"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo sequence_number=""5"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" child_delimiter_type=""hex"" child_delimiter=""0x3A"" child_order=""infix"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:attribute name=""M0020"" type=""xs:string"" use=""required"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo justification=""left"" sequence_number=""1"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""S005"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo sequence_number=""6"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" child_delimiter_type=""hex"" child_delimiter=""0x3A"" child_order=""infix"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:attribute name=""M0022"" type=""xs:string"" use=""required"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""1"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""S0026"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo sequence_number=""7"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" child_delimiter_type=""hex"" child_delimiter=""0x3A"" child_order=""infix"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:attribute name=""C0026"" type=""xs:string"" use=""optional"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""1"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""S0029"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo sequence_number=""8"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" child_delimiter_type=""hex"" child_delimiter=""0x3A"" child_order=""infix"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:attribute name=""C0029"" type=""xs:string"" use=""optional"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""1"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""S0031"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo sequence_number=""9"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" child_delimiter_type=""hex"" child_delimiter=""0x3A"" child_order=""infix"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:attribute name=""C0031"" type=""xs:string"" use=""optional"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""1"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""S0035"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo sequence_number=""10"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" child_delimiter_type=""hex"" child_delimiter=""0x3A"" child_order=""infix"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:attribute name=""C0035"" type=""xs:string"" use=""optional"">
                    <xs:annotation>
                      <xs:appinfo>
                        <b:fieldInfo sequence_number=""1"" justification=""left"" />
                      </xs:appinfo>
                    </xs:annotation>
                  </xs:attribute>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public EDI() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Root";
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
