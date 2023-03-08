﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace BizTalkLibrary.WS_AutoPostDoc {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AutoPostDocument_Binding", Namespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument")]
    public partial class AutoPostDocument : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ReopenPurchaseOrderOperationCompleted;
        
        private System.Threading.SendOrPostCallback AutoPostPoOperationCompleted;
        
        private System.Threading.SendOrPostCallback PoPrepareDocAlphaOperationCompleted;
        
        private System.Threading.SendOrPostCallback RunAdjustCostReportOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertPoGlLineOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReleasePurchaseOrderOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateBizStatusPOOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AutoPostDocument() {
            this.Url = global::BizTalkLibrary.Properties.Settings.Default.BizTalkLibrary_AutoPostDoc_AutoPostDocument;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ReopenPurchaseOrderCompletedEventHandler ReopenPurchaseOrderCompleted;
        
        /// <remarks/>
        public event AutoPostPoCompletedEventHandler AutoPostPoCompleted;
        
        /// <remarks/>
        public event PoPrepareDocAlphaCompletedEventHandler PoPrepareDocAlphaCompleted;
        
        /// <remarks/>
        public event RunAdjustCostReportCompletedEventHandler RunAdjustCostReportCompleted;
        
        /// <remarks/>
        public event InsertPoGlLineCompletedEventHandler InsertPoGlLineCompleted;
        
        /// <remarks/>
        public event ReleasePurchaseOrderCompletedEventHandler ReleasePurchaseOrderCompleted;
        
        /// <remarks/>
        public event UpdateBizStatusPOCompletedEventHandler UpdateBizStatusPOCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument:ReopenPurchaseOrder", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", ResponseElementName="ReopenPurchaseOrder_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ReopenPurchaseOrder(string purchaseOrderNo) {
            this.Invoke("ReopenPurchaseOrder", new object[] {
                        purchaseOrderNo});
        }
        
        /// <remarks/>
        public void ReopenPurchaseOrderAsync(string purchaseOrderNo) {
            this.ReopenPurchaseOrderAsync(purchaseOrderNo, null);
        }
        
        /// <remarks/>
        public void ReopenPurchaseOrderAsync(string purchaseOrderNo, object userState) {
            if ((this.ReopenPurchaseOrderOperationCompleted == null)) {
                this.ReopenPurchaseOrderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReopenPurchaseOrderOperationCompleted);
            }
            this.InvokeAsync("ReopenPurchaseOrder", new object[] {
                        purchaseOrderNo}, this.ReopenPurchaseOrderOperationCompleted, userState);
        }
        
        private void OnReopenPurchaseOrderOperationCompleted(object arg) {
            if ((this.ReopenPurchaseOrderCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReopenPurchaseOrderCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument:AutoPostPo", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", ResponseElementName="AutoPostPo_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AutoPostPo(string purchaseOrderNo, bool rcv, bool inv) {
            this.Invoke("AutoPostPo", new object[] {
                        purchaseOrderNo,
                        rcv,
                        inv});
        }
        
        /// <remarks/>
        public void AutoPostPoAsync(string purchaseOrderNo, bool rcv, bool inv) {
            this.AutoPostPoAsync(purchaseOrderNo, rcv, inv, null);
        }
        
        /// <remarks/>
        public void AutoPostPoAsync(string purchaseOrderNo, bool rcv, bool inv, object userState) {
            if ((this.AutoPostPoOperationCompleted == null)) {
                this.AutoPostPoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAutoPostPoOperationCompleted);
            }
            this.InvokeAsync("AutoPostPo", new object[] {
                        purchaseOrderNo,
                        rcv,
                        inv}, this.AutoPostPoOperationCompleted, userState);
        }
        
        private void OnAutoPostPoOperationCompleted(object arg) {
            if ((this.AutoPostPoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AutoPostPoCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument:PoPrepareDocAlpha", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", ResponseElementName="PoPrepareDocAlpha_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void PoPrepareDocAlpha(string purchaseOrderNo, bool receiveReq, bool invReq) {
            this.Invoke("PoPrepareDocAlpha", new object[] {
                        purchaseOrderNo,
                        receiveReq,
                        invReq});
        }
        
        /// <remarks/>
        public void PoPrepareDocAlphaAsync(string purchaseOrderNo, bool receiveReq, bool invReq) {
            this.PoPrepareDocAlphaAsync(purchaseOrderNo, receiveReq, invReq, null);
        }
        
        /// <remarks/>
        public void PoPrepareDocAlphaAsync(string purchaseOrderNo, bool receiveReq, bool invReq, object userState) {
            if ((this.PoPrepareDocAlphaOperationCompleted == null)) {
                this.PoPrepareDocAlphaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPoPrepareDocAlphaOperationCompleted);
            }
            this.InvokeAsync("PoPrepareDocAlpha", new object[] {
                        purchaseOrderNo,
                        receiveReq,
                        invReq}, this.PoPrepareDocAlphaOperationCompleted, userState);
        }
        
        private void OnPoPrepareDocAlphaOperationCompleted(object arg) {
            if ((this.PoPrepareDocAlphaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PoPrepareDocAlphaCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument:RunAdjustCostReport", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", ResponseElementName="RunAdjustCostReport_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void RunAdjustCostReport(string itemNoFilter, string itemCategoryFilter) {
            this.Invoke("RunAdjustCostReport", new object[] {
                        itemNoFilter,
                        itemCategoryFilter});
        }
        
        /// <remarks/>
        public void RunAdjustCostReportAsync(string itemNoFilter, string itemCategoryFilter) {
            this.RunAdjustCostReportAsync(itemNoFilter, itemCategoryFilter, null);
        }
        
        /// <remarks/>
        public void RunAdjustCostReportAsync(string itemNoFilter, string itemCategoryFilter, object userState) {
            if ((this.RunAdjustCostReportOperationCompleted == null)) {
                this.RunAdjustCostReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRunAdjustCostReportOperationCompleted);
            }
            this.InvokeAsync("RunAdjustCostReport", new object[] {
                        itemNoFilter,
                        itemCategoryFilter}, this.RunAdjustCostReportOperationCompleted, userState);
        }
        
        private void OnRunAdjustCostReportOperationCompleted(object arg) {
            if ((this.RunAdjustCostReportCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RunAdjustCostReportCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument:InsertPoGlLine", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", ResponseElementName="InsertPoGlLine_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public int InsertPoGlLine(string docNo, string itemNo, string itemDesc, decimal itemUnitCost, decimal itemQty) {
            object[] results = this.Invoke("InsertPoGlLine", new object[] {
                        docNo,
                        itemNo,
                        itemDesc,
                        itemUnitCost,
                        itemQty});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void InsertPoGlLineAsync(string docNo, string itemNo, string itemDesc, decimal itemUnitCost, decimal itemQty) {
            this.InsertPoGlLineAsync(docNo, itemNo, itemDesc, itemUnitCost, itemQty, null);
        }
        
        /// <remarks/>
        public void InsertPoGlLineAsync(string docNo, string itemNo, string itemDesc, decimal itemUnitCost, decimal itemQty, object userState) {
            if ((this.InsertPoGlLineOperationCompleted == null)) {
                this.InsertPoGlLineOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertPoGlLineOperationCompleted);
            }
            this.InvokeAsync("InsertPoGlLine", new object[] {
                        docNo,
                        itemNo,
                        itemDesc,
                        itemUnitCost,
                        itemQty}, this.InsertPoGlLineOperationCompleted, userState);
        }
        
        private void OnInsertPoGlLineOperationCompleted(object arg) {
            if ((this.InsertPoGlLineCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertPoGlLineCompleted(this, new InsertPoGlLineCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument:ReleasePurchaseOrder", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", ResponseElementName="ReleasePurchaseOrder_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ReleasePurchaseOrder(string purchaseOrderNo) {
            this.Invoke("ReleasePurchaseOrder", new object[] {
                        purchaseOrderNo});
        }
        
        /// <remarks/>
        public void ReleasePurchaseOrderAsync(string purchaseOrderNo) {
            this.ReleasePurchaseOrderAsync(purchaseOrderNo, null);
        }
        
        /// <remarks/>
        public void ReleasePurchaseOrderAsync(string purchaseOrderNo, object userState) {
            if ((this.ReleasePurchaseOrderOperationCompleted == null)) {
                this.ReleasePurchaseOrderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReleasePurchaseOrderOperationCompleted);
            }
            this.InvokeAsync("ReleasePurchaseOrder", new object[] {
                        purchaseOrderNo}, this.ReleasePurchaseOrderOperationCompleted, userState);
        }
        
        private void OnReleasePurchaseOrderOperationCompleted(object arg) {
            if ((this.ReleasePurchaseOrderCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReleasePurchaseOrderCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument:UpdateBizStatusPO", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", ResponseElementName="UpdateBizStatusPO_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/AutoPostDocument", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateBizStatusPO(string purchOrderNo, [System.Xml.Serialization.XmlElementAttribute(DataType="date")] System.DateTime date, [System.Xml.Serialization.XmlElementAttribute(DataType="time")] System.DateTime time, string status) {
            this.Invoke("UpdateBizStatusPO", new object[] {
                        purchOrderNo,
                        date,
                        time,
                        status});
        }
        
        /// <remarks/>
        public void UpdateBizStatusPOAsync(string purchOrderNo, System.DateTime date, System.DateTime time, string status) {
            this.UpdateBizStatusPOAsync(purchOrderNo, date, time, status, null);
        }
        
        /// <remarks/>
        public void UpdateBizStatusPOAsync(string purchOrderNo, System.DateTime date, System.DateTime time, string status, object userState) {
            if ((this.UpdateBizStatusPOOperationCompleted == null)) {
                this.UpdateBizStatusPOOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateBizStatusPOOperationCompleted);
            }
            this.InvokeAsync("UpdateBizStatusPO", new object[] {
                        purchOrderNo,
                        date,
                        time,
                        status}, this.UpdateBizStatusPOOperationCompleted, userState);
        }
        
        private void OnUpdateBizStatusPOOperationCompleted(object arg) {
            if ((this.UpdateBizStatusPOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateBizStatusPOCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void ReopenPurchaseOrderCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void AutoPostPoCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void PoPrepareDocAlphaCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void RunAdjustCostReportCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void InsertPoGlLineCompletedEventHandler(object sender, InsertPoGlLineCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertPoGlLineCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertPoGlLineCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void ReleasePurchaseOrderCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void UpdateBizStatusPOCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591