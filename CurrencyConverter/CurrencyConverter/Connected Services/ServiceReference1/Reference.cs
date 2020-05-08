﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CurrencyConverter.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        CurrencyConverter.ServiceReference1.HelloWorldResponse HelloWorld(CurrencyConverter.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<CurrencyConverter.ServiceReference1.HelloWorldResponse> HelloWorldAsync(CurrencyConverter.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name fromCurrency from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Convert", ReplyAction="*")]
        CurrencyConverter.ServiceReference1.ConvertResponse Convert(CurrencyConverter.ServiceReference1.ConvertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Convert", ReplyAction="*")]
        System.Threading.Tasks.Task<CurrencyConverter.ServiceReference1.ConvertResponse> ConvertAsync(CurrencyConverter.ServiceReference1.ConvertRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public CurrencyConverter.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(CurrencyConverter.ServiceReference1.HelloWorldRequestBody Body) {
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
        public CurrencyConverter.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(CurrencyConverter.ServiceReference1.HelloWorldResponseBody Body) {
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
    public partial class ConvertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Convert", Namespace="http://tempuri.org/", Order=0)]
        public CurrencyConverter.ServiceReference1.ConvertRequestBody Body;
        
        public ConvertRequest() {
        }
        
        public ConvertRequest(CurrencyConverter.ServiceReference1.ConvertRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double from;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fromCurrency;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string toCurrency;
        
        public ConvertRequestBody() {
        }
        
        public ConvertRequestBody(double from, string fromCurrency, string toCurrency) {
            this.from = from;
            this.fromCurrency = fromCurrency;
            this.toCurrency = toCurrency;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertResponse", Namespace="http://tempuri.org/", Order=0)]
        public CurrencyConverter.ServiceReference1.ConvertResponseBody Body;
        
        public ConvertResponse() {
        }
        
        public ConvertResponse(CurrencyConverter.ServiceReference1.ConvertResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double ConvertResult;
        
        public ConvertResponseBody() {
        }
        
        public ConvertResponseBody(double ConvertResult) {
            this.ConvertResult = ConvertResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : CurrencyConverter.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<CurrencyConverter.ServiceReference1.WebService1Soap>, CurrencyConverter.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CurrencyConverter.ServiceReference1.HelloWorldResponse CurrencyConverter.ServiceReference1.WebService1Soap.HelloWorld(CurrencyConverter.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            CurrencyConverter.ServiceReference1.HelloWorldRequest inValue = new CurrencyConverter.ServiceReference1.HelloWorldRequest();
            inValue.Body = new CurrencyConverter.ServiceReference1.HelloWorldRequestBody();
            CurrencyConverter.ServiceReference1.HelloWorldResponse retVal = ((CurrencyConverter.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CurrencyConverter.ServiceReference1.HelloWorldResponse> CurrencyConverter.ServiceReference1.WebService1Soap.HelloWorldAsync(CurrencyConverter.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<CurrencyConverter.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            CurrencyConverter.ServiceReference1.HelloWorldRequest inValue = new CurrencyConverter.ServiceReference1.HelloWorldRequest();
            inValue.Body = new CurrencyConverter.ServiceReference1.HelloWorldRequestBody();
            return ((CurrencyConverter.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CurrencyConverter.ServiceReference1.ConvertResponse CurrencyConverter.ServiceReference1.WebService1Soap.Convert(CurrencyConverter.ServiceReference1.ConvertRequest request) {
            return base.Channel.Convert(request);
        }
        
        public double Convert(double from, string fromCurrency, string toCurrency) {
            CurrencyConverter.ServiceReference1.ConvertRequest inValue = new CurrencyConverter.ServiceReference1.ConvertRequest();
            inValue.Body = new CurrencyConverter.ServiceReference1.ConvertRequestBody();
            inValue.Body.from = from;
            inValue.Body.fromCurrency = fromCurrency;
            inValue.Body.toCurrency = toCurrency;
            CurrencyConverter.ServiceReference1.ConvertResponse retVal = ((CurrencyConverter.ServiceReference1.WebService1Soap)(this)).Convert(inValue);
            return retVal.Body.ConvertResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CurrencyConverter.ServiceReference1.ConvertResponse> CurrencyConverter.ServiceReference1.WebService1Soap.ConvertAsync(CurrencyConverter.ServiceReference1.ConvertRequest request) {
            return base.Channel.ConvertAsync(request);
        }
        
        public System.Threading.Tasks.Task<CurrencyConverter.ServiceReference1.ConvertResponse> ConvertAsync(double from, string fromCurrency, string toCurrency) {
            CurrencyConverter.ServiceReference1.ConvertRequest inValue = new CurrencyConverter.ServiceReference1.ConvertRequest();
            inValue.Body = new CurrencyConverter.ServiceReference1.ConvertRequestBody();
            inValue.Body.from = from;
            inValue.Body.fromCurrency = fromCurrency;
            inValue.Body.toCurrency = toCurrency;
            return ((CurrencyConverter.ServiceReference1.WebService1Soap)(this)).ConvertAsync(inValue);
        }
    }
}