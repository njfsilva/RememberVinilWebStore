﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Transportadora.VinilBackoffice {

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ObjectMakeCDResponse", Namespace="http://schemas.datacontract.org/2004/07/BackOffice")]
    [System.SerializableAttribute()]
    public partial class ObjectMakeCDResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeliveryAdressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DistanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string encomendaIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fabricaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string refRequestCDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int userIDField;
        
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
        public string DeliveryAdress {
            get {
                return this.DeliveryAdressField;
            }
            set {
                if ((object.ReferenceEquals(this.DeliveryAdressField, value) != true)) {
                    this.DeliveryAdressField = value;
                    this.RaisePropertyChanged("DeliveryAdress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Distance {
            get {
                return this.DistanceField;
            }
            set {
                if ((object.ReferenceEquals(this.DistanceField, value) != true)) {
                    this.DistanceField = value;
                    this.RaisePropertyChanged("Distance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string encomendaID {
            get {
                return this.encomendaIDField;
            }
            set {
                if ((object.ReferenceEquals(this.encomendaIDField, value) != true)) {
                    this.encomendaIDField = value;
                    this.RaisePropertyChanged("encomendaID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fabrica {
            get {
                return this.fabricaField;
            }
            set {
                if ((object.ReferenceEquals(this.fabricaField, value) != true)) {
                    this.fabricaField = value;
                    this.RaisePropertyChanged("fabrica");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string refRequestCD {
            get {
                return this.refRequestCDField;
            }
            set {
                if ((object.ReferenceEquals(this.refRequestCDField, value) != true)) {
                    this.refRequestCDField = value;
                    this.RaisePropertyChanged("refRequestCD");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int userID {
            get {
                return this.userIDField;
            }
            set {
                if ((this.userIDField.Equals(value) != true)) {
                    this.userIDField = value;
                    this.RaisePropertyChanged("userID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TransportJobResponse", Namespace="http://schemas.datacontract.org/2004/07/BackOffice")]
    [System.SerializableAttribute()]
    public partial class TransportJobResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeliveryAdressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DistanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SucessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string encomendaIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fabricaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userIDField;
        
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
        public string DeliveryAdress {
            get {
                return this.DeliveryAdressField;
            }
            set {
                if ((object.ReferenceEquals(this.DeliveryAdressField, value) != true)) {
                    this.DeliveryAdressField = value;
                    this.RaisePropertyChanged("DeliveryAdress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Distance {
            get {
                return this.DistanceField;
            }
            set {
                if ((object.ReferenceEquals(this.DistanceField, value) != true)) {
                    this.DistanceField = value;
                    this.RaisePropertyChanged("Distance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Sucess {
            get {
                return this.SucessField;
            }
            set {
                if ((this.SucessField.Equals(value) != true)) {
                    this.SucessField = value;
                    this.RaisePropertyChanged("Sucess");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string encomendaID {
            get {
                return this.encomendaIDField;
            }
            set {
                if ((object.ReferenceEquals(this.encomendaIDField, value) != true)) {
                    this.encomendaIDField = value;
                    this.RaisePropertyChanged("encomendaID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fabrica {
            get {
                return this.fabricaField;
            }
            set {
                if ((object.ReferenceEquals(this.fabricaField, value) != true)) {
                    this.fabricaField = value;
                    this.RaisePropertyChanged("fabrica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userID {
            get {
                return this.userIDField;
            }
            set {
                if ((object.ReferenceEquals(this.userIDField, value) != true)) {
                    this.userIDField = value;
                    this.RaisePropertyChanged("userID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TransportJobPriceResponse", Namespace="http://schemas.datacontract.org/2004/07/BackOffice")]
    [System.SerializableAttribute()]
    public partial class TransportJobPriceResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string encomendaIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fabricanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string refRequestPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userIDField;
        
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
        public string encomendaID {
            get {
                return this.encomendaIDField;
            }
            set {
                if ((object.ReferenceEquals(this.encomendaIDField, value) != true)) {
                    this.encomendaIDField = value;
                    this.RaisePropertyChanged("encomendaID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fabricante {
            get {
                return this.fabricanteField;
            }
            set {
                if ((object.ReferenceEquals(this.fabricanteField, value) != true)) {
                    this.fabricanteField = value;
                    this.RaisePropertyChanged("fabricante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string refRequestPrice {
            get {
                return this.refRequestPriceField;
            }
            set {
                if ((object.ReferenceEquals(this.refRequestPriceField, value) != true)) {
                    this.refRequestPriceField = value;
                    this.RaisePropertyChanged("refRequestPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userID {
            get {
                return this.userIDField;
            }
            set {
                if ((object.ReferenceEquals(this.userIDField, value) != true)) {
                    this.userIDField = value;
                    this.RaisePropertyChanged("userID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FabricantePriceResponse", Namespace="http://schemas.datacontract.org/2004/07/BackOffice")]
    [System.SerializableAttribute()]
    public partial class FabricantePriceResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string encomendaIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fabricanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string refRequestPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userIDField;
        
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
        public string encomendaID {
            get {
                return this.encomendaIDField;
            }
            set {
                if ((object.ReferenceEquals(this.encomendaIDField, value) != true)) {
                    this.encomendaIDField = value;
                    this.RaisePropertyChanged("encomendaID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fabricante {
            get {
                return this.fabricanteField;
            }
            set {
                if ((object.ReferenceEquals(this.fabricanteField, value) != true)) {
                    this.fabricanteField = value;
                    this.RaisePropertyChanged("fabricante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string refRequestPrice {
            get {
                return this.refRequestPriceField;
            }
            set {
                if ((object.ReferenceEquals(this.refRequestPriceField, value) != true)) {
                    this.refRequestPriceField = value;
                    this.RaisePropertyChanged("refRequestPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userID {
            get {
                return this.userIDField;
            }
            set {
                if ((object.ReferenceEquals(this.userIDField, value) != true)) {
                    this.userIDField = value;
                    this.RaisePropertyChanged("userID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VinilBackoffice.IBackOfficeCallBackService")]
    public interface IBackOfficeCallBackService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBackOfficeCallBackService/GetStatus", ReplyAction="http://tempuri.org/IBackOfficeCallBackService/GetStatusResponse")]
        string GetStatus(Transportadora.VinilBackoffice.ObjectMakeCDResponse response);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBackOfficeCallBackService/UpdateOrderTransportStatus", ReplyAction="http://tempuri.org/IBackOfficeCallBackService/UpdateOrderTransportStatusResponse")]
        string UpdateOrderTransportStatus(Transportadora.VinilBackoffice.TransportJobResponse response);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBackOfficeCallBackService/GetTransporterPrice", ReplyAction="http://tempuri.org/IBackOfficeCallBackService/GetTransporterPriceResponse")]
        string GetTransporterPrice(Transportadora.VinilBackoffice.TransportJobPriceResponse response);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBackOfficeCallBackService/GetFabricantePrice", ReplyAction="http://tempuri.org/IBackOfficeCallBackService/GetFabricantePriceResponse")]
        string GetFabricantePrice(Transportadora.VinilBackoffice.FabricantePriceResponse response);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBackOfficeCallBackServiceChannel : Transportadora.VinilBackoffice.IBackOfficeCallBackService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BackOfficeCallBackServiceClient : System.ServiceModel.ClientBase<Transportadora.VinilBackoffice.IBackOfficeCallBackService>, Transportadora.VinilBackoffice.IBackOfficeCallBackService {
        
        public BackOfficeCallBackServiceClient() {
        }
        
        public BackOfficeCallBackServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BackOfficeCallBackServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BackOfficeCallBackServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BackOfficeCallBackServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetStatus(Transportadora.VinilBackoffice.ObjectMakeCDResponse response) {
            return base.Channel.GetStatus(response);
        }
        
        public string UpdateOrderTransportStatus(Transportadora.VinilBackoffice.TransportJobResponse response) {
            return base.Channel.UpdateOrderTransportStatus(response);
        }
        
        public string GetTransporterPrice(Transportadora.VinilBackoffice.TransportJobPriceResponse response) {
            return base.Channel.GetTransporterPrice(response);
        }
        
        public string GetFabricantePrice(Transportadora.VinilBackoffice.FabricantePriceResponse response) {
            return base.Channel.GetFabricantePrice(response);
        }
    }
}
