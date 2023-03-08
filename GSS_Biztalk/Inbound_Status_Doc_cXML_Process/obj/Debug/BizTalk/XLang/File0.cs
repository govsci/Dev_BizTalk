
#pragma warning disable 162

namespace Inbound_Status_Doc_cXML_Process
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Inbound_Status_Doc_cXML_Process.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Inbound_Status_Doc_cXML_Process_PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Inbound_Status_Doc_cXML_Process_PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Inbound_Status_Doc_cXML_Process_PortType_1(Inbound_Status_Doc_cXML_Process_PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Inbound_Status_Doc_cXML_Process_PortType_1 p = new Inbound_Status_Doc_cXML_Process_PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Inbound_Status_Doc_cXML_Process_PortType_1),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    [Microsoft.XLANGs.BaseTypes.CorrelationTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        new string[] {
            "BTS.ReceivePortName"
        }
    )]
    sealed internal class CorrelationType_1 : Microsoft.XLANGs.Core.CorrelationType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        private static Microsoft.XLANGs.BaseTypes.PropertyBase[] _properties = new Microsoft.XLANGs.BaseTypes.PropertyBase[] {
            new BTS.ReceivePortName()
         };
        public override Microsoft.XLANGs.BaseTypes.PropertyBase[] Properties { get { return _properties; } }
        public static Microsoft.XLANGs.BaseTypes.PropertyBase[] PropertiesList { get { return _properties; } }
    }
    //#line 204 "R:\Source\GSS_Biztalk\Inbound_Status_Doc_cXML_Process\Inbound_Status_Doc_cXML_Process_Orch.odx"
    [Microsoft.XLANGs.BaseTypes.StaticConvoyAttribute(
        0,
        new System.Type[] { typeof(CorrelationType_1) }
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Inbound_Status_Doc_cXML_Process_Port_1", "Operation_1", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        1, "Inbound_Status_Doc_cXML_Process_Port_1", "Operation_1", -1, 0, false
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(Inbound_Status_Doc_cXML_Process.Inbound_Status_Doc_cXML_Process_PortType_1)
        },
        new System.String[] {
            "Inbound_Status_Doc_cXML_Process_Port_1"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class Inbound_Status_Doc_cXML_Process_Orch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Inbound_Status_Doc_cXML_Process_Orch));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static Inbound_Status_Doc_cXML_Process_Orch()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 2, 3)
            };

            _Locks = 0;
            _rootContext = new __Inbound_Status_Doc_cXML_Process_Orch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Inbound_Status_Doc_cXML_Process_Orch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Inbound_Status_Doc_cXML_Process_Orch", tracker)
        {
            ConstructorHelper();
        }

        public Inbound_Status_Doc_cXML_Process_Orch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Inbound_Status_Doc_cXML_Process_Orch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>57ad54d6-8e48-4144-b210-2163e7f6f60a</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>9d7ad7b1-695a-440b-b79e-2cd86300a32e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>2258f7ed-19c5-403b-bf69-27093fb35156</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>7a36b185-bd85-42e1-a45b-83f02eddb736</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Process_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>f7306d42-c646-4632-a4e9-649ce5f91438</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Loop_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>0cb288ad-f3d7-4b4e-b821-5ef2824ff1a1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>da0f9c37-25a1-42e9-a479-8ba825a6719b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Process_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>9b61c88b-3743-4d41-86dc-764dc1282c53</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a7d0c619-845a-43d4-b34c-d5c18ca6bb77</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Inbound_Status_Doc_cXML_Process_Orch'</ActionName><IsAtomic>0</IsAtomic><Line>204</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>217</Line><Position>22</Position><ShapeID>'9d7ad7b1-695a-440b-b79e-2cd86300a32e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>223</Line><Position>13</Position><ShapeID>'2258f7ed-19c5-403b-bf69-27093fb35156'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>228</Line><Position>31</Position><ShapeID>'7a36b185-bd85-42e1-a45b-83f02eddb736'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>233</Line><Position>21</Position><ShapeID>'f7306d42-c646-4632-a4e9-649ce5f91438'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>236</Line><Position>25</Position><ShapeID>'0cb288ad-f3d7-4b4e-b821-5ef2824ff1a1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>238</Line><Position>35</Position><ShapeID>'da0f9c37-25a1-42e9-a479-8ba825a6719b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>247</Line><Position>21</Position><ShapeID>'9b61c88b-3743-4d41-86dc-764dc1282c53'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>250</Line><Position>33</Position><ShapeID>'a7d0c619-845a-43d4-b34c-d5c18ca6bb77'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='499a037c-ce3c-48b5-a160-fc3c23afef5e' LowerBound='1.1' HigherBound='76.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Inbound_Status_Doc_cXML_Process' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='bd8c4dfd-8300-4093-b3a3-4054a7b028c0' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Inbound_Status_Doc_cXML_Process_PortType_1' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='7876f1cd-cb5e-4c9c-9eac-938c252ecb4d' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='aca07212-13f2-40bf-852c-33137acd907a' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='96feff11-2cd6-42ad-b801-fc350f171d77' ParentLink='Module_CorrelationType' LowerBound='11.1' HigherBound='15.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PropertyRef' OID='a9a7f48e-e6c8-4260-b741-774a420ed8e0' ParentLink='CorrelationType_PropertyRef' LowerBound='13.9' HigherBound='13.28'>
                <om:Property Name='Ref' Value='BTS.ReceivePortName' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='df810af4-550a-478f-a880-998e92d868c4' ParentLink='Module_ServiceDeclaration' LowerBound='15.1' HigherBound='75.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Inbound_Status_Doc_cXML_Process_Orch' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='8cab35c5-8084-4b68-94dc-62abab011b76' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='timestamp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4d828cee-2cdd-4ebf-9a7c-e744bf061044' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='23.1' HigherBound='24.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='BizTalkLibrary.Orchestrations.OrchestrationFunctions' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='library' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='86505c90-c469-4f18-af93-33dcb42172bc' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='key' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d4c752dd-7702-40de-8e52-20242e24efa7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='BizTalkLibrary.Classes.Constants.DUMP_FOLDERS' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='dumpFolders' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='CorrelationDeclaration' OID='50b4456e-6661-4f86-8e48-9c51cfafda44' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='Type' Value='Inbound_Status_Doc_cXML_Process.CorrelationType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Correlation_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='99a41e6b-529d-4f07-96f2-8dc97f7943d2' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='29.89' HigherBound='29.113'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='9d7ad7b1-695a-440b-b79e-2cd86300a32e' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='2d566c5d-3fa0-47f5-8e5d-913d4130b398' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='48.92' HigherBound='48.105'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='0cb288ad-f3d7-4b4e-b821-5ef2824ff1a1' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d4befaf7-6e0e-4edc-9c90-8523419933cf' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='cXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='57ad54d6-8e48-4144-b210-2163e7f6f60a' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='9d7ad7b1-695a-440b-b79e-2cd86300a32e' ParentLink='ServiceBody_Statement' LowerBound='28.1' HigherBound='34.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Inbound_Status_Doc_cXML_Process_Port_1' />
                    <om:Property Name='MessageName' Value='cXML' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='2258f7ed-19c5-403b-bf69-27093fb35156' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='73.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='VariableAssignment' OID='7a36b185-bd85-42e1-a45b-83f02eddb736' ParentLink='ComplexStatement_Statement' LowerBound='39.1' HigherBound='44.1'>
                        <om:Property Name='Expression' Value='timestamp = library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;key = library.HasKey(cXML);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_PROCESSED_INCOMING(),key,timestamp,cXML,true);&#xD;&#xA;library.ProcessIncomingStatusDocument(cXML,timestamp,key);' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Process_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='While' OID='f7306d42-c646-4632-a4e9-649ce5f91438' ParentLink='ComplexStatement_Statement' LowerBound='44.1' HigherBound='55.1'>
                        <om:Property Name='Expression' Value='true' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Loop_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Receive' OID='0cb288ad-f3d7-4b4e-b821-5ef2824ff1a1' ParentLink='ComplexStatement_Statement' LowerBound='47.1' HigherBound='49.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='Inbound_Status_Doc_cXML_Process_Port_1' />
                            <om:Property Name='MessageName' Value='cXML' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='da0f9c37-25a1-42e9-a479-8ba825a6719b' ParentLink='ComplexStatement_Statement' LowerBound='49.1' HigherBound='54.1'>
                            <om:Property Name='Expression' Value='timestamp = library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;key = library.HasKey(cXML);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_PROCESSED_INCOMING(),key,timestamp,cXML,true);&#xD;&#xA;library.ProcessIncomingStatusDocument(cXML,timestamp,key);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Process_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='9b61c88b-3743-4d41-86dc-764dc1282c53' ParentLink='Scope_Catch' LowerBound='58.1' HigherBound='71.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='a7d0c619-845a-43d4-b34c-d5c18ca6bb77' ParentLink='Catch_Statement' LowerBound='61.1' HigherBound='70.1'>
                            <om:Property Name='Expression' Value='library = new BizTalkLibrary.Orchestrations.OrchestrationFunctions();&#xD;&#xA;dumpFolders = new BizTalkLibrary.Classes.Constants.DUMP_FOLDERS();&#xD;&#xA;&#xD;&#xA;timestamp=library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;key=library.HasKey(cXML);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_FAILED(),key+&quot;.Process&quot;,timestamp,cXML,true);&#xD;&#xA;&#xD;&#xA;library.sendExceptionEmail(ex,&quot;Inbound_Status_Doc_cXML_Process&quot;,&quot;&quot;,&quot;&quot;,key);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='71024a8a-c1b8-4ce1-a3bd-57b07555a790' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='18.1' HigherBound='20.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Inbound_Status_Doc_cXML_Process.Inbound_Status_Doc_cXML_Process_PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Inbound_Status_Doc_cXML_Process_Port_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='5333151c-d527-4f66-be8a-d1d91ab7058e' ParentLink='PortDeclaration_CLRAttribute' LowerBound='18.1' HigherBound='19.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Inbound_Status_Doc_cXML_Process_Orch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Inbound_Status_Doc_cXML_Process_Orch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Inbound_Status_Doc_cXML_Process_Orch")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                Inbound_Status_Doc_cXML_Process_Orch __svc__ = (Inbound_Status_Doc_cXML_Process_Orch)_service;
                __Inbound_Status_Doc_cXML_Process_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_cXML_Process_Orch_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Inbound_Status_Doc_cXML_Process_Port_1 != null)
                {
                    __svc__.Inbound_Status_Doc_cXML_Process_Port_1.Close(this, null);
                    __svc__.Inbound_Status_Doc_cXML_Process_Port_1 = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __Inbound_Status_Doc_cXML_Process_Orch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Inbound_Status_Doc_cXML_Process_Orch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Inbound_Status_Doc_cXML_Process_Orch")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                Inbound_Status_Doc_cXML_Process_Orch __svc__ = (Inbound_Status_Doc_cXML_Process_Orch)_service;
                __Inbound_Status_Doc_cXML_Process_Orch_1 __ctx1__ = (__Inbound_Status_Doc_cXML_Process_Orch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__key = null;
                if (__ctx1__ != null && __ctx1__.__cXML != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__cXML);
                    __ctx1__.__cXML = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__timestamp = null;
                if (__ctx1__ != null)
                    __ctx1__.__library = null;
                if (__ctx1__ != null)
                    __ctx1__.__dumpFolders = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("cXML")]
            public __messagetype_System_Xml_XmlDocument __cXML;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_1")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("timestamp")]
            internal System.String __timestamp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("library")]
            internal BizTalkLibrary.Orchestrations.OrchestrationFunctions __library;
            [Microsoft.XLANGs.Core.UserVariableAttribute("key")]
            internal System.String __key;
            [Microsoft.XLANGs.Core.UserVariableAttribute("dumpFolders")]
            internal BizTalkLibrary.Classes.Constants.DUMP_FOLDERS __dumpFolders;
        }


        [System.SerializableAttribute]
        public class ____scope33_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope33_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope33")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[3];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                Inbound_Status_Doc_cXML_Process_Orch __svc__ = (Inbound_Status_Doc_cXML_Process_Orch)_service;
                ____scope33_2 __ctx2__ = (____scope33_2)(__svc__._stateMgrs[2]);

                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                base.Finally();
            }

            internal object __exv__;
            internal System.Exception __ex_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = new Microsoft.XLANGs.Core.CorrelationType[] { new CorrelationType_1() };
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return new object[] {
                    new Microsoft.XLANGs.Core.CorrelationType[] { _correlationTypes[0] }
                };
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Inbound_Status_Doc_cXML_Process_Port_1")]
        internal Inbound_Status_Doc_cXML_Process_PortType_1 Inbound_Status_Doc_cXML_Process_Port_1;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Inbound_Status_Doc_cXML_Process_PortType_1.Operation_1},
                                               typeof(Inbound_Status_Doc_cXML_Process_Orch).GetField("Inbound_Status_Doc_cXML_Process_Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Inbound_Status_Doc_cXML_Process_Orch), "Inbound_Status_Doc_cXML_Process_Port_1"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[2]{
                     new object[5] { _portInfo[0], 0, null , 0, true }
                    , new object[5] { _portInfo[0], 0, null , 0, false }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "9d7ad7b1-695a-440b-b79e-2cd86300a32e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "9d7ad7b1-695a-440b-b79e-2cd86300a32e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "2258f7ed-19c5-403b-bf69-27093fb35156", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "7a36b185-bd85-42e1-a45b-83f02eddb736", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "7a36b185-bd85-42e1-a45b-83f02eddb736", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "f7306d42-c646-4632-a4e9-649ce5f91438", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "0cb288ad-f3d7-4b4e-b821-5ef2824ff1a1", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "0cb288ad-f3d7-4b4e-b821-5ef2824ff1a1", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "da0f9c37-25a1-42e9-a479-8ba825a6719b", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "da0f9c37-25a1-42e9-a479-8ba825a6719b", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "f7306d42-c646-4632-a4e9-649ce5f91438", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "9b61c88b-3743-4d41-86dc-764dc1282c53", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "a7d0c619-845a-43d4-b34c-d5c18ca6bb77", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "a7d0c619-845a-43d4-b34c-d5c18ca6bb77", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "9b61c88b-3743-4d41-86dc-764dc1282c53", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "2258f7ed-19c5-403b-bf69-27093fb35156", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,4,4,4,21,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,7,7,7,9,9,9,10,10,11,12,12,13,13,13,13,14,14,14,14,14,14,};
        public static int[] __progressLocation3 = new int[] { 15,15,16,16,17,17,17,17,17,17,20,20,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Inbound_Status_Doc_cXML_Process_Orch_1 __ctx1__ = (__Inbound_Status_Doc_cXML_Process_Orch_1)_stateMgrs[1];
            __Inbound_Status_Doc_cXML_Process_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_cXML_Process_Orch_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Inbound_Status_Doc_cXML_Process_Port_1 = new Inbound_Status_Doc_cXML_Process_PortType_1(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Inbound_Status_Doc_cXML_Process_Port_1, this);
                __ctx0__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[1], Inbound_Status_Doc_cXML_Process_Port_1, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Inbound_Status_Doc_cXML_Process_Orch_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __Inbound_Status_Doc_cXML_Process_Orch_1 __ctx1__ = (__Inbound_Status_Doc_cXML_Process_Orch_1)_stateMgrs[1];
            __Inbound_Status_Doc_cXML_Process_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_cXML_Process_Orch_root_0)_stateMgrs[0];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__timestamp = default(System.String);
                __ctx1__.__library = default(BizTalkLibrary.Orchestrations.OrchestrationFunctions);
                __ctx1__.__key = default(System.String);
                __ctx1__.__dumpFolders = default(BizTalkLibrary.Classes.Constants.DUMP_FOLDERS);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.__Correlation_1 = new Microsoft.XLANGs.Core.Correlation(this, 0, 0);
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!Inbound_Status_Doc_cXML_Process_Port_1.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__cXML != null)
                    __ctx1__.UnrefMessage(__ctx1__.__cXML);
                __ctx1__.__cXML = new __messagetype_System_Xml_XmlDocument("cXML", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__cXML);
                Inbound_Status_Doc_cXML_Process_Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__cXML, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__cXML);
                    __edata.PortName = @"Inbound_Status_Doc_cXML_Process_Port_1";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__timestamp = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__library = new BizTalkLibrary.Orchestrations.OrchestrationFunctions();
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__key = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__dumpFolders = new BizTalkLibrary.Classes.Constants.DUMP_FOLDERS();
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx2__ = new ____scope33_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__dumpFolders = null;
                if (__ctx1__ != null)
                    __ctx1__.__key = null;
                if (__ctx1__ != null)
                    __ctx1__.__library = null;
                if (__ctx1__ != null)
                    __ctx1__.__timestamp = null;
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (__ctx1__ != null && __ctx1__.__cXML != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__cXML);
                    __ctx1__.__cXML = null;
                }
                if (Inbound_Status_Doc_cXML_Process_Port_1 != null)
                {
                    Inbound_Status_Doc_cXML_Process_Port_1.Close(__ctx1__, __seg__);
                    Inbound_Status_Doc_cXML_Process_Port_1 = null;
                }
                Tracker.FireEvent(__eventLocations[21],__eventData[11],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[12],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 16;
            case 16:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Inbound_Status_Doc_cXML_Process_Orch_1 __ctx1__ = (__Inbound_Status_Doc_cXML_Process_Orch_1)_stateMgrs[1];
            __Inbound_Status_Doc_cXML_Process_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_cXML_Process_Orch_root_0)_stateMgrs[0];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx1__.__timestamp = __ctx1__.__library.GetTimeStamp(System.DateTime.Now);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __ctx1__.__key = __ctx1__.__library.HasKey(__ctx1__.__cXML.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_PROCESSED_INCOMING(), __ctx1__.__key, __ctx1__.__timestamp, __ctx1__.__cXML.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__library.ProcessIncomingStatusDocument(__ctx1__.__cXML.part.TypedValue, __ctx1__.__timestamp, __ctx1__.__key);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __condition__ = true;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 21;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if (!Inbound_Status_Doc_cXML_Process_Port_1.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__cXML != null)
                    __ctx1__.UnrefMessage(__ctx1__.__cXML);
                __ctx1__.__cXML = new __messagetype_System_Xml_XmlDocument("cXML", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__cXML);
                Inbound_Status_Doc_cXML_Process_Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__cXML, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__cXML);
                    __edata.PortName = @"Inbound_Status_Doc_cXML_Process_Port_1";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                __ctx1__.__timestamp = __ctx1__.__library.GetTimeStamp(System.DateTime.Now);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                __ctx1__.__key = __ctx1__.__library.HasKey(__ctx1__.__cXML.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_PROCESSED_INCOMING(), __ctx1__.__key, __ctx1__.__timestamp, __ctx1__.__cXML.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx1__.__library.ProcessIncomingStatusDocument(__ctx1__.__cXML.part.TypedValue, __ctx1__.__timestamp, __ctx1__.__key);
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 24;
            case 24:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Inbound_Status_Doc_cXML_Process_Orch_1 __ctx1__ = (__Inbound_Status_Doc_cXML_Process_Orch_1)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__library = new BizTalkLibrary.Orchestrations.OrchestrationFunctions();
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__dumpFolders = new BizTalkLibrary.Classes.Constants.DUMP_FOLDERS();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__timestamp = __ctx1__.__library.GetTimeStamp(System.DateTime.Now);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__key = __ctx1__.__library.HasKey(__ctx1__.__cXML.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_FAILED(), __ctx1__.__key + ".Process", __ctx1__.__timestamp, __ctx1__.__cXML.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__library.sendExceptionEmail(__ctx2__.__ex_0, "Inbound_Status_Doc_cXML_Process", "", "", __ctx1__.__key);
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{E317812C-A004-474B-8F66-B84C78A92FEC}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __Microsoft_XLANGs_BaseTypes_Any__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Microsoft.XLANGs.BaseTypes.Any _schema = new Microsoft.XLANGs.BaseTypes.Any();

        public __Microsoft_XLANGs_BaseTypes_Any__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.Xml.XmlDocument",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_Xml_XmlDocument : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_Xml_XmlDocument(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
