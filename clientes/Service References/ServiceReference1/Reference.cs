﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clientes.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.basica")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CpfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private clientes.ServiceReference1.Endereco EnderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefoneField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cpf {
            get {
                return this.CpfField;
            }
            set {
                if ((object.ReferenceEquals(this.CpfField, value) != true)) {
                    this.CpfField = value;
                    this.RaisePropertyChanged("Cpf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public clientes.ServiceReference1.Endereco Endereco {
            get {
                return this.EnderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoField, value) != true)) {
                    this.EnderecoField = value;
                    this.RaisePropertyChanged("Endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCliente {
            get {
                return this.IdClienteField;
            }
            set {
                if ((this.IdClienteField.Equals(value) != true)) {
                    this.IdClienteField = value;
                    this.RaisePropertyChanged("IdCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefone {
            get {
                return this.TelefoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefoneField, value) != true)) {
                    this.TelefoneField = value;
                    this.RaisePropertyChanged("Telefone");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Endereco", Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.basica")]
    [System.SerializableAttribute()]
    public partial class Endereco : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BairroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CepField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ComplementoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdEnderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RuaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UfField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Bairro {
            get {
                return this.BairroField;
            }
            set {
                if ((object.ReferenceEquals(this.BairroField, value) != true)) {
                    this.BairroField = value;
                    this.RaisePropertyChanged("Bairro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cep {
            get {
                return this.CepField;
            }
            set {
                if ((object.ReferenceEquals(this.CepField, value) != true)) {
                    this.CepField = value;
                    this.RaisePropertyChanged("Cep");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cidade {
            get {
                return this.CidadeField;
            }
            set {
                if ((object.ReferenceEquals(this.CidadeField, value) != true)) {
                    this.CidadeField = value;
                    this.RaisePropertyChanged("Cidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Complemento {
            get {
                return this.ComplementoField;
            }
            set {
                if ((object.ReferenceEquals(this.ComplementoField, value) != true)) {
                    this.ComplementoField = value;
                    this.RaisePropertyChanged("Complemento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdEndereco {
            get {
                return this.IdEnderecoField;
            }
            set {
                if ((this.IdEnderecoField.Equals(value) != true)) {
                    this.IdEnderecoField = value;
                    this.RaisePropertyChanged("IdEndereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Numero {
            get {
                return this.NumeroField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroField, value) != true)) {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rua {
            get {
                return this.RuaField;
            }
            set {
                if ((object.ReferenceEquals(this.RuaField, value) != true)) {
                    this.RuaField = value;
                    this.RaisePropertyChanged("Rua");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Uf {
            get {
                return this.UfField;
            }
            set {
                if ((object.ReferenceEquals(this.UfField, value) != true)) {
                    this.UfField = value;
                    this.RaisePropertyChanged("Uf");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Agencia", Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.basica")]
    [System.SerializableAttribute()]
    public partial class Agencia : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private clientes.ServiceReference1.Endereco EnderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumeroAgenciaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public clientes.ServiceReference1.Endereco Endereco {
            get {
                return this.EnderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoField, value) != true)) {
                    this.EnderecoField = value;
                    this.RaisePropertyChanged("Endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumeroAgencia {
            get {
                return this.NumeroAgenciaField;
            }
            set {
                if ((this.NumeroAgenciaField.Equals(value) != true)) {
                    this.NumeroAgenciaField = value;
                    this.RaisePropertyChanged("NumeroAgencia");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Conta", Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.basica")]
    [System.SerializableAttribute()]
    public partial class Conta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private clientes.ServiceReference1.Agencia AgenciaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private clientes.ServiceReference1.Cliente ClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataCriacaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumeroContaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal SaldoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public clientes.ServiceReference1.Agencia Agencia {
            get {
                return this.AgenciaField;
            }
            set {
                if ((object.ReferenceEquals(this.AgenciaField, value) != true)) {
                    this.AgenciaField = value;
                    this.RaisePropertyChanged("Agencia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public clientes.ServiceReference1.Cliente Cliente {
            get {
                return this.ClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.ClienteField, value) != true)) {
                    this.ClienteField = value;
                    this.RaisePropertyChanged("Cliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataCriacao {
            get {
                return this.DataCriacaoField;
            }
            set {
                if ((this.DataCriacaoField.Equals(value) != true)) {
                    this.DataCriacaoField = value;
                    this.RaisePropertyChanged("DataCriacao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumeroConta {
            get {
                return this.NumeroContaField;
            }
            set {
                if ((this.NumeroContaField.Equals(value) != true)) {
                    this.NumeroContaField = value;
                    this.RaisePropertyChanged("NumeroConta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Saldo {
            get {
                return this.SaldoField;
            }
            set {
                if ((this.SaldoField.Equals(value) != true)) {
                    this.SaldoField = value;
                    this.RaisePropertyChanged("Saldo");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Emprestimo", Namespace="http://schemas.datacontract.org/2004/07/Biblioteca.basica")]
    [System.SerializableAttribute()]
    public partial class Emprestimo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataCriacaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdEmprestimoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private clientes.ServiceReference1.Conta NumeroContaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantidadeParcelaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TaxaJurosMensalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ValorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataCriacao {
            get {
                return this.DataCriacaoField;
            }
            set {
                if ((this.DataCriacaoField.Equals(value) != true)) {
                    this.DataCriacaoField = value;
                    this.RaisePropertyChanged("DataCriacao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdEmprestimo {
            get {
                return this.IdEmprestimoField;
            }
            set {
                if ((this.IdEmprestimoField.Equals(value) != true)) {
                    this.IdEmprestimoField = value;
                    this.RaisePropertyChanged("IdEmprestimo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public clientes.ServiceReference1.Conta NumeroConta {
            get {
                return this.NumeroContaField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroContaField, value) != true)) {
                    this.NumeroContaField = value;
                    this.RaisePropertyChanged("NumeroConta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int QuantidadeParcela {
            get {
                return this.QuantidadeParcelaField;
            }
            set {
                if ((this.QuantidadeParcelaField.Equals(value) != true)) {
                    this.QuantidadeParcelaField = value;
                    this.RaisePropertyChanged("QuantidadeParcela");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TaxaJurosMensal {
            get {
                return this.TaxaJurosMensalField;
            }
            set {
                if ((this.TaxaJurosMensalField.Equals(value) != true)) {
                    this.TaxaJurosMensalField = value;
                    this.RaisePropertyChanged("TaxaJurosMensal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Valor {
            get {
                return this.ValorField;
            }
            set {
                if ((this.ValorField.Equals(value) != true)) {
                    this.ValorField = value;
                    this.RaisePropertyChanged("Valor");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PesquisaCliente", ReplyAction="http://tempuri.org/IService1/PesquisaClienteResponse")]
        clientes.ServiceReference1.Cliente[] PesquisaCliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PesquisaCliente", ReplyAction="http://tempuri.org/IService1/PesquisaClienteResponse")]
        System.Threading.Tasks.Task<clientes.ServiceReference1.Cliente[]> PesquisaClienteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PesquisaAgencia", ReplyAction="http://tempuri.org/IService1/PesquisaAgenciaResponse")]
        clientes.ServiceReference1.Agencia[] PesquisaAgencia();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PesquisaAgencia", ReplyAction="http://tempuri.org/IService1/PesquisaAgenciaResponse")]
        System.Threading.Tasks.Task<clientes.ServiceReference1.Agencia[]> PesquisaAgenciaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PesquisaConta", ReplyAction="http://tempuri.org/IService1/PesquisaContaResponse")]
        clientes.ServiceReference1.Conta[] PesquisaConta();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PesquisaConta", ReplyAction="http://tempuri.org/IService1/PesquisaContaResponse")]
        System.Threading.Tasks.Task<clientes.ServiceReference1.Conta[]> PesquisaContaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SalvarConta", ReplyAction="http://tempuri.org/IService1/SalvarContaResponse")]
        void SalvarConta(clientes.ServiceReference1.Conta conta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SalvarConta", ReplyAction="http://tempuri.org/IService1/SalvarContaResponse")]
        System.Threading.Tasks.Task SalvarContaAsync(clientes.ServiceReference1.Conta conta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PesquisaContaPorNumeroConta", ReplyAction="http://tempuri.org/IService1/PesquisaContaPorNumeroContaResponse")]
        clientes.ServiceReference1.Conta PesquisaContaPorNumeroConta(int numeroConta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PesquisaContaPorNumeroConta", ReplyAction="http://tempuri.org/IService1/PesquisaContaPorNumeroContaResponse")]
        System.Threading.Tasks.Task<clientes.ServiceReference1.Conta> PesquisaContaPorNumeroContaAsync(int numeroConta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SalvarEmprestimo", ReplyAction="http://tempuri.org/IService1/SalvarEmprestimoResponse")]
        void SalvarEmprestimo(clientes.ServiceReference1.Emprestimo emprestimo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SalvarEmprestimo", ReplyAction="http://tempuri.org/IService1/SalvarEmprestimoResponse")]
        System.Threading.Tasks.Task SalvarEmprestimoAsync(clientes.ServiceReference1.Emprestimo emprestimo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : clientes.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<clientes.ServiceReference1.IService1>, clientes.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public clientes.ServiceReference1.Cliente[] PesquisaCliente() {
            return base.Channel.PesquisaCliente();
        }
        
        public System.Threading.Tasks.Task<clientes.ServiceReference1.Cliente[]> PesquisaClienteAsync() {
            return base.Channel.PesquisaClienteAsync();
        }
        
        public clientes.ServiceReference1.Agencia[] PesquisaAgencia() {
            return base.Channel.PesquisaAgencia();
        }
        
        public System.Threading.Tasks.Task<clientes.ServiceReference1.Agencia[]> PesquisaAgenciaAsync() {
            return base.Channel.PesquisaAgenciaAsync();
        }
        
        public clientes.ServiceReference1.Conta[] PesquisaConta() {
            return base.Channel.PesquisaConta();
        }
        
        public System.Threading.Tasks.Task<clientes.ServiceReference1.Conta[]> PesquisaContaAsync() {
            return base.Channel.PesquisaContaAsync();
        }
        
        public void SalvarConta(clientes.ServiceReference1.Conta conta) {
            base.Channel.SalvarConta(conta);
        }
        
        public System.Threading.Tasks.Task SalvarContaAsync(clientes.ServiceReference1.Conta conta) {
            return base.Channel.SalvarContaAsync(conta);
        }
        
        public clientes.ServiceReference1.Conta PesquisaContaPorNumeroConta(int numeroConta) {
            return base.Channel.PesquisaContaPorNumeroConta(numeroConta);
        }
        
        public System.Threading.Tasks.Task<clientes.ServiceReference1.Conta> PesquisaContaPorNumeroContaAsync(int numeroConta) {
            return base.Channel.PesquisaContaPorNumeroContaAsync(numeroConta);
        }
        
        public void SalvarEmprestimo(clientes.ServiceReference1.Emprestimo emprestimo) {
            base.Channel.SalvarEmprestimo(emprestimo);
        }
        
        public System.Threading.Tasks.Task SalvarEmprestimoAsync(clientes.ServiceReference1.Emprestimo emprestimo) {
            return base.Channel.SalvarEmprestimoAsync(emprestimo);
        }
    }
}
