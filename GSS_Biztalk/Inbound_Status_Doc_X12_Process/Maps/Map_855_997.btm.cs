namespace Inbound_Status_Doc_X12_Process.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EdiSchemas.X12.X12_00401_855", typeof(global::EdiSchemas.X12.X12_00401_855))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"EdiSchemas.X12.X12_00401_997", typeof(global::EdiSchemas.X12.X12_00401_997))]
    public sealed class Map_855_997 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/BizTalk/EDI/X12/2006"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:X12_00401_855"" />
  </xsl:template>
  <xsl:template match=""/ns0:X12_00401_855"">
    <xsl:variable name=""var:v2"" select=""userCSharp:StringTrimRight(&quot;PR&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringTrimRight(&quot;1&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringTrimRight(&quot;855&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringTrimRight(&quot;A&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringTrimRight(&quot;6&quot;)"" />
    <ns0:X12_00401_997>
      <xsl:for-each select=""ST"">
        <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimRight(&quot;997&quot;)"" />
        <ST>
          <ST01>
            <xsl:value-of select=""$var:v1"" />
          </ST01>
          <ST02>
            <xsl:value-of select=""ST02/text()"" />
          </ST02>
        </ST>
      </xsl:for-each>
      <ns0:AK1>
        <AK101>
          <xsl:value-of select=""$var:v2"" />
        </AK101>
        <AK102>
          <xsl:value-of select=""$var:v3"" />
        </AK102>
      </ns0:AK1>
      <ns0:AK2Loop1>
        <ns0:AK2>
          <AK201>
            <xsl:value-of select=""$var:v4"" />
          </AK201>
          <AK202>
            <xsl:value-of select=""ns0:BAK/BAK03/text()"" />
          </AK202>
        </ns0:AK2>
        <ns0:AK3Loop1>
          <ns0:AK3>
            <AK301>
              <xsl:value-of select=""$var:v3"" />
            </AK301>
          </ns0:AK3>
        </ns0:AK3Loop1>
        <ns0:AK5>
          <AK501>
            <xsl:value-of select=""$var:v5"" />
          </AK501>
        </ns0:AK5>
      </ns0:AK2Loop1>
      <ns0:AK9>
        <AK901>
          <xsl:value-of select=""$var:v5"" />
        </AK901>
        <AK902>
          <xsl:value-of select=""$var:v3"" />
        </AK902>
        <AK903>
          <xsl:value-of select=""$var:v3"" />
        </AK903>
        <AK904>
          <xsl:value-of select=""$var:v3"" />
        </AK904>
      </ns0:AK9>
      <SE>
        <SE01>
          <xsl:value-of select=""$var:v6"" />
        </SE01>
        <SE02>
          <xsl:value-of select=""ns0:BAK/BAK03/text()"" />
        </SE02>
      </SE>
    </ns0:X12_00401_997>
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



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"EdiSchemas.X12.X12_00401_855";
        
        private const global::EdiSchemas.X12.X12_00401_855 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"EdiSchemas.X12.X12_00401_997";
        
        private const global::EdiSchemas.X12.X12_00401_997 _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"EdiSchemas.X12.X12_00401_997";
                return _TrgSchemas;
            }
        }
    }
}
