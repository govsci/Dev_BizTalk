
#pragma warning disable 162

namespace Outbound_PO_EDI_Pickup
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Outbound_PO_EDI_Pickup.__messagetype_EdiSchemas_cXML_cXML)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Outbound_PO_X12_Pickup_PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Outbound_PO_X12_Pickup_PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Outbound_PO_X12_Pickup_PortType_1(Outbound_PO_X12_Pickup_PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Outbound_PO_X12_Pickup_PortType_1 p = new Outbound_PO_X12_Pickup_PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Outbound_PO_X12_Pickup_PortType_1),
            typeof(__messagetype_EdiSchemas_cXML_cXML),
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
    //#line 283 "R:\Source\GSS_Biztalk\Outbound_PO_X12_Pickup\Outbound_PO_X12_Pickup_Orch.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Outbound_PO_X12_Pickup_Port_1", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(Outbound_PO_EDI_Pickup.Outbound_PO_X12_Pickup_PortType_1)
        },
        new System.String[] {
            "Outbound_PO_X12_Pickup_Port_1"
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
    sealed internal class Outbound_PO_X12_Pickup_Orch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Outbound_PO_X12_Pickup_Orch));
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

        static Outbound_PO_X12_Pickup_Orch()
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
            _rootContext = new __Outbound_PO_X12_Pickup_Orch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Outbound_PO_X12_Pickup_Orch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Outbound_PO_X12_Pickup_Orch", tracker)
        {
            ConstructorHelper();
        }

        public Outbound_PO_X12_Pickup_Orch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Outbound_PO_X12_Pickup_Orch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>315d64a0-f33c-4d87-8c89-95623ef1799d</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>81f6dc5d-30fb-424f-9965-364291756511</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>4ba21d43-2a22-450d-8a04-2d422080be20</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>71b3cd6d-93c9-4725-bfad-fef649283bc3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>46bcfc09-d908-435a-913b-80e38550fb99</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>05ef4868-f145-4631-bf6b-2da8bc2e9fed</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c705ea0c-d36c-43d2-b8a7-322ee84070b2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>d2de8feb-8f12-4a2b-b9f7-e6e105f4bc36</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>0522d468-3edf-4062-9b86-7a8631cc1709</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>a50580fb-8049-4f01-a189-fca7fc276c1c</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>ae22047a-be8c-4227-8edd-bf05463c0beb</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>9d72e566-23d2-42cf-8b4f-20aef8aa90ab</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>4f63d776-8eff-422b-919d-dfad46e4d4de</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>18f66f6e-f6d8-4158-b6ab-30f6a505d6eb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>5b58e73b-157f-4a01-965b-1e1d7cee30c3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>770e0526-ad41-4298-b036-f173a31f7dfe</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3e435a4e-1e71-483a-a7ab-93001eeff78f</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>c793dbb2-3664-4f42-b137-610b2c95714f</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>345a3894-514e-4e97-abf3-7451304865b3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>13e351dc-99bf-4cce-a28c-7cf9491ebcc3</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>74b691c8-7c9e-46e0-bfa0-978f7e916fc6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>d39d104a-9406-4798-bca4-5221eee26238</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.SystemException</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>8e486c5b-d554-492b-bded-ed0a7cb8f30c</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Outbound_PO_X12_Pickup_Orch'</ActionName><IsAtomic>0</IsAtomic><Line>283</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>300</Line><Position>22</Position><ShapeID>'81f6dc5d-30fb-424f-9965-364291756511'</ShapeID>
<Messages>
	<MsgInfo><name>xml</name><part>part</part><schema>EdiSchemas.cXML.cXML</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>309</Line><Position>13</Position><ShapeID>'4ba21d43-2a22-450d-8a04-2d422080be20'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>314</Line><Position>31</Position><ShapeID>'71b3cd6d-93c9-4725-bfad-fef649283bc3'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>321</Line><Position>21</Position><ShapeID>'46bcfc09-d908-435a-913b-80e38550fb99'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>324</Line><Position>25</Position><ShapeID>'c705ea0c-d36c-43d2-b8a7-322ee84070b2'</ShapeID>
<Messages>
	<MsgInfo><name>edi850</name><part>part</part><schema>EdiSchemas.X12.X12_00401_850</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>xml</name><part>part</part><schema>EdiSchemas.cXML.cXML</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>330</Line><Position>43</Position><ShapeID>'9d72e566-23d2-42cf-8b4f-20aef8aa90ab'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>336</Line><Position>25</Position><ShapeID>'18f66f6e-f6d8-4158-b6ab-30f6a505d6eb'</ShapeID>
<Messages>
	<MsgInfo><name>edi860</name><part>part</part><schema>EdiSchemas.X12.X12_00401_860</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>xml</name><part>part</part><schema>EdiSchemas.cXML.cXML</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>342</Line><Position>43</Position><ShapeID>'345a3894-514e-4e97-abf3-7451304865b3'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>348</Line><Position>43</Position><ShapeID>'74b691c8-7c9e-46e0-bfa0-978f7e916fc6'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>357</Line><Position>21</Position><ShapeID>'d39d104a-9406-4798-bca4-5221eee26238'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>360</Line><Position>33</Position><ShapeID>'8e486c5b-d554-492b-bded-ed0a7cb8f30c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='5525bdc8-c44a-4e59-8fa3-1c661ed435ef' LowerBound='1.1' HigherBound='101.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Outbound_PO_EDI_Pickup' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='6d4c2f8a-eca8-4fed-aea6-67a0dfe654f2' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='100.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Outbound_PO_X12_Pickup_Orch' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='93ddcf74-4ebf-4571-b3b2-7be6b2b07c7c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='19.1' HigherBound='20.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='BizTalkLibrary.Orchestrations.OrchestrationFunctions' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='library' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1d82474f-0af3-41c7-8959-4e1d00ad1710' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='BizTalkLibrary.Classes.Constants.DUMP_FOLDERS' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='dumpFolders' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='98601999-7288-4f8e-8337-84ac9e3369cc' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='timestamp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b2e816e8-3b98-435e-89b3-154d6a6b99c6' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='orderID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='075e29ac-614b-476b-b925-01d8a6084ed8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='23.1' HigherBound='24.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='orderType' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='62b736f4-d83a-4a28-a0aa-0919c4cc87ed' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='toIdentity' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4822a433-6d53-4d4d-b700-a5fd7784756d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='duped' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='b14af415-673a-48f6-8eeb-d11236c967d0' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='EdiSchemas.X12.X12_00401_850' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='edi850' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='cdba0227-794d-42c8-b303-de2cf1b5b1d8' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='Type' Value='EdiSchemas.X12.X12_00401_860' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='edi860' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='309e163b-c98e-491e-91bc-09e4db73311f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='Type' Value='EdiSchemas.cXML.cXML' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xml' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='315d64a0-f33c-4d87-8c89-95623ef1799d' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='81f6dc5d-30fb-424f-9965-364291756511' ParentLink='ServiceBody_Statement' LowerBound='28.1' HigherBound='37.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Outbound_PO_X12_Pickup_Port_1' />
                    <om:Property Name='MessageName' Value='xml' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='4ba21d43-2a22-450d-8a04-2d422080be20' ParentLink='ServiceBody_Statement' LowerBound='37.1' HigherBound='98.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='VariableAssignment' OID='71b3cd6d-93c9-4725-bfad-fef649283bc3' ParentLink='ComplexStatement_Statement' LowerBound='42.1' HigherBound='49.1'>
                        <om:Property Name='Expression' Value='timestamp = library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;orderID = library.GetOrderId(xml);&#xD;&#xA;toIdentity = library.GetToIdentity(xml);&#xD;&#xA;library.CreateDump(dumpFolders.OUTBOUND_PO_ARRIVED(),orderID,timestamp,xml,true);&#xD;&#xA;orderType = library.GetOrderRequestType(xml);&#xD;&#xA;duped = library.CheckOutboundPoDuplicate(orderID,&quot;SPS&quot;);' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Expression_1' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Decision' OID='46bcfc09-d908-435a-913b-80e38550fb99' ParentLink='ComplexStatement_Statement' LowerBound='49.1' HigherBound='82.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Decide_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='DecisionBranch' OID='05ef4868-f145-4631-bf6b-2da8bc2e9fed' ParentLink='ReallyComplexStatement_Branch' LowerBound='50.21' HigherBound='62.1'>
                            <om:Property Name='Expression' Value='orderType == &quot;new&quot; &amp;&amp; !duped' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rule_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='c705ea0c-d36c-43d2-b8a7-322ee84070b2' ParentLink='ComplexStatement_Statement' LowerBound='52.1' HigherBound='58.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='d2de8feb-8f12-4a2b-b9f7-e6e105f4bc36' ParentLink='ComplexStatement_Statement' LowerBound='55.1' HigherBound='57.1'>
                                    <om:Property Name='ClassName' Value='Outbound_PO_EDI_Pickup.Maps.PO_850_Map' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessagePartRef' OID='0522d468-3edf-4062-9b86-7a8631cc1709' ParentLink='Transform_InputMessagePartRef' LowerBound='56.90' HigherBound='56.93'>
                                        <om:Property Name='MessageRef' Value='xml' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_1' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='a50580fb-8049-4f01-a189-fca7fc276c1c' ParentLink='Transform_OutputMessagePartRef' LowerBound='56.40' HigherBound='56.46'>
                                        <om:Property Name='MessageRef' Value='edi850' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_2' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='ae22047a-be8c-4227-8edd-bf05463c0beb' ParentLink='Construct_MessageRef' LowerBound='53.35' HigherBound='53.41'>
                                    <om:Property Name='Ref' Value='edi850' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='9d72e566-23d2-42cf-8b4f-20aef8aa90ab' ParentLink='ComplexStatement_Statement' LowerBound='58.1' HigherBound='61.1'>
                                <om:Property Name='Expression' Value='library.CreateDump(dumpFolders.OUTBOUND_PO_OUTGOING(),orderID,timestamp,edi850,true);&#xD;&#xA;library.CreateDump(dumpFolders.OUTBOUND_PORT_SEND_CXML_PO_ERP_X12_PICKUP(),orderID,timestamp,edi850,false);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_2' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='4f63d776-8eff-422b-919d-dfad46e4d4de' ParentLink='ReallyComplexStatement_Branch' LowerBound='62.26' HigherBound='74.1'>
                            <om:Property Name='Expression' Value='orderType == &quot;edit&quot;' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rule_2' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Construct' OID='18f66f6e-f6d8-4158-b6ab-30f6a505d6eb' ParentLink='ComplexStatement_Statement' LowerBound='64.1' HigherBound='70.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_2' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='5b58e73b-157f-4a01-965b-1e1d7cee30c3' ParentLink='ComplexStatement_Statement' LowerBound='67.1' HigherBound='69.1'>
                                    <om:Property Name='ClassName' Value='Outbound_PO_EDI_Pickup.Maps.PO_860_Map' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_2' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessagePartRef' OID='770e0526-ad41-4298-b036-f173a31f7dfe' ParentLink='Transform_InputMessagePartRef' LowerBound='68.90' HigherBound='68.93'>
                                        <om:Property Name='MessageRef' Value='xml' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_3' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='3e435a4e-1e71-483a-a7ab-93001eeff78f' ParentLink='Transform_OutputMessagePartRef' LowerBound='68.40' HigherBound='68.46'>
                                        <om:Property Name='MessageRef' Value='edi860' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_4' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='c793dbb2-3664-4f42-b137-610b2c95714f' ParentLink='Construct_MessageRef' LowerBound='65.35' HigherBound='65.41'>
                                    <om:Property Name='Ref' Value='edi860' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='345a3894-514e-4e97-abf3-7451304865b3' ParentLink='ComplexStatement_Statement' LowerBound='70.1' HigherBound='73.1'>
                                <om:Property Name='Expression' Value='library.CreateDump(dumpFolders.OUTBOUND_PO_OUTGOING(),orderID,timestamp,edi860,true);&#xD;&#xA;library.CreateDump(dumpFolders.OUTBOUND_PORT_SEND_CXML_PO_ERP_X12_PICKUP(),orderID,timestamp,edi860,false);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_3' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='13e351dc-99bf-4cce-a28c-7cf9491ebcc3' ParentLink='ReallyComplexStatement_Branch'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Else' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='VariableAssignment' OID='74b691c8-7c9e-46e0-bfa0-978f7e916fc6' ParentLink='ComplexStatement_Statement' LowerBound='76.1' HigherBound='81.1'>
                                <om:Property Name='Expression' Value='library.CreateDump(dumpFolders.OUTBOUND_PO_FAILED(),orderID,timestamp,xml,true);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;EDI.Waiting.Pickup&quot;,&quot;EDI &quot;+orderID+&quot; was duped&quot;);&#xD;&#xA;library.sendExceptionEmail(new System.Exception(&quot;Duplication detected&quot;),&quot;Outbound_PO_X12_Pickup&quot;,&quot;&quot;,&quot;&quot;,orderID);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_5' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='d39d104a-9406-4798-bca4-5221eee26238' ParentLink='Scope_Catch' LowerBound='85.1' HigherBound='96.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.SystemException' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='8e486c5b-d554-492b-bded-ed0a7cb8f30c' ParentLink='Catch_Statement' LowerBound='88.1' HigherBound='95.1'>
                            <om:Property Name='Expression' Value='library = new BizTalkLibrary.Orchestrations.OrchestrationFunctions();&#xD;&#xA;timestamp=library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;orderID=library.GetOrderId(xml);&#xD;&#xA;library.CreateDump(dumpFolders.OUTBOUND_PO_FAILED(),orderID+&quot;.cXML_X12_PO_Pickup&quot;,timestamp,xml,true);&#xD;&#xA;&#xD;&#xA;library.sendExceptionEmail(ex,&quot;Outbound_PO_X12_Pickup&quot;,&quot;&quot;,&quot;&quot;,orderID);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_4' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='2416c14f-80b7-4e33-8ecd-598c02276ebc' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Outbound_PO_EDI_Pickup.Outbound_PO_X12_Pickup_PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Outbound_PO_X12_Pickup_Port_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='8db22476-0b53-4f43-b458-24df977f52aa' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='4fd821d9-30c5-4c8d-a712-06a6c765cbdc' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Outbound_PO_X12_Pickup_PortType_1' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='1308e7b6-be36-4b44-85b0-ea4b5ac046bc' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='4f83fbd2-70f8-4cff-9437-89f612476c23' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.33'>
                    <om:Property Name='Ref' Value='EdiSchemas.cXML.cXML' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Outbound_PO_X12_Pickup_Orch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Outbound_PO_X12_Pickup_Orch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Outbound_PO_X12_Pickup_Orch")
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
                Outbound_PO_X12_Pickup_Orch __svc__ = (Outbound_PO_X12_Pickup_Orch)_service;
                __Outbound_PO_X12_Pickup_Orch_root_0 __ctx0__ = (__Outbound_PO_X12_Pickup_Orch_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Outbound_PO_X12_Pickup_Port_1 != null)
                {
                    __svc__.Outbound_PO_X12_Pickup_Port_1.Close(this, null);
                    __svc__.Outbound_PO_X12_Pickup_Port_1 = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __Outbound_PO_X12_Pickup_Orch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Outbound_PO_X12_Pickup_Orch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Outbound_PO_X12_Pickup_Orch")
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
                Outbound_PO_X12_Pickup_Orch __svc__ = (Outbound_PO_X12_Pickup_Orch)_service;
                __Outbound_PO_X12_Pickup_Orch_1 __ctx1__ = (__Outbound_PO_X12_Pickup_Orch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__toIdentity = null;
                if (__ctx1__ != null)
                    __ctx1__.__dumpFolders = null;
                if (__ctx1__ != null)
                    __ctx1__.__timestamp = null;
                if (__ctx1__ != null)
                    __ctx1__.__orderID = null;
                if (__ctx1__ != null && __ctx1__.__xml != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__xml);
                    __ctx1__.__xml = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__orderType = null;
                if (__ctx1__ != null)
                    __ctx1__.__library = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("edi850")]
            public __messagetype_EdiSchemas_X12_X12_00401_850 __edi850;
            [Microsoft.XLANGs.Core.UserVariableAttribute("edi860")]
            public __messagetype_EdiSchemas_X12_X12_00401_860 __edi860;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xml")]
            public __messagetype_EdiSchemas_cXML_cXML __xml;
            [Microsoft.XLANGs.Core.UserVariableAttribute("library")]
            internal BizTalkLibrary.Orchestrations.OrchestrationFunctions __library;
            [Microsoft.XLANGs.Core.UserVariableAttribute("dumpFolders")]
            internal BizTalkLibrary.Classes.Constants.DUMP_FOLDERS __dumpFolders;
            [Microsoft.XLANGs.Core.UserVariableAttribute("timestamp")]
            internal System.String __timestamp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("orderID")]
            internal System.String __orderID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("orderType")]
            internal System.String __orderType;
            [Microsoft.XLANGs.Core.UserVariableAttribute("toIdentity")]
            internal System.String __toIdentity;
            [Microsoft.XLANGs.Core.UserVariableAttribute("duped")]
            internal System.Boolean __duped;
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
                Outbound_PO_X12_Pickup_Orch __svc__ = (Outbound_PO_X12_Pickup_Orch)_service;
                __Outbound_PO_X12_Pickup_Orch_1 __ctx1__ = (__Outbound_PO_X12_Pickup_Orch_1)(__svc__._stateMgrs[1]);
                ____scope33_2 __ctx2__ = (____scope33_2)(__svc__._stateMgrs[2]);

                if (__ctx1__ != null && __ctx1__.__edi850 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__edi850);
                    __ctx1__.__edi850 = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if (__ctx1__ != null && __ctx1__.__edi860 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__edi860);
                    __ctx1__.__edi860 = null;
                }
                base.Finally();
            }

            internal object __exv__;
            internal System.SystemException __ex_0
            {
                get { return (System.SystemException)__exv__; }
                set { __exv__ = value; }
            }
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
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
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Outbound_PO_X12_Pickup_Port_1")]
        internal Outbound_PO_X12_Pickup_PortType_1 Outbound_PO_X12_Pickup_Port_1;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Outbound_PO_X12_Pickup_PortType_1.Operation_1},
                                               typeof(Outbound_PO_X12_Pickup_Orch).GetField("Outbound_PO_X12_Pickup_Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Outbound_PO_X12_Pickup_Orch), "Outbound_PO_X12_Pickup_Port_1"),
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
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "81f6dc5d-30fb-424f-9965-364291756511", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "81f6dc5d-30fb-424f-9965-364291756511", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "4ba21d43-2a22-450d-8a04-2d422080be20", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "71b3cd6d-93c9-4725-bfad-fef649283bc3", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "71b3cd6d-93c9-4725-bfad-fef649283bc3", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "46bcfc09-d908-435a-913b-80e38550fb99", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "c705ea0c-d36c-43d2-b8a7-322ee84070b2", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "c705ea0c-d36c-43d2-b8a7-322ee84070b2", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "9d72e566-23d2-42cf-8b4f-20aef8aa90ab", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "9d72e566-23d2-42cf-8b4f-20aef8aa90ab", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "18f66f6e-f6d8-4158-b6ab-30f6a505d6eb", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "18f66f6e-f6d8-4158-b6ab-30f6a505d6eb", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "345a3894-514e-4e97-abf3-7451304865b3", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "345a3894-514e-4e97-abf3-7451304865b3", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "74b691c8-7c9e-46e0-bfa0-978f7e916fc6", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "74b691c8-7c9e-46e0-bfa0-978f7e916fc6", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "46bcfc09-d908-435a-913b-80e38550fb99", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "d39d104a-9406-4798-bca4-5221eee26238", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "8e486c5b-d554-492b-bded-ed0a7cb8f30c", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "8e486c5b-d554-492b-bded-ed0a7cb8f30c", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "d39d104a-9406-4798-bca4-5221eee26238", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "4ba21d43-2a22-450d-8a04-2d422080be20", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,4,4,4,27,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,7,7,7,7,7,9,9,10,10,11,12,12,13,13,9,9,9,14,14,15,16,16,17,17,17,18,18,19,19,19,19,20,20,20,20,};
        public static int[] __progressLocation3 = new int[] { 21,21,22,22,23,23,23,23,23,26,26,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Outbound_PO_X12_Pickup_Orch_1 __ctx1__ = (__Outbound_PO_X12_Pickup_Orch_1)_stateMgrs[1];
            __Outbound_PO_X12_Pickup_Orch_root_0 __ctx0__ = (__Outbound_PO_X12_Pickup_Orch_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Outbound_PO_X12_Pickup_Port_1 = new Outbound_PO_X12_Pickup_PortType_1(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Outbound_PO_X12_Pickup_Port_1, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Outbound_PO_X12_Pickup_Orch_1(this);
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
            __Outbound_PO_X12_Pickup_Orch_1 __ctx1__ = (__Outbound_PO_X12_Pickup_Orch_1)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __Outbound_PO_X12_Pickup_Orch_root_0 __ctx0__ = (__Outbound_PO_X12_Pickup_Orch_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__library = default(BizTalkLibrary.Orchestrations.OrchestrationFunctions);
                __ctx1__.__dumpFolders = default(BizTalkLibrary.Classes.Constants.DUMP_FOLDERS);
                __ctx1__.__timestamp = default(System.String);
                __ctx1__.__orderID = default(System.String);
                __ctx1__.__orderType = default(System.String);
                __ctx1__.__toIdentity = default(System.String);
                __ctx1__.__duped = default(System.Boolean);
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
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!Outbound_PO_X12_Pickup_Port_1.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__xml != null)
                    __ctx1__.UnrefMessage(__ctx1__.__xml);
                __ctx1__.__xml = new __messagetype_EdiSchemas_cXML_cXML("xml", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__xml);
                Outbound_PO_X12_Pickup_Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__xml, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Outbound_PO_X12_Pickup_Port_1 != null)
                {
                    Outbound_PO_X12_Pickup_Port_1.Close(__ctx1__, __seg__);
                    Outbound_PO_X12_Pickup_Port_1 = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__xml);
                    __edata.PortName = @"Outbound_PO_X12_Pickup_Port_1";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__library = new BizTalkLibrary.Orchestrations.OrchestrationFunctions();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__dumpFolders = new BizTalkLibrary.Classes.Constants.DUMP_FOLDERS();
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__timestamp = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__orderID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__orderType = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__toIdentity = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__duped = true;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __ctx2__ = new ____scope33_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__toIdentity = null;
                if (__ctx1__ != null)
                    __ctx1__.__orderType = null;
                if (__ctx1__ != null)
                    __ctx1__.__orderID = null;
                if (__ctx1__ != null)
                    __ctx1__.__timestamp = null;
                if (__ctx1__ != null)
                    __ctx1__.__dumpFolders = null;
                if (__ctx1__ != null)
                    __ctx1__.__library = null;
                if (__ctx1__ != null && __ctx1__.__xml != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__xml);
                    __ctx1__.__xml = null;
                }
                Tracker.FireEvent(__eventLocations[27],__eventData[10],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 19;
            case 19:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Outbound_PO_X12_Pickup_Orch_1 __ctx1__ = (__Outbound_PO_X12_Pickup_Orch_1)_stateMgrs[1];
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
                __ctx1__.__orderID = __ctx1__.__library.GetOrderId(__ctx1__.__xml.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__toIdentity = __ctx1__.__library.GetToIdentity(__ctx1__.__xml.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.OUTBOUND_PO_ARRIVED(), __ctx1__.__orderID, __ctx1__.__timestamp, __ctx1__.__xml.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__orderType = __ctx1__.__library.GetOrderRequestType(__ctx1__.__xml.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__duped = __ctx1__.__library.CheckOutboundPoDuplicate(__ctx1__.__orderID, "SPS");
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __condition__ = __ctx1__.__orderType == "new" && !__ctx1__.__duped;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 19;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_850 __edi850 = new __messagetype_EdiSchemas_X12_X12_00401_850("edi850", __ctx1__);

                    ApplyTransform(typeof(Outbound_PO_EDI_Pickup.Maps.PO_850_Map), new object[] {__edi850.part}, new object[] {__ctx1__.__xml.part});

                    if (__ctx1__.__edi850 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__edi850);
                    __ctx1__.__edi850 = __edi850;
                    __ctx1__.RefMessage(__ctx1__.__edi850);
                }
                __ctx1__.__edi850.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__edi850);
                    __edata.Messages.Add(__ctx1__.__xml);
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.OUTBOUND_PO_OUTGOING(), __ctx1__.__orderID, __ctx1__.__timestamp, __ctx1__.__edi850.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.OUTBOUND_PORT_SEND_CXML_PO_ERP_X12_PICKUP(), __ctx1__.__orderID, __ctx1__.__timestamp, __ctx1__.__edi850.part.TypedValue, false);
                if (__ctx1__ != null && __ctx1__.__edi850 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__edi850);
                    __ctx1__.__edi850 = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                __condition__ = __ctx1__.__orderType == "edit";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 29;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_860 __edi860 = new __messagetype_EdiSchemas_X12_X12_00401_860("edi860", __ctx1__);

                    ApplyTransform(typeof(Outbound_PO_EDI_Pickup.Maps.PO_860_Map), new object[] {__edi860.part}, new object[] {__ctx1__.__xml.part});

                    if (__ctx1__.__edi860 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__edi860);
                    __ctx1__.__edi860 = __edi860;
                    __ctx1__.RefMessage(__ctx1__.__edi860);
                }
                __ctx1__.__edi860.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__edi860);
                    __edata.Messages.Add(__ctx1__.__xml);
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.OUTBOUND_PO_OUTGOING(), __ctx1__.__orderID, __ctx1__.__timestamp, __ctx1__.__edi860.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.OUTBOUND_PORT_SEND_CXML_PO_ERP_X12_PICKUP(), __ctx1__.__orderID, __ctx1__.__timestamp, __ctx1__.__edi860.part.TypedValue, false);
                if (__ctx1__ != null && __ctx1__.__edi860 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__edi860);
                    __ctx1__.__edi860 = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.OUTBOUND_PO_FAILED(), __ctx1__.__orderID, __ctx1__.__timestamp, __ctx1__.__xml.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                System.Diagnostics.EventLog.WriteEntry("EDI.Waiting.Pickup", "EDI " + __ctx1__.__orderID + " was duped");
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                __ctx1__.__library.sendExceptionEmail(new System.Exception("Duplication detected"), "Outbound_PO_X12_Pickup", "", "", __ctx1__.__orderID);
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 38;
            case 38:
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
            __Outbound_PO_X12_Pickup_Orch_1 __ctx1__ = (__Outbound_PO_X12_Pickup_Orch_1)_stateMgrs[1];
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
                Tracker.FireEvent(__eventLocations[21],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[3],_stateMgrs[2].TrackDataStream );
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
                Tracker.FireEvent(__eventLocations[23],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__timestamp = __ctx1__.__library.GetTimeStamp(System.DateTime.Now);
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__orderID = __ctx1__.__library.GetOrderId(__ctx1__.__xml.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.OUTBOUND_PO_FAILED(), __ctx1__.__orderID + ".cXML_X12_PO_Pickup", __ctx1__.__timestamp, __ctx1__.__xml.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__library.sendExceptionEmail(__ctx2__.__ex_0, "Outbound_PO_X12_Pickup", "", "", __ctx1__.__orderID);
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __EdiSchemas_cXML_cXML__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static EdiSchemas.cXML.cXML _schema = new EdiSchemas.cXML.cXML();

        public __EdiSchemas_cXML_cXML__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "EdiSchemas.cXML.cXML",
        new System.Type[]{
            typeof(EdiSchemas.cXML.cXML)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__EdiSchemas_cXML_cXML__)
        },
        0,
        @"cXML"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_EdiSchemas_cXML_cXML : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __EdiSchemas_cXML_cXML__ part;

        private void __CreatePartWrappers()
        {
            part = new __EdiSchemas_cXML_cXML__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_EdiSchemas_cXML_cXML(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __EdiSchemas_X12_X12_00401_850__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static EdiSchemas.X12.X12_00401_850 _schema = new EdiSchemas.X12.X12_00401_850();

        public __EdiSchemas_X12_X12_00401_850__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "EdiSchemas.X12.X12_00401_850",
        new System.Type[]{
            typeof(EdiSchemas.X12.X12_00401_850)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__EdiSchemas_X12_X12_00401_850__)
        },
        0,
        @"http://schemas.microsoft.com/BizTalk/EDI/X12/2006#X12_00401_850"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_EdiSchemas_X12_X12_00401_850 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __EdiSchemas_X12_X12_00401_850__ part;

        private void __CreatePartWrappers()
        {
            part = new __EdiSchemas_X12_X12_00401_850__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_EdiSchemas_X12_X12_00401_850(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __EdiSchemas_X12_X12_00401_860__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static EdiSchemas.X12.X12_00401_860 _schema = new EdiSchemas.X12.X12_00401_860();

        public __EdiSchemas_X12_X12_00401_860__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "EdiSchemas.X12.X12_00401_860",
        new System.Type[]{
            typeof(EdiSchemas.X12.X12_00401_860)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__EdiSchemas_X12_X12_00401_860__)
        },
        0,
        @"http://schemas.microsoft.com/BizTalk/EDI/X12/2006#X12_00401_860"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_EdiSchemas_X12_X12_00401_860 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __EdiSchemas_X12_X12_00401_860__ part;

        private void __CreatePartWrappers()
        {
            part = new __EdiSchemas_X12_X12_00401_860__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_EdiSchemas_X12_X12_00401_860(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
