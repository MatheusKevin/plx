﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebLayerProject.ServiceAnuncio {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AnuncioDto", Namespace="http://schemas.datacontract.org/2004/07/BusinessLayer.DTO")]
    [System.SerializableAttribute()]
    public partial class AnuncioDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebLayerProject.ServiceAnuncio.CategoriaDto CategoriaDtoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebLayerProject.ServiceAnuncio.ComentarioDto[] ComentariosDtoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImagemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PrecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebLayerProject.ServiceAnuncio.UsuarioDto UsuarioDtoField;
        
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
        public WebLayerProject.ServiceAnuncio.CategoriaDto CategoriaDto {
            get {
                return this.CategoriaDtoField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriaDtoField, value) != true)) {
                    this.CategoriaDtoField = value;
                    this.RaisePropertyChanged("CategoriaDto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebLayerProject.ServiceAnuncio.ComentarioDto[] ComentariosDto {
            get {
                return this.ComentariosDtoField;
            }
            set {
                if ((object.ReferenceEquals(this.ComentariosDtoField, value) != true)) {
                    this.ComentariosDtoField = value;
                    this.RaisePropertyChanged("ComentariosDto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        public string Imagem {
            get {
                return this.ImagemField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagemField, value) != true)) {
                    this.ImagemField = value;
                    this.RaisePropertyChanged("Imagem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Preco {
            get {
                return this.PrecoField;
            }
            set {
                if ((this.PrecoField.Equals(value) != true)) {
                    this.PrecoField = value;
                    this.RaisePropertyChanged("Preco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titulo {
            get {
                return this.TituloField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloField, value) != true)) {
                    this.TituloField = value;
                    this.RaisePropertyChanged("Titulo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebLayerProject.ServiceAnuncio.UsuarioDto UsuarioDto {
            get {
                return this.UsuarioDtoField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioDtoField, value) != true)) {
                    this.UsuarioDtoField = value;
                    this.RaisePropertyChanged("UsuarioDto");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoriaDto", Namespace="http://schemas.datacontract.org/2004/07/BusinessLayer.DTO")]
    [System.SerializableAttribute()]
    public partial class CategoriaDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebLayerProject.ServiceAnuncio.AnuncioDto[] AnunciosDtoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebLayerProject.ServiceAnuncio.CategoriaDto[] CategoriasDtoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebLayerProject.ServiceAnuncio.AnuncioDto[] AnunciosDto {
            get {
                return this.AnunciosDtoField;
            }
            set {
                if ((object.ReferenceEquals(this.AnunciosDtoField, value) != true)) {
                    this.AnunciosDtoField = value;
                    this.RaisePropertyChanged("AnunciosDto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebLayerProject.ServiceAnuncio.CategoriaDto[] CategoriasDto {
            get {
                return this.CategoriasDtoField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriasDtoField, value) != true)) {
                    this.CategoriasDtoField = value;
                    this.RaisePropertyChanged("CategoriasDto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UsuarioDto", Namespace="http://schemas.datacontract.org/2004/07/BusinessLayer.DTO")]
    [System.SerializableAttribute()]
    public partial class UsuarioDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebLayerProject.ServiceAnuncio.AnuncioDto[] AnunciosDtoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebLayerProject.ServiceAnuncio.AvaliacaoDto[] AvaliacoesDtoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebLayerProject.ServiceAnuncio.ComentarioDto[] ComentariosDtoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContatoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SenhaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TelefoneField;
        
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
        public WebLayerProject.ServiceAnuncio.AnuncioDto[] AnunciosDto {
            get {
                return this.AnunciosDtoField;
            }
            set {
                if ((object.ReferenceEquals(this.AnunciosDtoField, value) != true)) {
                    this.AnunciosDtoField = value;
                    this.RaisePropertyChanged("AnunciosDto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebLayerProject.ServiceAnuncio.AvaliacaoDto[] AvaliacoesDto {
            get {
                return this.AvaliacoesDtoField;
            }
            set {
                if ((object.ReferenceEquals(this.AvaliacoesDtoField, value) != true)) {
                    this.AvaliacoesDtoField = value;
                    this.RaisePropertyChanged("AvaliacoesDto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebLayerProject.ServiceAnuncio.ComentarioDto[] ComentariosDto {
            get {
                return this.ComentariosDtoField;
            }
            set {
                if ((object.ReferenceEquals(this.ComentariosDtoField, value) != true)) {
                    this.ComentariosDtoField = value;
                    this.RaisePropertyChanged("ComentariosDto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contato {
            get {
                return this.ContatoField;
            }
            set {
                if ((object.ReferenceEquals(this.ContatoField, value) != true)) {
                    this.ContatoField = value;
                    this.RaisePropertyChanged("Contato");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Senha {
            get {
                return this.SenhaField;
            }
            set {
                if ((object.ReferenceEquals(this.SenhaField, value) != true)) {
                    this.SenhaField = value;
                    this.RaisePropertyChanged("Senha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Telefone {
            get {
                return this.TelefoneField;
            }
            set {
                if ((this.TelefoneField.Equals(value) != true)) {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ComentarioDto", Namespace="http://schemas.datacontract.org/2004/07/BusinessLayer.DTO")]
    [System.SerializableAttribute()]
    public partial class ComentarioDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebLayerProject.ServiceAnuncio.AnuncioDto AnuncioDtoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ConteudoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebLayerProject.ServiceAnuncio.UsuarioDto UsuarioDtoField;
        
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
        public WebLayerProject.ServiceAnuncio.AnuncioDto AnuncioDto {
            get {
                return this.AnuncioDtoField;
            }
            set {
                if ((object.ReferenceEquals(this.AnuncioDtoField, value) != true)) {
                    this.AnuncioDtoField = value;
                    this.RaisePropertyChanged("AnuncioDto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Conteudo {
            get {
                return this.ConteudoField;
            }
            set {
                if ((object.ReferenceEquals(this.ConteudoField, value) != true)) {
                    this.ConteudoField = value;
                    this.RaisePropertyChanged("Conteudo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebLayerProject.ServiceAnuncio.UsuarioDto UsuarioDto {
            get {
                return this.UsuarioDtoField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioDtoField, value) != true)) {
                    this.UsuarioDtoField = value;
                    this.RaisePropertyChanged("UsuarioDto");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AvaliacaoDto", Namespace="http://schemas.datacontract.org/2004/07/BusinessLayer.DTO")]
    [System.SerializableAttribute()]
    public partial class AvaliacaoDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double NotaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebLayerProject.ServiceAnuncio.UsuarioDto UsuarioDtoField;
        
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
        public double Nota {
            get {
                return this.NotaField;
            }
            set {
                if ((this.NotaField.Equals(value) != true)) {
                    this.NotaField = value;
                    this.RaisePropertyChanged("Nota");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebLayerProject.ServiceAnuncio.UsuarioDto UsuarioDto {
            get {
                return this.UsuarioDtoField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioDtoField, value) != true)) {
                    this.UsuarioDtoField = value;
                    this.RaisePropertyChanged("UsuarioDto");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAnuncio.IServiceAnuncio")]
    public interface IServiceAnuncio {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAnuncio/SalvarAnuncio", ReplyAction="http://tempuri.org/IServiceAnuncio/SalvarAnuncioResponse")]
        void SalvarAnuncio(int IdUsuario, int IdCategoria, string Descricao, string Titulo, double Preco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAnuncio/SalvarAnuncio", ReplyAction="http://tempuri.org/IServiceAnuncio/SalvarAnuncioResponse")]
        System.Threading.Tasks.Task SalvarAnuncioAsync(int IdUsuario, int IdCategoria, string Descricao, string Titulo, double Preco);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAnuncio/ListarTodos", ReplyAction="http://tempuri.org/IServiceAnuncio/ListarTodosResponse")]
        WebLayerProject.ServiceAnuncio.AnuncioDto[] ListarTodos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAnuncio/ListarTodos", ReplyAction="http://tempuri.org/IServiceAnuncio/ListarTodosResponse")]
        System.Threading.Tasks.Task<WebLayerProject.ServiceAnuncio.AnuncioDto[]> ListarTodosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAnuncio/buscarPorId", ReplyAction="http://tempuri.org/IServiceAnuncio/buscarPorIdResponse")]
        WebLayerProject.ServiceAnuncio.AnuncioDto buscarPorId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAnuncio/buscarPorId", ReplyAction="http://tempuri.org/IServiceAnuncio/buscarPorIdResponse")]
        System.Threading.Tasks.Task<WebLayerProject.ServiceAnuncio.AnuncioDto> buscarPorIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAnuncioChannel : WebLayerProject.ServiceAnuncio.IServiceAnuncio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAnuncioClient : System.ServiceModel.ClientBase<WebLayerProject.ServiceAnuncio.IServiceAnuncio>, WebLayerProject.ServiceAnuncio.IServiceAnuncio {
        
        public ServiceAnuncioClient() {
        }
        
        public ServiceAnuncioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAnuncioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAnuncioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAnuncioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SalvarAnuncio(int IdUsuario, int IdCategoria, string Descricao, string Titulo, double Preco) {
            base.Channel.SalvarAnuncio(IdUsuario, IdCategoria, Descricao, Titulo, Preco);
        }
        
        public System.Threading.Tasks.Task SalvarAnuncioAsync(int IdUsuario, int IdCategoria, string Descricao, string Titulo, double Preco) {
            return base.Channel.SalvarAnuncioAsync(IdUsuario, IdCategoria, Descricao, Titulo, Preco);
        }
        
        public WebLayerProject.ServiceAnuncio.AnuncioDto[] ListarTodos() {
            return base.Channel.ListarTodos();
        }
        
        public System.Threading.Tasks.Task<WebLayerProject.ServiceAnuncio.AnuncioDto[]> ListarTodosAsync() {
            return base.Channel.ListarTodosAsync();
        }
        
        public WebLayerProject.ServiceAnuncio.AnuncioDto buscarPorId(int id) {
            return base.Channel.buscarPorId(id);
        }
        
        public System.Threading.Tasks.Task<WebLayerProject.ServiceAnuncio.AnuncioDto> buscarPorIdAsync(int id) {
            return base.Channel.buscarPorIdAsync(id);
        }
    }
}