
#pragma warning disable 162

namespace Inbound_Status_Doc_X12_Receive
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Inbound_Status_Doc_X12_Receive.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Inbound_Status_Doc_X12_Receive_PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Inbound_Status_Doc_X12_Receive_PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Inbound_Status_Doc_X12_Receive_PortType_1(Inbound_Status_Doc_X12_Receive_PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Inbound_Status_Doc_X12_Receive_PortType_1 p = new Inbound_Status_Doc_X12_Receive_PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Inbound_Status_Doc_X12_Receive_PortType_1),
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
    //#line 204 "R:\Source\GSS_Biztalk\Inbound_Status_Doc_X12_Receive\Inbound_Status_Doc_X12_Receive_Orch.odx"
    [Microsoft.XLANGs.BaseTypes.StaticConvoyAttribute(
        0,
        new System.Type[] { typeof(CorrelationType_1) }
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Inbound_Status_Doc_X12_Receive_Port_1", "Operation_1", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        1, "Inbound_Status_Doc_X12_Receive_Port_1", "Operation_1", -1, 0, false
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(Inbound_Status_Doc_X12_Receive.Inbound_Status_Doc_X12_Receive_PortType_1)
        },
        new System.String[] {
            "Inbound_Status_Doc_X12_Receive_Port_1"
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
    sealed internal class Inbound_Status_Doc_X12_Receive_Orch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Inbound_Status_Doc_X12_Receive_Orch));
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

        static Inbound_Status_Doc_X12_Receive_Orch()
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
            _rootContext = new __Inbound_Status_Doc_X12_Receive_Orch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Inbound_Status_Doc_X12_Receive_Orch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Inbound_Status_Doc_X12_Receive_Orch", tracker)
        {
            ConstructorHelper();
        }

        public Inbound_Status_Doc_X12_Receive_Orch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Inbound_Status_Doc_X12_Receive_Orch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>8b3de72e-f703-420b-a6b0-dd53ca935ec9</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>f5df6955-8eca-4b39-80cc-aed4607f6462</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>ae704a65-6223-44b4-a6f0-68751099556e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>66169fd1-941f-4fd0-9fd6-4f998df249ed</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>20e934a3-92d0-46e6-94a4-6b2a655c89f1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Loop_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>4bed4d05-49f4-4826-88b7-3f38881cb3ce</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>362fed55-e0c4-4327-877b-16ec5fdc0c17</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>e503e971-9af7-4ce6-9da8-d25a9b7c3899</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.SystemException</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>b0861e31-aa1c-4873-a204-0adf4c3fe906</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>CatchExpression</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Inbound_Status_Doc_X12_Receive_Orch'</ActionName><IsAtomic>0</IsAtomic><Line>204</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>217</Line><Position>22</Position><ShapeID>'f5df6955-8eca-4b39-80cc-aed4607f6462'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>223</Line><Position>13</Position><ShapeID>'ae704a65-6223-44b4-a6f0-68751099556e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>228</Line><Position>30</Position><ShapeID>'66169fd1-941f-4fd0-9fd6-4f998df249ed'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>233</Line><Position>21</Position><ShapeID>'20e934a3-92d0-46e6-94a4-6b2a655c89f1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>236</Line><Position>25</Position><ShapeID>'4bed4d05-49f4-4826-88b7-3f38881cb3ce'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>238</Line><Position>34</Position><ShapeID>'362fed55-e0c4-4327-877b-16ec5fdc0c17'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>247</Line><Position>21</Position><ShapeID>'e503e971-9af7-4ce6-9da8-d25a9b7c3899'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>250</Line><Position>33</Position><ShapeID>'b0861e31-aa1c-4873-a204-0adf4c3fe906'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='e11da511-8cc0-4acb-86b8-71e6b6f26e28' LowerBound='1.1' HigherBound='75.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Inbound_Status_Doc_X12_Receive' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='d0e8876c-2034-4ed5-8e03-188668debf3a' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Inbound_Status_Doc_X12_Receive_PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='8982c8bc-3cd3-4318-bcb1-380c2d0231f5' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='7381efbb-3595-4ab3-8c95-5acab5d36b8f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='e7ccc59c-c012-401a-aab4-8d49735fa082' ParentLink='Module_CorrelationType' LowerBound='11.1' HigherBound='15.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PropertyRef' OID='3a1e1fbc-2e75-497e-b2de-e8276004eeb5' ParentLink='CorrelationType_PropertyRef' LowerBound='13.9' HigherBound='13.28'>
                <om:Property Name='Ref' Value='BTS.ReceivePortName' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='cc8358e2-194a-4ea2-a904-efaa14b8ea20' ParentLink='Module_ServiceDeclaration' LowerBound='15.1' HigherBound='74.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Inbound_Status_Doc_X12_Receive_Orch' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='94598fd3-36ec-4ba2-8033-e1b3b9f6faa5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='timestamp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='78eb03fb-a839-4707-ba93-e484452f37d4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='23.1' HigherBound='24.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='BizTalkLibrary.Orchestrations.OrchestrationFunctions' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='library' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='254050c9-94a1-440f-9b5f-a00c8156b887' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='docId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='361b8551-7fdd-4b3b-9afa-514a828ad7a0' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='BizTalkLibrary.Classes.Constants.DUMP_FOLDERS' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='dumpFolders' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='CorrelationDeclaration' OID='82978bad-4f65-4624-9b7c-788bfbe6da92' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='Type' Value='Inbound_Status_Doc_X12_Receive.CorrelationType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Correlation_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='bd2d5dbd-2c79-4aa1-8741-fa16a2f2ad7e' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='29.87' HigherBound='29.111'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='f5df6955-8eca-4b39-80cc-aed4607f6462' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='9fafa254-85d3-4952-8f25-3f3fc2deaf9b' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='48.90' HigherBound='48.103'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='4bed4d05-49f4-4826-88b7-3f38881cb3ce' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0c10aaf2-5c9e-4c79-977e-d49a710516ed' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xml' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='8b3de72e-f703-420b-a6b0-dd53ca935ec9' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='f5df6955-8eca-4b39-80cc-aed4607f6462' ParentLink='ServiceBody_Statement' LowerBound='28.1' HigherBound='34.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Inbound_Status_Doc_X12_Receive_Port_1' />
                    <om:Property Name='MessageName' Value='xml' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='ae704a65-6223-44b4-a6f0-68751099556e' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='72.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='VariableAssignment' OID='66169fd1-941f-4fd0-9fd6-4f998df249ed' ParentLink='ComplexStatement_Statement' LowerBound='39.1' HigherBound='44.1'>
                        <om:Property Name='Expression' Value='timestamp=library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;docId=library.GetX12DocId(xml);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_ARRIVED(),docId,timestamp,xml,true);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_PORT_RECEIVE_X12_STATUS_ARRIVE(),docId,timestamp,xml,false);' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Expression_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='While' OID='20e934a3-92d0-46e6-94a4-6b2a655c89f1' ParentLink='ComplexStatement_Statement' LowerBound='44.1' HigherBound='55.1'>
                        <om:Property Name='Expression' Value='true' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Loop_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Receive' OID='4bed4d05-49f4-4826-88b7-3f38881cb3ce' ParentLink='ComplexStatement_Statement' LowerBound='47.1' HigherBound='49.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='Inbound_Status_Doc_X12_Receive_Port_1' />
                            <om:Property Name='MessageName' Value='xml' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='362fed55-e0c4-4327-877b-16ec5fdc0c17' ParentLink='ComplexStatement_Statement' LowerBound='49.1' HigherBound='54.1'>
                            <om:Property Name='Expression' Value='timestamp=library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;docId=library.GetX12DocId(xml);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_ARRIVED(),docId,timestamp,xml,true);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_PORT_RECEIVE_X12_STATUS_ARRIVE(),docId,timestamp,xml,false);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='e503e971-9af7-4ce6-9da8-d25a9b7c3899' ParentLink='Scope_Catch' LowerBound='58.1' HigherBound='70.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.SystemException' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='b0861e31-aa1c-4873-a204-0adf4c3fe906' ParentLink='Catch_Statement' LowerBound='61.1' HigherBound='69.1'>
                            <om:Property Name='Expression' Value='library = new BizTalkLibrary.Orchestrations.OrchestrationFunctions();&#xD;&#xA;dumpFolders = new BizTalkLibrary.Classes.Constants.DUMP_FOLDERS();&#xD;&#xA;timestamp=library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;docId = library.GetX12DocId(xml);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_FAILED(),docId+&quot;.X12.Arrive&quot;,timestamp,xml,true);&#xD;&#xA;&#xD;&#xA;library.sendExceptionEmail(ex,&quot;Inbound_Status_Doc_X12_Receive&quot;,&quot;&quot;,&quot;&quot;,docId);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='CatchExpression' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='b50b782a-daf1-4d9c-9a95-fba844037af3' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='18.1' HigherBound='20.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Inbound_Status_Doc_X12_Receive.Inbound_Status_Doc_X12_Receive_PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Inbound_Status_Doc_X12_Receive_Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c362f78f-2e4b-4948-a8ac-3f32c364ac90' ParentLink='PortDeclaration_CLRAttribute' LowerBound='18.1' HigherBound='19.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Inbound_Status_Doc_X12_Receive_Orch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Inbound_Status_Doc_X12_Receive_Orch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Inbound_Status_Doc_X12_Receive_Orch")
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
                Inbound_Status_Doc_X12_Receive_Orch __svc__ = (Inbound_Status_Doc_X12_Receive_Orch)_service;
                __Inbound_Status_Doc_X12_Receive_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_X12_Receive_Orch_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Inbound_Status_Doc_X12_Receive_Port_1 != null)
                {
                    __svc__.Inbound_Status_Doc_X12_Receive_Port_1.Close(this, null);
                    __svc__.Inbound_Status_Doc_X12_Receive_Port_1 = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __Inbound_Status_Doc_X12_Receive_Orch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Inbound_Status_Doc_X12_Receive_Orch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Inbound_Status_Doc_X12_Receive_Orch")
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
                Inbound_Status_Doc_X12_Receive_Orch __svc__ = (Inbound_Status_Doc_X12_Receive_Orch)_service;
                __Inbound_Status_Doc_X12_Receive_Orch_1 __ctx1__ = (__Inbound_Status_Doc_X12_Receive_Orch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__timestamp = null;
                if (__ctx1__ != null)
                    __ctx1__.__library = null;
                if (__ctx1__ != null && __ctx1__.__xml != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__xml);
                    __ctx1__.__xml = null;
                }
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__docId = null;
                if (__ctx1__ != null)
                    __ctx1__.__dumpFolders = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("xml")]
            public __messagetype_System_Xml_XmlDocument __xml;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_1")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("timestamp")]
            internal System.String __timestamp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("library")]
            internal BizTalkLibrary.Orchestrations.OrchestrationFunctions __library;
            [Microsoft.XLANGs.Core.UserVariableAttribute("docId")]
            internal System.String __docId;
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
                    if ((__fault__ == null) && (__exv__ is System.SystemException))
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
                Inbound_Status_Doc_X12_Receive_Orch __svc__ = (Inbound_Status_Doc_X12_Receive_Orch)_service;
                ____scope33_2 __ctx2__ = (____scope33_2)(__svc__._stateMgrs[2]);

                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                base.Finally();
            }

            internal object __exv__;
            internal System.SystemException __ex_0
            {
                get { return (System.SystemException)__exv__; }
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Inbound_Status_Doc_X12_Receive_Port_1")]
        internal Inbound_Status_Doc_X12_Receive_PortType_1 Inbound_Status_Doc_X12_Receive_Port_1;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Inbound_Status_Doc_X12_Receive_PortType_1.Operation_1},
                                               typeof(Inbound_Status_Doc_X12_Receive_Orch).GetField("Inbound_Status_Doc_X12_Receive_Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Inbound_Status_Doc_X12_Receive_Orch), "Inbound_Status_Doc_X12_Receive_Port_1"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "f5df6955-8eca-4b39-80cc-aed4607f6462", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "f5df6955-8eca-4b39-80cc-aed4607f6462", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "ae704a65-6223-44b4-a6f0-68751099556e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "66169fd1-941f-4fd0-9fd6-4f998df249ed", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "66169fd1-941f-4fd0-9fd6-4f998df249ed", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "20e934a3-92d0-46e6-94a4-6b2a655c89f1", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "4bed4d05-49f4-4826-88b7-3f38881cb3ce", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "4bed4d05-49f4-4826-88b7-3f38881cb3ce", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "362fed55-e0c4-4327-877b-16ec5fdc0c17", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "362fed55-e0c4-4327-877b-16ec5fdc0c17", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "20e934a3-92d0-46e6-94a4-6b2a655c89f1", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "e503e971-9af7-4ce6-9da8-d25a9b7c3899", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "b0861e31-aa1c-4873-a204-0adf4c3fe906", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "b0861e31-aa1c-4873-a204-0adf4c3fe906", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "e503e971-9af7-4ce6-9da8-d25a9b7c3899", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "ae704a65-6223-44b4-a6f0-68751099556e", 1, false)
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
            __Inbound_Status_Doc_X12_Receive_Orch_1 __ctx1__ = (__Inbound_Status_Doc_X12_Receive_Orch_1)_stateMgrs[1];
            __Inbound_Status_Doc_X12_Receive_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_X12_Receive_Orch_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Inbound_Status_Doc_X12_Receive_Port_1 = new Inbound_Status_Doc_X12_Receive_PortType_1(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Inbound_Status_Doc_X12_Receive_Port_1, this);
                __ctx0__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[1], Inbound_Status_Doc_X12_Receive_Port_1, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Inbound_Status_Doc_X12_Receive_Orch_1(this);
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
            __Inbound_Status_Doc_X12_Receive_Orch_1 __ctx1__ = (__Inbound_Status_Doc_X12_Receive_Orch_1)_stateMgrs[1];
            __Inbound_Status_Doc_X12_Receive_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_X12_Receive_Orch_root_0)_stateMgrs[0];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__timestamp = default(System.String);
                __ctx1__.__library = default(BizTalkLibrary.Orchestrations.OrchestrationFunctions);
                __ctx1__.__docId = default(System.String);
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
                if (!Inbound_Status_Doc_X12_Receive_Port_1.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__xml != null)
                    __ctx1__.UnrefMessage(__ctx1__.__xml);
                __ctx1__.__xml = new __messagetype_System_Xml_XmlDocument("xml", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__xml);
                Inbound_Status_Doc_X12_Receive_Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__xml, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__xml);
                    __edata.PortName = @"Inbound_Status_Doc_X12_Receive_Port_1";
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
                __ctx1__.__docId = "";
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
                    __ctx1__.__docId = null;
                if (__ctx1__ != null)
                    __ctx1__.__library = null;
                if (__ctx1__ != null)
                    __ctx1__.__timestamp = null;
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (__ctx1__ != null && __ctx1__.__xml != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__xml);
                    __ctx1__.__xml = null;
                }
                if (Inbound_Status_Doc_X12_Receive_Port_1 != null)
                {
                    Inbound_Status_Doc_X12_Receive_Port_1.Close(__ctx1__, __seg__);
                    Inbound_Status_Doc_X12_Receive_Port_1 = null;
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
            __Inbound_Status_Doc_X12_Receive_Orch_1 __ctx1__ = (__Inbound_Status_Doc_X12_Receive_Orch_1)_stateMgrs[1];
            __Inbound_Status_Doc_X12_Receive_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_X12_Receive_Orch_root_0)_stateMgrs[0];
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
                __ctx1__.__docId = __ctx1__.__library.GetX12DocId(__ctx1__.__xml.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_ARRIVED(), __ctx1__.__docId, __ctx1__.__timestamp, __ctx1__.__xml.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_PORT_RECEIVE_X12_STATUS_ARRIVE(), __ctx1__.__docId, __ctx1__.__timestamp, __ctx1__.__xml.part.TypedValue, false);
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
                if (!Inbound_Status_Doc_X12_Receive_Port_1.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__xml != null)
                    __ctx1__.UnrefMessage(__ctx1__.__xml);
                __ctx1__.__xml = new __messagetype_System_Xml_XmlDocument("xml", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__xml);
                Inbound_Status_Doc_X12_Receive_Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__xml, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__xml);
                    __edata.PortName = @"Inbound_Status_Doc_X12_Receive_Port_1";
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
                __ctx1__.__docId = __ctx1__.__library.GetX12DocId(__ctx1__.__xml.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_ARRIVED(), __ctx1__.__docId, __ctx1__.__timestamp, __ctx1__.__xml.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_PORT_RECEIVE_X12_STATUS_ARRIVE(), __ctx1__.__docId, __ctx1__.__timestamp, __ctx1__.__xml.part.TypedValue, false);
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
            __Inbound_Status_Doc_X12_Receive_Orch_1 __ctx1__ = (__Inbound_Status_Doc_X12_Receive_Orch_1)_stateMgrs[1];
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
                __ctx1__.__docId = __ctx1__.__library.GetX12DocId(__ctx1__.__xml.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_FAILED(), __ctx1__.__docId + ".X12.Arrive", __ctx1__.__timestamp, __ctx1__.__xml.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__library.sendExceptionEmail(__ctx2__.__ex_0, "Inbound_Status_Doc_X12_Receive", "", "", __ctx1__.__docId);
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
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{05749BE7-6EED-4B64-B5A5-A34287FAFD81}"))
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
