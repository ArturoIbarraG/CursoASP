﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceApp.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebServiceApp.ServiceReference.HelloWorldResponse HelloWorld(WebServiceApp.ServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceApp.ServiceReference.HelloWorldResponse> HelloWorldAsync(WebServiceApp.ServiceReference.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento WriteDateResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WriteDate", ReplyAction="*")]
        WebServiceApp.ServiceReference.WriteDateResponse WriteDate(WebServiceApp.ServiceReference.WriteDateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WriteDate", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceApp.ServiceReference.WriteDateResponse> WriteDateAsync(WebServiceApp.ServiceReference.WriteDateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceApp.ServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebServiceApp.ServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceApp.ServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebServiceApp.ServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WriteDateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WriteDate", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceApp.ServiceReference.WriteDateRequestBody Body;
        
        public WriteDateRequest() {
        }
        
        public WriteDateRequest(WebServiceApp.ServiceReference.WriteDateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class WriteDateRequestBody {
        
        public WriteDateRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WriteDateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WriteDateResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceApp.ServiceReference.WriteDateResponseBody Body;
        
        public WriteDateResponse() {
        }
        
        public WriteDateResponse(WebServiceApp.ServiceReference.WriteDateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WriteDateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string WriteDateResult;
        
        public WriteDateResponseBody() {
        }
        
        public WriteDateResponseBody(string WriteDateResult) {
            this.WriteDateResult = WriteDateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : WebServiceApp.ServiceReference.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<WebServiceApp.ServiceReference.WebServiceSoap>, WebServiceApp.ServiceReference.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceApp.ServiceReference.HelloWorldResponse WebServiceApp.ServiceReference.WebServiceSoap.HelloWorld(WebServiceApp.ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebServiceApp.ServiceReference.HelloWorldRequest inValue = new WebServiceApp.ServiceReference.HelloWorldRequest();
            inValue.Body = new WebServiceApp.ServiceReference.HelloWorldRequestBody();
            WebServiceApp.ServiceReference.HelloWorldResponse retVal = ((WebServiceApp.ServiceReference.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceApp.ServiceReference.HelloWorldResponse> WebServiceApp.ServiceReference.WebServiceSoap.HelloWorldAsync(WebServiceApp.ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceApp.ServiceReference.HelloWorldResponse> HelloWorldAsync() {
            WebServiceApp.ServiceReference.HelloWorldRequest inValue = new WebServiceApp.ServiceReference.HelloWorldRequest();
            inValue.Body = new WebServiceApp.ServiceReference.HelloWorldRequestBody();
            return ((WebServiceApp.ServiceReference.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceApp.ServiceReference.WriteDateResponse WebServiceApp.ServiceReference.WebServiceSoap.WriteDate(WebServiceApp.ServiceReference.WriteDateRequest request) {
            return base.Channel.WriteDate(request);
        }
        
        public string WriteDate() {
            WebServiceApp.ServiceReference.WriteDateRequest inValue = new WebServiceApp.ServiceReference.WriteDateRequest();
            inValue.Body = new WebServiceApp.ServiceReference.WriteDateRequestBody();
            WebServiceApp.ServiceReference.WriteDateResponse retVal = ((WebServiceApp.ServiceReference.WebServiceSoap)(this)).WriteDate(inValue);
            return retVal.Body.WriteDateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceApp.ServiceReference.WriteDateResponse> WebServiceApp.ServiceReference.WebServiceSoap.WriteDateAsync(WebServiceApp.ServiceReference.WriteDateRequest request) {
            return base.Channel.WriteDateAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceApp.ServiceReference.WriteDateResponse> WriteDateAsync() {
            WebServiceApp.ServiceReference.WriteDateRequest inValue = new WebServiceApp.ServiceReference.WriteDateRequest();
            inValue.Body = new WebServiceApp.ServiceReference.WriteDateRequestBody();
            return ((WebServiceApp.ServiceReference.WebServiceSoap)(this)).WriteDateAsync(inValue);
        }
    }
}
