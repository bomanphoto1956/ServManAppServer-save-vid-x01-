﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormTest.PictLoad {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UploadedFile", Namespace="http://schemas.datacontract.org/2004/07/SmanStreamAPI")]
    [System.SerializableAttribute()]
    public partial class UploadedFile : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FileLengthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FilePathField;
        
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
        public int FileLength {
            get {
                return this.FileLengthField;
            }
            set {
                if ((this.FileLengthField.Equals(value) != true)) {
                    this.FileLengthField = value;
                    this.RaisePropertyChanged("FileLength");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileName {
            get {
                return this.FileNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FileNameField, value) != true)) {
                    this.FileNameField = value;
                    this.RaisePropertyChanged("FileName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FilePath {
            get {
                return this.FilePathField;
            }
            set {
                if ((object.ReferenceEquals(this.FilePathField, value) != true)) {
                    this.FilePathField = value;
                    this.RaisePropertyChanged("FilePath");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PictLoad.IPictLoad")]
    public interface IPictLoad {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPictLoad/Upload", ReplyAction="http://tempuri.org/IPictLoad/UploadResponse")]
        WinFormTest.PictLoad.UploadedFile Upload(System.IO.Stream Uploading);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPictLoad/Upload", ReplyAction="http://tempuri.org/IPictLoad/UploadResponse")]
        System.Threading.Tasks.Task<WinFormTest.PictLoad.UploadedFile> UploadAsync(System.IO.Stream Uploading);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPictLoadChannel : WinFormTest.PictLoad.IPictLoad, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PictLoadClient : System.ServiceModel.ClientBase<WinFormTest.PictLoad.IPictLoad>, WinFormTest.PictLoad.IPictLoad {
        
        public PictLoadClient() {
        }
        
        public PictLoadClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PictLoadClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PictLoadClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PictLoadClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WinFormTest.PictLoad.UploadedFile Upload(System.IO.Stream Uploading) {
            return base.Channel.Upload(Uploading);
        }
        
        public System.Threading.Tasks.Task<WinFormTest.PictLoad.UploadedFile> UploadAsync(System.IO.Stream Uploading) {
            return base.Channel.UploadAsync(Uploading);
        }
    }
}
