﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biller.Test.GS1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.ekomercio.com/", ConfigurationName="GS1.WSFEBuilderSoap")]
    public interface WSFEBuilderSoap {
        
        // CODEGEN: Generating message contract since element name getVersionResult from namespace http://www.ekomercio.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ekomercio.com/getVersion", ReplyAction="*")]
        Biller.Test.GS1.getVersionResponse getVersion(Biller.Test.GS1.getVersionRequest request);
        
        // CODEGEN: Generating message contract since element name usuario from namespace http://www.ekomercio.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ekomercio.com/VerificaEstadoFactura", ReplyAction="*")]
        Biller.Test.GS1.VerificaEstadoFacturaResponse VerificaEstadoFactura(Biller.Test.GS1.VerificaEstadoFacturaRequest request);
        
        // CODEGEN: Generating message contract since element name usuario from namespace http://www.ekomercio.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ekomercio.com/procesarTextoPlano", ReplyAction="*")]
        Biller.Test.GS1.procesarTextoPlanoResponse procesarTextoPlano(Biller.Test.GS1.procesarTextoPlanoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getVersionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getVersion", Namespace="http://www.ekomercio.com/", Order=0)]
        public Biller.Test.GS1.getVersionRequestBody Body;
        
        public getVersionRequest() {
        }
        
        public getVersionRequest(Biller.Test.GS1.getVersionRequestBody Body) {
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
        public Biller.Test.GS1.getVersionResponseBody Body;
        
        public getVersionResponse() {
        }
        
        public getVersionResponse(Biller.Test.GS1.getVersionResponseBody Body) {
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
        public Biller.Test.GS1.VerificaEstadoFacturaRequestBody Body;
        
        public VerificaEstadoFacturaRequest() {
        }
        
        public VerificaEstadoFacturaRequest(Biller.Test.GS1.VerificaEstadoFacturaRequestBody Body) {
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
        public Biller.Test.GS1.VerificaEstadoFacturaResponseBody Body;
        
        public VerificaEstadoFacturaResponse() {
        }
        
        public VerificaEstadoFacturaResponse(Biller.Test.GS1.VerificaEstadoFacturaResponseBody Body) {
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
        public Biller.Test.GS1.procesarTextoPlanoRequestBody Body;
        
        public procesarTextoPlanoRequest() {
        }
        
        public procesarTextoPlanoRequest(Biller.Test.GS1.procesarTextoPlanoRequestBody Body) {
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
        public Biller.Test.GS1.procesarTextoPlanoResponseBody Body;
        
        public procesarTextoPlanoResponse() {
        }
        
        public procesarTextoPlanoResponse(Biller.Test.GS1.procesarTextoPlanoResponseBody Body) {
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
    public interface WSFEBuilderSoapChannel : Biller.Test.GS1.WSFEBuilderSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSFEBuilderSoapClient : System.ServiceModel.ClientBase<Biller.Test.GS1.WSFEBuilderSoap>, Biller.Test.GS1.WSFEBuilderSoap {
        
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
        Biller.Test.GS1.getVersionResponse Biller.Test.GS1.WSFEBuilderSoap.getVersion(Biller.Test.GS1.getVersionRequest request) {
            return base.Channel.getVersion(request);
        }
        
        public string getVersion() {
            Biller.Test.GS1.getVersionRequest inValue = new Biller.Test.GS1.getVersionRequest();
            inValue.Body = new Biller.Test.GS1.getVersionRequestBody();
            Biller.Test.GS1.getVersionResponse retVal = ((Biller.Test.GS1.WSFEBuilderSoap)(this)).getVersion(inValue);
            return retVal.Body.getVersionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Biller.Test.GS1.VerificaEstadoFacturaResponse Biller.Test.GS1.WSFEBuilderSoap.VerificaEstadoFactura(Biller.Test.GS1.VerificaEstadoFacturaRequest request) {
            return base.Channel.VerificaEstadoFactura(request);
        }
        
        public string VerificaEstadoFactura(string usuario, string password, string folios) {
            Biller.Test.GS1.VerificaEstadoFacturaRequest inValue = new Biller.Test.GS1.VerificaEstadoFacturaRequest();
            inValue.Body = new Biller.Test.GS1.VerificaEstadoFacturaRequestBody();
            inValue.Body.usuario = usuario;
            inValue.Body.password = password;
            inValue.Body.folios = folios;
            Biller.Test.GS1.VerificaEstadoFacturaResponse retVal = ((Biller.Test.GS1.WSFEBuilderSoap)(this)).VerificaEstadoFactura(inValue);
            return retVal.Body.VerificaEstadoFacturaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Biller.Test.GS1.procesarTextoPlanoResponse Biller.Test.GS1.WSFEBuilderSoap.procesarTextoPlano(Biller.Test.GS1.procesarTextoPlanoRequest request) {
            return base.Channel.procesarTextoPlano(request);
        }
        
        public string procesarTextoPlano(string usuario, string password, string id, string textoPlano, string cifrasDeControl) {
            Biller.Test.GS1.procesarTextoPlanoRequest inValue = new Biller.Test.GS1.procesarTextoPlanoRequest();
            inValue.Body = new Biller.Test.GS1.procesarTextoPlanoRequestBody();
            inValue.Body.usuario = usuario;
            inValue.Body.password = password;
            inValue.Body.id = id;
            inValue.Body.textoPlano = textoPlano;
            inValue.Body.cifrasDeControl = cifrasDeControl;
            Biller.Test.GS1.procesarTextoPlanoResponse retVal = ((Biller.Test.GS1.WSFEBuilderSoap)(this)).procesarTextoPlano(inValue);
            return retVal.Body.procesarTextoPlanoResult;
        }
    }
}