﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESTM.Client.BLL.ServiceReference_MyWCF {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference_MyWCF.ICSOAService")]
    public interface ICSOAService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICSOAService/GetAllUsers", ReplyAction="http://tempuri.org/ICSOAService/GetAllUsersResponse")]
        ESTM.Common.Model.DTO_USERS[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICSOAService/GetAllUsers", ReplyAction="http://tempuri.org/ICSOAService/GetAllUsersResponse")]
        System.Threading.Tasks.Task<ESTM.Common.Model.DTO_USERS[]> GetAllUsersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICSOAServiceChannel : ESTM.Client.BLL.ServiceReference_MyWCF.ICSOAService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CSOAServiceClient : System.ServiceModel.ClientBase<ESTM.Client.BLL.ServiceReference_MyWCF.ICSOAService>, ESTM.Client.BLL.ServiceReference_MyWCF.ICSOAService {
        
        public CSOAServiceClient() {
        }
        
        public CSOAServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CSOAServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CSOAServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CSOAServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ESTM.Common.Model.DTO_USERS[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<ESTM.Common.Model.DTO_USERS[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
    }
}
