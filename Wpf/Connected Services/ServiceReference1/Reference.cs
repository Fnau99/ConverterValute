﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wpf.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Converter")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Wpf.ServiceReference1.CompositeType GetDataUsingDataContract(Wpf.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Wpf.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Wpf.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaLiraADem", ReplyAction="http://tempuri.org/IService1/ConvertiDaLiraADemResponse")]
        double ConvertiDaLiraADem(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaLiraADem", ReplyAction="http://tempuri.org/IService1/ConvertiDaLiraADemResponse")]
        System.Threading.Tasks.Task<double> ConvertiDaLiraADemAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaLiraAFranchi", ReplyAction="http://tempuri.org/IService1/ConvertiDaLiraAFranchiResponse")]
        double ConvertiDaLiraAFranchi(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaLiraAFranchi", ReplyAction="http://tempuri.org/IService1/ConvertiDaLiraAFranchiResponse")]
        System.Threading.Tasks.Task<double> ConvertiDaLiraAFranchiAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaLiraAEuro", ReplyAction="http://tempuri.org/IService1/ConvertiDaLiraAEuroResponse")]
        double ConvertiDaLiraAEuro(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaLiraAEuro", ReplyAction="http://tempuri.org/IService1/ConvertiDaLiraAEuroResponse")]
        System.Threading.Tasks.Task<double> ConvertiDaLiraAEuroAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaDemLira", ReplyAction="http://tempuri.org/IService1/ConvertiDaDemLiraResponse")]
        double ConvertiDaDemLira(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaDemLira", ReplyAction="http://tempuri.org/IService1/ConvertiDaDemLiraResponse")]
        System.Threading.Tasks.Task<double> ConvertiDaDemLiraAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaDemAFranchi", ReplyAction="http://tempuri.org/IService1/ConvertiDaDemAFranchiResponse")]
        double ConvertiDaDemAFranchi(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaDemAFranchi", ReplyAction="http://tempuri.org/IService1/ConvertiDaDemAFranchiResponse")]
        System.Threading.Tasks.Task<double> ConvertiDaDemAFranchiAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaDemAEuro", ReplyAction="http://tempuri.org/IService1/ConvertiDaDemAEuroResponse")]
        double ConvertiDaDemAEuro(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaDemAEuro", ReplyAction="http://tempuri.org/IService1/ConvertiDaDemAEuroResponse")]
        System.Threading.Tasks.Task<double> ConvertiDaDemAEuroAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaFranchiADem", ReplyAction="http://tempuri.org/IService1/ConvertiDaFranchiADemResponse")]
        double ConvertiDaFranchiADem(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaFranchiADem", ReplyAction="http://tempuri.org/IService1/ConvertiDaFranchiADemResponse")]
        System.Threading.Tasks.Task<double> ConvertiDaFranchiADemAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaFranchiALira", ReplyAction="http://tempuri.org/IService1/ConvertiDaFranchiALiraResponse")]
        double ConvertiDaFranchiALira(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaFranchiALira", ReplyAction="http://tempuri.org/IService1/ConvertiDaFranchiALiraResponse")]
        System.Threading.Tasks.Task<double> ConvertiDaFranchiALiraAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaFranchiAEuro", ReplyAction="http://tempuri.org/IService1/ConvertiDaFranchiAEuroResponse")]
        double ConvertiDaFranchiAEuro(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ConvertiDaFranchiAEuro", ReplyAction="http://tempuri.org/IService1/ConvertiDaFranchiAEuroResponse")]
        System.Threading.Tasks.Task<double> ConvertiDaFranchiAEuroAsync(double value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Wpf.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Wpf.ServiceReference1.IService1>, Wpf.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Wpf.ServiceReference1.CompositeType GetDataUsingDataContract(Wpf.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Wpf.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Wpf.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public double ConvertiDaLiraADem(double value) {
            return base.Channel.ConvertiDaLiraADem(value);
        }
        
        public System.Threading.Tasks.Task<double> ConvertiDaLiraADemAsync(double value) {
            return base.Channel.ConvertiDaLiraADemAsync(value);
        }
        
        public double ConvertiDaLiraAFranchi(double value) {
            return base.Channel.ConvertiDaLiraAFranchi(value);
        }
        
        public System.Threading.Tasks.Task<double> ConvertiDaLiraAFranchiAsync(double value) {
            return base.Channel.ConvertiDaLiraAFranchiAsync(value);
        }
        
        public double ConvertiDaLiraAEuro(double value) {
            return base.Channel.ConvertiDaLiraAEuro(value);
        }
        
        public System.Threading.Tasks.Task<double> ConvertiDaLiraAEuroAsync(double value) {
            return base.Channel.ConvertiDaLiraAEuroAsync(value);
        }
        
        public double ConvertiDaDemLira(double value) {
            return base.Channel.ConvertiDaDemLira(value);
        }
        
        public System.Threading.Tasks.Task<double> ConvertiDaDemLiraAsync(double value) {
            return base.Channel.ConvertiDaDemLiraAsync(value);
        }
        
        public double ConvertiDaDemAFranchi(double value) {
            return base.Channel.ConvertiDaDemAFranchi(value);
        }
        
        public System.Threading.Tasks.Task<double> ConvertiDaDemAFranchiAsync(double value) {
            return base.Channel.ConvertiDaDemAFranchiAsync(value);
        }
        
        public double ConvertiDaDemAEuro(double value) {
            return base.Channel.ConvertiDaDemAEuro(value);
        }
        
        public System.Threading.Tasks.Task<double> ConvertiDaDemAEuroAsync(double value) {
            return base.Channel.ConvertiDaDemAEuroAsync(value);
        }
        
        public double ConvertiDaFranchiADem(double value) {
            return base.Channel.ConvertiDaFranchiADem(value);
        }
        
        public System.Threading.Tasks.Task<double> ConvertiDaFranchiADemAsync(double value) {
            return base.Channel.ConvertiDaFranchiADemAsync(value);
        }
        
        public double ConvertiDaFranchiALira(double value) {
            return base.Channel.ConvertiDaFranchiALira(value);
        }
        
        public System.Threading.Tasks.Task<double> ConvertiDaFranchiALiraAsync(double value) {
            return base.Channel.ConvertiDaFranchiALiraAsync(value);
        }
        
        public double ConvertiDaFranchiAEuro(double value) {
            return base.Channel.ConvertiDaFranchiAEuro(value);
        }
        
        public System.Threading.Tasks.Task<double> ConvertiDaFranchiAEuroAsync(double value) {
            return base.Channel.ConvertiDaFranchiAEuroAsync(value);
        }
    }
}
