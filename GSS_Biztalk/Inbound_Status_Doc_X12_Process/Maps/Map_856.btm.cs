namespace Inbound_Status_Doc_X12_Process.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EdiSchemas.X12.X12_00401_856", typeof(global::EdiSchemas.X12.X12_00401_856))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EdiSchemas.cXML.Fulfill+cXML_Fulfill", typeof(global::EdiSchemas.cXML.Fulfill.cXML_Fulfill))]
    public sealed class Map_856 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://www.w3.org/XML/1998/namespace"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:X12_00401_856"" />
  </xsl:template>
  <xsl:template match=""/s0:X12_00401_856"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimRight(&quot;S3CR3T&quot;)"" />
    <cXML_Fulfill>
      <xsl:attribute name=""version"">
        <xsl:text>1.1.010</xsl:text>
      </xsl:attribute>
      <Header>
        <From>
          <Credential>
            <DigitalSignature>
              <xsl:attribute name=""encoding"">
                <xsl:text>Base64</xsl:text>
              </xsl:attribute>
              <xsl:attribute name=""type"">
                <xsl:text>PK7 self-contained</xsl:text>
              </xsl:attribute>
            </DigitalSignature>
          </Credential>
        </From>
        <To>
          <Credential>
            <DigitalSignature>
              <xsl:attribute name=""encoding"">
                <xsl:text>Base64</xsl:text>
              </xsl:attribute>
              <xsl:attribute name=""type"">
                <xsl:text>PK7 self-contained</xsl:text>
              </xsl:attribute>
            </DigitalSignature>
          </Credential>
        </To>
        <Sender>
          <Credential>
            <SharedSecret>
              <xsl:value-of select=""$var:v1"" />
            </SharedSecret>
            <DigitalSignature>
              <xsl:attribute name=""encoding"">
                <xsl:text>Base64</xsl:text>
              </xsl:attribute>
              <xsl:attribute name=""type"">
                <xsl:text>PK7 self-contained</xsl:text>
              </xsl:attribute>
            </DigitalSignature>
          </Credential>
        </Sender>
      </Header>
      <Message>
        <xsl:attribute name=""deploymentMode"">
          <xsl:text>production</xsl:text>
        </xsl:attribute>
      </Message>
      <Request>
        <xsl:attribute name=""deploymentMode"">
          <xsl:text>production</xsl:text>
        </xsl:attribute>
        <ConfirmationRequest>
          <ConfirmationHeader>
            <xsl:attribute name=""operation"">
              <xsl:text>new</xsl:text>
            </xsl:attribute>
          </ConfirmationHeader>
        </ConfirmationRequest>
        <ShipNoticeRequest>
          <xsl:for-each select=""s0:HLLoop1"">
            <ShipNoticeHeader>
              <xsl:attribute name=""deliveryDate"">
                <xsl:value-of select=""../s0:BSN/BSN03/text()"" />
              </xsl:attribute>
              <xsl:if test=""../s0:DTM/DTM02"">
                <xsl:attribute name=""shipmentDate"">
                  <xsl:value-of select=""../s0:DTM/DTM02/text()"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:attribute name=""shipmentID"">
                <xsl:value-of select=""../s0:BSN/BSN02/text()"" />
              </xsl:attribute>
              <xsl:attribute name=""operation"">
                <xsl:text>new</xsl:text>
              </xsl:attribute>
              <xsl:for-each select=""s0:N1Loop1"">
                <Contact>
                  <xsl:attribute name=""role"">
                    <xsl:value-of select=""s0:N1/N101/text()"" />
                  </xsl:attribute>
                  <Name>
                    <xsl:if test=""s0:N1/N102"">
                      <xsl:value-of select=""s0:N1/N102/text()"" />
                    </xsl:if>
                  </Name>
                  <xsl:for-each select=""s0:N4"">
                    <PostalAddress>
                      <xsl:for-each select=""../s0:N3"">
                        <Street>
                          <xsl:value-of select=""N301/text()"" />
                        </Street>
                      </xsl:for-each>
                      <xsl:if test=""N401"">
                        <City>
                          <xsl:value-of select=""N401/text()"" />
                        </City>
                      </xsl:if>
                      <xsl:if test=""N402"">
                        <State>
                          <xsl:value-of select=""N402/text()"" />
                        </State>
                      </xsl:if>
                      <xsl:if test=""N403"">
                        <PostalCode>
                          <xsl:value-of select=""N403/text()"" />
                        </PostalCode>
                      </xsl:if>
                    </PostalAddress>
                  </xsl:for-each>
                  <xsl:value-of select=""./text()"" />
                </Contact>
              </xsl:for-each>
              <xsl:value-of select=""./text()"" />
            </ShipNoticeHeader>
          </xsl:for-each>
          <xsl:for-each select=""s0:HLLoop1"">
            <xsl:for-each select=""s0:TD5"">
              <Route>
                <CarrierIdentifier>
                  <xsl:if test=""TD505"">
                    <xsl:attribute name=""domain"">
                      <xsl:value-of select=""TD505/text()"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""TD505"">
                    <xsl:value-of select=""TD505/text()"" />
                  </xsl:if>
                </CarrierIdentifier>
                <xsl:if test=""TD508"">
                  <ShipmentIdentifier>
                    <xsl:value-of select=""TD508/text()"" />
                  </ShipmentIdentifier>
                </xsl:if>
                <xsl:if test=""../s0:REF/REF02"">
                  <ShipmentIdentifier>
                    <xsl:value-of select=""../s0:REF/REF02/text()"" />
                  </ShipmentIdentifier>
                </xsl:if>
              </Route>
            </xsl:for-each>
          </xsl:for-each>
          <ShipNoticePortion>
            <xsl:for-each select=""s0:HLLoop1"">
              <xsl:for-each select=""s0:PRF"">
                <OrderReference>
                  <xsl:attribute name=""orderID"">
                    <xsl:value-of select=""PRF01/text()"" />
                  </xsl:attribute>
                  <xsl:if test=""PRF04"">
                    <xsl:attribute name=""orderDate"">
                      <xsl:value-of select=""PRF04/text()"" />
                    </xsl:attribute>
                  </xsl:if>
                  <DocumentReference>
                    <xsl:variable name=""var:v2"" select=""userCSharp:payLoad()"" />
                    <xsl:attribute name=""payloadID"">
                      <xsl:value-of select=""$var:v2"" />
                    </xsl:attribute>
                  </DocumentReference>
                </OrderReference>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:HLLoop1"">
              <ShipNoticeItem>
                <xsl:attribute name=""quantity"">
                  <xsl:value-of select=""s0:SN1/SN102/text()"" />
                </xsl:attribute>
                <xsl:if test=""s0:SN1/SN101"">
                  <xsl:attribute name=""lineNumber"">
                    <xsl:value-of select=""s0:SN1/SN101/text()"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""s0:LIN/LIN01"">
                  <xsl:attribute name=""lineNumber"">
                    <xsl:value-of select=""s0:LIN/LIN01/text()"" />
                  </xsl:attribute>
                </xsl:if>
                <UnitOfMeasure>
                  <xsl:value-of select=""s0:SN1/SN103/text()"" />
                </UnitOfMeasure>
                <xsl:value-of select=""./text()"" />
              </ShipNoticeItem>
            </xsl:for-each>
          </ShipNoticePortion>
        </ShipNoticeRequest>
      </Request>
    </cXML_Fulfill>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string payLoad()
        {
            return DateTime.Now.ToString(""yyyy-MM-ddTHH:mm:ss"") + ""@govsci.com"";
        }

public string StringTrimRight(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimEnd(null);
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"EdiSchemas.X12.X12_00401_856";
        
        private const global::EdiSchemas.X12.X12_00401_856 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"EdiSchemas.cXML.Fulfill+cXML_Fulfill";
        
        private const global::EdiSchemas.cXML.Fulfill.cXML_Fulfill _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltEngine {
            get {
                return _xsltEngine;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"EdiSchemas.X12.X12_00401_856";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"EdiSchemas.cXML.Fulfill+cXML_Fulfill";
                return _TrgSchemas;
            }
        }
    }
}
