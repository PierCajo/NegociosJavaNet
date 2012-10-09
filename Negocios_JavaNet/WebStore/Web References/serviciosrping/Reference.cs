﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.269
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.269.
// 
#pragma warning disable 1591

namespace WebStore.serviciosrping {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="PersonaServiceImplServiceSoapBinding", Namespace="http://service.webpersona.reniec.pe/")]
    public partial class PersonaServiceImplService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback validaPersonaInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback validaPersonaOperationCompleted;
        
        private System.Threading.SendOrPostCallback validaPersonaInfoTestOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public PersonaServiceImplService() {
            this.Url = global::WebStore.Properties.Settings.Default.WebStore_serviciosrping_PersonaServiceImplService;
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
        public event validaPersonaInfoCompletedEventHandler validaPersonaInfoCompleted;
        
        /// <remarks/>
        public event validaPersonaCompletedEventHandler validaPersonaCompleted;
        
        /// <remarks/>
        public event validaPersonaInfoTestCompletedEventHandler validaPersonaInfoTestCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.webpersona.reniec.pe/", ResponseNamespace="http://service.webpersona.reniec.pe/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public persona[] validaPersonaInfo([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string dni) {
            object[] results = this.Invoke("validaPersonaInfo", new object[] {
                        dni});
            return ((persona[])(results[0]));
        }
        
        /// <remarks/>
        public void validaPersonaInfoAsync(string dni) {
            this.validaPersonaInfoAsync(dni, null);
        }
        
        /// <remarks/>
        public void validaPersonaInfoAsync(string dni, object userState) {
            if ((this.validaPersonaInfoOperationCompleted == null)) {
                this.validaPersonaInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnvalidaPersonaInfoOperationCompleted);
            }
            this.InvokeAsync("validaPersonaInfo", new object[] {
                        dni}, this.validaPersonaInfoOperationCompleted, userState);
        }
        
        private void OnvalidaPersonaInfoOperationCompleted(object arg) {
            if ((this.validaPersonaInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.validaPersonaInfoCompleted(this, new validaPersonaInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.webpersona.reniec.pe/", ResponseNamespace="http://service.webpersona.reniec.pe/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string validaPersona([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string dni) {
            object[] results = this.Invoke("validaPersona", new object[] {
                        dni});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void validaPersonaAsync(string dni) {
            this.validaPersonaAsync(dni, null);
        }
        
        /// <remarks/>
        public void validaPersonaAsync(string dni, object userState) {
            if ((this.validaPersonaOperationCompleted == null)) {
                this.validaPersonaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnvalidaPersonaOperationCompleted);
            }
            this.InvokeAsync("validaPersona", new object[] {
                        dni}, this.validaPersonaOperationCompleted, userState);
        }
        
        private void OnvalidaPersonaOperationCompleted(object arg) {
            if ((this.validaPersonaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.validaPersonaCompleted(this, new validaPersonaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.webpersona.reniec.pe/", ResponseNamespace="http://service.webpersona.reniec.pe/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public persona[] validaPersonaInfoTest([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string dni) {
            object[] results = this.Invoke("validaPersonaInfoTest", new object[] {
                        dni});
            return ((persona[])(results[0]));
        }
        
        /// <remarks/>
        public void validaPersonaInfoTestAsync(string dni) {
            this.validaPersonaInfoTestAsync(dni, null);
        }
        
        /// <remarks/>
        public void validaPersonaInfoTestAsync(string dni, object userState) {
            if ((this.validaPersonaInfoTestOperationCompleted == null)) {
                this.validaPersonaInfoTestOperationCompleted = new System.Threading.SendOrPostCallback(this.OnvalidaPersonaInfoTestOperationCompleted);
            }
            this.InvokeAsync("validaPersonaInfoTest", new object[] {
                        dni}, this.validaPersonaInfoTestOperationCompleted, userState);
        }
        
        private void OnvalidaPersonaInfoTestOperationCompleted(object arg) {
            if ((this.validaPersonaInfoTestCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.validaPersonaInfoTestCompleted(this, new validaPersonaInfoTestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.webpersona.reniec.pe/")]
    public partial class persona {
        
        private string apellidosField;
        
        private string direccionField;
        
        private string dniField;
        
        private int estadoField;
        
        private string nombresField;
        
        private string telefonoField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string apellidos {
            get {
                return this.apellidosField;
            }
            set {
                this.apellidosField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string dni {
            get {
                return this.dniField;
            }
            set {
                this.dniField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombres {
            get {
                return this.nombresField;
            }
            set {
                this.nombresField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void validaPersonaInfoCompletedEventHandler(object sender, validaPersonaInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class validaPersonaInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal validaPersonaInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public persona[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((persona[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void validaPersonaCompletedEventHandler(object sender, validaPersonaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class validaPersonaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal validaPersonaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void validaPersonaInfoTestCompletedEventHandler(object sender, validaPersonaInfoTestCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class validaPersonaInfoTestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal validaPersonaInfoTestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public persona[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((persona[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591