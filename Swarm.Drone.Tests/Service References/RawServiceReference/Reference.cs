﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Swarm.Drone.Tests.RawServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoadTestScenario", Namespace="http://schemas.datacontract.org/2004/07/Swarm.Contracts.Models")]
    [System.SerializableAttribute()]
    public partial class LoadTestScenario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[][] DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EndpointField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Swarm.Drone.Tests.RawServiceReference.Method MethodField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> RequestTimeoutField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> SamplingIntervalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> StartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Swarm.Drone.Tests.RawServiceReference.VirtualUserSettings UsersField;
        
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
        public string[][] Data {
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
        public string Endpoint {
            get {
                return this.EndpointField;
            }
            set {
                if ((object.ReferenceEquals(this.EndpointField, value) != true)) {
                    this.EndpointField = value;
                    this.RaisePropertyChanged("Endpoint");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Swarm.Drone.Tests.RawServiceReference.Method Method {
            get {
                return this.MethodField;
            }
            set {
                if ((this.MethodField.Equals(value) != true)) {
                    this.MethodField = value;
                    this.RaisePropertyChanged("Method");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> RequestTimeout {
            get {
                return this.RequestTimeoutField;
            }
            set {
                if ((this.RequestTimeoutField.Equals(value) != true)) {
                    this.RequestTimeoutField = value;
                    this.RaisePropertyChanged("RequestTimeout");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> SamplingInterval {
            get {
                return this.SamplingIntervalField;
            }
            set {
                if ((this.SamplingIntervalField.Equals(value) != true)) {
                    this.SamplingIntervalField = value;
                    this.RaisePropertyChanged("SamplingInterval");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Swarm.Drone.Tests.RawServiceReference.VirtualUserSettings Users {
            get {
                return this.UsersField;
            }
            set {
                if ((object.ReferenceEquals(this.UsersField, value) != true)) {
                    this.UsersField = value;
                    this.RaisePropertyChanged("Users");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="VirtualUserSettings", Namespace="http://schemas.datacontract.org/2004/07/Swarm.Contracts.Models")]
    [System.SerializableAttribute()]
    public partial class VirtualUserSettings : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> RampTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.TimeSpan> SleepTimeField;
        
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
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> RampTime {
            get {
                return this.RampTimeField;
            }
            set {
                if ((this.RampTimeField.Equals(value) != true)) {
                    this.RampTimeField = value;
                    this.RaisePropertyChanged("RampTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> SleepTime {
            get {
                return this.SleepTimeField;
            }
            set {
                if ((this.SleepTimeField.Equals(value) != true)) {
                    this.SleepTimeField = value;
                    this.RaisePropertyChanged("SleepTime");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Method", Namespace="http://schemas.datacontract.org/2004/07/RestSharp")]
    public enum Method : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GET = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        POST = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PUT = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DELETE = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HEAD = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OPTIONS = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PATCH = 6,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RawServiceReference.IDroneService")]
    public interface IDroneService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDroneService/StartLoadTest", ReplyAction="http://tempuri.org/IDroneService/StartLoadTestResponse")]
        void StartLoadTest(Swarm.Drone.Tests.RawServiceReference.LoadTestScenario scenario);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDroneServiceChannel : Swarm.Drone.Tests.RawServiceReference.IDroneService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DroneServiceClient : System.ServiceModel.ClientBase<Swarm.Drone.Tests.RawServiceReference.IDroneService>, Swarm.Drone.Tests.RawServiceReference.IDroneService {
        
        public DroneServiceClient() {
        }
        
        public DroneServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DroneServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DroneServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DroneServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void StartLoadTest(Swarm.Drone.Tests.RawServiceReference.LoadTestScenario scenario) {
            base.Channel.StartLoadTest(scenario);
        }
    }
}
