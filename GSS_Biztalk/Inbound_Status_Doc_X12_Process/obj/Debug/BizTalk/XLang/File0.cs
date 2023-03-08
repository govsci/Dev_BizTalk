
#pragma warning disable 162

namespace Inbound_Status_Doc_X12_Process
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Inbound_Status_Doc_X12_Process.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Inbound_Status_Doc_X12_Process_PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Inbound_Status_Doc_X12_Process_PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Inbound_Status_Doc_X12_Process_PortType_1(Inbound_Status_Doc_X12_Process_PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Inbound_Status_Doc_X12_Process_PortType_1 p = new Inbound_Status_Doc_X12_Process_PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Inbound_Status_Doc_X12_Process_PortType_1),
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
    //#line 797 "R:\Source\GSS_Biztalk\Inbound_Status_Doc_X12_Process\Inbound_Status_Doc_X12_Process_Orch.odx"
    [Microsoft.XLANGs.BaseTypes.StaticConvoyAttribute(
        0,
        new System.Type[] { typeof(CorrelationType_1) }
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Inbound_Status_Doc_X12_Process_Port_1", "Operation_1", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        1, "Inbound_Status_Doc_X12_Process_Port_1", "Operation_1", -1, 0, false
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(Inbound_Status_Doc_X12_Process.Inbound_Status_Doc_X12_Process_PortType_1)
        },
        new System.String[] {
            "Inbound_Status_Doc_X12_Process_Port_1"
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
    sealed internal class Inbound_Status_Doc_X12_Process_Orch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Inbound_Status_Doc_X12_Process_Orch));
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

        static Inbound_Status_Doc_X12_Process_Orch()
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
            _rootContext = new __Inbound_Status_Doc_X12_Process_Orch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Inbound_Status_Doc_X12_Process_Orch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Inbound_Status_Doc_X12_Process_Orch", tracker)
        {
            ConstructorHelper();
        }

        public Inbound_Status_Doc_X12_Process_Orch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Inbound_Status_Doc_X12_Process_Orch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>96e07047-eaaf-4fec-9205-2e7709eed2b3</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>dd61eb18-b190-46be-af45-b12bfe42bd9b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>f56b1752-254d-40f3-a719-1806dfd04738</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>e20f5949-a76f-40a8-8895-c46757eebfaa</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>6b911853-0410-4261-bf40-175b2d1763ef</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>c0f7212c-abe5-4e66-8e67-4336bcb5f749</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>855</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>00c0624f-8ba7-4a6b-b157-6a31d09ccf5b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assign855_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>a27b390d-a98f-47c7-a50a-5bbe6664e89b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>810001fe-22b2-48fd-9937-ff5eb9b94e89</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>259a7ddf-78e9-4641-8ae4-e90c28f07ec3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_855_997_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>daae785f-f233-4908-a1a5-0b2301c57e9a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_855_997_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>72547135-bf7a-486f-8245-644e421b8532</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>8e297339-70ac-4a09-9a74-2146fd31cdff</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>b1356993-613b-4753-9b67-b675f1263acf</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>2b837692-5723-46c1-97b1-1ebc5b3facf8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_OrderConfirm_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>63b09ac0-eed1-44d7-870c-20655abbd01b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_OrderConfirm_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>efda9ff6-baad-4b3f-bac9-8b4eb1c0aea8</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_7</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>fc4cfd86-0d60-42b5-8fa3-f9a98e5ea1e1</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_8</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>2032582a-a874-41f8-82a9-601977648698</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>dc4640b0-22f7-41df-a027-be359e8a8d2d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Process_OrderConfirm_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>6a10da6e-f370-4bf6-992f-fcd6e2235e55</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>856</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>98d9d853-1f7b-4b1b-90a9-5d09a61f723c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assign856_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>a434bd33-a6c8-4be7-b9d7-60780a18e22b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>1b9b2404-20b9-4b32-a089-cdb3c3672440</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>599ce786-11df-48a9-92f2-3f19d10126db</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_856_997_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>4712c5e7-fc6f-48d1-9123-ad8ea34229d0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_856_997_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>67bdb38c-6691-40ae-bbd0-92bbbc1dc477</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7a3840f4-6065-4a8d-ad5f-395b70c64eb3</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>81082586-8396-492a-9def-aade091048b5</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>527c7040-9e5f-4458-99fd-dde8b2196b10</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_ASN_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>c6544cec-f4e7-46a6-a60b-19b079c3f4a1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_ASN_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>6d5ec5de-508e-4009-879b-4bb5b01fdace</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_9</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>881ccfa5-9dc9-4a1e-8fd5-85d5945cbb66</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_10</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>9b13c0fc-72fd-4ae1-a5a6-9675ca8d280b</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>8485574e-f82c-4548-a8f0-6d5505e73b4e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Process_ASN_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>ae2709c5-78fe-41bc-8b39-71597a4ab8e4</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>810</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>d8ca4b1c-919f-46f2-8b30-cbc9987246d0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assign810_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>b8e97d56-db4e-463f-8184-5c2f65a79cbb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>5b77c783-b731-4a98-8aa7-00910f5fb1eb</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c5d6564f-41d9-43ae-8506-a6456d6b4b81</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_810_997_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>b7594eea-b45d-406b-9e92-b23b6e6d4cbb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_81_997_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9596c376-429f-41d3-b3ef-4047d788e655</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>89c17d6f-180e-40a6-87d3-627ef45b241d</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0f8384d4-c73f-4d3c-8f6c-2ac2a418b7f3</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>4d501e4d-594f-43fc-a6e5-66f9c05c69b9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_Invoice_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>9dc16c12-d15d-46af-a73c-35142d2970f5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_Invoice_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>fc359d1b-ceec-40a9-b9bf-88f1b3d03d20</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_11</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>c3e0a846-4fdb-4b58-9c80-e4e14b0b257b</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_12</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>4a4d9840-44d0-4db4-840f-6c432c16fe1f</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>c0bda29a-8fc9-457e-b268-255565507f54</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Process_Invoice_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>70a2dc58-8cea-494d-800e-5b2b6899eeb2</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>fe33a64c-6b04-4688-9b64-690631a65fcb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>9d025611-39b3-4c5e-bd0a-6afcf570de40</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Loop_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>111a0ab0-9f42-46a7-9c6e-5eaa365956d8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>b316e11b-5d27-4b7e-9038-8a7f6db85bb2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>9b7ecd03-60ab-41dc-aa45-03bd516ef176</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>21c37d9b-e8fe-4590-be93-af38b637c3aa</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>855</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>23421fca-90bf-4864-9058-e2a0da06208a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assign855_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>1fc823b1-4460-4eb5-a542-279944461f11</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>ab99ac70-7fa6-41d5-a0f2-5ee1984ac660</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>26650ade-07cd-470f-803f-6dae97256a26</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_855_997_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e3fb48c4-8243-45ab-af56-3ca26423d825</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>e7317458-60d4-4d87-83fc-937653102fb5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_855_997_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>c07581ae-5371-4a51-8592-0a3493b8b3e4</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>25e7ce9f-0713-4b56-aa7f-1a59b3e9aa9c</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>3afa7c8d-5c4d-400b-92c7-92d97d84e8c9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_OrderConfirm_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>36c580c4-569b-45a6-9daa-cee65b0a63b8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_OrderConfirm_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>29f23f8e-e9ce-4237-83fe-b9af4fa7b20e</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_8</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>66d6c3f1-dc73-48f7-92af-298574e0639e</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_7</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>3346a16f-867c-4755-b74d-3477716d314e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>1b7fb9b3-09b7-48f8-8b4b-d1d2ff3b194f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Process_OrderConfirm_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>692b9233-61f5-4b6c-8e2c-6416b9ef50dd</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>856</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>403b54e1-2d52-468b-9a01-a51fc0cf50d3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assign856_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>0c884e82-2b44-47e2-a728-e645e43690ea</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>72a7b75b-4202-41f5-b790-b80870967d24</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>eda55d34-83ec-48a9-a19a-f83773a72ebf</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_856_997_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>121620d1-8463-46ad-bff9-98a95db21a80</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>f3717def-da5b-49e1-932c-0df6bd3b54e4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_856_997_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>78eec78b-80e5-4c37-bc30-c6aa7f1516a9</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>c2ee9365-b76f-428c-8a92-e51ce4a365a8</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>8ab6fb5a-11f2-47ee-a2c8-8e966f73347b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_ASN_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>71beba91-fd7f-4f1d-aa64-8704c0fce123</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>fd258891-f629-45f1-8897-d10b96d33506</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_ASN_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>65ebab07-f39f-4adc-b43d-70fc11098c67</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_9</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3e465e1e-abb1-47f3-b1f1-89367d7a6a91</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_10</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>8e63e82b-fc9d-410b-9578-3120e7426de8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Process_ASN_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>d9624fdc-ab16-4023-9a54-b3036f661335</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>810</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>b097e786-e657-4d9d-89bf-8af515e01a49</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assign810_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>1febc3b5-a687-4ea8-ae85-64d28ae12e70</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>573cf84f-74c6-40f5-bb0a-df1d56fdc175</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>993d4061-f86b-4d66-b724-d06f69c2cdb4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_810_997_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>0181d516-0330-4bfa-9d11-7ee01f5229df</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_81_997_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>ec9c6f85-207d-4e61-a726-82ead32890bc</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1eb53d3b-121d-4b0c-b73e-904253c8aedb</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>c4f1bcb9-4663-4184-a83f-ccb204673584</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>04f05146-5a5c-4501-a007-1648201d0f8e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_Invoice_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>37f46d6d-92ee-4c79-bc24-940c4e8420f0</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>6597eb99-1308-45c5-8356-44a7d5f0f5c8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_Invoice_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>8c64e963-f4db-444e-9431-873292afe60f</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_12</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>0bde6e80-994c-4625-8d74-76b4d9b1de39</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_11</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d0f98e57-452d-4a6b-b035-0d3dd2854eb3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Process_Invoice_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>9f1939c9-f089-406f-9bf9-6750178785cd</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a0595937-6e20-4091-8e47-2dff412f04e5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>461387e1-2468-46b2-b3c0-81297c96b657</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.SystemException</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>772eaa6a-233f-4f76-8f4a-95dd2b032ced</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Inbound_Status_Doc_X12_Process_Orch'</ActionName><IsAtomic>0</IsAtomic><Line>797</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>817</Line><Position>22</Position><ShapeID>'dd61eb18-b190-46be-af45-b12bfe42bd9b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>823</Line><Position>13</Position><ShapeID>'f56b1752-254d-40f3-a719-1806dfd04738'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>828</Line><Position>31</Position><ShapeID>'e20f5949-a76f-40a8-8895-c46757eebfaa'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>832</Line><Position>21</Position><ShapeID>'6b911853-0410-4261-bf40-175b2d1763ef'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>835</Line><Position>25</Position><ShapeID>'00c0624f-8ba7-4a6b-b157-6a31d09ccf5b'</ShapeID>
<Messages>
	<MsgInfo><name>x855</name><part>part</part><schema>EdiSchemas.X12.X12_00401_855</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>841</Line><Position>25</Position><ShapeID>'259a7ddf-78e9-4641-8ae4-e90c28f07ec3'</ShapeID>
<Messages>
	<MsgInfo><name>x997</name><part>part</part><schema>EdiSchemas.X12.X12_00401_997</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>x855</name><part>part</part><schema>EdiSchemas.X12.X12_00401_855</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>847</Line><Position>25</Position><ShapeID>'2b837692-5723-46c1-97b1-1ebc5b3facf8'</ShapeID>
<Messages>
	<MsgInfo><name>orderConfirm</name><part>part</part><schema>EdiSchemas.cXML.Fulfill+cXML_Fulfill</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>x855</name><part>part</part><schema>EdiSchemas.X12.X12_00401_855</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>853</Line><Position>42</Position><ShapeID>'dc4640b0-22f7-41df-a027-be359e8a8d2d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>859</Line><Position>25</Position><ShapeID>'98d9d853-1f7b-4b1b-90a9-5d09a61f723c'</ShapeID>
<Messages>
	<MsgInfo><name>x856</name><part>part</part><schema>EdiSchemas.X12.X12_00401_856</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>865</Line><Position>25</Position><ShapeID>'599ce786-11df-48a9-92f2-3f19d10126db'</ShapeID>
<Messages>
	<MsgInfo><name>x997</name><part>part</part><schema>EdiSchemas.X12.X12_00401_997</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>x856</name><part>part</part><schema>EdiSchemas.X12.X12_00401_856</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>871</Line><Position>25</Position><ShapeID>'527c7040-9e5f-4458-99fd-dde8b2196b10'</ShapeID>
<Messages>
	<MsgInfo><name>asn</name><part>part</part><schema>EdiSchemas.cXML.Fulfill+cXML_Fulfill</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>x856</name><part>part</part><schema>EdiSchemas.X12.X12_00401_856</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>877</Line><Position>42</Position><ShapeID>'8485574e-f82c-4548-a8f0-6d5505e73b4e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>883</Line><Position>25</Position><ShapeID>'d8ca4b1c-919f-46f2-8b30-cbc9987246d0'</ShapeID>
<Messages>
	<MsgInfo><name>x810</name><part>part</part><schema>EdiSchemas.X12.X12_00401_810</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>889</Line><Position>25</Position><ShapeID>'c5d6564f-41d9-43ae-8506-a6456d6b4b81'</ShapeID>
<Messages>
	<MsgInfo><name>x997</name><part>part</part><schema>EdiSchemas.X12.X12_00401_997</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>x810</name><part>part</part><schema>EdiSchemas.X12.X12_00401_810</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>895</Line><Position>25</Position><ShapeID>'4d501e4d-594f-43fc-a6e5-66f9c05c69b9'</ShapeID>
<Messages>
	<MsgInfo><name>invoice</name><part>part</part><schema>EdiSchemas.cXML.cXMLinvoice</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>x810</name><part>part</part><schema>EdiSchemas.X12.X12_00401_810</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>901</Line><Position>42</Position><ShapeID>'c0bda29a-8fc9-457e-b268-255565507f54'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>907</Line><Position>43</Position><ShapeID>'fe33a64c-6b04-4688-9b64-690631a65fcb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>910</Line><Position>21</Position><ShapeID>'9d025611-39b3-4c5e-bd0a-6afcf570de40'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>913</Line><Position>25</Position><ShapeID>'111a0ab0-9f42-46a7-9c6e-5eaa365956d8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>915</Line><Position>35</Position><ShapeID>'b316e11b-5d27-4b7e-9038-8a7f6db85bb2'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>919</Line><Position>25</Position><ShapeID>'9b7ecd03-60ab-41dc-aa45-03bd516ef176'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>922</Line><Position>29</Position><ShapeID>'23421fca-90bf-4864-9058-e2a0da06208a'</ShapeID>
<Messages>
	<MsgInfo><name>x855</name><part>part</part><schema>EdiSchemas.X12.X12_00401_855</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>928</Line><Position>29</Position><ShapeID>'26650ade-07cd-470f-803f-6dae97256a26'</ShapeID>
<Messages>
	<MsgInfo><name>x997</name><part>part</part><schema>EdiSchemas.X12.X12_00401_997</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>x855</name><part>part</part><schema>EdiSchemas.X12.X12_00401_855</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>934</Line><Position>29</Position><ShapeID>'3afa7c8d-5c4d-400b-92c7-92d97d84e8c9'</ShapeID>
<Messages>
	<MsgInfo><name>orderConfirm</name><part>part</part><schema>EdiSchemas.cXML.Fulfill+cXML_Fulfill</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>x855</name><part>part</part><schema>EdiSchemas.X12.X12_00401_855</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>940</Line><Position>46</Position><ShapeID>'1b7fb9b3-09b7-48f8-8b4b-d1d2ff3b194f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>946</Line><Position>29</Position><ShapeID>'403b54e1-2d52-468b-9a01-a51fc0cf50d3'</ShapeID>
<Messages>
	<MsgInfo><name>x856</name><part>part</part><schema>EdiSchemas.X12.X12_00401_856</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>952</Line><Position>29</Position><ShapeID>'eda55d34-83ec-48a9-a19a-f83773a72ebf'</ShapeID>
<Messages>
	<MsgInfo><name>x997</name><part>part</part><schema>EdiSchemas.X12.X12_00401_997</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>x856</name><part>part</part><schema>EdiSchemas.X12.X12_00401_856</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>958</Line><Position>29</Position><ShapeID>'8ab6fb5a-11f2-47ee-a2c8-8e966f73347b'</ShapeID>
<Messages>
	<MsgInfo><name>asn</name><part>part</part><schema>EdiSchemas.cXML.Fulfill+cXML_Fulfill</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>x856</name><part>part</part><schema>EdiSchemas.X12.X12_00401_856</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>964</Line><Position>46</Position><ShapeID>'8e63e82b-fc9d-410b-9578-3120e7426de8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>970</Line><Position>29</Position><ShapeID>'b097e786-e657-4d9d-89bf-8af515e01a49'</ShapeID>
<Messages>
	<MsgInfo><name>x810</name><part>part</part><schema>EdiSchemas.X12.X12_00401_810</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>976</Line><Position>29</Position><ShapeID>'993d4061-f86b-4d66-b724-d06f69c2cdb4'</ShapeID>
<Messages>
	<MsgInfo><name>x997</name><part>part</part><schema>EdiSchemas.X12.X12_00401_997</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>x810</name><part>part</part><schema>EdiSchemas.X12.X12_00401_810</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>982</Line><Position>29</Position><ShapeID>'04f05146-5a5c-4501-a007-1648201d0f8e'</ShapeID>
<Messages>
	<MsgInfo><name>invoice</name><part>part</part><schema>EdiSchemas.cXML.cXMLinvoice</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>x810</name><part>part</part><schema>EdiSchemas.X12.X12_00401_810</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>988</Line><Position>46</Position><ShapeID>'d0f98e57-452d-4a6b-b035-0d3dd2854eb3'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>994</Line><Position>47</Position><ShapeID>'a0595937-6e20-4091-8e47-2dff412f04e5'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1001</Line><Position>21</Position><ShapeID>'461387e1-2468-46b2-b3c0-81297c96b657'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1004</Line><Position>33</Position><ShapeID>'772eaa6a-233f-4f76-8f4a-95dd2b032ced'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='ff6e10b5-9c8d-4836-a1ca-dbfbd7a2ebe4' LowerBound='1.1' HigherBound='236.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Inbound_Status_Doc_X12_Process' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='fe04e45d-f809-490e-b5a1-6546e8f09d1b' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Inbound_Status_Doc_X12_Process_PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='44be5565-54a3-41a0-986f-8ba4610a8ad0' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='ff87baaa-2849-4c8a-9561-eb7f4be0a43f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='3d1bd3a4-f21c-44bf-8e04-e4fc9ae267f6' ParentLink='Module_CorrelationType' LowerBound='11.1' HigherBound='15.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PropertyRef' OID='bb139c94-e16a-4829-b891-5943bd6409c9' ParentLink='CorrelationType_PropertyRef' LowerBound='13.9' HigherBound='13.28'>
                <om:Property Name='Ref' Value='BTS.ReceivePortName' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='f6adcb2b-dac1-42b9-901a-291dcb3e7909' ParentLink='Module_ServiceDeclaration' LowerBound='15.1' HigherBound='235.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Inbound_Status_Doc_X12_Process_Orch' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='25639ed9-6606-49d0-91cb-c7f094675360' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='BizTalkLibrary.Orchestrations.OrchestrationFunctions' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='library' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ce37864e-6341-4ffd-b36f-ae9fdf00bd03' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='timestamp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7474931d-c5fb-468f-92b4-525a89e548c2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='docType' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ac48b044-6894-4e54-bce6-f16b1c124b79' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='32.1' HigherBound='33.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='BizTalkLibrary.Classes.Constants.DUMP_FOLDERS' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='dumpFolders' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='CorrelationDeclaration' OID='2bf14be1-e9f9-4b14-944b-c90d1f1a161d' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='Type' Value='Inbound_Status_Doc_X12_Process.CorrelationType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Correlation_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='1e2fe2bf-da6c-4c15-b157-a3041954421f' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='36.87' HigherBound='36.111'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='dd61eb18-b190-46be-af45-b12bfe42bd9b' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='08238a8a-02c1-4fdd-9f5d-e373c2d45d05' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='132.90' HigherBound='132.103'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='111a0ab0-9f42-46a7-9c6e-5eaa365956d8' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4403e29c-3b7f-4d27-b8e0-fb2140460f6a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xml' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7a72f0e8-b1a6-46c1-b1d0-bcb4f3a7fc05' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='Type' Value='EdiSchemas.X12.X12_00401_997' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='x997' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='faab3718-a696-438e-8e6a-fc5ff8861a7e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='23.1' HigherBound='24.1'>
                <om:Property Name='Type' Value='EdiSchemas.X12.X12_00401_810' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='x810' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c9524d78-9881-4575-84be-63ae5b6d08ec' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='Type' Value='EdiSchemas.X12.X12_00401_855' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='x855' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4f4b3429-0cd2-4c28-a564-67f20aa98e8a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='EdiSchemas.X12.X12_00401_856' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='x856' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4f3d3dbc-dec9-4d0f-af06-c63173f19d4f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='EdiSchemas.cXML.Fulfill.cXML_Fulfill' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='orderConfirm' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4513861e-f251-4b3b-b556-c4eb49dbfbe3' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='EdiSchemas.cXML.Fulfill.cXML_Fulfill' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='asn' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='495a5659-827f-4020-b27a-8940de7b1f80' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='EdiSchemas.cXML.cXMLinvoice' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='invoice' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='96e07047-eaaf-4fec-9205-2e7709eed2b3' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='dd61eb18-b190-46be-af45-b12bfe42bd9b' ParentLink='ServiceBody_Statement' LowerBound='35.1' HigherBound='41.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Inbound_Status_Doc_X12_Process_Port_1' />
                    <om:Property Name='MessageName' Value='xml' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='f56b1752-254d-40f3-a719-1806dfd04738' ParentLink='ServiceBody_Statement' LowerBound='41.1' HigherBound='233.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='VariableAssignment' OID='e20f5949-a76f-40a8-8895-c46757eebfaa' ParentLink='ComplexStatement_Statement' LowerBound='46.1' HigherBound='50.1'>
                        <om:Property Name='Expression' Value='timestamp = library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;docType = library.GetEdiDocumentType(xml);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_PROCESSED_INCOMING(),docType,timestamp,xml,true);&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Expression_1' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Decision' OID='6b911853-0410-4261-bf40-175b2d1763ef' ParentLink='ComplexStatement_Statement' LowerBound='50.1' HigherBound='128.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Decide_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='DecisionBranch' OID='c0f7212c-abe5-4e66-8e67-4336bcb5f749' ParentLink='ReallyComplexStatement_Branch' LowerBound='51.21' HigherBound='75.1'>
                            <om:Property Name='Expression' Value='docType == &quot;855&quot;' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='855' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='00c0624f-8ba7-4a6b-b157-6a31d09ccf5b' ParentLink='ComplexStatement_Statement' LowerBound='53.1' HigherBound='59.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Assign855_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='a27b390d-a98f-47c7-a50a-5bbe6664e89b' ParentLink='ComplexStatement_Statement' LowerBound='56.1' HigherBound='58.1'>
                                    <om:Property Name='Expression' Value='x855 = xml;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_1' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='810001fe-22b2-48fd-9937-ff5eb9b94e89' ParentLink='Construct_MessageRef' LowerBound='54.35' HigherBound='54.39'>
                                    <om:Property Name='Ref' Value='x855' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Construct' OID='259a7ddf-78e9-4641-8ae4-e90c28f07ec3' ParentLink='ComplexStatement_Statement' LowerBound='59.1' HigherBound='65.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Construct_855_997_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='daae785f-f233-4908-a1a5-0b2301c57e9a' ParentLink='ComplexStatement_Statement' LowerBound='62.1' HigherBound='64.1'>
                                    <om:Property Name='ClassName' Value='Inbound_Status_Doc_X12_Process.Maps.Map_855_997' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_855_997_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessagePartRef' OID='72547135-bf7a-486f-8245-644e421b8532' ParentLink='Transform_InputMessagePartRef' LowerBound='63.97' HigherBound='63.101'>
                                        <om:Property Name='MessageRef' Value='x855' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_1' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='8e297339-70ac-4a09-9a74-2146fd31cdff' ParentLink='Transform_OutputMessagePartRef' LowerBound='63.40' HigherBound='63.44'>
                                        <om:Property Name='MessageRef' Value='x997' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_2' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='b1356993-613b-4753-9b67-b675f1263acf' ParentLink='Construct_MessageRef' LowerBound='60.35' HigherBound='60.39'>
                                    <om:Property Name='Ref' Value='x997' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Construct' OID='2b837692-5723-46c1-97b1-1ebc5b3facf8' ParentLink='ComplexStatement_Statement' LowerBound='65.1' HigherBound='71.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Construct_OrderConfirm_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='63b09ac0-eed1-44d7-870c-20655abbd01b' ParentLink='ComplexStatement_Statement' LowerBound='68.1' HigherBound='70.1'>
                                    <om:Property Name='ClassName' Value='Inbound_Status_Doc_X12_Process.Maps.Map_855' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_OrderConfirm_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessagePartRef' OID='efda9ff6-baad-4b3f-bac9-8b4eb1c0aea8' ParentLink='Transform_InputMessagePartRef' LowerBound='69.101' HigherBound='69.105'>
                                        <om:Property Name='MessageRef' Value='x855' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_7' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='fc4cfd86-0d60-42b5-8fa3-f9a98e5ea1e1' ParentLink='Transform_OutputMessagePartRef' LowerBound='69.40' HigherBound='69.52'>
                                        <om:Property Name='MessageRef' Value='orderConfirm' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_8' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='2032582a-a874-41f8-82a9-601977648698' ParentLink='Construct_MessageRef' LowerBound='66.35' HigherBound='66.47'>
                                    <om:Property Name='Ref' Value='orderConfirm' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='dc4640b0-22f7-41df-a027-be359e8a8d2d' ParentLink='ComplexStatement_Statement' LowerBound='71.1' HigherBound='74.1'>
                                <om:Property Name='Expression' Value='library.Create997(timestamp,x997);&#xD;&#xA;library.CreateStatusDocFromEdi(orderConfirm,docType);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Process_OrderConfirm_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='6a10da6e-f370-4bf6-992f-fcd6e2235e55' ParentLink='ReallyComplexStatement_Branch' LowerBound='75.26' HigherBound='99.1'>
                            <om:Property Name='Expression' Value='docType == &quot;856&quot;' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='856' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Construct' OID='98d9d853-1f7b-4b1b-90a9-5d09a61f723c' ParentLink='ComplexStatement_Statement' LowerBound='77.1' HigherBound='83.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Assign856_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='a434bd33-a6c8-4be7-b9d7-60780a18e22b' ParentLink='ComplexStatement_Statement' LowerBound='80.1' HigherBound='82.1'>
                                    <om:Property Name='Expression' Value='x856 = xml;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='1b9b2404-20b9-4b32-a089-cdb3c3672440' ParentLink='Construct_MessageRef' LowerBound='78.35' HigherBound='78.39'>
                                    <om:Property Name='Ref' Value='x856' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Construct' OID='599ce786-11df-48a9-92f2-3f19d10126db' ParentLink='ComplexStatement_Statement' LowerBound='83.1' HigherBound='89.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Construct_856_997_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='4712c5e7-fc6f-48d1-9123-ad8ea34229d0' ParentLink='ComplexStatement_Statement' LowerBound='86.1' HigherBound='88.1'>
                                    <om:Property Name='ClassName' Value='Inbound_Status_Doc_X12_Process.Maps.Map_856_997' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_856_997_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessagePartRef' OID='67bdb38c-6691-40ae-bbd0-92bbbc1dc477' ParentLink='Transform_InputMessagePartRef' LowerBound='87.97' HigherBound='87.101'>
                                        <om:Property Name='MessageRef' Value='x856' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_3' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='7a3840f4-6065-4a8d-ad5f-395b70c64eb3' ParentLink='Transform_OutputMessagePartRef' LowerBound='87.40' HigherBound='87.44'>
                                        <om:Property Name='MessageRef' Value='x997' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_4' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='81082586-8396-492a-9def-aade091048b5' ParentLink='Construct_MessageRef' LowerBound='84.35' HigherBound='84.39'>
                                    <om:Property Name='Ref' Value='x997' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Construct' OID='527c7040-9e5f-4458-99fd-dde8b2196b10' ParentLink='ComplexStatement_Statement' LowerBound='89.1' HigherBound='95.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Construct_ASN_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='c6544cec-f4e7-46a6-a60b-19b079c3f4a1' ParentLink='ComplexStatement_Statement' LowerBound='92.1' HigherBound='94.1'>
                                    <om:Property Name='ClassName' Value='Inbound_Status_Doc_X12_Process.Maps.Map_856' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_ASN_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessagePartRef' OID='6d5ec5de-508e-4009-879b-4bb5b01fdace' ParentLink='Transform_InputMessagePartRef' LowerBound='93.92' HigherBound='93.96'>
                                        <om:Property Name='MessageRef' Value='x856' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_9' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='881ccfa5-9dc9-4a1e-8fd5-85d5945cbb66' ParentLink='Transform_OutputMessagePartRef' LowerBound='93.40' HigherBound='93.43'>
                                        <om:Property Name='MessageRef' Value='asn' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_10' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='9b13c0fc-72fd-4ae1-a5a6-9675ca8d280b' ParentLink='Construct_MessageRef' LowerBound='90.35' HigherBound='90.38'>
                                    <om:Property Name='Ref' Value='asn' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='8485574e-f82c-4548-a8f0-6d5505e73b4e' ParentLink='ComplexStatement_Statement' LowerBound='95.1' HigherBound='98.1'>
                                <om:Property Name='Expression' Value='library.Create997(timestamp,x997);&#xD;&#xA;library.CreateStatusDocFromEdi(asn,docType);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Process_ASN_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='ae2709c5-78fe-41bc-8b39-71597a4ab8e4' ParentLink='ReallyComplexStatement_Branch' LowerBound='99.26' HigherBound='123.1'>
                            <om:Property Name='Expression' Value='docType == &quot;810&quot;' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='810' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Construct' OID='d8ca4b1c-919f-46f2-8b30-cbc9987246d0' ParentLink='ComplexStatement_Statement' LowerBound='101.1' HigherBound='107.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Assign810_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='b8e97d56-db4e-463f-8184-5c2f65a79cbb' ParentLink='ComplexStatement_Statement' LowerBound='104.1' HigherBound='106.1'>
                                    <om:Property Name='Expression' Value='x810 = xml;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_3' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='5b77c783-b731-4a98-8aa7-00910f5fb1eb' ParentLink='Construct_MessageRef' LowerBound='102.35' HigherBound='102.39'>
                                    <om:Property Name='Ref' Value='x810' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Construct' OID='c5d6564f-41d9-43ae-8506-a6456d6b4b81' ParentLink='ComplexStatement_Statement' LowerBound='107.1' HigherBound='113.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Construct_810_997_3' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='b7594eea-b45d-406b-9e92-b23b6e6d4cbb' ParentLink='ComplexStatement_Statement' LowerBound='110.1' HigherBound='112.1'>
                                    <om:Property Name='ClassName' Value='Inbound_Status_Doc_X12_Process.Maps.Map_810_997' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_81_997_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessagePartRef' OID='9596c376-429f-41d3-b3ef-4047d788e655' ParentLink='Transform_InputMessagePartRef' LowerBound='111.97' HigherBound='111.101'>
                                        <om:Property Name='MessageRef' Value='x810' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_5' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='89c17d6f-180e-40a6-87d3-627ef45b241d' ParentLink='Transform_OutputMessagePartRef' LowerBound='111.40' HigherBound='111.44'>
                                        <om:Property Name='MessageRef' Value='x997' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_6' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='0f8384d4-c73f-4d3c-8f6c-2ac2a418b7f3' ParentLink='Construct_MessageRef' LowerBound='108.35' HigherBound='108.39'>
                                    <om:Property Name='Ref' Value='x997' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Construct' OID='4d501e4d-594f-43fc-a6e5-66f9c05c69b9' ParentLink='ComplexStatement_Statement' LowerBound='113.1' HigherBound='119.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Construct_Invoice_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='9dc16c12-d15d-46af-a73c-35142d2970f5' ParentLink='ComplexStatement_Statement' LowerBound='116.1' HigherBound='118.1'>
                                    <om:Property Name='ClassName' Value='Inbound_Status_Doc_X12_Process.Maps.Map_810' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_Invoice_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessagePartRef' OID='fc359d1b-ceec-40a9-b9bf-88f1b3d03d20' ParentLink='Transform_InputMessagePartRef' LowerBound='117.96' HigherBound='117.100'>
                                        <om:Property Name='MessageRef' Value='x810' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_11' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='c3e0a846-4fdb-4b58-9c80-e4e14b0b257b' ParentLink='Transform_OutputMessagePartRef' LowerBound='117.40' HigherBound='117.47'>
                                        <om:Property Name='MessageRef' Value='invoice' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_12' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='4a4d9840-44d0-4db4-840f-6c432c16fe1f' ParentLink='Construct_MessageRef' LowerBound='114.35' HigherBound='114.42'>
                                    <om:Property Name='Ref' Value='invoice' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='c0bda29a-8fc9-457e-b268-255565507f54' ParentLink='ComplexStatement_Statement' LowerBound='119.1' HigherBound='122.1'>
                                <om:Property Name='Expression' Value='library.Create997(timestamp,x997);&#xD;&#xA;library.CreateStatusDocFromEdi(invoice,docType);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Process_Invoice_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='70a2dc58-8cea-494d-800e-5b2b6899eeb2' ParentLink='ReallyComplexStatement_Branch'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Else' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='VariableAssignment' OID='fe33a64c-6b04-4688-9b64-690631a65fcb' ParentLink='ComplexStatement_Statement' LowerBound='125.1' HigherBound='127.1'>
                                <om:Property Name='Expression' Value='library.CreateDump(dumpFolders.INBOUND_STATUS_FAILED(),timestamp,&quot;&quot;,xml,true);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_4' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='While' OID='9d025611-39b3-4c5e-bd0a-6afcf570de40' ParentLink='ComplexStatement_Statement' LowerBound='128.1' HigherBound='216.1'>
                        <om:Property Name='Expression' Value='true' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Loop_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Receive' OID='111a0ab0-9f42-46a7-9c6e-5eaa365956d8' ParentLink='ComplexStatement_Statement' LowerBound='131.1' HigherBound='133.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='Inbound_Status_Doc_X12_Process_Port_1' />
                            <om:Property Name='MessageName' Value='xml' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='b316e11b-5d27-4b7e-9038-8a7f6db85bb2' ParentLink='ComplexStatement_Statement' LowerBound='133.1' HigherBound='137.1'>
                            <om:Property Name='Expression' Value='timestamp = library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;docType = library.GetEdiDocumentType(xml);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_PROCESSED_INCOMING(),docType,timestamp,xml,true);&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Decision' OID='9b7ecd03-60ab-41dc-aa45-03bd516ef176' ParentLink='ComplexStatement_Statement' LowerBound='137.1' HigherBound='215.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Decide_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='DecisionBranch' OID='21c37d9b-e8fe-4590-be93-af38b637c3aa' ParentLink='ReallyComplexStatement_Branch' LowerBound='138.25' HigherBound='162.1'>
                                <om:Property Name='Expression' Value='docType == &quot;855&quot;' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='855' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='Construct' OID='23421fca-90bf-4864-9058-e2a0da06208a' ParentLink='ComplexStatement_Statement' LowerBound='140.1' HigherBound='146.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Assign855_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageAssignment' OID='1fc823b1-4460-4eb5-a542-279944461f11' ParentLink='ComplexStatement_Statement' LowerBound='143.1' HigherBound='145.1'>
                                        <om:Property Name='Expression' Value='x855 = xml;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='MessageAssignment_1' />
                                        <om:Property Name='Signal' Value='True' />
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='ab99ac70-7fa6-41d5-a0f2-5ee1984ac660' ParentLink='Construct_MessageRef' LowerBound='141.39' HigherBound='141.43'>
                                        <om:Property Name='Ref' Value='x855' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Construct' OID='26650ade-07cd-470f-803f-6dae97256a26' ParentLink='ComplexStatement_Statement' LowerBound='146.1' HigherBound='152.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct_855_997_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='e3fb48c4-8243-45ab-af56-3ca26423d825' ParentLink='Construct_MessageRef' LowerBound='147.39' HigherBound='147.43'>
                                        <om:Property Name='Ref' Value='x997' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Transform' OID='e7317458-60d4-4d87-83fc-937653102fb5' ParentLink='ComplexStatement_Statement' LowerBound='149.1' HigherBound='151.1'>
                                        <om:Property Name='ClassName' Value='Inbound_Status_Doc_X12_Process.Maps.Map_855_997' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Transform_855_997_1' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessagePartRef' OID='c07581ae-5371-4a51-8592-0a3493b8b3e4' ParentLink='Transform_OutputMessagePartRef' LowerBound='150.44' HigherBound='150.48'>
                                            <om:Property Name='MessageRef' Value='x997' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_2' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='25e7ce9f-0713-4b56-aa7f-1a59b3e9aa9c' ParentLink='Transform_InputMessagePartRef' LowerBound='150.101' HigherBound='150.105'>
                                            <om:Property Name='MessageRef' Value='x855' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_1' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Construct' OID='3afa7c8d-5c4d-400b-92c7-92d97d84e8c9' ParentLink='ComplexStatement_Statement' LowerBound='152.1' HigherBound='158.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct_OrderConfirm_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Transform' OID='36c580c4-569b-45a6-9daa-cee65b0a63b8' ParentLink='ComplexStatement_Statement' LowerBound='155.1' HigherBound='157.1'>
                                        <om:Property Name='ClassName' Value='Inbound_Status_Doc_X12_Process.Maps.Map_855' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Transform_OrderConfirm_1' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessagePartRef' OID='29f23f8e-e9ce-4237-83fe-b9af4fa7b20e' ParentLink='Transform_OutputMessagePartRef' LowerBound='156.44' HigherBound='156.56'>
                                            <om:Property Name='MessageRef' Value='orderConfirm' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_8' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='66d6c3f1-dc73-48f7-92af-298574e0639e' ParentLink='Transform_InputMessagePartRef' LowerBound='156.105' HigherBound='156.109'>
                                            <om:Property Name='MessageRef' Value='x855' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_7' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='3346a16f-867c-4755-b74d-3477716d314e' ParentLink='Construct_MessageRef' LowerBound='153.39' HigherBound='153.51'>
                                        <om:Property Name='Ref' Value='orderConfirm' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='VariableAssignment' OID='1b7fb9b3-09b7-48f8-8b4b-d1d2ff3b194f' ParentLink='ComplexStatement_Statement' LowerBound='158.1' HigherBound='161.1'>
                                    <om:Property Name='Expression' Value='library.Create997(timestamp,x997);&#xD;&#xA;library.CreateStatusDocFromEdi(orderConfirm,docType);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Process_OrderConfirm_1' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='692b9233-61f5-4b6c-8e2c-6416b9ef50dd' ParentLink='ReallyComplexStatement_Branch' LowerBound='162.30' HigherBound='186.1'>
                                <om:Property Name='Expression' Value='docType == &quot;856&quot;' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='856' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Construct' OID='403b54e1-2d52-468b-9a01-a51fc0cf50d3' ParentLink='ComplexStatement_Statement' LowerBound='164.1' HigherBound='170.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Assign856_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageAssignment' OID='0c884e82-2b44-47e2-a728-e645e43690ea' ParentLink='ComplexStatement_Statement' LowerBound='167.1' HigherBound='169.1'>
                                        <om:Property Name='Expression' Value='x856 = xml;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='MessageAssignment_2' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='72a7b75b-4202-41f5-b790-b80870967d24' ParentLink='Construct_MessageRef' LowerBound='165.39' HigherBound='165.43'>
                                        <om:Property Name='Ref' Value='x856' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Construct' OID='eda55d34-83ec-48a9-a19a-f83773a72ebf' ParentLink='ComplexStatement_Statement' LowerBound='170.1' HigherBound='176.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct_856_997_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='121620d1-8463-46ad-bff9-98a95db21a80' ParentLink='Construct_MessageRef' LowerBound='171.39' HigherBound='171.43'>
                                        <om:Property Name='Ref' Value='x997' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Transform' OID='f3717def-da5b-49e1-932c-0df6bd3b54e4' ParentLink='ComplexStatement_Statement' LowerBound='173.1' HigherBound='175.1'>
                                        <om:Property Name='ClassName' Value='Inbound_Status_Doc_X12_Process.Maps.Map_856_997' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Transform_856_997_1' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessagePartRef' OID='78eec78b-80e5-4c37-bc30-c6aa7f1516a9' ParentLink='Transform_InputMessagePartRef' LowerBound='174.101' HigherBound='174.105'>
                                            <om:Property Name='MessageRef' Value='x856' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_3' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='c2ee9365-b76f-428c-8a92-e51ce4a365a8' ParentLink='Transform_OutputMessagePartRef' LowerBound='174.44' HigherBound='174.48'>
                                            <om:Property Name='MessageRef' Value='x997' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_4' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Construct' OID='8ab6fb5a-11f2-47ee-a2c8-8e966f73347b' ParentLink='ComplexStatement_Statement' LowerBound='176.1' HigherBound='182.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct_ASN_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='71beba91-fd7f-4f1d-aa64-8704c0fce123' ParentLink='Construct_MessageRef' LowerBound='177.39' HigherBound='177.42'>
                                        <om:Property Name='Ref' Value='asn' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Transform' OID='fd258891-f629-45f1-8897-d10b96d33506' ParentLink='ComplexStatement_Statement' LowerBound='179.1' HigherBound='181.1'>
                                        <om:Property Name='ClassName' Value='Inbound_Status_Doc_X12_Process.Maps.Map_856' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Transform_ASN_1' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessagePartRef' OID='65ebab07-f39f-4adc-b43d-70fc11098c67' ParentLink='Transform_InputMessagePartRef' LowerBound='180.96' HigherBound='180.100'>
                                            <om:Property Name='MessageRef' Value='x856' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_9' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='3e465e1e-abb1-47f3-b1f1-89367d7a6a91' ParentLink='Transform_OutputMessagePartRef' LowerBound='180.44' HigherBound='180.47'>
                                            <om:Property Name='MessageRef' Value='asn' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_10' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='VariableAssignment' OID='8e63e82b-fc9d-410b-9578-3120e7426de8' ParentLink='ComplexStatement_Statement' LowerBound='182.1' HigherBound='185.1'>
                                    <om:Property Name='Expression' Value='library.Create997(timestamp,x997);&#xD;&#xA;library.CreateStatusDocFromEdi(asn,docType);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Process_ASN_1' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='d9624fdc-ab16-4023-9a54-b3036f661335' ParentLink='ReallyComplexStatement_Branch' LowerBound='186.30' HigherBound='210.1'>
                                <om:Property Name='Expression' Value='docType == &quot;810&quot;' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='810' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Construct' OID='b097e786-e657-4d9d-89bf-8af515e01a49' ParentLink='ComplexStatement_Statement' LowerBound='188.1' HigherBound='194.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Assign810_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='1febc3b5-a687-4ea8-ae85-64d28ae12e70' ParentLink='Construct_MessageRef' LowerBound='189.39' HigherBound='189.43'>
                                        <om:Property Name='Ref' Value='x810' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='573cf84f-74c6-40f5-bb0a-df1d56fdc175' ParentLink='ComplexStatement_Statement' LowerBound='191.1' HigherBound='193.1'>
                                        <om:Property Name='Expression' Value='x810 = xml;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='MessageAssignment_3' />
                                        <om:Property Name='Signal' Value='True' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Construct' OID='993d4061-f86b-4d66-b724-d06f69c2cdb4' ParentLink='ComplexStatement_Statement' LowerBound='194.1' HigherBound='200.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct_810_997_3' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Transform' OID='0181d516-0330-4bfa-9d11-7ee01f5229df' ParentLink='ComplexStatement_Statement' LowerBound='197.1' HigherBound='199.1'>
                                        <om:Property Name='ClassName' Value='Inbound_Status_Doc_X12_Process.Maps.Map_810_997' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Transform_81_997_1' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessagePartRef' OID='ec9c6f85-207d-4e61-a726-82ead32890bc' ParentLink='Transform_InputMessagePartRef' LowerBound='198.101' HigherBound='198.105'>
                                            <om:Property Name='MessageRef' Value='x810' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_5' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='1eb53d3b-121d-4b0c-b73e-904253c8aedb' ParentLink='Transform_OutputMessagePartRef' LowerBound='198.44' HigherBound='198.48'>
                                            <om:Property Name='MessageRef' Value='x997' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_6' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='c4f1bcb9-4663-4184-a83f-ccb204673584' ParentLink='Construct_MessageRef' LowerBound='195.39' HigherBound='195.43'>
                                        <om:Property Name='Ref' Value='x997' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Construct' OID='04f05146-5a5c-4501-a007-1648201d0f8e' ParentLink='ComplexStatement_Statement' LowerBound='200.1' HigherBound='206.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct_Invoice_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='37f46d6d-92ee-4c79-bc24-940c4e8420f0' ParentLink='Construct_MessageRef' LowerBound='201.39' HigherBound='201.46'>
                                        <om:Property Name='Ref' Value='invoice' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Transform' OID='6597eb99-1308-45c5-8356-44a7d5f0f5c8' ParentLink='ComplexStatement_Statement' LowerBound='203.1' HigherBound='205.1'>
                                        <om:Property Name='ClassName' Value='Inbound_Status_Doc_X12_Process.Maps.Map_810' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Transform_Invoice_1' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessagePartRef' OID='8c64e963-f4db-444e-9431-873292afe60f' ParentLink='Transform_OutputMessagePartRef' LowerBound='204.44' HigherBound='204.51'>
                                            <om:Property Name='MessageRef' Value='invoice' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_12' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='0bde6e80-994c-4625-8d74-76b4d9b1de39' ParentLink='Transform_InputMessagePartRef' LowerBound='204.100' HigherBound='204.104'>
                                            <om:Property Name='MessageRef' Value='x810' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_11' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='VariableAssignment' OID='d0f98e57-452d-4a6b-b035-0d3dd2854eb3' ParentLink='ComplexStatement_Statement' LowerBound='206.1' HigherBound='209.1'>
                                    <om:Property Name='Expression' Value='library.Create997(timestamp,x997);&#xD;&#xA;library.CreateStatusDocFromEdi(invoice,docType);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Process_Invoice_1' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='9f1939c9-f089-406f-9bf9-6750178785cd' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='a0595937-6e20-4091-8e47-2dff412f04e5' ParentLink='ComplexStatement_Statement' LowerBound='212.1' HigherBound='214.1'>
                                    <om:Property Name='Expression' Value='library.CreateDump(dumpFolders.INBOUND_STATUS_FAILED(),timestamp,&quot;&quot;,xml,true);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Expression_4' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='461387e1-2468-46b2-b3c0-81297c96b657' ParentLink='Scope_Catch' LowerBound='219.1' HigherBound='231.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.SystemException' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='772eaa6a-233f-4f76-8f4a-95dd2b032ced' ParentLink='Catch_Statement' LowerBound='222.1' HigherBound='230.1'>
                            <om:Property Name='Expression' Value='library = new BizTalkLibrary.Orchestrations.OrchestrationFunctions();&#xD;&#xA;dumpFolders = new BizTalkLibrary.Classes.Constants.DUMP_FOLDERS();&#xD;&#xA;timestamp=library.GetTimeStamp(System.DateTime.Now);&#xD;&#xA;docType = library.GetEdiDocumentType(xml);&#xD;&#xA;library.CreateDump(dumpFolders.INBOUND_STATUS_FAILED(),docType+&quot;.Arrive&quot;,timestamp,xml,true);&#xD;&#xA;&#xD;&#xA;library.sendExceptionEmail(ex,&quot;Inbound_Status_Doc_cXML_Receive&quot;,&quot;&quot;,&quot;&quot;,docType);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_3' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='c6194be0-e5ce-44bd-85df-3fd4cf642728' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='18.1' HigherBound='20.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Inbound_Status_Doc_X12_Process.Inbound_Status_Doc_X12_Process_PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Inbound_Status_Doc_X12_Process_Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='8e043f0e-3b96-4d39-bdcd-bfbc1f352e17' ParentLink='PortDeclaration_CLRAttribute' LowerBound='18.1' HigherBound='19.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Inbound_Status_Doc_X12_Process_Orch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Inbound_Status_Doc_X12_Process_Orch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Inbound_Status_Doc_X12_Process_Orch")
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
                Inbound_Status_Doc_X12_Process_Orch __svc__ = (Inbound_Status_Doc_X12_Process_Orch)_service;
                __Inbound_Status_Doc_X12_Process_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_X12_Process_Orch_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Inbound_Status_Doc_X12_Process_Port_1 != null)
                {
                    __svc__.Inbound_Status_Doc_X12_Process_Port_1.Close(this, null);
                    __svc__.Inbound_Status_Doc_X12_Process_Port_1 = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __Inbound_Status_Doc_X12_Process_Orch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Inbound_Status_Doc_X12_Process_Orch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Inbound_Status_Doc_X12_Process_Orch")
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
                Inbound_Status_Doc_X12_Process_Orch __svc__ = (Inbound_Status_Doc_X12_Process_Orch)_service;
                __Inbound_Status_Doc_X12_Process_Orch_1 __ctx1__ = (__Inbound_Status_Doc_X12_Process_Orch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__dumpFolders = null;
                if (__ctx1__ != null)
                    __ctx1__.__timestamp = null;
                if (__ctx1__ != null)
                    __ctx1__.__docType = null;
                if (__ctx1__ != null)
                    __ctx1__.__library = null;
                if (__ctx1__ != null && __ctx1__.__xml != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__xml);
                    __ctx1__.__xml = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("xml")]
            public __messagetype_System_Xml_XmlDocument __xml;
            [Microsoft.XLANGs.Core.UserVariableAttribute("x997")]
            public __messagetype_EdiSchemas_X12_X12_00401_997 __x997;
            [Microsoft.XLANGs.Core.UserVariableAttribute("x810")]
            public __messagetype_EdiSchemas_X12_X12_00401_810 __x810;
            [Microsoft.XLANGs.Core.UserVariableAttribute("x855")]
            public __messagetype_EdiSchemas_X12_X12_00401_855 __x855;
            [Microsoft.XLANGs.Core.UserVariableAttribute("x856")]
            public __messagetype_EdiSchemas_X12_X12_00401_856 __x856;
            [Microsoft.XLANGs.Core.UserVariableAttribute("orderConfirm")]
            public __messagetype_EdiSchemas_cXML_Fulfill_cXML_Fulfill __orderConfirm;
            [Microsoft.XLANGs.Core.UserVariableAttribute("asn")]
            public __messagetype_EdiSchemas_cXML_Fulfill_cXML_Fulfill __asn;
            [Microsoft.XLANGs.Core.UserVariableAttribute("invoice")]
            public __messagetype_EdiSchemas_cXML_cXMLinvoice __invoice;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_1")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("library")]
            internal BizTalkLibrary.Orchestrations.OrchestrationFunctions __library;
            [Microsoft.XLANGs.Core.UserVariableAttribute("timestamp")]
            internal System.String __timestamp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("docType")]
            internal System.String __docType;
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
                Inbound_Status_Doc_X12_Process_Orch __svc__ = (Inbound_Status_Doc_X12_Process_Orch)_service;
                __Inbound_Status_Doc_X12_Process_Orch_1 __ctx1__ = (__Inbound_Status_Doc_X12_Process_Orch_1)(__svc__._stateMgrs[1]);
                ____scope33_2 __ctx2__ = (____scope33_2)(__svc__._stateMgrs[2]);

                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if (__ctx1__ != null && __ctx1__.__x856 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__x856);
                    __ctx1__.__x856 = null;
                }
                if (__ctx1__ != null && __ctx1__.__x855 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__x855);
                    __ctx1__.__x855 = null;
                }
                if (__ctx1__ != null && __ctx1__.__invoice != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__invoice);
                    __ctx1__.__invoice = null;
                }
                if (__ctx1__ != null && __ctx1__.__orderConfirm != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__orderConfirm);
                    __ctx1__.__orderConfirm = null;
                }
                if (__ctx1__ != null && __ctx1__.__asn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__asn);
                    __ctx1__.__asn = null;
                }
                if (__ctx1__ != null && __ctx1__.__x810 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__x810);
                    __ctx1__.__x810 = null;
                }
                if (__ctx1__ != null && __ctx1__.__x997 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__x997);
                    __ctx1__.__x997 = null;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Inbound_Status_Doc_X12_Process_Port_1")]
        internal Inbound_Status_Doc_X12_Process_PortType_1 Inbound_Status_Doc_X12_Process_Port_1;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Inbound_Status_Doc_X12_Process_PortType_1.Operation_1},
                                               typeof(Inbound_Status_Doc_X12_Process_Orch).GetField("Inbound_Status_Doc_X12_Process_Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Inbound_Status_Doc_X12_Process_Orch), "Inbound_Status_Doc_X12_Process_Port_1"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "dd61eb18-b190-46be-af45-b12bfe42bd9b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "dd61eb18-b190-46be-af45-b12bfe42bd9b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "f56b1752-254d-40f3-a719-1806dfd04738", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "e20f5949-a76f-40a8-8895-c46757eebfaa", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "e20f5949-a76f-40a8-8895-c46757eebfaa", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "6b911853-0410-4261-bf40-175b2d1763ef", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "00c0624f-8ba7-4a6b-b157-6a31d09ccf5b", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00c0624f-8ba7-4a6b-b157-6a31d09ccf5b", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "259a7ddf-78e9-4641-8ae4-e90c28f07ec3", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "259a7ddf-78e9-4641-8ae4-e90c28f07ec3", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "2b837692-5723-46c1-97b1-1ebc5b3facf8", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "2b837692-5723-46c1-97b1-1ebc5b3facf8", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "dc4640b0-22f7-41df-a027-be359e8a8d2d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "dc4640b0-22f7-41df-a027-be359e8a8d2d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "98d9d853-1f7b-4b1b-90a9-5d09a61f723c", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "98d9d853-1f7b-4b1b-90a9-5d09a61f723c", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "599ce786-11df-48a9-92f2-3f19d10126db", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "599ce786-11df-48a9-92f2-3f19d10126db", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "527c7040-9e5f-4458-99fd-dde8b2196b10", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "527c7040-9e5f-4458-99fd-dde8b2196b10", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "8485574e-f82c-4548-a8f0-6d5505e73b4e", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "8485574e-f82c-4548-a8f0-6d5505e73b4e", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "d8ca4b1c-919f-46f2-8b30-cbc9987246d0", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "d8ca4b1c-919f-46f2-8b30-cbc9987246d0", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "c5d6564f-41d9-43ae-8506-a6456d6b4b81", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "c5d6564f-41d9-43ae-8506-a6456d6b4b81", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "4d501e4d-594f-43fc-a6e5-66f9c05c69b9", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "4d501e4d-594f-43fc-a6e5-66f9c05c69b9", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "c0bda29a-8fc9-457e-b268-255565507f54", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "c0bda29a-8fc9-457e-b268-255565507f54", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "fe33a64c-6b04-4688-9b64-690631a65fcb", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "fe33a64c-6b04-4688-9b64-690631a65fcb", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "6b911853-0410-4261-bf40-175b2d1763ef", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "9d025611-39b3-4c5e-bd0a-6afcf570de40", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "111a0ab0-9f42-46a7-9c6e-5eaa365956d8", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "111a0ab0-9f42-46a7-9c6e-5eaa365956d8", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "b316e11b-5d27-4b7e-9038-8a7f6db85bb2", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "b316e11b-5d27-4b7e-9038-8a7f6db85bb2", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "9b7ecd03-60ab-41dc-aa45-03bd516ef176", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "23421fca-90bf-4864-9058-e2a0da06208a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "23421fca-90bf-4864-9058-e2a0da06208a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "26650ade-07cd-470f-803f-6dae97256a26", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(46, "26650ade-07cd-470f-803f-6dae97256a26", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(47, "3afa7c8d-5c4d-400b-92c7-92d97d84e8c9", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(48, "3afa7c8d-5c4d-400b-92c7-92d97d84e8c9", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(49, "1b7fb9b3-09b7-48f8-8b4b-d1d2ff3b194f", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(50, "1b7fb9b3-09b7-48f8-8b4b-d1d2ff3b194f", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(51, "403b54e1-2d52-468b-9a01-a51fc0cf50d3", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(52, "403b54e1-2d52-468b-9a01-a51fc0cf50d3", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(53, "eda55d34-83ec-48a9-a19a-f83773a72ebf", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(54, "eda55d34-83ec-48a9-a19a-f83773a72ebf", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(55, "8ab6fb5a-11f2-47ee-a2c8-8e966f73347b", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(56, "8ab6fb5a-11f2-47ee-a2c8-8e966f73347b", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(57, "8e63e82b-fc9d-410b-9578-3120e7426de8", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(58, "8e63e82b-fc9d-410b-9578-3120e7426de8", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(59, "b097e786-e657-4d9d-89bf-8af515e01a49", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(60, "b097e786-e657-4d9d-89bf-8af515e01a49", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(61, "993d4061-f86b-4d66-b724-d06f69c2cdb4", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(62, "993d4061-f86b-4d66-b724-d06f69c2cdb4", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(63, "04f05146-5a5c-4501-a007-1648201d0f8e", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(64, "04f05146-5a5c-4501-a007-1648201d0f8e", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(65, "d0f98e57-452d-4a6b-b035-0d3dd2854eb3", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(66, "d0f98e57-452d-4a6b-b035-0d3dd2854eb3", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(67, "a0595937-6e20-4091-8e47-2dff412f04e5", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(68, "a0595937-6e20-4091-8e47-2dff412f04e5", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(69, "9b7ecd03-60ab-41dc-aa45-03bd516ef176", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(70, "9d025611-39b3-4c5e-bd0a-6afcf570de40", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(71, "461387e1-2468-46b2-b3c0-81297c96b657", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(72, "772eaa6a-233f-4f76-8f4a-95dd2b032ced", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(73, "772eaa6a-233f-4f76-8f4a-95dd2b032ced", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(74, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(75, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(76, "461387e1-2468-46b2-b3c0-81297c96b657", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(77, "f56b1752-254d-40f3-a719-1806dfd04738", 1, false)
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
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,4,4,4,77,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,7,7,9,9,10,10,11,12,12,13,14,14,15,16,16,17,17,9,9,9,18,18,19,20,20,21,22,22,23,24,24,25,25,25,25,25,26,26,27,28,28,29,30,30,31,32,32,33,33,33,34,34,35,35,35,36,37,37,37,38,38,39,40,40,41,41,41,42,42,43,43,44,45,45,46,47,47,48,49,49,50,50,42,42,42,51,51,52,53,53,54,55,55,56,57,57,58,58,58,58,58,59,59,60,61,61,62,63,63,64,65,65,66,66,66,67,67,68,68,68,69,70,70,70,70,70,70,};
        public static int[] __progressLocation3 = new int[] { 71,71,72,72,73,73,73,73,73,73,76,76,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Inbound_Status_Doc_X12_Process_Orch_1 __ctx1__ = (__Inbound_Status_Doc_X12_Process_Orch_1)_stateMgrs[1];
            __Inbound_Status_Doc_X12_Process_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_X12_Process_Orch_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Inbound_Status_Doc_X12_Process_Port_1 = new Inbound_Status_Doc_X12_Process_PortType_1(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Inbound_Status_Doc_X12_Process_Port_1, this);
                __ctx0__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[1], Inbound_Status_Doc_X12_Process_Port_1, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Inbound_Status_Doc_X12_Process_Orch_1(this);
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
            __Inbound_Status_Doc_X12_Process_Orch_1 __ctx1__ = (__Inbound_Status_Doc_X12_Process_Orch_1)_stateMgrs[1];
            __Inbound_Status_Doc_X12_Process_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_X12_Process_Orch_root_0)_stateMgrs[0];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__library = default(BizTalkLibrary.Orchestrations.OrchestrationFunctions);
                __ctx1__.__timestamp = default(System.String);
                __ctx1__.__docType = default(System.String);
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
                if (!Inbound_Status_Doc_X12_Process_Port_1.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__xml != null)
                    __ctx1__.UnrefMessage(__ctx1__.__xml);
                __ctx1__.__xml = new __messagetype_System_Xml_XmlDocument("xml", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__xml);
                Inbound_Status_Doc_X12_Process_Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__xml, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__xml);
                    __edata.PortName = @"Inbound_Status_Doc_X12_Process_Port_1";
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
                __ctx1__.__timestamp = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__docType = "";
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
                    __ctx1__.__docType = null;
                if (__ctx1__ != null)
                    __ctx1__.__timestamp = null;
                if (__ctx1__ != null)
                    __ctx1__.__library = null;
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (__ctx1__ != null && __ctx1__.__xml != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__xml);
                    __ctx1__.__xml = null;
                }
                if (Inbound_Status_Doc_X12_Process_Port_1 != null)
                {
                    Inbound_Status_Doc_X12_Process_Port_1.Close(__ctx1__, __seg__);
                    Inbound_Status_Doc_X12_Process_Port_1 = null;
                }
                Tracker.FireEvent(__eventLocations[77],__eventData[14],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[15],_stateMgrs[1].TrackDataStream );
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
            __Inbound_Status_Doc_X12_Process_Orch_1 __ctx1__ = (__Inbound_Status_Doc_X12_Process_Orch_1)_stateMgrs[1];
            __Inbound_Status_Doc_X12_Process_Orch_root_0 __ctx0__ = (__Inbound_Status_Doc_X12_Process_Orch_root_0)_stateMgrs[0];
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
                __ctx1__.__docType = __ctx1__.__library.GetEdiDocumentType(__ctx1__.__xml.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_PROCESSED_INCOMING(), __ctx1__.__docType, __ctx1__.__timestamp, __ctx1__.__xml.part.TypedValue, true);
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
                __condition__ = __ctx1__.__docType == "855";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 22;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_855 __x855 = new __messagetype_EdiSchemas_X12_X12_00401_855("x855", __ctx1__);

                    __x855.CopyFrom(__ctx1__.__xml);

                    if (__ctx1__.__x855 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__x855);
                    __ctx1__.__x855 = __x855;
                    __ctx1__.RefMessage(__ctx1__.__x855);
                }
                __ctx1__.__x855.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__x855);
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_997 __x997 = new __messagetype_EdiSchemas_X12_X12_00401_997("x997", __ctx1__);

                    ApplyTransform(typeof(Inbound_Status_Doc_X12_Process.Maps.Map_855_997), new object[] {__x997.part}, new object[] {__ctx1__.__x855.part});

                    if (__ctx1__.__x997 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__x997);
                    __ctx1__.__x997 = __x997;
                    __ctx1__.RefMessage(__ctx1__.__x997);
                }
                __ctx1__.__x997.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__x997);
                    __edata.Messages.Add(__ctx1__.__x855);
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                {
                    __messagetype_EdiSchemas_cXML_Fulfill_cXML_Fulfill __orderConfirm = new __messagetype_EdiSchemas_cXML_Fulfill_cXML_Fulfill("orderConfirm", __ctx1__);

                    ApplyTransform(typeof(Inbound_Status_Doc_X12_Process.Maps.Map_855), new object[] {__orderConfirm.part}, new object[] {__ctx1__.__x855.part});

                    if (__ctx1__.__orderConfirm != null)
                        __ctx1__.UnrefMessage(__ctx1__.__orderConfirm);
                    __ctx1__.__orderConfirm = __orderConfirm;
                    __ctx1__.RefMessage(__ctx1__.__orderConfirm);
                }
                __ctx1__.__orderConfirm.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__orderConfirm);
                    __edata.Messages.Add(__ctx1__.__x855);
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                __ctx1__.__library.Create997(__ctx1__.__timestamp, __ctx1__.__x997.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                __ctx1__.__library.CreateStatusDocFromEdi(__ctx1__.__orderConfirm.part.TypedValue, __ctx1__.__docType);
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PostProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 59;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                __condition__ = __ctx1__.__docType == "856";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 38;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_856 __x856 = new __messagetype_EdiSchemas_X12_X12_00401_856("x856", __ctx1__);

                    __x856.CopyFrom(__ctx1__.__xml);

                    if (__ctx1__.__x856 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__x856);
                    __ctx1__.__x856 = __x856;
                    __ctx1__.RefMessage(__ctx1__.__x856);
                }
                __ctx1__.__x856.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__x856);
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_997 __x997 = new __messagetype_EdiSchemas_X12_X12_00401_997("x997", __ctx1__);

                    ApplyTransform(typeof(Inbound_Status_Doc_X12_Process.Maps.Map_856_997), new object[] {__x997.part}, new object[] {__ctx1__.__x856.part});

                    if (__ctx1__.__x997 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__x997);
                    __ctx1__.__x997 = __x997;
                    __ctx1__.RefMessage(__ctx1__.__x997);
                }
                __ctx1__.__x997.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__x997);
                    __edata.Messages.Add(__ctx1__.__x856);
                    Tracker.FireEvent(__eventLocations[21],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                {
                    __messagetype_EdiSchemas_cXML_Fulfill_cXML_Fulfill __asn = new __messagetype_EdiSchemas_cXML_Fulfill_cXML_Fulfill("asn", __ctx1__);

                    ApplyTransform(typeof(Inbound_Status_Doc_X12_Process.Maps.Map_856), new object[] {__asn.part}, new object[] {__ctx1__.__x856.part});

                    if (__ctx1__.__asn != null)
                        __ctx1__.UnrefMessage(__ctx1__.__asn);
                    __ctx1__.__asn = __asn;
                    __ctx1__.RefMessage(__ctx1__.__asn);
                }
                __ctx1__.__asn.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__asn);
                    __edata.Messages.Add(__ctx1__.__x856);
                    Tracker.FireEvent(__eventLocations[23],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                __ctx1__.__library.Create997(__ctx1__.__timestamp, __ctx1__.__x997.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                __ctx1__.__library.CreateStatusDocFromEdi(__ctx1__.__asn.part.TypedValue, __ctx1__.__docType);
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                if ( !PostProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 58;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                __condition__ = __ctx1__.__docType == "810";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 54 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 54;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_810 __x810 = new __messagetype_EdiSchemas_X12_X12_00401_810("x810", __ctx1__);

                    __x810.CopyFrom(__ctx1__.__xml);

                    if (__ctx1__.__x810 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__x810);
                    __ctx1__.__x810 = __x810;
                    __ctx1__.RefMessage(__ctx1__.__x810);
                }
                __ctx1__.__x810.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__x810);
                    Tracker.FireEvent(__eventLocations[27],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_997 __x997 = new __messagetype_EdiSchemas_X12_X12_00401_997("x997", __ctx1__);

                    ApplyTransform(typeof(Inbound_Status_Doc_X12_Process.Maps.Map_810_997), new object[] {__x997.part}, new object[] {__ctx1__.__x810.part});

                    if (__ctx1__.__x997 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__x997);
                    __ctx1__.__x997 = __x997;
                    __ctx1__.RefMessage(__ctx1__.__x997);
                }
                __ctx1__.__x997.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 45;
            case 45:
                if ( !PreProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__x997);
                    __edata.Messages.Add(__ctx1__.__x810);
                    Tracker.FireEvent(__eventLocations[29],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 47;
            case 47:
                {
                    __messagetype_EdiSchemas_cXML_cXMLinvoice __invoice = new __messagetype_EdiSchemas_cXML_cXMLinvoice("invoice", __ctx1__);

                    ApplyTransform(typeof(Inbound_Status_Doc_X12_Process.Maps.Map_810), new object[] {__invoice.part}, new object[] {__ctx1__.__x810.part});

                    if (__ctx1__.__invoice != null)
                        __ctx1__.UnrefMessage(__ctx1__.__invoice);
                    __ctx1__.__invoice = __invoice;
                    __ctx1__.RefMessage(__ctx1__.__invoice);
                }
                __ctx1__.__invoice.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 48;
            case 48:
                if ( !PreProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__invoice);
                    __edata.Messages.Add(__ctx1__.__x810);
                    Tracker.FireEvent(__eventLocations[31],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 49;
            case 49:
                if ( !PreProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 50;
            case 50:
                __ctx1__.__library.Create997(__ctx1__.__timestamp, __ctx1__.__x997.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 51;
            case 51:
                if ( !PreProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[33],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 52;
            case 52:
                __ctx1__.__library.CreateStatusDocFromEdi(__ctx1__.__invoice.part.TypedValue, __ctx1__.__docType);
                if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 53;
            case 53:
                if ( !PostProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 57;
            case 54:
                if ( !PreProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 55;
            case 55:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_FAILED(), __ctx1__.__timestamp, "", __ctx1__.__xml.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 56;
            case 56:
                Tracker.FireEvent(__eventLocations[35],__eventData[4],_stateMgrs[2].TrackDataStream );
                if ( !PostProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 57;
            case 57:
                if ( !PreProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 58;
            case 58:
                if ( !PreProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 59;
            case 59:
                if ( !PreProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[36],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 60;
            case 60:
                if ( !PreProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 61;
            case 61:
                __condition__ = true;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 127 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 127;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 62;
            case 62:
                if ( !PreProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 63;
            case 63:
                if ( !PreProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[38],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 64;
            case 64:
                if (!Inbound_Status_Doc_X12_Process_Port_1.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__xml != null)
                    __ctx1__.UnrefMessage(__ctx1__.__xml);
                __ctx1__.__xml = new __messagetype_System_Xml_XmlDocument("xml", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__xml);
                Inbound_Status_Doc_X12_Process_Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__xml, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 65 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 65;
            case 65:
                if ( !PreProgressInc( __seg__, __ctx__, 66 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__xml);
                    __edata.PortName = @"Inbound_Status_Doc_X12_Process_Port_1";
                    Tracker.FireEvent(__eventLocations[39],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 66;
            case 66:
                if ( !PreProgressInc( __seg__, __ctx__, 67 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[40],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 67;
            case 67:
                __ctx1__.__timestamp = __ctx1__.__library.GetTimeStamp(System.DateTime.Now);
                if ( !PostProgressInc( __seg__, __ctx__, 68 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 68;
            case 68:
                if ( !PreProgressInc( __seg__, __ctx__, 69 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[41],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 69;
            case 69:
                __ctx1__.__docType = __ctx1__.__library.GetEdiDocumentType(__ctx1__.__xml.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 70 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 70;
            case 70:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_PROCESSED_INCOMING(), __ctx1__.__docType, __ctx1__.__timestamp, __ctx1__.__xml.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 71 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 71;
            case 71:
                if ( !PreProgressInc( __seg__, __ctx__, 72 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[42],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 72;
            case 72:
                __condition__ = __ctx1__.__docType == "855";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 87 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 87;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 73 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 73;
            case 73:
                if ( !PreProgressInc( __seg__, __ctx__, 74 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[43],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 74;
            case 74:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_855 __x855 = new __messagetype_EdiSchemas_X12_X12_00401_855("x855", __ctx1__);

                    __x855.CopyFrom(__ctx1__.__xml);

                    if (__ctx1__.__x855 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__x855);
                    __ctx1__.__x855 = __x855;
                    __ctx1__.RefMessage(__ctx1__.__x855);
                }
                __ctx1__.__x855.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 75 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 75;
            case 75:
                if ( !PreProgressInc( __seg__, __ctx__, 76 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__x855);
                    Tracker.FireEvent(__eventLocations[44],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 76;
            case 76:
                if ( !PreProgressInc( __seg__, __ctx__, 77 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[45],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 77;
            case 77:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_997 __x997 = new __messagetype_EdiSchemas_X12_X12_00401_997("x997", __ctx1__);

                    ApplyTransform(typeof(Inbound_Status_Doc_X12_Process.Maps.Map_855_997), new object[] {__x997.part}, new object[] {__ctx1__.__x855.part});

                    if (__ctx1__.__x997 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__x997);
                    __ctx1__.__x997 = __x997;
                    __ctx1__.RefMessage(__ctx1__.__x997);
                }
                __ctx1__.__x997.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 78 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 78;
            case 78:
                if ( !PreProgressInc( __seg__, __ctx__, 79 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__x997);
                    __edata.Messages.Add(__ctx1__.__x855);
                    Tracker.FireEvent(__eventLocations[46],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 79;
            case 79:
                if ( !PreProgressInc( __seg__, __ctx__, 80 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[47],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 80;
            case 80:
                {
                    __messagetype_EdiSchemas_cXML_Fulfill_cXML_Fulfill __orderConfirm = new __messagetype_EdiSchemas_cXML_Fulfill_cXML_Fulfill("orderConfirm", __ctx1__);

                    ApplyTransform(typeof(Inbound_Status_Doc_X12_Process.Maps.Map_855), new object[] {__orderConfirm.part}, new object[] {__ctx1__.__x855.part});

                    if (__ctx1__.__orderConfirm != null)
                        __ctx1__.UnrefMessage(__ctx1__.__orderConfirm);
                    __ctx1__.__orderConfirm = __orderConfirm;
                    __ctx1__.RefMessage(__ctx1__.__orderConfirm);
                }
                __ctx1__.__orderConfirm.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 81 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 81;
            case 81:
                if ( !PreProgressInc( __seg__, __ctx__, 82 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__orderConfirm);
                    __edata.Messages.Add(__ctx1__.__x855);
                    Tracker.FireEvent(__eventLocations[48],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 82;
            case 82:
                if ( !PreProgressInc( __seg__, __ctx__, 83 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[49],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 83;
            case 83:
                __ctx1__.__library.Create997(__ctx1__.__timestamp, __ctx1__.__x997.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 84 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 84;
            case 84:
                if ( !PreProgressInc( __seg__, __ctx__, 85 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[50],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 85;
            case 85:
                __ctx1__.__library.CreateStatusDocFromEdi(__ctx1__.__orderConfirm.part.TypedValue, __ctx1__.__docType);
                if ( !PostProgressInc( __seg__, __ctx__, 86 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 86;
            case 86:
                if ( !PostProgressInc( __seg__, __ctx__, 124 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 124;
            case 87:
                if ( !PreProgressInc( __seg__, __ctx__, 88 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 88;
            case 88:
                __condition__ = __ctx1__.__docType == "856";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 103 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 103;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 89 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 89;
            case 89:
                if ( !PreProgressInc( __seg__, __ctx__, 90 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[51],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 90;
            case 90:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_856 __x856 = new __messagetype_EdiSchemas_X12_X12_00401_856("x856", __ctx1__);

                    __x856.CopyFrom(__ctx1__.__xml);

                    if (__ctx1__.__x856 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__x856);
                    __ctx1__.__x856 = __x856;
                    __ctx1__.RefMessage(__ctx1__.__x856);
                }
                __ctx1__.__x856.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 91 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 91;
            case 91:
                if ( !PreProgressInc( __seg__, __ctx__, 92 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__x856);
                    Tracker.FireEvent(__eventLocations[52],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 92;
            case 92:
                if ( !PreProgressInc( __seg__, __ctx__, 93 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[53],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 93;
            case 93:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_997 __x997 = new __messagetype_EdiSchemas_X12_X12_00401_997("x997", __ctx1__);

                    ApplyTransform(typeof(Inbound_Status_Doc_X12_Process.Maps.Map_856_997), new object[] {__x997.part}, new object[] {__ctx1__.__x856.part});

                    if (__ctx1__.__x997 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__x997);
                    __ctx1__.__x997 = __x997;
                    __ctx1__.RefMessage(__ctx1__.__x997);
                }
                __ctx1__.__x997.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 94 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 94;
            case 94:
                if ( !PreProgressInc( __seg__, __ctx__, 95 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__x997);
                    __edata.Messages.Add(__ctx1__.__x856);
                    Tracker.FireEvent(__eventLocations[54],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 95;
            case 95:
                if ( !PreProgressInc( __seg__, __ctx__, 96 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[55],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 96;
            case 96:
                {
                    __messagetype_EdiSchemas_cXML_Fulfill_cXML_Fulfill __asn = new __messagetype_EdiSchemas_cXML_Fulfill_cXML_Fulfill("asn", __ctx1__);

                    ApplyTransform(typeof(Inbound_Status_Doc_X12_Process.Maps.Map_856), new object[] {__asn.part}, new object[] {__ctx1__.__x856.part});

                    if (__ctx1__.__asn != null)
                        __ctx1__.UnrefMessage(__ctx1__.__asn);
                    __ctx1__.__asn = __asn;
                    __ctx1__.RefMessage(__ctx1__.__asn);
                }
                __ctx1__.__asn.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 97 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 97;
            case 97:
                if ( !PreProgressInc( __seg__, __ctx__, 98 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__asn);
                    __edata.Messages.Add(__ctx1__.__x856);
                    Tracker.FireEvent(__eventLocations[56],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 98;
            case 98:
                if ( !PreProgressInc( __seg__, __ctx__, 99 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[57],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 99;
            case 99:
                __ctx1__.__library.Create997(__ctx1__.__timestamp, __ctx1__.__x997.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 100 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 100;
            case 100:
                if ( !PreProgressInc( __seg__, __ctx__, 101 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[58],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 101;
            case 101:
                __ctx1__.__library.CreateStatusDocFromEdi(__ctx1__.__asn.part.TypedValue, __ctx1__.__docType);
                if ( !PostProgressInc( __seg__, __ctx__, 102 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 102;
            case 102:
                if ( !PostProgressInc( __seg__, __ctx__, 123 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 123;
            case 103:
                if ( !PreProgressInc( __seg__, __ctx__, 104 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 104;
            case 104:
                __condition__ = __ctx1__.__docType == "810";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 119 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 119;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 105 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 105;
            case 105:
                if ( !PreProgressInc( __seg__, __ctx__, 106 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[59],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 106;
            case 106:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_810 __x810 = new __messagetype_EdiSchemas_X12_X12_00401_810("x810", __ctx1__);

                    __x810.CopyFrom(__ctx1__.__xml);

                    if (__ctx1__.__x810 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__x810);
                    __ctx1__.__x810 = __x810;
                    __ctx1__.RefMessage(__ctx1__.__x810);
                }
                __ctx1__.__x810.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 107 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 107;
            case 107:
                if ( !PreProgressInc( __seg__, __ctx__, 108 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__x810);
                    Tracker.FireEvent(__eventLocations[60],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 108;
            case 108:
                if ( !PreProgressInc( __seg__, __ctx__, 109 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[61],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 109;
            case 109:
                {
                    __messagetype_EdiSchemas_X12_X12_00401_997 __x997 = new __messagetype_EdiSchemas_X12_X12_00401_997("x997", __ctx1__);

                    ApplyTransform(typeof(Inbound_Status_Doc_X12_Process.Maps.Map_810_997), new object[] {__x997.part}, new object[] {__ctx1__.__x810.part});

                    if (__ctx1__.__x997 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__x997);
                    __ctx1__.__x997 = __x997;
                    __ctx1__.RefMessage(__ctx1__.__x997);
                }
                __ctx1__.__x997.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 110 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 110;
            case 110:
                if ( !PreProgressInc( __seg__, __ctx__, 111 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__x997);
                    __edata.Messages.Add(__ctx1__.__x810);
                    Tracker.FireEvent(__eventLocations[62],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 111;
            case 111:
                if ( !PreProgressInc( __seg__, __ctx__, 112 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[63],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 112;
            case 112:
                {
                    __messagetype_EdiSchemas_cXML_cXMLinvoice __invoice = new __messagetype_EdiSchemas_cXML_cXMLinvoice("invoice", __ctx1__);

                    ApplyTransform(typeof(Inbound_Status_Doc_X12_Process.Maps.Map_810), new object[] {__invoice.part}, new object[] {__ctx1__.__x810.part});

                    if (__ctx1__.__invoice != null)
                        __ctx1__.UnrefMessage(__ctx1__.__invoice);
                    __ctx1__.__invoice = __invoice;
                    __ctx1__.RefMessage(__ctx1__.__invoice);
                }
                __ctx1__.__invoice.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 113 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 113;
            case 113:
                if ( !PreProgressInc( __seg__, __ctx__, 114 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__invoice);
                    __edata.Messages.Add(__ctx1__.__x810);
                    Tracker.FireEvent(__eventLocations[64],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 114;
            case 114:
                if ( !PreProgressInc( __seg__, __ctx__, 115 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[65],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 115;
            case 115:
                __ctx1__.__library.Create997(__ctx1__.__timestamp, __ctx1__.__x997.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 116 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 116;
            case 116:
                if ( !PreProgressInc( __seg__, __ctx__, 117 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[66],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 117;
            case 117:
                __ctx1__.__library.CreateStatusDocFromEdi(__ctx1__.__invoice.part.TypedValue, __ctx1__.__docType);
                if ( !PostProgressInc( __seg__, __ctx__, 118 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 118;
            case 118:
                if ( !PostProgressInc( __seg__, __ctx__, 122 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 122;
            case 119:
                if ( !PreProgressInc( __seg__, __ctx__, 120 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[67],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 120;
            case 120:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_FAILED(), __ctx1__.__timestamp, "", __ctx1__.__xml.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 121 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 121;
            case 121:
                Tracker.FireEvent(__eventLocations[68],__eventData[4],_stateMgrs[2].TrackDataStream );
                if ( !PostProgressInc( __seg__, __ctx__, 122 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 122;
            case 122:
                if ( !PreProgressInc( __seg__, __ctx__, 123 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 123;
            case 123:
                if ( !PreProgressInc( __seg__, __ctx__, 124 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 124;
            case 124:
                if ( !PreProgressInc( __seg__, __ctx__, 125 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[69],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 125;
            case 125:
                if ( !PreProgressInc( __seg__, __ctx__, 126 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[70],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 126;
            case 126:
                if ( !PostProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 61;
            case 127:
                if ( !PreProgressInc( __seg__, __ctx__, 128 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__invoice != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__invoice);
                    __ctx1__.__invoice = null;
                }
                if (__ctx1__ != null && __ctx1__.__asn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__asn);
                    __ctx1__.__asn = null;
                }
                if (__ctx1__ != null && __ctx1__.__orderConfirm != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__orderConfirm);
                    __ctx1__.__orderConfirm = null;
                }
                if (__ctx1__ != null && __ctx1__.__x856 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__x856);
                    __ctx1__.__x856 = null;
                }
                if (__ctx1__ != null && __ctx1__.__x855 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__x855);
                    __ctx1__.__x855 = null;
                }
                if (__ctx1__ != null && __ctx1__.__x810 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__x810);
                    __ctx1__.__x810 = null;
                }
                if (__ctx1__ != null && __ctx1__.__x997 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__x997);
                    __ctx1__.__x997 = null;
                }
                Tracker.FireEvent(__eventLocations[70],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 128;
            case 128:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 129 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 129;
            case 129:
                if ( !PreProgressInc( __seg__, __ctx__, 130 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 130;
            case 130:
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
            __Inbound_Status_Doc_X12_Process_Orch_1 __ctx1__ = (__Inbound_Status_Doc_X12_Process_Orch_1)_stateMgrs[1];
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
                Tracker.FireEvent(__eventLocations[71],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[72],__eventData[3],_stateMgrs[2].TrackDataStream );
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
                Tracker.FireEvent(__eventLocations[73],__eventData[4],_stateMgrs[2].TrackDataStream );
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
                __ctx1__.__docType = __ctx1__.__library.GetEdiDocumentType(__ctx1__.__xml.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__library.CreateDump(__ctx1__.__dumpFolders.INBOUND_STATUS_FAILED(), __ctx1__.__docType + ".Arrive", __ctx1__.__timestamp, __ctx1__.__xml.part.TypedValue, true);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__library.sendExceptionEmail(__ctx2__.__ex_0, "Inbound_Status_Doc_cXML_Receive", "", "", __ctx1__.__docType);
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[76],__eventData[13],_stateMgrs[2].TrackDataStream );
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
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{A6F5DEC6-B715-4EFD-8E48-EFA2D46E9888}"))
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

    [System.SerializableAttribute]
    sealed public class __EdiSchemas_X12_X12_00401_997__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static EdiSchemas.X12.X12_00401_997 _schema = new EdiSchemas.X12.X12_00401_997();

        public __EdiSchemas_X12_X12_00401_997__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "EdiSchemas.X12.X12_00401_997",
        new System.Type[]{
            typeof(EdiSchemas.X12.X12_00401_997)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__EdiSchemas_X12_X12_00401_997__)
        },
        0,
        @"http://schemas.microsoft.com/BizTalk/EDI/X12/2006#X12_00401_997"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_EdiSchemas_X12_X12_00401_997 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __EdiSchemas_X12_X12_00401_997__ part;

        private void __CreatePartWrappers()
        {
            part = new __EdiSchemas_X12_X12_00401_997__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_EdiSchemas_X12_X12_00401_997(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __EdiSchemas_X12_X12_00401_810__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static EdiSchemas.X12.X12_00401_810 _schema = new EdiSchemas.X12.X12_00401_810();

        public __EdiSchemas_X12_X12_00401_810__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "EdiSchemas.X12.X12_00401_810",
        new System.Type[]{
            typeof(EdiSchemas.X12.X12_00401_810)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__EdiSchemas_X12_X12_00401_810__)
        },
        0,
        @"http://schemas.microsoft.com/BizTalk/EDI/X12/2006#X12_00401_810"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_EdiSchemas_X12_X12_00401_810 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __EdiSchemas_X12_X12_00401_810__ part;

        private void __CreatePartWrappers()
        {
            part = new __EdiSchemas_X12_X12_00401_810__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_EdiSchemas_X12_X12_00401_810(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __EdiSchemas_X12_X12_00401_855__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static EdiSchemas.X12.X12_00401_855 _schema = new EdiSchemas.X12.X12_00401_855();

        public __EdiSchemas_X12_X12_00401_855__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "EdiSchemas.X12.X12_00401_855",
        new System.Type[]{
            typeof(EdiSchemas.X12.X12_00401_855)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__EdiSchemas_X12_X12_00401_855__)
        },
        0,
        @"http://schemas.microsoft.com/BizTalk/EDI/X12/2006#X12_00401_855"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_EdiSchemas_X12_X12_00401_855 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __EdiSchemas_X12_X12_00401_855__ part;

        private void __CreatePartWrappers()
        {
            part = new __EdiSchemas_X12_X12_00401_855__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_EdiSchemas_X12_X12_00401_855(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __EdiSchemas_X12_X12_00401_856__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static EdiSchemas.X12.X12_00401_856 _schema = new EdiSchemas.X12.X12_00401_856();

        public __EdiSchemas_X12_X12_00401_856__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "EdiSchemas.X12.X12_00401_856",
        new System.Type[]{
            typeof(EdiSchemas.X12.X12_00401_856)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__EdiSchemas_X12_X12_00401_856__)
        },
        0,
        @"http://schemas.microsoft.com/BizTalk/EDI/X12/2006#X12_00401_856"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_EdiSchemas_X12_X12_00401_856 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __EdiSchemas_X12_X12_00401_856__ part;

        private void __CreatePartWrappers()
        {
            part = new __EdiSchemas_X12_X12_00401_856__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_EdiSchemas_X12_X12_00401_856(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __EdiSchemas_cXML_Fulfill_cXML_Fulfill__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static EdiSchemas.cXML.Fulfill.cXML_Fulfill _schema = new EdiSchemas.cXML.Fulfill.cXML_Fulfill();

        public __EdiSchemas_cXML_Fulfill_cXML_Fulfill__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "EdiSchemas.cXML.Fulfill.cXML_Fulfill",
        new System.Type[]{
            typeof(EdiSchemas.cXML.Fulfill.cXML_Fulfill)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__EdiSchemas_cXML_Fulfill_cXML_Fulfill__)
        },
        0,
        @"cXML_Fulfill"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_EdiSchemas_cXML_Fulfill_cXML_Fulfill : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __EdiSchemas_cXML_Fulfill_cXML_Fulfill__ part;

        private void __CreatePartWrappers()
        {
            part = new __EdiSchemas_cXML_Fulfill_cXML_Fulfill__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_EdiSchemas_cXML_Fulfill_cXML_Fulfill(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __EdiSchemas_cXML_cXMLinvoice__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static EdiSchemas.cXML.cXMLinvoice _schema = new EdiSchemas.cXML.cXMLinvoice();

        public __EdiSchemas_cXML_cXMLinvoice__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "EdiSchemas.cXML.cXMLinvoice",
        new System.Type[]{
            typeof(EdiSchemas.cXML.cXMLinvoice)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__EdiSchemas_cXML_cXMLinvoice__)
        },
        0,
        @"cXML_Invoice"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_EdiSchemas_cXML_cXMLinvoice : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __EdiSchemas_cXML_cXMLinvoice__ part;

        private void __CreatePartWrappers()
        {
            part = new __EdiSchemas_cXML_cXMLinvoice__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_EdiSchemas_cXML_cXMLinvoice(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
