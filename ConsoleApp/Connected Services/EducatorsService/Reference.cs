﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp.EducatorsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EducatorsService.IEducatorsService")]
    public interface IEducatorsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEducatorsService/Read", ReplyAction="http://tempuri.org/IEducatorsService/ReadResponse")]
        Models.Educator[] Read();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEducatorsService/Read", ReplyAction="http://tempuri.org/IEducatorsService/ReadResponse")]
        System.Threading.Tasks.Task<Models.Educator[]> ReadAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEducatorsServiceChannel : ConsoleApp.EducatorsService.IEducatorsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EducatorsServiceClient : System.ServiceModel.ClientBase<ConsoleApp.EducatorsService.IEducatorsService>, ConsoleApp.EducatorsService.IEducatorsService {
        
        public EducatorsServiceClient() {
        }
        
        public EducatorsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EducatorsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EducatorsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EducatorsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Models.Educator[] Read() {
            return base.Channel.Read();
        }
        
        public System.Threading.Tasks.Task<Models.Educator[]> ReadAsync() {
            return base.Channel.ReadAsync();
        }
    }
}
