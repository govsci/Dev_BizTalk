namespace Pipelines_EDI
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class Pipelines_EDI_Receive : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" "+
"minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" "+
"/>      <Components>        <Component>          <Name>Microsoft.BizTalk.Edi.Pipelines.EdiDisassembl"+
"er,Microsoft.BizTalk.Edi.PipelineComponents, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf38"+
"56ad364e35</Name>          <ComponentName>EDI disassembler</ComponentName>          <Description>EDI"+
" Disassembler</Description>          <Version>1.1</Version>          <Properties>            <Proper"+
"ty Name=\"XmlSchemaValidation\">              <Value xsi:type=\"xsd:boolean\">false</Value>            <"+
"/Property>            <Property Name=\"Override997With999\">              <Value xsi:type=\"xsd:boolean"+
"\">false</Value>            </Property>            <Property Name=\"OverrideFallbackSettings\">        "+
"      <Value xsi:type=\"xsd:boolean\">true</Value>            </Property>            <Property Name=\"E"+
"diDataValidation\">              <Value xsi:type=\"xsd:boolean\">true</Value>            </Property>   "+
"         <Property Name=\"AllowTrailingDelimiters\">              <Value xsi:type=\"xsd:boolean\">false<"+
"/Value>            </Property>            <Property Name=\"UseIsa11AsRepetitionSeparator\">           "+
"   <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Property Name=\"Pre"+
"serveInterchange\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>  "+
"          <Property Name=\"EfactDelimiters\">              <Value xsi:type=\"xsd:string\">0x3A, 0x2B, 0x"+
"2C, 0x3F, 0x20, 0x27</Value>            </Property>            <Property Name=\"CreateXmlTagForTraili"+
"ngSeparators\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>      "+
"      <Property Name=\"MaskSecurityInformation\">              <Value xsi:type=\"xsd:boolean\">true</Val"+
"ue>            </Property>            <Property Name=\"ConvertToImpliedDecimal\">              <Value "+
"xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Property Name=\"RouteAckOn2Wa"+
"yPort\">              <Value xsi:type=\"xsd:boolean\">true</Value>            </Property>            <P"+
"roperty Name=\"CharacterSet\">              <Value xsi:type=\"xsd:string\">UTF8</Value>            </Pro"+
"perty>            <Property Name=\"DetectMID\">              <Value xsi:type=\"xsd:boolean\">true</Value"+
">            </Property>            <Property Name=\"UseDotAsDecimalSeparator\">              <Value x"+
"si:type=\"xsd:boolean\">false</Value>            </Property>          </Properties>          <CachedDi"+
"splayName>EDI disassembler</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>     "+
"   </Component>      </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" "+
"_locID=\"3\" Name=\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536"+
"-83fa-4a5040674ad6\" />      <Components />    </Stage>    <Stage>      <PolicyFileStage _locAttrData"+
"=\"Name\" _locID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e41"+
"0e-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "1c9fc3f7-af4c-47df-a934-9dacfbae6a5a";
        
        public Pipelines_EDI_Receive()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Edi.Pipelines.EdiDisassembler,Microsoft.BizTalk.Edi.PipelineComponents, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"XmlSchemaValida"+
"tion\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"Override99"+
"7With999\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"Overri"+
"deFallbackSettings\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Nam"+
"e=\"EdiDataValidation\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property N"+
"ame=\"AllowTrailingDelimiters\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <P"+
"roperty Name=\"UseIsa11AsRepetitionSeparator\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </"+
"Property>    <Property Name=\"PreserveInterchange\">      <Value xsi:type=\"xsd:boolean\">false</Value> "+
"   </Property>    <Property Name=\"EfactDelimiters\">      <Value xsi:type=\"xsd:string\">0x3A, 0x2B, 0x"+
"2C, 0x3F, 0x20, 0x27</Value>    </Property>    <Property Name=\"CreateXmlTagForTrailingSeparators\">  "+
"    <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"MaskSecurityInform"+
"ation\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Name=\"ConvertToI"+
"mpliedDecimal\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"R"+
"outeAckOn2WayPort\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Name"+
"=\"CharacterSet\">      <Value xsi:type=\"xsd:string\">UTF8</Value>    </Property>    <Property Name=\"De"+
"tectMID\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Name=\"UseDotAs"+
"DecimalSeparator\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>  </Properties></P"+
"ropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
