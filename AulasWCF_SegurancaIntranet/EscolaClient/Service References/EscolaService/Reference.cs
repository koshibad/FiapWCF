﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EscolaClient.EscolaService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Disciplina", Namespace="http://schemas.datacontract.org/2004/07/EscolaEntities")]
    [System.SerializableAttribute()]
    public partial class Disciplina : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Aluno", Namespace="http://schemas.datacontract.org/2004/07/EscolaEntities")]
    [System.SerializableAttribute()]
    public partial class Aluno : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Nota", Namespace="http://schemas.datacontract.org/2004/07/EscolaEntities")]
    [System.SerializableAttribute()]
    public partial class Nota : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int AlunoIdField;
        
        private int DisciplinaIdField;
        
        private decimal PontosField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int AlunoId {
            get {
                return this.AlunoIdField;
            }
            set {
                if ((this.AlunoIdField.Equals(value) != true)) {
                    this.AlunoIdField = value;
                    this.RaisePropertyChanged("AlunoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int DisciplinaId {
            get {
                return this.DisciplinaIdField;
            }
            set {
                if ((this.DisciplinaIdField.Equals(value) != true)) {
                    this.DisciplinaIdField = value;
                    this.RaisePropertyChanged("DisciplinaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal Pontos {
            get {
                return this.PontosField;
            }
            set {
                if ((this.PontosField.Equals(value) != true)) {
                    this.PontosField = value;
                    this.RaisePropertyChanged("Pontos");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ErroProcessamento", Namespace="http://schemas.datacontract.org/2004/07/EscolaService")]
    [System.SerializableAttribute()]
    public partial class ErroProcessamento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessagemField;
        
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
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Messagem {
            get {
                return this.MessagemField;
            }
            set {
                if ((object.ReferenceEquals(this.MessagemField, value) != true)) {
                    this.MessagemField = value;
                    this.RaisePropertyChanged("Messagem");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EscolaService.INotasService")]
    public interface INotasService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotasService/GetDisciplinas", ReplyAction="http://tempuri.org/INotasService/GetDisciplinasResponse")]
        System.Collections.Generic.List<EscolaClient.EscolaService.Disciplina> GetDisciplinas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotasService/GetDisciplinas", ReplyAction="http://tempuri.org/INotasService/GetDisciplinasResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<EscolaClient.EscolaService.Disciplina>> GetDisciplinasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotasService/GetAlunos", ReplyAction="http://tempuri.org/INotasService/GetAlunosResponse")]
        System.Collections.Generic.List<EscolaClient.EscolaService.Aluno> GetAlunos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotasService/GetAlunos", ReplyAction="http://tempuri.org/INotasService/GetAlunosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<EscolaClient.EscolaService.Aluno>> GetAlunosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotasService/EnviarNotas", ReplyAction="http://tempuri.org/INotasService/EnviarNotasResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EscolaClient.EscolaService.ErroProcessamento), Action="http://tempuri.org/INotasService/EnviarNotasErroProcessamentoFault", Name="ErroProcessamento", Namespace="http://schemas.datacontract.org/2004/07/EscolaService")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void EnviarNotas(EscolaClient.EscolaService.Nota nota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotasService/EnviarNotas", ReplyAction="http://tempuri.org/INotasService/EnviarNotasResponse")]
        System.Threading.Tasks.Task EnviarNotasAsync(EscolaClient.EscolaService.Nota nota);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INotasServiceChannel : EscolaClient.EscolaService.INotasService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NotasServiceClient : System.ServiceModel.ClientBase<EscolaClient.EscolaService.INotasService>, EscolaClient.EscolaService.INotasService {
        
        public NotasServiceClient() {
        }
        
        public NotasServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NotasServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NotasServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NotasServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<EscolaClient.EscolaService.Disciplina> GetDisciplinas() {
            return base.Channel.GetDisciplinas();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<EscolaClient.EscolaService.Disciplina>> GetDisciplinasAsync() {
            return base.Channel.GetDisciplinasAsync();
        }
        
        public System.Collections.Generic.List<EscolaClient.EscolaService.Aluno> GetAlunos() {
            return base.Channel.GetAlunos();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<EscolaClient.EscolaService.Aluno>> GetAlunosAsync() {
            return base.Channel.GetAlunosAsync();
        }
        
        public void EnviarNotas(EscolaClient.EscolaService.Nota nota) {
            base.Channel.EnviarNotas(nota);
        }
        
        public System.Threading.Tasks.Task EnviarNotasAsync(EscolaClient.EscolaService.Nota nota) {
            return base.Channel.EnviarNotasAsync(nota);
        }
    }
}