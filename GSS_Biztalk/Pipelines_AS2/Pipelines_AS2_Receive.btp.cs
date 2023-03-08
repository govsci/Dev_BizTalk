namespace Pipelines_AS2
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class Pipelines_AS2_Receive : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s>        <Component>          <Name>Microsoft.BizTalk.AS2.Pipelines.Decoder,Microsoft.BizTalk.EdiIn"+
"t.PipelineComponents, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>      "+
"    <ComponentName>AS2 decoder</ComponentName>          <Description>AS2 decoder component</Descript"+
"ion>          <Version>1.0</Version>          <Properties />          <CachedDisplayName>AS2 decoder"+
"</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </Component>      </Com"+
"ponents>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemb"+
"le\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674a"+
"d6\" />      <Components>        <Component>          <Name>Microsoft.BizTalk.AS2.Pipelines.AS2Disass"+
"embler,Microsoft.BizTalk.EdiInt.PipelineComponents, Version=3.0.1.0, Culture=neutral, PublicKeyToken"+
"=31bf3856ad364e35</Name>          <ComponentName>AS2 disassembler</ComponentName>          <Descript"+
"ion>AS2 disassembler component.</Description>          <Version>1.0</Version>          <Properties /"+
">          <CachedDisplayName>AS2 disassembler</CachedDisplayName>          <CachedIsManaged>true</C"+
"achedIsManaged>        </Component>        <Component>          <Name>Microsoft.BizTalk.Component.Xm"+
"lDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31"+
"bf3856ad364e35</Name>          <ComponentName>XML disassembler</ComponentName>          <Description"+
">Streaming XML disassembler</Description>          <Version>1.0</Version>          <Properties>     "+
"       <Property Name=\"EnvelopeSpecNames\">              <Value xsi:type=\"xsd:string\" />            <"+
"/Property>            <Property Name=\"EnvelopeSpecTargetNamespaces\">              <Value xsi:type=\"x"+
"sd:string\" />            </Property>            <Property Name=\"DocumentSpecNames\">              <Va"+
"lue xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"DocumentSpecTargetNam"+
"espaces\">              <Value xsi:type=\"xsd:string\" />            </Property>            <Property N"+
"ame=\"AllowUnrecognizedMessage\">              <Value xsi:type=\"xsd:boolean\">false</Value>            "+
"</Property>            <Property Name=\"ValidateDocument\">              <Value xsi:type=\"xsd:boolean\""+
">false</Value>            </Property>            <Property Name=\"RecoverableInterchangeProcessing\"> "+
"             <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Property"+
" Name=\"HiddenProperties\">              <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,Doc"+
"umentSpecTargetNamespaces</Value>            </Property>            <Property Name=\"DtdProcessing\"> "+
"             <Value xsi:type=\"xsd:string\" />            </Property>          </Properties>          "+
"<CachedDisplayName>XML disassembler</CachedDisplayName>          <CachedIsManaged>true</CachedIsMana"+
"ged>        </Component>      </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrDat"+
"a=\"Name\" _locID=\"3\" Name=\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-"+
"4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>    <Stage>      <PolicyFileStage _lo"+
"cAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageI"+
"d=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "a6e34235-e159-46e4-8ded-8244ed71c883";
        
        public Pipelines_AS2_Receive()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4103-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.AS2.Pipelines.Decoder,Microsoft.BizTalk.EdiInt.PipelineComponents, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties /></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.AS2.Pipelines.AS2Disassembler,Microsoft.BizTalk.EdiInt.PipelineComponents, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties /></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
            IBaseComponent comp2 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp2 is IPersistPropertyBag)
            {
                string comp2XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeSpecNam"+
"es\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"EnvelopeSpecTargetNamesp"+
"aces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecNames\">   "+
"   <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecTargetNamespaces\"> "+
"     <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"AllowUnrecognizedMessage\">   "+
"   <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ValidateDocument\"> "+
"     <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"RecoverableInterc"+
"hangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name="+
"\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTarge"+
"tNamespaces</Value>    </Property>    <Property Name=\"DtdProcessing\">      <Value xsi:type=\"xsd:stri"+
"ng\" />    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp2XmlProperties);;
                ((IPersistPropertyBag)(comp2)).Load(pb, 0);
            }
            this.AddComponent(stage, comp2);
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
