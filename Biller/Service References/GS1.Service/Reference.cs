﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biller.GS1.Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.ekomercio.com/", ConfigurationName="GS1.Service.WSFEBuilderSoap")]
    public interface WSFEBuilderSoap {
        
        // CODEGEN: Generating message contract since element name getVersionResult from namespace http://www.ekomercio.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ekomercio.com/getVersion", ReplyAction="*")]
        Biller.GS1.Service.getVersionResponse getVersion(Biller.GS1.Service.getVersionRequest request);
        
        // CODEGEN: Generating message contract since element name usuario from namespace http://www.ekomercio.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ekomercio.com/VerificaEstadoFactura", ReplyAction="*")]
        Biller.GS1.Service.VerificaEstadoFacturaResponse VerificaEstadoFactura(Biller.GS1.Service.VerificaEstadoFacturaRequest request);
        
        // CODEGEN: Generating message contract since element name usuario from namespace http://www.ekomercio.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ekomercio.com/procesarTextoPlano", ReplyAction="*")]
        Biller.GS1.Service.procesarTextoPlanoResponse procesarTextoPlano(Biller.GS1.Service.procesarTextoPlanoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getVersionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getVersion", Namespace="http://www.ekomercio.com/", Order=0)]
        public Biller.GS1.Service.getVersionRequestBody Body;
        
        public getVersionRequest() {
        }
        
        public getVersionRequest(Biller.GS1.Service.getVersionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getVersionRequestBody {
        
        public getVersionRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getVersionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getVersionResponse", Namespace="http://www.ekomercio.com/", Order=0)]
        public Biller.GS1.Service.getVersionResponseBody Body;
        
        public getVersionResponse() {
        }
        
        public getVersionResponse(Biller.GS1.Service.getVersionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.ekomercio.com/")]
    public partial class getVersionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getVersionResult;
        
        public getVersionResponseBody() {
        }
        
        public getVersionResponseBody(string getVersionResult) {
            this.getVersionResult = getVersionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerificaEstadoFacturaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerificaEstadoFactura", Namespace="http://www.ekomercio.com/", Order=0)]
        public Biller.GS1.Service.VerificaEstadoFacturaRequestBody Body;
        
        public VerificaEstadoFacturaRequest() {
        }
        
        public VerificaEstadoFacturaRequest(Biller.GS1.Service.VerificaEstadoFacturaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.ekomercio.com/")]
    public partial class VerificaEstadoFacturaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string folios;
        
        public VerificaEstadoFacturaRequestBody() {
        }
        
        public VerificaEstadoFacturaRequestBody(string usuario, string password, string folios) {
            this.usuario = usuario;
            this.password = password;
            this.folios = folios;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerificaEstadoFacturaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerificaEstadoFacturaResponse", Namespace="http://www.ekomercio.com/", Order=0)]
        public Biller.GS1.Service.VerificaEstadoFacturaResponseBody Body;
        
        public VerificaEstadoFacturaResponse() {
        }
        
        public VerificaEstadoFacturaResponse(Biller.GS1.Service.VerificaEstadoFacturaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.ekomercio.com/")]
    public partial class VerificaEstadoFacturaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VerificaEstadoFacturaResult;
        
        public VerificaEstadoFacturaResponseBody() {
        }
        
        public VerificaEstadoFacturaResponseBody(string VerificaEstadoFacturaResult) {
            this.VerificaEstadoFacturaResult = VerificaEstadoFacturaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class procesarTextoPlanoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="procesarTextoPlano", Namespace="http://www.ekomercio.com/", Order=0)]
        public Biller.GS1.Service.procesarTextoPlanoRequestBody Body;
        
        public procesarTextoPlanoRequest() {
        }
        
        public procesarTextoPlanoRequest(Biller.GS1.Service.procesarTextoPlanoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.ekomercio.com/")]
    public partial class procesarTextoPlanoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string textoPlano;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string cifrasDeControl;
        
        public procesarTextoPlanoRequestBody() {
        }
        
        public procesarTextoPlanoRequestBody(string usuario, string password, string id, string textoPlano, string cifrasDeControl) {
            this.usuario = usuario;
            this.password = password;
            this.id = id;
            this.textoPlano = textoPlano;
            this.cifrasDeControl = cifrasDeControl;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class procesarTextoPlanoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="procesarTextoPlanoResponse", Namespace="http://www.ekomercio.com/", Order=0)]
        public Biller.GS1.Service.procesarTextoPlanoResponseBody Body;
        
        public procesarTextoPlanoResponse() {
        }
        
        public procesarTextoPlanoResponse(Biller.GS1.Service.procesarTextoPlanoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.ekomercio.com/")]
    public partial class procesarTextoPlanoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string procesarTextoPlanoResult;
        
        public procesarTextoPlanoResponseBody() {
        }
        
        public procesarTextoPlanoResponseBody(string procesarTextoPlanoResult) {
            this.procesarTextoPlanoResult = procesarTextoPlanoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSFEBuilderSoapChannel : Biller.GS1.Service.WSFEBuilderSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSFEBuilderSoapClient : System.ServiceModel.ClientBase<Biller.GS1.Service.WSFEBuilderSoap>, Biller.GS1.Service.WSFEBuilderSoap {
        
        public WSFEBuilderSoapClient() {
        }
        
        public WSFEBuilderSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSFEBuilderSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSFEBuilderSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSFEBuilderSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Biller.GS1.Service.getVersionResponse Biller.GS1.Service.WSFEBuilderSoap.getVersion(Biller.GS1.Service.getVersionRequest request) {
            return base.Channel.getVersion(request);
        }
        
        public string getVersion() {
            Biller.GS1.Service.getVersionRequest inValue = new Biller.GS1.Service.getVersionRequest();
            inValue.Body = new Biller.GS1.Service.getVersionRequestBody();
            Biller.GS1.Service.getVersionResponse retVal = ((Biller.GS1.Service.WSFEBuilderSoap)(this)).getVersion(inValue);
            return retVal.Body.getVersionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Biller.GS1.Service.VerificaEstadoFacturaResponse Biller.GS1.Service.WSFEBuilderSoap.VerificaEstadoFactura(Biller.GS1.Service.VerificaEstadoFacturaRequest request) {
            return base.Channel.VerificaEstadoFactura(request);
        }
        
        public string VerificaEstadoFactura(string usuario, string password, string folios) {
            Biller.GS1.Service.VerificaEstadoFacturaRequest inValue = new Biller.GS1.Service.VerificaEstadoFacturaRequest();
            inValue.Body = new Biller.GS1.Service.VerificaEstadoFacturaRequestBody();
            inValue.Body.usuario = usuario;
            inValue.Body.password = password;
            inValue.Body.folios = folios;
            Biller.GS1.Service.VerificaEstadoFacturaResponse retVal = ((Biller.GS1.Service.WSFEBuilderSoap)(this)).VerificaEstadoFactura(inValue);
            return retVal.Body.VerificaEstadoFacturaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Biller.GS1.Service.procesarTextoPlanoResponse Biller.GS1.Service.WSFEBuilderSoap.procesarTextoPlano(Biller.GS1.Service.procesarTextoPlanoRequest request) {
            return base.Channel.procesarTextoPlano(request);
        }
        
        public string procesarTextoPlano(string usuario, string password, string id, string textoPlano, string cifrasDeControl) {
            Biller.GS1.Service.procesarTextoPlanoRequest inValue = new Biller.GS1.Service.procesarTextoPlanoRequest();
            inValue.Body = new Biller.GS1.Service.procesarTextoPlanoRequestBody();
            inValue.Body.usuario = usuario;
            inValue.Body.password = password;
            inValue.Body.id = id;
            inValue.Body.textoPlano = textoPlano;
            inValue.Body.cifrasDeControl = cifrasDeControl;
            Biller.GS1.Service.procesarTextoPlanoResponse retVal = ((Biller.GS1.Service.WSFEBuilderSoap)(this)).procesarTextoPlano(inValue);
            return retVal.Body.procesarTextoPlanoResult;
        }
    }
}
