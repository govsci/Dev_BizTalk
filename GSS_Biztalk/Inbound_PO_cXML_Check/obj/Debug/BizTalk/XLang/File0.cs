
#pragma warning disable 162

namespace Inbound_PO_cXML_Check
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Inbound_PO_cXML_Check.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Inbound_PO_cXML_Check_PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Inbound_PO_cXML_Check_PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Inbound_PO_cXML_Check_PortType_1(Inbound_PO_cXML_Check_PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Inbound_PO_cXML_Check_PortType_1 p = new Inbound_PO_cXML_Check_PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Inbound_PO_cXML_Check_PortType_1),
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
    //#line 204 "R:\Source\GSS_Biztalk\Inbound_PO_cXML_Check\Inbound_PO_cXML_Check_Orch.odx"
    [Microsoft.XLANGs.BaseTypes.StaticConvoyAttribute(
        0,
        new System.Type[] { typeof(CorrelationType_1) }
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Inbound_PO_cXML_Check_Port_1", "Operation_1", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        1, "Inbound_PO_cXML_Check_Port_1", "Operation_1", -1, 0, false
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(Inbound_PO_cXML_Check.Inbound_PO_cXML_Check_PortType_1)
        },
        new System.String[] {
            "Inbound_PO_cXML_Check_Port_1"
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
    sealed internal class Inbound_PO_cXML_Check_Orch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Inbound_PO_cXML_Check_Orch));
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

        static Inbound_PO_cXML_Check_Orch()
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
            _rootContext = new __Inbound_PO_cXML_Check_Orch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Inbound_PO_cXML_Check_Orch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Inbound_PO_cXML_Check_Orch", tracker)
        {
            ConstructorHelper();
        }

        public Inbound_PO_cXML_Check_Orch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Inbound_PO_cXML_Check_Orch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>50d93d98-009c-41a9-bd1e-09a92adaad06</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>23f32418-7d2b-4e34-aa3c-22722cba2f36</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>a7c18ad8-803a-497b-bde2-3557208461d5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>013d3e03-b56b-4a53-8e13-81f2da98e68f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Check PO 1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>274e18ac-b8d2-4de4-8368-f1911d9ca615</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Loop_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>69ede9bd-7223-4774-8527-447a9639514b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d9c8e9b8-8e19-49d7-a656-b388f7780286</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Check PO 2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>d08523eb-7d4d-4216-8918-b345aba8772b</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>3a926b88-4e0a-4069-b62e-99ad24d2ac9c</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Inbound_PO_cXML_Check_Orch'</ActionName><IsAtomic>0</IsAtomic><Line>204</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>217</Line><Position>22</Position><ShapeID>'23f32418-7d2b-4e34-aa3c-22722cba2f36'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>223</Line><Position>13</Position><ShapeID>'a7c18ad8-803a-497b-bde2-3557208461d5'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>228</Line><Position>30</Position><ShapeID>'013d3e03-b56b-4a53-8e13-81f2da98e68f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>232</Line><Position>21</Position><ShapeID>'274e18ac-b8d2-4de4-8368-f1911d9ca615'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>235</Line><Position>25</Position><ShapeID>'69ede9bd-7223-4774-8527-447a9639514b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>237</Line><Position>34</Position><ShapeID>'d9c8e9b8-8e19-49d7-a656-b388f7780286'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>245</Line><Position>21</Position><ShapeID>'d08523eb-7d4d-4216-8918-b345aba8772b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>248</Line><Position>33</Position><ShapeID>'3a926b88-4e0a-4069-b62e-99ad24d2ac9c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='aa87a652-8b54-4bb9-85b5-2b0f4430d722' LowerBound='1.1' HigherBound='73.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Inbound_PO_cXML_Check' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='ef47950b-3a41-4af5-b8c7-03ff7d367e84' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Inbound_PO_cXML_Check_PortType_1' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='15efa972-05a3-435b-bb56-8ece991bb5a6' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='806c04e9-e621-4ffe-bbd7-0eff27678565' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='752af3c1-ca1a-43c7-8518-756dae96b335' ParentLink='Module_CorrelationType' LowerBound='11.1' HigherBound='15.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PropertyRef' OID='7f609ef2-afed-4af5-ba72-7ba81022d66c' ParentLink='CorrelationType_PropertyRef' LowerBound='13.9' HigherBound='13.28'>
                <om:Property Name='Ref' Value='BTS.ReceivePortName' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='2adc027d-5921-4ab7-b321-e3031e4590c3' ParentLink='Module_ServiceDeclaration' LowerBound='15.1' HigherBound='72.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Inbound_PO_cXML_Check_Orch' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='258cb5a0-d8c4-4efa-8972-f83e8da2e2a3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='timestamp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='fc297a0a-87ed-4e85-a177-f66e0144bd5e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='23.1' HigherBound='24.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='orderId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='2d341cca-79b3-4754-8359-975428ebb17e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='BizTalkLibrary.Orchestrations.OrchestrationFunctions' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='library' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5ab7537b-6f32-4226-9baf-8a3fb8d3af72' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='BizTalkLibrary.Classes.Constants.DUMP_FOLDERS' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='dumpFolders' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='CorrelationDeclaration' OID='3d801afc-e4a8-4d86-90bc-8fdd5ffff7f1' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='Type' Value='Inbound_PO_cXML_Check.CorrelationType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Correlation_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='7ac5b40c-a3fd-43a7-a5d0-7d5969203e15' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='29.79' HigherBound='29.103'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='23f32418-7d2b-4e34-aa3c-22722cba2f36' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='9bcd02ba-d3ef-492f-9076-ef581fd3b4f7' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='47.82' HigherBound='47.95'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='69ede9bd-7223-4774-8527-447a9639514b' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='558e1aa6-8bf9-4d50-8e73-c2ed418ae57f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='cXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='50d93d98-009c-41a9-bd1e-09a92adaad06' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='23f32418-7d2b-4e34-aa3c-22722cba2f36' ParentLink='ServiceBody_Statement' LowerBound='28.1' HigherBound='34.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Inbound_PO_cXML_Check_Port_1' />
                    <om:Property Name='MessageName' Value='cXML' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='a7c18ad8-803a-497b-bde2-3557208461d5' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='70.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='VariableAssignment' OID='013d3e03-b56b-4a53-8e13-81f2da98e68f' ParentLink='ComplexStatement_Statement' LowerBound='39.1' HigherBound='43.1'>
                        <om:Property Name='Expression' Value='timestamp=library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;orderId=library.GetOrderId(cXML);&#xD;&#xA;library.CheckIncomingPo(cXML,timestamp,orderId);&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Check PO 1' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='While' OID='274e18ac-b8d2-4de4-8368-f1911d9ca615' ParentLink='ComplexStatement_Statement' LowerBound='43.1' HigherBound='53.1'>
                        <om:Property Name='Expression' Value='true' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Loop_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Receive' OID='69ede9bd-7223-4774-8527-447a9639514b' ParentLink='ComplexStatement_Statement' LowerBound='46.1' HigherBound='48.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='Inbound_PO_cXML_Check_Port_1' />
                            <om:Property Name='MessageName' Value='cXML' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='d9c8e9b8-8e19-49d7-a656-b388f7780286' ParentLink='ComplexStatement_Statement' LowerBound='48.1' HigherBound='52.1'>
                            <om:Property Name='Expression' Value='timestamp=library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;orderId=library.GetOrderId(cXML);&#xD;&#xA;library.CheckIncomingPo(cXML,timestamp,orderId);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Check PO 2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='d08523eb-7d4d-4216-8918-b345aba8772b' ParentLink='Scope_Catch' LowerBound='56.1' HigherBound='68.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='3a926b88-4e0a-4069-b62e-99ad24d2ac9c' ParentLink='Catch_Statement' LowerBound='59.1' HigherBound='67.1'>
                            <om:Property Name='Expression' Value='library = new BizTalkLibrary.Orchestrations.OrchestrationFunctions();&#xD;&#xA;dumpFolders = new BizTalkLibrary.Classes.Constants.DUMP_FOLDERS();&#xD;&#xA;timestamp=library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;orderId=library.GetOrderId(cXML);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_PO_FAILED(),orderId+&quot;.Check&quot;,timestamp,cXML,true);&#xD;&#xA;&#xD;&#xA;library.sendExceptionEmail(ex,&quot;Inbound_PO_cXML_Check&quot;,&quot;&quot;,&quot;&quot;,orderId);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='0835b1cb-a426-4d98-8460-583d800b87bb' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='18.1' HigherBound='20.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Inbound_PO_cXML_Check.Inbound_PO_cXML_Check_PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Inbound_PO_cXML_Check_Port_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='bc1a7307-7986-40f6-9c37-5c059545f2ec' ParentLink='PortDeclaration_CLRAttribute' LowerBound='18.1' HigherBound='19.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Inbound_PO_cXML_Check_Orch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Inbound_PO_cXML_Check_Orch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Inbound_PO_cXML_Check_Orch")
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
                Inbound_PO_cXML_Check_Orch __svc__ = (Inbound_PO_cXML_Check_Orch)_service;
                __Inbound_PO_cXML_Check_Orch_root_0 __ctx0__ = (__Inbound_PO_cXML_Check_Orch_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Inbound_PO_cXML_Check_Port_1 != null)
                {
                    __svc__.Inbound_PO_cXML_Check_Port_1.Close(this, null);
                    __svc__.Inbound_PO_cXML_Check_Port_1 = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __Inbound_PO_cXML_Check_Orch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Inbound_PO_cXML_Check_Orch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Inbound_PO_cXML_Check_Orch")
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
                Inbound_PO_cXML_Check_Orch __svc__ = (Inbound_PO_cXML_Check_Orch)_service;
                __Inbound_PO_cXML_Check_Orch_1 __ctx1__ = (__Inbound_PO_cXML_Check_Orch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__library = null;
                if (__ctx1__ != null)
                    __ctx1__.__dumpFolders = null;
                if (__ctx1__ != null && __ctx1__.__cXML != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__cXML);
                    __ctx1__.__cXML = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__timestamp = null;
                if (__ctx1__ != null)
                    __ctx1__.__orderId = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("cXML")]
            public __messagetype_System_Xml_XmlDocument __cXML;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_1")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("timestamp")]
            internal System.String __timestamp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("orderId")]
            internal System.String __orderId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("library")]
            internal BizTalkLibrary.Orchestrations.OrchestrationFunctions __library;
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
                Inbound_PO_cXML_Check_Orch __svc__ = (Inbound_PO_cXML_Check_Orch)_service;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Inbound_PO_cXML_Check_Port_1")]
        internal Inbound_PO_cXML_Check_PortType_1 Inbound_PO_cXML_Check_Port_1;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Inbound_PO_cXML_Check_PortType_1.Operation_1},
                                               typeof(Inbound_PO_cXML_Check_Orch).GetField("Inbound_PO_cXML_Check_Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Inbound_PO_cXML_Check_Orch), "Inbound_PO_cXML_Check_Port_1"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "23f32418-7d2b-4e34-aa3c-22722cba2f36", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "23f32418-7d2b-4e34-aa3c-22722cba2f36", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "a7c18ad8-803a-497b-bde2-3557208461d5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "013d3e03-b56b-4a53-8e13-81f2da98e68f", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "013d3e03-b56b-4a53-8e13-81f2da98e68f", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "274e18ac-b8d2-4de4-8368-f1911d9ca615", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "69ede9bd-7223-4774-8527-447a9639514b", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "69ede9bd-7223-4774-8527-447a9639514b", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "d9c8e9b8-8e19-49d7-a656-b388f7780286", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "d9c8e9b8-8e19-49d7-a656-b388f7780286", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "274e18ac-b8d2-4de4-8368-f1911d9ca615", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "d08523eb-7d4d-4216-8918-b345aba8772b", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "3a926b88-4e0a-4069-b62e-99ad24d2ac9c", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "3a926b88-4e0a-4069-b62e-99ad24d2ac9c", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "d08523eb-7d4d-4216-8918-b345aba8772b", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "a7c18ad8-803a-497b-bde2-3557208461d5", 1, false)
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
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,7,7,9,9,9,10,10,11,12,12,13,13,13,14,14,14,14,14,14,};
        public static int[] __progressLocation3 = new int[] { 15,15,16,16,17,17,17,17,17,17,20,20,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Inbound_PO_cXML_Check_Orch_root_0 __ctx0__ = (__Inbound_PO_cXML_Check_Orch_root_0)_stateMgrs[0];
            __Inbound_PO_cXML_Check_Orch_1 __ctx1__ = (__Inbound_PO_cXML_Check_Orch_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Inbound_PO_cXML_Check_Port_1 = new Inbound_PO_cXML_Check_PortType_1(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Inbound_PO_cXML_Check_Port_1, this);
                __ctx0__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[1], Inbound_PO_cXML_Check_Port_1, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Inbound_PO_cXML_Check_Orch_1(this);
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
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __Inbound_PO_cXML_Check_Orch_root_0 __ctx0__ = (__Inbound_PO_cXML_Check_Orch_root_0)_stateMgrs[0];
            __Inbound_PO_cXML_Check_Orch_1 __ctx1__ = (__Inbound_PO_cXML_Check_Orch_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__timestamp = default(System.String);
                __ctx1__.__orderId = default(System.String);
                __ctx1__.__library = default(BizTalkLibrary.Orchestrations.OrchestrationFunctions);
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
                if (!Inbound_PO_cXML_Check_Port_1.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__cXML != null)
                    __ctx1__.UnrefMessage(__ctx1__.__cXML);
                __ctx1__.__cXML = new __messagetype_System_Xml_XmlDocument("cXML", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__cXML);
                Inbound_PO_cXML_Check_Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__cXML, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__cXML);
                    __edata.PortName = @"Inbound_PO_cXML_Check_Port_1";
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
                __ctx1__.__orderId = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__library = new BizTalkLibrary.Orchestrations.OrchestrationFunctions();
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
                    __ctx1__.__library = null;
                if (__ctx1__ != null)
                    __ctx1__.__orderId = null;
                if (__ctx1__ != null)
                    __ctx1__.__timestamp = null;
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (__ctx1__ != null && __ctx1__.__cXML != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__cXML);
                    __ctx1__.__cXML = null;
                }
                if (Inbound_PO_cXML_Check_Port_1 != null)
                {
                    Inbound_PO_cXML_Check_Port_1.Close(__ctx1__, __seg__);
                    Inbound_PO_cXML_Check_Port_1 = null;
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
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __Inbound_PO_cXML_Check_Orch_root_0 __ctx0__ = (__Inbound_PO_cXML_Check_Orch_root_0)_stateMgrs[0];
            __Inbound_PO_cXML_Check_Orch_1 __ctx1__ = (__Inbound_PO_cXML_Check_Orch_1)_stateMgrs[1];

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
                __ctx1__.__orderId = __ctx1__.__library.GetOrderId(__ctx1__.__cXML.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__library.CheckIncomingPo(__ctx1__.__cXML.part.TypedValue, __ctx1__.__timestamp, __ctx1__.__orderId);
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __condition__ = true;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 19;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!Inbound_PO_cXML_Check_Port_1.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__cXML != null)
                    __ctx1__.UnrefMessage(__ctx1__.__cXML);
                __ctx1__.__cXML = new __messagetype_System_Xml_XmlDocument("cXML", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__cXML);
                Inbound_PO_cXML_Check_Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__cXML, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__cXML);
                    __edata.PortName = @"Inbound_PO_cXML_Check_Port_1";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __ctx1__.__timestamp = __ctx1__.__library.GetTimeStamp(System.DateTime.Now);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                __ctx1__.__orderId = __ctx1__.__library.GetOrderId(__ctx1__.__cXML.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__library.CheckIncomingPo(__ctx1__.__cXML.part.TypedValue, __ctx1__.__timestamp, __ctx1__.__orderId);
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 22;
            case 22:
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
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __Inbound_PO_cXML_Check_Orch_1 __ctx1__ = (__Inbound_PO_cXML_Check_Orch_1)_stateMgrs[1];

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
                __ctx1__.__orderId = __ctx1__.__library.GetOrderId(__ctx1__.__cXML.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_PO_FAILED(), __ctx1__.__orderId + ".Check", __ctx1__.__timestamp, __ctx1__.__cXML.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__library.sendExceptionEmail(__ctx2__.__ex_0, "Inbound_PO_cXML_Check", "", "", __ctx1__.__orderId);
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
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{2950BC14-C879-4D84-AEF5-A0F67657ED89}"))
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
