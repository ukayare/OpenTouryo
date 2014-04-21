﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.18052
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// このソース コードは Microsoft.VSDesigner、バージョン 4.0.30319.18052 によって自動生成されました。
// 
#pragma warning disable 1591

namespace AuthServiceClient.ASPNETWebService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceForAuthSoap", Namespace="http://tempuri.org/")]
    public partial class ServiceForAuth : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetChallengeOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAuthTicketOperationCompleted;
        
        private System.Threading.SendOrPostCallback ValidateAuthTicketOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiceForAuth() {
            this.Url = global::AuthServiceClient.Properties.Settings.Default.AuthServiceClient_ASPNETWebService_ServiceForAuth;
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
        public event GetChallengeCompletedEventHandler GetChallengeCompleted;
        
        /// <remarks/>
        public event GetAuthTicketCompletedEventHandler GetAuthTicketCompleted;
        
        /// <remarks/>
        public event ValidateAuthTicketCompletedEventHandler ValidateAuthTicketCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetChallenge", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetChallenge() {
            object[] results = this.Invoke("GetChallenge", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetChallengeAsync() {
            this.GetChallengeAsync(null);
        }
        
        /// <remarks/>
        public void GetChallengeAsync(object userState) {
            if ((this.GetChallengeOperationCompleted == null)) {
                this.GetChallengeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetChallengeOperationCompleted);
            }
            this.InvokeAsync("GetChallenge", new object[0], this.GetChallengeOperationCompleted, userState);
        }
        
        private void OnGetChallengeOperationCompleted(object arg) {
            if ((this.GetChallengeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetChallengeCompleted(this, new GetChallengeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAuthTicket", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAuthTicket(string encUid, string encPwd) {
            object[] results = this.Invoke("GetAuthTicket", new object[] {
                        encUid,
                        encPwd});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAuthTicketAsync(string encUid, string encPwd) {
            this.GetAuthTicketAsync(encUid, encPwd, null);
        }
        
        /// <remarks/>
        public void GetAuthTicketAsync(string encUid, string encPwd, object userState) {
            if ((this.GetAuthTicketOperationCompleted == null)) {
                this.GetAuthTicketOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAuthTicketOperationCompleted);
            }
            this.InvokeAsync("GetAuthTicket", new object[] {
                        encUid,
                        encPwd}, this.GetAuthTicketOperationCompleted, userState);
        }
        
        private void OnGetAuthTicketOperationCompleted(object arg) {
            if ((this.GetAuthTicketCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAuthTicketCompleted(this, new GetAuthTicketCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ValidateAuthTicket", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ValidateAuthTicket(string authTicket) {
            object[] results = this.Invoke("ValidateAuthTicket", new object[] {
                        authTicket});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void ValidateAuthTicketAsync(string authTicket) {
            this.ValidateAuthTicketAsync(authTicket, null);
        }
        
        /// <remarks/>
        public void ValidateAuthTicketAsync(string authTicket, object userState) {
            if ((this.ValidateAuthTicketOperationCompleted == null)) {
                this.ValidateAuthTicketOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidateAuthTicketOperationCompleted);
            }
            this.InvokeAsync("ValidateAuthTicket", new object[] {
                        authTicket}, this.ValidateAuthTicketOperationCompleted, userState);
        }
        
        private void OnValidateAuthTicketOperationCompleted(object arg) {
            if ((this.ValidateAuthTicketCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidateAuthTicketCompleted(this, new ValidateAuthTicketCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetChallengeCompletedEventHandler(object sender, GetChallengeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetChallengeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetChallengeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetAuthTicketCompletedEventHandler(object sender, GetAuthTicketCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAuthTicketCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAuthTicketCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void ValidateAuthTicketCompletedEventHandler(object sender, ValidateAuthTicketCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidateAuthTicketCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidateAuthTicketCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591