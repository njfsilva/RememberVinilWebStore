﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackOffice.FabricanteBService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ObjectQuoteRequest", Namespace="http://schemas.datacontract.org/2004/07/FabricanteB")]
    [System.SerializableAttribute()]
    public partial class ObjectQuoteRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BackOffice.FabricanteBService.Music[] ListaMusicasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WSCallbackField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
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
        public BackOffice.FabricanteBService.Music[] ListaMusicas {
            get {
                return this.ListaMusicasField;
            }
            set {
                if ((object.ReferenceEquals(this.ListaMusicasField, value) != true)) {
                    this.ListaMusicasField = value;
                    this.RaisePropertyChanged("ListaMusicas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WSCallback {
            get {
                return this.WSCallbackField;
            }
            set {
                if ((object.ReferenceEquals(this.WSCallbackField, value) != true)) {
                    this.WSCallbackField = value;
                    this.RaisePropertyChanged("WSCallback");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Music", Namespace="http://schemas.datacontract.org/2004/07/FabricanteB")]
    [System.SerializableAttribute()]
    public partial class Music : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArtisNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PriceFormattedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrackNameField;
        
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
        public string ArtisName {
            get {
                return this.ArtisNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ArtisNameField, value) != true)) {
                    this.ArtisNameField = value;
                    this.RaisePropertyChanged("ArtisName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PriceFormatted {
            get {
                return this.PriceFormattedField;
            }
            set {
                if ((object.ReferenceEquals(this.PriceFormattedField, value) != true)) {
                    this.PriceFormattedField = value;
                    this.RaisePropertyChanged("PriceFormatted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TrackName {
            get {
                return this.TrackNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TrackNameField, value) != true)) {
                    this.TrackNameField = value;
                    this.RaisePropertyChanged("TrackName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ObjectCDRequest", Namespace="http://schemas.datacontract.org/2004/07/FabricanteB")]
    [System.SerializableAttribute()]
    public partial class ObjectCDRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BackOffice.FabricanteBService.Music[] ListaMusicasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WSCallbackField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
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
        public BackOffice.FabricanteBService.Music[] ListaMusicas {
            get {
                return this.ListaMusicasField;
            }
            set {
                if ((object.ReferenceEquals(this.ListaMusicasField, value) != true)) {
                    this.ListaMusicasField = value;
                    this.RaisePropertyChanged("ListaMusicas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WSCallback {
            get {
                return this.WSCallbackField;
            }
            set {
                if ((object.ReferenceEquals(this.WSCallbackField, value) != true)) {
                    this.WSCallbackField = value;
                    this.RaisePropertyChanged("WSCallback");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FabricanteBService.IFabricanteBService")]
    public interface IFabricanteBService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFabricanteBService/getQuote", ReplyAction="http://tempuri.org/IFabricanteBService/getQuoteResponse")]
        double getQuote(BackOffice.FabricanteBService.ObjectQuoteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFabricanteBService/MakeCD", ReplyAction="http://tempuri.org/IFabricanteBService/MakeCDResponse")]
        string MakeCD(BackOffice.FabricanteBService.ObjectCDRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFabricanteBServiceChannel : BackOffice.FabricanteBService.IFabricanteBService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FabricanteBServiceClient : System.ServiceModel.ClientBase<BackOffice.FabricanteBService.IFabricanteBService>, BackOffice.FabricanteBService.IFabricanteBService {
        
        public FabricanteBServiceClient() {
        }
        
        public FabricanteBServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FabricanteBServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FabricanteBServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FabricanteBServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double getQuote(BackOffice.FabricanteBService.ObjectQuoteRequest request) {
            return base.Channel.getQuote(request);
        }
        
        public string MakeCD(BackOffice.FabricanteBService.ObjectCDRequest request) {
            return base.Channel.MakeCD(request);
        }
    }
}