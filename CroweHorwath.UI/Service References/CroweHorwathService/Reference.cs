﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CroweHorwath.UI.CroweHorwathService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CroweHorwathService.ICHService")]
    public interface ICHService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICHService/GetData", ReplyAction="http://tempuri.org/ICHService/GetDataResponse")]
        string GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICHService/GetData", ReplyAction="http://tempuri.org/ICHService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICHService/GetUserData", ReplyAction="http://tempuri.org/ICHService/GetUserDataResponse")]
        string GetUserData(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICHService/GetUserData", ReplyAction="http://tempuri.org/ICHService/GetUserDataResponse")]
        System.Threading.Tasks.Task<string> GetUserDataAsync(string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICHServiceChannel : CroweHorwath.UI.CroweHorwathService.ICHService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CHServiceClient : System.ServiceModel.ClientBase<CroweHorwath.UI.CroweHorwathService.ICHService>, CroweHorwath.UI.CroweHorwathService.ICHService {
        
        public CHServiceClient() {
        }
        
        public CHServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CHServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CHServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CHServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
        
        public string GetUserData(string value) {
            return base.Channel.GetUserData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetUserDataAsync(string value) {
            return base.Channel.GetUserDataAsync(value);
        }
    }
}
