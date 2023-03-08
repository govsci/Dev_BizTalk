namespace Inbound_Status_Doc_X12_Process.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EdiSchemas.X12.X12_00401_810", typeof(global::EdiSchemas.X12.X12_00401_810))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EdiSchemas.cXML.cXMLinvoice", typeof(global::EdiSchemas.cXML.cXMLinvoice))]
    public sealed class Map_810 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://www.w3.org/XML/1998/namespace"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:X12_00401_810"" />
  </xsl:template>
  <xsl:template match=""/s0:X12_00401_810"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimRight(&quot;TVGOVTSCISOURCE&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringTrimRight(&quot;USD&quot;)"" />
    <cXML_Invoice>
      <Header>
        <From>
          <Credential>
            <Identity>
              <xsl:value-of select=""$var:v1"" />
            </Identity>
          </Credential>
        </From>
        <Sender>
          <UserAgent>
            <xsl:value-of select=""$var:v1"" />
          </UserAgent>
        </Sender>
      </Header>
      <Request>
        <InvoiceDetailRequest>
          <InvoiceDetailRequestHeader>
            <xsl:attribute name=""invoiceDate"">
              <xsl:value-of select=""s0:BIG/BIG01/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""invoiceID"">
              <xsl:value-of select=""s0:BIG/BIG02/text()"" />
            </xsl:attribute>
            <xsl:for-each select=""s0:N1Loop1"">
              <InvoicePartner>
                <Contact>
                  <xsl:attribute name=""role"">
                    <xsl:value-of select=""s0:N1/N101/text()"" />
                  </xsl:attribute>
                  <Name>
                    <xsl:if test=""s0:N1/N102"">
                      <xsl:value-of select=""s0:N1/N102/text()"" />
                    </xsl:if>
                  </Name>
                  <xsl:for-each select=""s0:N3"">
                    <PostalAddress>
                      <xsl:if test=""../s0:N1/N102"">
                        <xsl:attribute name=""name"">
                          <xsl:value-of select=""../s0:N1/N102/text()"" />
                        </xsl:attribute>
                      </xsl:if>
                      <Street>
                        <xsl:value-of select=""N301/text()"" />
                      </Street>
                      <xsl:if test=""../s0:N4/N401"">
                        <City>
                          <xsl:value-of select=""../s0:N4/N401/text()"" />
                        </City>
                      </xsl:if>
                      <xsl:if test=""../s0:N4/N402"">
                        <State>
                          <xsl:value-of select=""../s0:N4/N402/text()"" />
                        </State>
                      </xsl:if>
                      <xsl:if test=""../s0:N4/N403"">
                        <PostalCode>
                          <xsl:value-of select=""../s0:N4/N403/text()"" />
                        </PostalCode>
                      </xsl:if>
                      <xsl:for-each select=""../s0:N4"">
                        <Country>
                          <xsl:if test=""N404"">
                            <xsl:attribute name=""isoCountryCode"">
                              <xsl:value-of select=""N404/text()"" />
                            </xsl:attribute>
                          </xsl:if>
                        </Country>
                      </xsl:for-each>
                    </PostalAddress>
                  </xsl:for-each>
                </Contact>
                <xsl:value-of select=""./text()"" />
              </InvoicePartner>
            </xsl:for-each>
          </InvoiceDetailRequestHeader>
          <InvoiceDetailOrder>
            <InvoiceDetailOrderInfo>
              <OrderReference>
                <xsl:if test=""s0:BIG/BIG04"">
                  <xsl:attribute name=""orderID"">
                    <xsl:value-of select=""s0:BIG/BIG04/text()"" />
                  </xsl:attribute>
                </xsl:if>
              </OrderReference>
            </InvoiceDetailOrderInfo>
            <xsl:for-each select=""s0:IT1Loop1"">
              <xsl:variable name=""var:v2"" select=""userCSharp:StringTrimRight(&quot;USD&quot;)"" />
              <InvoiceDetailItem>
                <xsl:if test=""s0:IT1/IT102"">
                  <xsl:attribute name=""quantity"">
                    <xsl:value-of select=""s0:IT1/IT102/text()"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""s0:IT1/IT103"">
                  <UnitOfMeasure>
                    <xsl:value-of select=""s0:IT1/IT103/text()"" />
                  </UnitOfMeasure>
                </xsl:if>
                <UnitPrice>
                  <Money>
                    <xsl:attribute name=""currency"">
                      <xsl:value-of select=""$var:v2"" />
                    </xsl:attribute>
                    <xsl:if test=""s0:IT1/IT104"">
                      <xsl:value-of select=""s0:IT1/IT104/text()"" />
                    </xsl:if>
                  </Money>
                </UnitPrice>
                <InvoiceDetailItemReference>
                  <xsl:if test=""s0:IT1/IT101"">
                    <xsl:attribute name=""lineNumber"">
                      <xsl:value-of select=""s0:IT1/IT101/text()"" />
                    </xsl:attribute>
                  </xsl:if>
                  <ItemID>
                    <xsl:if test=""s0:IT1/IT107"">
                      <SupplierPartID>
                        <xsl:value-of select=""s0:IT1/IT107/text()"" />
                      </SupplierPartID>
                    </xsl:if>
                  </ItemID>
                  <xsl:for-each select=""s0:PIDLoop1"">
                    <Description>
                      <xsl:value-of select=""./text()"" />
                      <xsl:if test=""s0:PID_2/PID05"">
                        <xsl:value-of select=""s0:PID_2/PID05/text()"" />
                      </xsl:if>
                    </Description>
                  </xsl:for-each>
                </InvoiceDetailItemReference>
                <SubtotalAmount>
                  <Money>
                    <xsl:attribute name=""currency"">
                      <xsl:value-of select=""$var:v2"" />
                    </xsl:attribute>
                  </Money>
                  <xsl:value-of select=""../s0:TDS/TDS01/text()"" />
                </SubtotalAmount>
                <Tax>
                  <Money>
                    <xsl:attribute name=""currency"">
                      <xsl:value-of select=""$var:v2"" />
                    </xsl:attribute>
                  </Money>
                </Tax>
                <xsl:value-of select=""./text()"" />
              </InvoiceDetailItem>
            </xsl:for-each>
          </InvoiceDetailOrder>
          <InvoiceDetailSummary>
            <SubtotalAmount>
              <Money>
                <xsl:attribute name=""currency"">
                  <xsl:value-of select=""$var:v3"" />
                </xsl:attribute>
                <xsl:variable name=""var:v4"" select=""userCSharp:InitCumulativeSum(0)"" />
                <xsl:for-each select=""/s0:X12_00401_810/s0:IT1Loop1/s0:IT1"">
                  <xsl:variable name=""var:v5"" select=""userCSharp:MathMultiply(string(IT102/text()) , string(IT104/text()))"" />
                  <xsl:variable name=""var:v6"" select=""userCSharp:AddToCumulativeSum(0,string($var:v5),&quot;1000&quot;)"" />
                </xsl:for-each>
                <xsl:variable name=""var:v7"" select=""userCSharp:GetCumulativeSum(0)"" />
                <xsl:value-of select=""$var:v7"" />
              </Money>
            </SubtotalAmount>
            <Tax>
              <Money>
                <xsl:attribute name=""currency"">
                  <xsl:value-of select=""$var:v3"" />
                </xsl:attribute>
              </Money>
            </Tax>
            <xsl:for-each select=""s0:SACLoop2"">
              <ShippingAmount>
                <Money>
                  <xsl:if test=""s0:SAC_3/SAC02"">
                    <xsl:attribute name=""currency"">
                      <xsl:value-of select=""s0:SAC_3/SAC02/text()"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""s0:SAC_3/SAC05"">
                    <xsl:value-of select=""s0:SAC_3/SAC05/text()"" />
                  </xsl:if>
                </Money>
                <xsl:value-of select=""./text()"" />
              </ShippingAmount>
            </xsl:for-each>
            <GrossAmount>
              <Money>
                <xsl:attribute name=""currency"">
                  <xsl:value-of select=""$var:v3"" />
                </xsl:attribute>
                <xsl:variable name=""var:v8"" select=""userCSharp:InitCumulativeSum(0)"" />
                <xsl:for-each select=""/s0:X12_00401_810/s0:IT1Loop1/s0:IT1"">
                  <xsl:variable name=""var:v9"" select=""string(IT102/text())"" />
                  <xsl:variable name=""var:v10"" select=""string(IT104/text())"" />
                  <xsl:variable name=""var:v11"" select=""userCSharp:MathMultiply($var:v9 , $var:v10)"" />
                  <xsl:variable name=""var:v12"" select=""userCSharp:AddToCumulativeSum(0,string($var:v11),&quot;1000&quot;)"" />
                </xsl:for-each>
                <xsl:variable name=""var:v13"" select=""userCSharp:GetCumulativeSum(0)"" />
                <xsl:value-of select=""$var:v13"" />
              </Money>
            </GrossAmount>
            <NetAmount>
              <Money>
                <xsl:attribute name=""currency"">
                  <xsl:value-of select=""$var:v3"" />
                </xsl:attribute>
              </Money>
            </NetAmount>
            <DueAmount>
              <Money>
                <xsl:attribute name=""currency"">
                  <xsl:value-of select=""$var:v3"" />
                </xsl:attribute>
                <xsl:variable name=""var:v14"" select=""userCSharp:InitCumulativeSum(0)"" />
                <xsl:for-each select=""/s0:X12_00401_810/s0:IT1Loop1/s0:IT1"">
                  <xsl:variable name=""var:v15"" select=""string(IT102/text())"" />
                  <xsl:variable name=""var:v16"" select=""string(IT104/text())"" />
                  <xsl:variable name=""var:v17"" select=""userCSharp:MathMultiply($var:v15 , $var:v16)"" />
                  <xsl:variable name=""var:v18"" select=""userCSharp:AddToCumulativeSum(0,string($var:v17),&quot;1000&quot;)"" />
                </xsl:for-each>
                <xsl:variable name=""var:v19"" select=""userCSharp:GetCumulativeSum(0)"" />
                <xsl:value-of select=""$var:v19"" />
              </Money>
            </DueAmount>
          </InvoiceDetailSummary>
        </InvoiceDetailRequest>
      </Request>
    </cXML_Invoice>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringTrimRight(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimEnd(null);
}


public string MathMultiply(string param0, string param1)
{
	System.Collections.ArrayList listValues = new System.Collections.ArrayList();
	listValues.Add(param0);
	listValues.Add(param1);
	double ret = 1;
	bool first = true;
	foreach (string obj in listValues)
	{
		double d = 0;
		if (IsNumeric(obj, ref d))
		{
			if (first)
			{
				first = false;
				ret = d;
			}
			else
			{
				ret *= d;
			}
		}
		else
		{
			return """";
		}
	}
	return ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
}


public string InitCumulativeSum(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeSumArray.Count)
		{
			int i = myCumulativeSumArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeSumArray.Add("""");
			}
		}
		else
		{
			myCumulativeSumArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeSumArray = new System.Collections.ArrayList();

public string AddToCumulativeSum(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
    }
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		if (myCumulativeSumArray[index] == """")
		{
			myCumulativeSumArray[index] = d;
		}
		else
		{
			myCumulativeSumArray[index] = (double)(myCumulativeSumArray[index]) + d;
		}
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string GetCumulativeSum(int index)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"EdiSchemas.X12.X12_00401_810";
        
        private const global::EdiSchemas.X12.X12_00401_810 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"EdiSchemas.cXML.cXMLinvoice";
        
        private const global::EdiSchemas.cXML.cXMLinvoice _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"EdiSchemas.X12.X12_00401_810";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"EdiSchemas.cXML.cXMLinvoice";
                return _TrgSchemas;
            }
        }
    }
}
