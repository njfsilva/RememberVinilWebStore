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
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TransportJobResponse", Namespace="http://schemas.datacontract.org/2004/07/Transportadora")]
    [System.SerializableAttribute()]
    public partial class TransportJobResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SucessField;
        
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBackOfficeCallBackService/getStatus", ReplyAction="http://tempuri.org/IBackOfficeCallBackService/getStatusResponse")]
        string getStatus(Transportadora.VinilBackoffice.TransportJobResponse response);
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
        
        public string getStatus(Transportadora.VinilBackoffice.TransportJobResponse response) {
            return base.Channel.getStatus(response);
        }
    }
}
