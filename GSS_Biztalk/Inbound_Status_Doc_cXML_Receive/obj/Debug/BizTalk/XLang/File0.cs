
#pragma warning disable 162

namespace Inbound_Status_Doc_cXML_Receive
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Inbound_Status_Doc_cXML_Receive.__messagetype_System_Xml_XmlDocument), 
            typeof(Inbound_Status_Doc_cXML_Receive.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Inbound_Status_Doc_cXML_Receive_PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Inbound_Status_Doc_cXML_Receive_PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Inbound_Status_Doc_cXML_Receive_PortType_1(Inbound_Status_Doc_cXML_Receive_PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Inbound_Status_Doc_cXML_Receive_PortType_1 p = new Inbound_Status_Doc_cXML_Receive_PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(Inbound_Status_Doc_cXML_Receive_PortType_1),
            typeof(__messagetype_System_Xml_XmlDocument),
            typeof(__messagetype_System_Xml_XmlDocument),
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
    //#line 261 "R:\Source\GSS_Biztalk\Inbound_Status_Doc_cXML_Receive\Inbound_Status_Doc_cXML_Receive_Orch.odx"
    [Microsoft.XLANGs.BaseTypes.StaticConvoyAttribute(
        0,
        new System.Type[] { typeof(CorrelationType_1) }
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Inbound_Status_Doc_cXML_Receive_Port_1", "Operation_1", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        1, "Inbound_Status_Doc_cXML_Receive_Port_1", "Operation_1", -1, 0, false
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(Inbound_Status_Doc_cXML_Receive.Inbound_Status_Doc_cXML_Receive_PortType_1)
        },
        new System.String[] {
            "Inbound_Status_Doc_cXML_Receive_Port_1"
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
    sealed internal class Inbound_Status_Doc_cXML_Receive_Orch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Inbound_Status_Doc_cXML_Receive_Orch));
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

        static Inbound_Status_Doc_cXML_Receive_Orch()
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
            _rootContext = new __Inbound_Status_Doc_cXML_Receive_Orch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Inbound_Status_Doc_cXML_Receive_Orch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Inbound_Status_Doc_cXML_Receive_Orch", tracker)
        {
            ConstructorHelper();
        }

        public Inbound_Status_Doc_cXML_Receive_Orch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Inbound_Status_Doc_cXML_Receive_Orch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>24016a2d-3eaf-4a8a-a3eb-2bcc7581ed05</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>95f6074f-beb6-4559-bd37-0c28c0252e2b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive 1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>f0b26f17-901c-4046-b7f7-9dbeda3fdc1d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>50825063-c3ae-4444-87cf-114eb120f244</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Create Dump 1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>c4d29a86-feb8-4963-b5b5-4918de56dd04</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Create Cxml Response 1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>aa11441f-6fe6-446b-bcff-f891aeb330ed</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send 1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>fc0d8f30-ce04-4faf-bea8-10586a5d50a1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Loop_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>f1e9d5d2-76cf-44a1-abf8-729f6c3ee704</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive 2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>ec14835e-d76f-4fd0-8c98-d34368bd9ab8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Create Dump 2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>c996ab31-a3b0-46b0-8d5d-1803535a5107</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Create Cxml Response 2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>61640a18-0943-4b28-9194-23ecbe6f6eb2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send 2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>8d8172b3-4ac9-410f-bda6-833631c330f3</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>2834761b-cbda-440b-8018-f73b32d7c1ac</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Exception_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Inbound_Status_Doc_cXML_Receive_Orch'</ActionName><IsAtomic>0</IsAtomic><Line>261</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>275</Line><Position>22</Position><ShapeID>'95f6074f-beb6-4559-bd37-0c28c0252e2b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>281</Line><Position>13</Position><ShapeID>'f0b26f17-901c-4046-b7f7-9dbeda3fdc1d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>286</Line><Position>31</Position><ShapeID>'50825063-c3ae-4444-87cf-114eb120f244'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>291</Line><Position>21</Position><ShapeID>'c4d29a86-feb8-4963-b5b5-4918de56dd04'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>298</Line><Position>21</Position><ShapeID>'aa11441f-6fe6-446b-bcff-f891aeb330ed'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>300</Line><Position>21</Position><ShapeID>'fc0d8f30-ce04-4faf-bea8-10586a5d50a1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>303</Line><Position>25</Position><ShapeID>'f1e9d5d2-76cf-44a1-abf8-729f6c3ee704'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>305</Line><Position>35</Position><ShapeID>'ec14835e-d76f-4fd0-8c98-d34368bd9ab8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>310</Line><Position>25</Position><ShapeID>'c996ab31-a3b0-46b0-8d5d-1803535a5107'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>317</Line><Position>25</Position><ShapeID>'61640a18-0943-4b28-9194-23ecbe6f6eb2'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>323</Line><Position>21</Position><ShapeID>'8d8172b3-4ac9-410f-bda6-833631c330f3'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>326</Line><Position>33</Position><ShapeID>'2834761b-cbda-440b-8018-f73b32d7c1ac'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='43f562e0-6e42-4b11-a19d-abee4d23105f' LowerBound='1.1' HigherBound='94.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Inbound_Status_Doc_cXML_Receive' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='8ee5e0b6-a8ed-4e48-a3a0-a11dc1c1ca48' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Inbound_Status_Doc_cXML_Receive_PortType_1' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='cf07d80c-dd54-40d5-838e-4b4d29d4510a' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='61badae9-90d3-426f-948c-82c648e59753' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='e8bd4f1a-dfe8-45ec-a70b-5339e650fd95' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.37' HigherBound='8.59'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='8c6e356f-8c21-4b87-8cd9-88c850e3c174' ParentLink='Module_CorrelationType' LowerBound='11.1' HigherBound='15.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PropertyRef' OID='c23b4212-d719-42bf-8a27-811dc38527cf' ParentLink='CorrelationType_PropertyRef' LowerBound='13.9' HigherBound='13.28'>
                <om:Property Name='Ref' Value='BTS.ReceivePortName' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='78942b0a-9f8d-4114-91cd-c5312cf3240c' ParentLink='Module_ServiceDeclaration' LowerBound='15.1' HigherBound='93.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Inbound_Status_Doc_cXML_Receive_Orch' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='cd729ea8-fe4a-4cf1-8508-e7f7ea0df0ae' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='23.1' HigherBound='24.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='timestamp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='638d9bb6-358a-43f0-b831-936d1be40a4e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='key' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ace31c6e-2af7-4b04-a2c7-92fdd9d6ce1d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='BizTalkLibrary.Orchestrations.OrchestrationFunctions' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='library' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f758a17a-9d74-4386-ba6c-02dd6f06edef' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='BizTalkLibrary.Classes.Constants.DUMP_FOLDERS' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='dumpFolders' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='CorrelationDeclaration' OID='0edd689c-9d45-42f7-b1d2-307825b6412b' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='Type' Value='Inbound_Status_Doc_cXML_Receive.CorrelationType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Correlation_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='9e32d0a6-e6e5-4231-9fc1-108bed0df19a' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='30.89' HigherBound='30.113'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='95f6074f-beb6-4559-bd37-0c28c0252e2b' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='e12d3f04-a1a7-4432-8377-7d9e857e996e' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='53.93' HigherBound='53.106'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='aa11441f-6fe6-446b-bcff-f891aeb330ed' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='07f4ffc8-5599-4e17-bcde-4a00e0598970' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='58.92' HigherBound='58.105'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='f1e9d5d2-76cf-44a1-abf8-729f6c3ee704' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_3' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='1304f630-8f8c-41ff-84a3-ff5eae279330' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='72.97' HigherBound='72.110'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='61640a18-0943-4b28-9194-23ecbe6f6eb2' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_4' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d28b8b8e-8cf5-4b17-8ac3-d46d60a9a778' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='cXML' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ea2bb2cd-6308-4d2e-a443-70ab6feb49b1' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='responseCxml' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='24016a2d-3eaf-4a8a-a3eb-2bcc7581ed05' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='95f6074f-beb6-4559-bd37-0c28c0252e2b' ParentLink='ServiceBody_Statement' LowerBound='29.1' HigherBound='35.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Inbound_Status_Doc_cXML_Receive_Port_1' />
                    <om:Property Name='MessageName' Value='cXML' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive 1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='f0b26f17-901c-4046-b7f7-9dbeda3fdc1d' ParentLink='ServiceBody_Statement' LowerBound='35.1' HigherBound='91.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='VariableAssignment' OID='50825063-c3ae-4444-87cf-114eb120f244' ParentLink='ComplexStatement_Statement' LowerBound='40.1' HigherBound='45.1'>
                        <om:Property Name='Expression' Value='timestamp = library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;key = library.HasKey(cXML);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_ARRIVED(),key,timestamp,cXML,true);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_PORT_RECEIVE_CXML_STATUS_ARRIVE(),key,timestamp,cXML,false);' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Create Dump 1' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='c4d29a86-feb8-4963-b5b5-4918de56dd04' ParentLink='ComplexStatement_Statement' LowerBound='45.1' HigherBound='52.1'>
                        <om:Property Name='Expression' Value='construct responseCxml {&#xD;&#xA;responseCxml = new System.Xml.XmlDocument();&#xD;&#xA;responseCxml.LoadXml(&quot;&lt;cXML version=\&quot;1.2.008\&quot; timestamp=\&quot;&quot;+System.DateTime.Now.ToString(&quot;yyyy-MM-dd:hh:mm:sszz&quot;)+&quot;\&quot; payloadID=\&quot;&quot;+System.DateTime.Now.ToString(&quot;yyyyMMddhhmmssffff&quot;)+&quot;@b2b.govsci.com\&quot;&gt;&lt;Response&gt;&lt;Status code=\&quot;200\&quot; text=\&quot;Accepted\&quot;&gt;&lt;/Status&gt;&lt;/Response&gt;&lt;/cXML&gt;&quot;);&#xD;&#xA;};&#xD;&#xA;&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_RESPONSE(),key,timestamp,responseCxml,true);' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Create Cxml Response 1' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Send' OID='aa11441f-6fe6-446b-bcff-f891aeb330ed' ParentLink='ComplexStatement_Statement' LowerBound='52.1' HigherBound='54.1'>
                        <om:Property Name='PortName' Value='Inbound_Status_Doc_cXML_Receive_Port_1' />
                        <om:Property Name='MessageName' Value='responseCxml' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send 1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='While' OID='fc0d8f30-ce04-4faf-bea8-10586a5d50a1' ParentLink='ComplexStatement_Statement' LowerBound='54.1' HigherBound='74.1'>
                        <om:Property Name='Expression' Value='true' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Loop_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Receive' OID='f1e9d5d2-76cf-44a1-abf8-729f6c3ee704' ParentLink='ComplexStatement_Statement' LowerBound='57.1' HigherBound='59.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='Inbound_Status_Doc_cXML_Receive_Port_1' />
                            <om:Property Name='MessageName' Value='cXML' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive 2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='ec14835e-d76f-4fd0-8c98-d34368bd9ab8' ParentLink='ComplexStatement_Statement' LowerBound='59.1' HigherBound='64.1'>
                            <om:Property Name='Expression' Value='timestamp = library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;key = library.HasKey(cXML);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_ARRIVED(),key,timestamp,cXML,true);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_PORT_RECEIVE_CXML_STATUS_ARRIVE(),key,timestamp,cXML,false);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Create Dump 2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='c996ab31-a3b0-46b0-8d5d-1803535a5107' ParentLink='ComplexStatement_Statement' LowerBound='64.1' HigherBound='71.1'>
                            <om:Property Name='Expression' Value='construct responseCxml {&#xD;&#xA;responseCxml = new System.Xml.XmlDocument();&#xD;&#xA;responseCxml.LoadXml(&quot;&lt;cXML version=\&quot;1.2.008\&quot; timestamp=\&quot;&quot;+System.DateTime.Now.ToString(&quot;yyyy-MM-dd:hh:mm:sszz&quot;)+&quot;\&quot; payloadID=\&quot;&quot;+System.DateTime.Now.ToString(&quot;yyyyMMddhhmmssffff&quot;)+&quot;@b2b.govsci.com\&quot;&gt;&lt;Response&gt;&lt;Status code=\&quot;200\&quot; text=\&quot;Accepted\&quot;&gt;&lt;/Status&gt;&lt;/Response&gt;&lt;/cXML&gt;&quot;);&#xD;&#xA;};&#xD;&#xA;&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_RESPONSE(),key,timestamp,responseCxml,true);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Create Cxml Response 2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Send' OID='61640a18-0943-4b28-9194-23ecbe6f6eb2' ParentLink='ComplexStatement_Statement' LowerBound='71.1' HigherBound='73.1'>
                            <om:Property Name='PortName' Value='Inbound_Status_Doc_cXML_Receive_Port_1' />
                            <om:Property Name='MessageName' Value='responseCxml' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Response' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send 2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='8d8172b3-4ac9-410f-bda6-833631c330f3' ParentLink='Scope_Catch' LowerBound='77.1' HigherBound='89.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='2834761b-cbda-440b-8018-f73b32d7c1ac' ParentLink='Catch_Statement' LowerBound='80.1' HigherBound='88.1'>
                            <om:Property Name='Expression' Value='library = new BizTalkLibrary.Orchestrations.OrchestrationFunctions();&#xD;&#xA;dumpFolders = new BizTalkLibrary.Classes.Constants.DUMP_FOLDERS();&#xD;&#xA;timestamp=library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;key=library.HasKey(cXML);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_FAILED(),key+&quot;.Arrive&quot;,timestamp,cXML,true);&#xD;&#xA;&#xD;&#xA;library.sendExceptionEmail(ex,&quot;Inbound_Status_Doc_cXML_Receive&quot;,&quot;&quot;,&quot;&quot;,key);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Exception_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='35380153-689b-4d62-8e08-87d4247c787a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='18.1' HigherBound='20.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Inbound_Status_Doc_cXML_Receive.Inbound_Status_Doc_cXML_Receive_PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Inbound_Status_Doc_cXML_Receive_Port_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='07853e38-53c7-47d3-9937-ffe5f4fa5dda' ParentLink='PortDeclaration_CLRAttribute' LowerBound='18.1' HigherBound='19.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Inbound_Status_Doc_cXML_Receive_Orch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Inbound_Status_Doc_cXML_Receive_Orch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Inbound_Status_Doc_cXML_Receive_Orch")
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
                Inbound_Status_Doc_cXML_Receive_Orch __svc__ = (Inbound_Status_Doc_cXML_Receive_Orch)_service;
                __Inbound_Status_Doc_cXML_Receive_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_cXML_Receive_Orch_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Inbound_Status_Doc_cXML_Receive_Port_1 != null)
                {
                    __svc__.Inbound_Status_Doc_cXML_Receive_Port_1.Close(this, null);
                    __svc__.Inbound_Status_Doc_cXML_Receive_Port_1 = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __Inbound_Status_Doc_cXML_Receive_Orch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Inbound_Status_Doc_cXML_Receive_Orch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Inbound_Status_Doc_cXML_Receive_Orch")
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
                Inbound_Status_Doc_cXML_Receive_Orch __svc__ = (Inbound_Status_Doc_cXML_Receive_Orch)_service;
                __Inbound_Status_Doc_cXML_Receive_Orch_1 __ctx1__ = (__Inbound_Status_Doc_cXML_Receive_Orch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__dumpFolders = null;
                if (__ctx1__ != null && __ctx1__.__cXML != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__cXML);
                    __ctx1__.__cXML = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__library = null;
                if (__ctx1__ != null)
                    __ctx1__.__key = null;
                if (__ctx1__ != null)
                    __ctx1__.__timestamp = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("cXML")]
            public __messagetype_System_Xml_XmlDocument __cXML;
            [Microsoft.XLANGs.Core.UserVariableAttribute("responseCxml")]
            public __messagetype_System_Xml_XmlDocument __responseCxml;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_1")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("timestamp")]
            internal System.String __timestamp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("key")]
            internal System.String __key;
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
                Inbound_Status_Doc_cXML_Receive_Orch __svc__ = (Inbound_Status_Doc_cXML_Receive_Orch)_service;
                __Inbound_Status_Doc_cXML_Receive_Orch_1 __ctx1__ = (__Inbound_Status_Doc_cXML_Receive_Orch_1)(__svc__._stateMgrs[1]);
                ____scope33_2 __ctx2__ = (____scope33_2)(__svc__._stateMgrs[2]);

                if (__ctx1__ != null && __ctx1__.__responseCxml != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__responseCxml);
                    __ctx1__.__responseCxml = null;
                }
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Inbound_Status_Doc_cXML_Receive_Port_1")]
        internal Inbound_Status_Doc_cXML_Receive_PortType_1 Inbound_Status_Doc_cXML_Receive_Port_1;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Inbound_Status_Doc_cXML_Receive_PortType_1.Operation_1},
                                               typeof(Inbound_Status_Doc_cXML_Receive_Orch).GetField("Inbound_Status_Doc_cXML_Receive_Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Inbound_Status_Doc_cXML_Receive_Orch), "Inbound_Status_Doc_cXML_Receive_Port_1"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "95f6074f-beb6-4559-bd37-0c28c0252e2b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "95f6074f-beb6-4559-bd37-0c28c0252e2b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "f0b26f17-901c-4046-b7f7-9dbeda3fdc1d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "50825063-c3ae-4444-87cf-114eb120f244", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "50825063-c3ae-4444-87cf-114eb120f244", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "c4d29a86-feb8-4963-b5b5-4918de56dd04", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "c4d29a86-feb8-4963-b5b5-4918de56dd04", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "aa11441f-6fe6-446b-bcff-f891aeb330ed", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "aa11441f-6fe6-446b-bcff-f891aeb330ed", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "fc0d8f30-ce04-4faf-bea8-10586a5d50a1", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "f1e9d5d2-76cf-44a1-abf8-729f6c3ee704", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "f1e9d5d2-76cf-44a1-abf8-729f6c3ee704", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "ec14835e-d76f-4fd0-8c98-d34368bd9ab8", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "ec14835e-d76f-4fd0-8c98-d34368bd9ab8", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "c996ab31-a3b0-46b0-8d5d-1803535a5107", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "c996ab31-a3b0-46b0-8d5d-1803535a5107", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "61640a18-0943-4b28-9194-23ecbe6f6eb2", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "61640a18-0943-4b28-9194-23ecbe6f6eb2", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "fc0d8f30-ce04-4faf-bea8-10586a5d50a1", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "8d8172b3-4ac9-410f-bda6-833631c330f3", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "2834761b-cbda-440b-8018-f73b32d7c1ac", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "2834761b-cbda-440b-8018-f73b32d7c1ac", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "8d8172b3-4ac9-410f-bda6-833631c330f3", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "f0b26f17-901c-4046-b7f7-9dbeda3fdc1d", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,4,4,4,29,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,7,7,7,9,9,10,10,11,11,11,12,13,13,13,14,14,15,16,16,17,17,17,17,18,18,19,19,20,20,20,21,22,22,22,22,22,22,};
        public static int[] __progressLocation3 = new int[] { 23,23,24,24,25,25,25,25,25,25,28,28,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Inbound_Status_Doc_cXML_Receive_Orch_1 __ctx1__ = (__Inbound_Status_Doc_cXML_Receive_Orch_1)_stateMgrs[1];
            __Inbound_Status_Doc_cXML_Receive_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_cXML_Receive_Orch_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Inbound_Status_Doc_cXML_Receive_Port_1 = new Inbound_Status_Doc_cXML_Receive_PortType_1(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Inbound_Status_Doc_cXML_Receive_Port_1, this);
                __ctx0__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[1], Inbound_Status_Doc_cXML_Receive_Port_1, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Inbound_Status_Doc_cXML_Receive_Orch_1(this);
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
            __Inbound_Status_Doc_cXML_Receive_Orch_1 __ctx1__ = (__Inbound_Status_Doc_cXML_Receive_Orch_1)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __Inbound_Status_Doc_cXML_Receive_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_cXML_Receive_Orch_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__timestamp = default(System.String);
                __ctx1__.__key = default(System.String);
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
                if (!Inbound_Status_Doc_cXML_Receive_Port_1.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__cXML != null)
                    __ctx1__.UnrefMessage(__ctx1__.__cXML);
                __ctx1__.__cXML = new __messagetype_System_Xml_XmlDocument("cXML", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__cXML);
                Inbound_Status_Doc_cXML_Receive_Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__cXML, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__cXML);
                    __edata.PortName = @"Inbound_Status_Doc_cXML_Receive_Port_1";
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
                __ctx1__.__key = "";
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
                    __ctx1__.__key = null;
                if (__ctx1__ != null)
                    __ctx1__.__timestamp = null;
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (__ctx1__ != null && __ctx1__.__cXML != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__cXML);
                    __ctx1__.__cXML = null;
                }
                if (Inbound_Status_Doc_cXML_Receive_Port_1 != null)
                {
                    Inbound_Status_Doc_cXML_Receive_Port_1.Close(__ctx1__, __seg__);
                    Inbound_Status_Doc_cXML_Receive_Port_1 = null;
                }
                Tracker.FireEvent(__eventLocations[29],__eventData[13],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[14],_stateMgrs[1].TrackDataStream );
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
            __Inbound_Status_Doc_cXML_Receive_Orch_1 __ctx1__ = (__Inbound_Status_Doc_cXML_Receive_Orch_1)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __Inbound_Status_Doc_cXML_Receive_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_cXML_Receive_Orch_root_0)_stateMgrs[0];

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
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_ARRIVED(), __ctx1__.__key, __ctx1__.__timestamp, __ctx1__.__cXML.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_PORT_RECEIVE_CXML_STATUS_ARRIVE(), __ctx1__.__key, __ctx1__.__timestamp, __ctx1__.__cXML.part.TypedValue, false);
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
                {
                    __messagetype_System_Xml_XmlDocument __responseCxml = new __messagetype_System_Xml_XmlDocument("responseCxml", __ctx1__);

                    __responseCxml.part.LoadFrom(new System.Xml.XmlDocument());
                    __responseCxml.part.TypedValue.LoadXml("<cXML version=\"1.2.008\" timestamp=\"" + System.DateTime.Now.ToString("yyyy-MM-dd:hh:mm:sszz") + "\" payloadID=\"" + System.DateTime.Now.ToString("yyyyMMddhhmmssffff") + "@b2b.govsci.com\"><Response><Status code=\"200\" text=\"Accepted\"></Status></Response></cXML>");

                    if (__ctx1__.__responseCxml != null)
                        __ctx1__.UnrefMessage(__ctx1__.__responseCxml);
                    __ctx1__.__responseCxml = __responseCxml;
                    __ctx1__.RefMessage(__ctx1__.__responseCxml);
                }
                __ctx1__.__responseCxml.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__responseCxml);
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_RESPONSE(), __ctx1__.__key, __ctx1__.__timestamp, __ctx1__.__responseCxml.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Inbound_Status_Doc_cXML_Receive_Port_1.SendMessage(0, __ctx1__.__responseCxml, null, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__responseCxml);
                    __edata.PortName = @"Inbound_Status_Doc_cXML_Receive_Port_1";
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                __condition__ = true;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 37;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if (!Inbound_Status_Doc_cXML_Receive_Port_1.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__cXML != null)
                    __ctx1__.UnrefMessage(__ctx1__.__cXML);
                __ctx1__.__cXML = new __messagetype_System_Xml_XmlDocument("cXML", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__cXML);
                Inbound_Status_Doc_cXML_Receive_Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__cXML, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__cXML);
                    __edata.PortName = @"Inbound_Status_Doc_cXML_Receive_Port_1";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                __ctx1__.__timestamp = __ctx1__.__library.GetTimeStamp(System.DateTime.Now);
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                __ctx1__.__key = __ctx1__.__library.HasKey(__ctx1__.__cXML.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_ARRIVED(), __ctx1__.__key, __ctx1__.__timestamp, __ctx1__.__cXML.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_PORT_RECEIVE_CXML_STATUS_ARRIVE(), __ctx1__.__key, __ctx1__.__timestamp, __ctx1__.__cXML.part.TypedValue, false);
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                {
                    __messagetype_System_Xml_XmlDocument __responseCxml = new __messagetype_System_Xml_XmlDocument("responseCxml", __ctx1__);

                    __responseCxml.part.LoadFrom(new System.Xml.XmlDocument());
                    __responseCxml.part.TypedValue.LoadXml("<cXML version=\"1.2.008\" timestamp=\"" + System.DateTime.Now.ToString("yyyy-MM-dd:hh:mm:sszz") + "\" payloadID=\"" + System.DateTime.Now.ToString("yyyyMMddhhmmssffff") + "@b2b.govsci.com\"><Response><Status code=\"200\" text=\"Accepted\"></Status></Response></cXML>");

                    if (__ctx1__.__responseCxml != null)
                        __ctx1__.UnrefMessage(__ctx1__.__responseCxml);
                    __ctx1__.__responseCxml = __responseCxml;
                    __ctx1__.RefMessage(__ctx1__.__responseCxml);
                }
                __ctx1__.__responseCxml.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__responseCxml);
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_RESPONSE(), __ctx1__.__key, __ctx1__.__timestamp, __ctx1__.__responseCxml.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Inbound_Status_Doc_cXML_Receive_Port_1.SendMessage(0, __ctx1__.__responseCxml, null, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__responseCxml);
                    __edata.PortName = @"Inbound_Status_Doc_cXML_Receive_Port_1";
                    Tracker.FireEvent(__eventLocations[21],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__responseCxml != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__responseCxml);
                    __ctx1__.__responseCxml = null;
                }
                Tracker.FireEvent(__eventLocations[22],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 40;
            case 40:
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
            __Inbound_Status_Doc_cXML_Receive_Orch_1 __ctx1__ = (__Inbound_Status_Doc_cXML_Receive_Orch_1)_stateMgrs[1];
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
                Tracker.FireEvent(__eventLocations[23],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[3],_stateMgrs[2].TrackDataStream );
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
                Tracker.FireEvent(__eventLocations[25],__eventData[4],_stateMgrs[2].TrackDataStream );
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
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_FAILED(), __ctx1__.__key + ".Arrive", __ctx1__.__timestamp, __ctx1__.__cXML.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__library.sendExceptionEmail(__ctx2__.__ex_0, "Inbound_Status_Doc_cXML_Receive", "", "", __ctx1__.__key);
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[12],_stateMgrs[2].TrackDataStream );
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
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{393E102B-7DA8-451C-AF20-4B4495EFCC28}"))
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
