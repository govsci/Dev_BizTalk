namespace Inbound_Status_Doc_X12_Process.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EdiSchemas.X12.X12_00401_855", typeof(global::EdiSchemas.X12.X12_00401_855))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EdiSchemas.cXML.Fulfill+cXML_Fulfill", typeof(global::EdiSchemas.cXML.Fulfill.cXML_Fulfill))]
    public sealed class Map_855 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://www.w3.org/XML/1998/namespace"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:X12_00401_855"" />
  </xsl:template>
  <xsl:template match=""/s0:X12_00401_855"">
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
            <xsl:attribute name=""noticeDate"">
              <xsl:value-of select=""s0:BAK/BAK04/text()"" />
            </xsl:attribute>
            <xsl:variable name=""var:v2"" select=""userCSharp:setType(string(s0:BAK/BAK02/text()))"" />
            <xsl:attribute name=""type"">
              <xsl:value-of select=""$var:v2"" />
            </xsl:attribute>
            <xsl:variable name=""var:v3"" select=""userCSharp:setOps(string(s0:BAK/BAK01/text()))"" />
            <xsl:attribute name=""operation"">
              <xsl:value-of select=""$var:v3"" />
            </xsl:attribute>
            <xsl:attribute name=""confirmID"">
              <xsl:value-of select=""s0:BAK/BAK03/text()"" />
            </xsl:attribute>
            <xsl:for-each select=""s0:N1Loop1"">
              <Contact>
                <xsl:variable name=""var:v4"" select=""userCSharp:setTypeItem(string(s0:N1/N101/text()))"" />
                <xsl:attribute name=""role"">
                  <xsl:value-of select=""$var:v4"" />
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
                    <Country>
                      <xsl:if test=""N404"">
                        <xsl:attribute name=""isoCountryCode"">
                          <xsl:value-of select=""N404/text()"" />
                        </xsl:attribute>
                      </xsl:if>
                    </Country>
                  </PostalAddress>
                </xsl:for-each>
              </Contact>
            </xsl:for-each>
          </ConfirmationHeader>
          <OrderReference>
            <xsl:attribute name=""orderID"">
              <xsl:value-of select=""s0:BAK/BAK03/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""orderDate"">
              <xsl:value-of select=""s0:BAK/BAK04/text()"" />
            </xsl:attribute>
            <DocumentReference>
              <xsl:variable name=""var:v5"" select=""userCSharp:payLoad()"" />
              <xsl:attribute name=""payloadID"">
                <xsl:value-of select=""$var:v5"" />
              </xsl:attribute>
            </DocumentReference>
          </OrderReference>
          <xsl:for-each select=""s0:PO1Loop1"">
            <ConfirmationItem>
              <xsl:if test=""s0:PO1/PO102"">
                <xsl:attribute name=""quantity"">
                  <xsl:value-of select=""s0:PO1/PO102/text()"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""s0:PO1/PO101"">
                <xsl:attribute name=""lineNumber"">
                  <xsl:value-of select=""s0:PO1/PO101/text()"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""s0:PO1/PO103"">
                <UnitOfMeasure>
                  <xsl:value-of select=""s0:PO1/PO103/text()"" />
                </UnitOfMeasure>
              </xsl:if>
              <xsl:for-each select=""s0:ACKLoop1"">
                <ConfirmationStatus>
                  <xsl:if test=""s0:ACK/ACK02"">
                    <xsl:attribute name=""quantity"">
                      <xsl:value-of select=""s0:ACK/ACK02/text()"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:variable name=""var:v6"" select=""userCSharp:setTypeItem(string(s0:ACK/ACK01/text()))"" />
                  <xsl:attribute name=""type"">
                    <xsl:value-of select=""$var:v6"" />
                  </xsl:attribute>
                  <xsl:if test=""s0:ACK/ACK05"">
                    <xsl:attribute name=""deliveryDate"">
                      <xsl:value-of select=""s0:ACK/ACK05/text()"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""s0:ACK/ACK03"">
                    <UnitOfMeasure>
                      <xsl:value-of select=""s0:ACK/ACK03/text()"" />
                    </UnitOfMeasure>
                  </xsl:if>
                  <ItemIn>
                    <xsl:if test=""../s0:PO1/PO102"">
                      <xsl:attribute name=""quantity"">
                        <xsl:value-of select=""../s0:PO1/PO102/text()"" />
                      </xsl:attribute>
                    </xsl:if>
                    <xsl:if test=""../s0:PO1/PO101"">
                      <xsl:attribute name=""lineNumber"">
                        <xsl:value-of select=""../s0:PO1/PO101/text()"" />
                      </xsl:attribute>
                    </xsl:if>
                    <ItemID>
                      <xsl:if test=""../s0:PO1/PO109"">
                        <SupplierPartID>
                          <xsl:value-of select=""../s0:PO1/PO109/text()"" />
                        </SupplierPartID>
                      </xsl:if>
                    </ItemID>
                    <ItemDetail>
                      <UnitPrice>
                        <Money>
                          <xsl:if test=""../s0:PO1/PO104"">
                            <xsl:value-of select=""../s0:PO1/PO104/text()"" />
                          </xsl:if>
                        </Money>
                      </UnitPrice>
                    </ItemDetail>
                  </ItemIn>
                  <xsl:value-of select=""./text()"" />
                </ConfirmationStatus>
              </xsl:for-each>
              <xsl:value-of select=""./text()"" />
            </ConfirmationItem>
          </xsl:for-each>
        </ConfirmationRequest>
        <ShipNoticeRequest>
          <ShipNoticeHeader>
            <xsl:attribute name=""operation"">
              <xsl:text>new</xsl:text>
            </xsl:attribute>
          </ShipNoticeHeader>
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


public string setOps(string param1)
        {
            if(param1.ToLower()!=""new"")
            {
                param1 = ""update"";
            }
            return param1;
        }

public string setType(string param1)
        {
            if(param1.ToLower()==""ac"")
            {
                param1 = ""detail"";
            }
            else if (param1.ToLower() == ""ad"")
            {
                param1 = ""accept"";
            }
            else
            {
                param1 = ""reject"";
            }
            return param1;
        }

public string setTypeItem(string param1)
        {
            if (param1.ToLower() == ""ia"")
            {
                param1 = ""accpet"";
            }
            else if (param1.ToLower() == ""ib"")
            {
                param1 = ""backordered"";
            }
            else if (param1.ToLower() == ""ir"")
            {
                param1 = ""reject"";
            }
            else
            {
                param1 = ""detail"";
            }
            return param1;
        }


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"EdiSchemas.X12.X12_00401_855";
        
        private const global::EdiSchemas.X12.X12_00401_855 _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"EdiSchemas.X12.X12_00401_855";
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
