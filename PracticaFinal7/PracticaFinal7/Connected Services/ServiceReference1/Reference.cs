﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticaFinal7.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento getArticuloXMLResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getArticuloXML", ReplyAction="*")]
        PracticaFinal7.ServiceReference1.getArticuloXMLResponse getArticuloXML(PracticaFinal7.ServiceReference1.getArticuloXMLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getArticuloXML", ReplyAction="*")]
        System.Threading.Tasks.Task<PracticaFinal7.ServiceReference1.getArticuloXMLResponse> getArticuloXMLAsync(PracticaFinal7.ServiceReference1.getArticuloXMLRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getArticuloXMLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getArticuloXML", Namespace="http://tempuri.org/", Order=0)]
        public PracticaFinal7.ServiceReference1.getArticuloXMLRequestBody Body;
        
        public getArticuloXMLRequest() {
        }
        
        public getArticuloXMLRequest(PracticaFinal7.ServiceReference1.getArticuloXMLRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getArticuloXMLRequestBody {
        
        public getArticuloXMLRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getArticuloXMLResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getArticuloXMLResponse", Namespace="http://tempuri.org/", Order=0)]
        public PracticaFinal7.ServiceReference1.getArticuloXMLResponseBody Body;
        
        public getArticuloXMLResponse() {
        }
        
        public getArticuloXMLResponse(PracticaFinal7.ServiceReference1.getArticuloXMLResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getArticuloXMLResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getArticuloXMLResult;
        
        public getArticuloXMLResponseBody() {
        }
        
        public getArticuloXMLResponseBody(string getArticuloXMLResult) {
            this.getArticuloXMLResult = getArticuloXMLResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : PracticaFinal7.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<PracticaFinal7.ServiceReference1.WebServiceSoap>, PracticaFinal7.ServiceReference1.WebServiceSoap {
        
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
        PracticaFinal7.ServiceReference1.getArticuloXMLResponse PracticaFinal7.ServiceReference1.WebServiceSoap.getArticuloXML(PracticaFinal7.ServiceReference1.getArticuloXMLRequest request) {
            return base.Channel.getArticuloXML(request);
        }
        
        public string getArticuloXML() {
            PracticaFinal7.ServiceReference1.getArticuloXMLRequest inValue = new PracticaFinal7.ServiceReference1.getArticuloXMLRequest();
            inValue.Body = new PracticaFinal7.ServiceReference1.getArticuloXMLRequestBody();
            PracticaFinal7.ServiceReference1.getArticuloXMLResponse retVal = ((PracticaFinal7.ServiceReference1.WebServiceSoap)(this)).getArticuloXML(inValue);
            return retVal.Body.getArticuloXMLResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PracticaFinal7.ServiceReference1.getArticuloXMLResponse> PracticaFinal7.ServiceReference1.WebServiceSoap.getArticuloXMLAsync(PracticaFinal7.ServiceReference1.getArticuloXMLRequest request) {
            return base.Channel.getArticuloXMLAsync(request);
        }
        
        public System.Threading.Tasks.Task<PracticaFinal7.ServiceReference1.getArticuloXMLResponse> getArticuloXMLAsync() {
            PracticaFinal7.ServiceReference1.getArticuloXMLRequest inValue = new PracticaFinal7.ServiceReference1.getArticuloXMLRequest();
            inValue.Body = new PracticaFinal7.ServiceReference1.getArticuloXMLRequestBody();
            return ((PracticaFinal7.ServiceReference1.WebServiceSoap)(this)).getArticuloXMLAsync(inValue);
        }
    }
}