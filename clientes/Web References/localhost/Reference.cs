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

namespace clientes.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService1", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback retornaClienteOperationCompleted;
        
        private System.Threading.SendOrPostCallback retornaClientesOperationCompleted;
        
        private System.Threading.SendOrPostCallback salvaClienteOperationCompleted;
        
        private System.Threading.SendOrPostCallback salvaContaOperationCompleted;
        
        private System.Threading.SendOrPostCallback RetornaContaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::clientes.Properties.Settings.Default.clientes_localhost_Service1;
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
        public event retornaClienteCompletedEventHandler retornaClienteCompleted;
        
        /// <remarks/>
        public event retornaClientesCompletedEventHandler retornaClientesCompleted;
        
        /// <remarks/>
        public event salvaClienteCompletedEventHandler salvaClienteCompleted;
        
        /// <remarks/>
        public event salvaContaCompletedEventHandler salvaContaCompleted;
        
        /// <remarks/>
        public event RetornaContaCompletedEventHandler RetornaContaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/retornaCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Cliente retornaCliente() {
            object[] results = this.Invoke("retornaCliente", new object[0]);
            return ((Cliente)(results[0]));
        }
        
        /// <remarks/>
        public void retornaClienteAsync() {
            this.retornaClienteAsync(null);
        }
        
        /// <remarks/>
        public void retornaClienteAsync(object userState) {
            if ((this.retornaClienteOperationCompleted == null)) {
                this.retornaClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnretornaClienteOperationCompleted);
            }
            this.InvokeAsync("retornaCliente", new object[0], this.retornaClienteOperationCompleted, userState);
        }
        
        private void OnretornaClienteOperationCompleted(object arg) {
            if ((this.retornaClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.retornaClienteCompleted(this, new retornaClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/retornaClientes", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.basica")]
        public Cliente[] retornaClientes() {
            object[] results = this.Invoke("retornaClientes", new object[0]);
            return ((Cliente[])(results[0]));
        }
        
        /// <remarks/>
        public void retornaClientesAsync() {
            this.retornaClientesAsync(null);
        }
        
        /// <remarks/>
        public void retornaClientesAsync(object userState) {
            if ((this.retornaClientesOperationCompleted == null)) {
                this.retornaClientesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnretornaClientesOperationCompleted);
            }
            this.InvokeAsync("retornaClientes", new object[0], this.retornaClientesOperationCompleted, userState);
        }
        
        private void OnretornaClientesOperationCompleted(object arg) {
            if ((this.retornaClientesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.retornaClientesCompleted(this, new retornaClientesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/salvaCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void salvaCliente([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Cliente cliente) {
            this.Invoke("salvaCliente", new object[] {
                        cliente});
        }
        
        /// <remarks/>
        public void salvaClienteAsync(Cliente cliente) {
            this.salvaClienteAsync(cliente, null);
        }
        
        /// <remarks/>
        public void salvaClienteAsync(Cliente cliente, object userState) {
            if ((this.salvaClienteOperationCompleted == null)) {
                this.salvaClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsalvaClienteOperationCompleted);
            }
            this.InvokeAsync("salvaCliente", new object[] {
                        cliente}, this.salvaClienteOperationCompleted, userState);
        }
        
        private void OnsalvaClienteOperationCompleted(object arg) {
            if ((this.salvaClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.salvaClienteCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/salvaConta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void salvaConta([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Conta conta) {
            this.Invoke("salvaConta", new object[] {
                        conta});
        }
        
        /// <remarks/>
        public void salvaContaAsync(Conta conta) {
            this.salvaContaAsync(conta, null);
        }
        
        /// <remarks/>
        public void salvaContaAsync(Conta conta, object userState) {
            if ((this.salvaContaOperationCompleted == null)) {
                this.salvaContaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsalvaContaOperationCompleted);
            }
            this.InvokeAsync("salvaConta", new object[] {
                        conta}, this.salvaContaOperationCompleted, userState);
        }
        
        private void OnsalvaContaOperationCompleted(object arg) {
            if ((this.salvaContaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.salvaContaCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/RetornaConta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Conta RetornaConta() {
            object[] results = this.Invoke("RetornaConta", new object[0]);
            return ((Conta)(results[0]));
        }
        
        /// <remarks/>
        public void RetornaContaAsync() {
            this.RetornaContaAsync(null);
        }
        
        /// <remarks/>
        public void RetornaContaAsync(object userState) {
            if ((this.RetornaContaOperationCompleted == null)) {
                this.RetornaContaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRetornaContaOperationCompleted);
            }
            this.InvokeAsync("RetornaConta", new object[0], this.RetornaContaOperationCompleted, userState);
        }
        
        private void OnRetornaContaOperationCompleted(object arg) {
            if ((this.RetornaContaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RetornaContaCompleted(this, new RetornaContaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.basica")]
    public partial class Cliente {
        
        private string cpfField;
        
        private string emailField;
        
        private Endereco enderecoField;
        
        private int idClienteField;
        
        private bool idClienteFieldSpecified;
        
        private string nomeField;
        
        private string telefoneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Cpf {
            get {
                return this.cpfField;
            }
            set {
                this.cpfField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Endereco Endereco {
            get {
                return this.enderecoField;
            }
            set {
                this.enderecoField = value;
            }
        }
        
        /// <remarks/>
        public int IdCliente {
            get {
                return this.idClienteField;
            }
            set {
                this.idClienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdClienteSpecified {
            get {
                return this.idClienteFieldSpecified;
            }
            set {
                this.idClienteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Telefone {
            get {
                return this.telefoneField;
            }
            set {
                this.telefoneField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.basica")]
    public partial class Endereco {
        
        private string bairroField;
        
        private string cepField;
        
        private string cidadeField;
        
        private string complementoField;
        
        private int endereco_idField;
        
        private bool endereco_idFieldSpecified;
        
        private string numeroField;
        
        private string ruaField;
        
        private string ufField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Bairro {
            get {
                return this.bairroField;
            }
            set {
                this.bairroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Cep {
            get {
                return this.cepField;
            }
            set {
                this.cepField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Cidade {
            get {
                return this.cidadeField;
            }
            set {
                this.cidadeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Complemento {
            get {
                return this.complementoField;
            }
            set {
                this.complementoField = value;
            }
        }
        
        /// <remarks/>
        public int Endereco_id {
            get {
                return this.endereco_idField;
            }
            set {
                this.endereco_idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Endereco_idSpecified {
            get {
                return this.endereco_idFieldSpecified;
            }
            set {
                this.endereco_idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Numero {
            get {
                return this.numeroField;
            }
            set {
                this.numeroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Rua {
            get {
                return this.ruaField;
            }
            set {
                this.ruaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Uf {
            get {
                return this.ufField;
            }
            set {
                this.ufField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.basica")]
    public partial class Agencia {
        
        private Endereco enderecoField;
        
        private string nomeField;
        
        private int numeroAgenciaField;
        
        private bool numeroAgenciaFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Endereco Endereco {
            get {
                return this.enderecoField;
            }
            set {
                this.enderecoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        public int NumeroAgencia {
            get {
                return this.numeroAgenciaField;
            }
            set {
                this.numeroAgenciaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumeroAgenciaSpecified {
            get {
                return this.numeroAgenciaFieldSpecified;
            }
            set {
                this.numeroAgenciaFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.basica")]
    public partial class Conta {
        
        private Cliente clienteField;
        
        private System.DateTime dataCriacaoField;
        
        private bool dataCriacaoFieldSpecified;
        
        private Agencia numeroAgenciaField;
        
        private int numeroContaField;
        
        private bool numeroContaFieldSpecified;
        
        private decimal saldoField;
        
        private bool saldoFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Cliente Cliente {
            get {
                return this.clienteField;
            }
            set {
                this.clienteField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DataCriacao {
            get {
                return this.dataCriacaoField;
            }
            set {
                this.dataCriacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataCriacaoSpecified {
            get {
                return this.dataCriacaoFieldSpecified;
            }
            set {
                this.dataCriacaoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Agencia NumeroAgencia {
            get {
                return this.numeroAgenciaField;
            }
            set {
                this.numeroAgenciaField = value;
            }
        }
        
        /// <remarks/>
        public int NumeroConta {
            get {
                return this.numeroContaField;
            }
            set {
                this.numeroContaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumeroContaSpecified {
            get {
                return this.numeroContaFieldSpecified;
            }
            set {
                this.numeroContaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Saldo {
            get {
                return this.saldoField;
            }
            set {
                this.saldoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SaldoSpecified {
            get {
                return this.saldoFieldSpecified;
            }
            set {
                this.saldoFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void retornaClienteCompletedEventHandler(object sender, retornaClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class retornaClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal retornaClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Cliente Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Cliente)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void retornaClientesCompletedEventHandler(object sender, retornaClientesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class retornaClientesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal retornaClientesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Cliente[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Cliente[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void salvaClienteCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void salvaContaCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void RetornaContaCompletedEventHandler(object sender, RetornaContaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RetornaContaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RetornaContaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Conta Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Conta)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591