namespace Pipelines_EDI
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class Pipelines_EDI_Send : Microsoft.BizTalk.PipelineOM.SendPipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>8c6b051c-0ff5-4fc2-9ae5-5016cb726282</CategoryId>  <FriendlyName>Transmit</FriendlyName"+
">  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Pre-Assemble\" minO"+
"ccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4101-4cce-4536-83fa-4a5040674ad6\" />      <Co"+
"mponents />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Assemb"+
"le\" minOccurs=\"0\" maxOccurs=\"1\" execMethod=\"All\" stageId=\"9d0e4107-4cce-4536-83fa-4a5040674ad6\" />  "+
"    <Components>        <Component>          <Name>Microsoft.BizTalk.Edi.Pipelines.EdiAssembler,Micr"+
"osoft.BizTalk.Edi.PipelineComponents, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364"+
"e35</Name>          <ComponentName>EDI Assembler</ComponentName>          <Description>EDI Assembler"+
"</Description>          <Version>1.1</Version>          <Properties>            <Property Name=\"Over"+
"rideFallbackSettings\">              <Value xsi:type=\"xsd:boolean\">true</Value>            </Property"+
">            <Property Name=\"XmlSchemaValidation\">              <Value xsi:type=\"xsd:boolean\">false<"+
"/Value>            </Property>            <Property Name=\"EdiDataValidation\">              <Value xs"+
"i:type=\"xsd:boolean\">true</Value>            </Property>            <Property Name=\"AllowTrailingDel"+
"imiters\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>           "+
" <Property Name=\"CharacterSet\">              <Value xsi:type=\"xsd:string\">UTF8</Value>            </"+
"Property>          </Properties>          <CachedDisplayName>EDI Assembler</CachedDisplayName>      "+
"    <CachedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage>    <S"+
"tage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Encode\" minOccurs=\"0\" maxOccurs=\"-1"+
"\" execMethod=\"All\" stageId=\"9d0e4108-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>"+
"  </Stages></Document>";
        
        private const string _versionDependentGuid = "9905408d-867e-4a63-b636-9dbf189cfd35";
        
        public Pipelines_EDI_Send()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4107-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Edi.Pipelines.EdiAssembler,Microsoft.BizTalk.Edi.PipelineComponents, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"OverrideFallbac"+
"kSettings\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Name=\"XmlSch"+
"emaValidation\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"E"+
"diDataValidation\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Name="+
"\"AllowTrailingDelimiters\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Prope"+
"rty Name=\"CharacterSet\">      <Value xsi:type=\"xsd:string\">UTF8</Value>    </Property>  </Properties"+
"></PropertyBag>";
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
