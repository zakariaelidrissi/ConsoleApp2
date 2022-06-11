﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws/", ConfigurationName="ServiceReference1.BanqueService")]
    public interface BanqueService {
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/getCompteRequest", ReplyAction="http://ws/BanqueService/getCompteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ConsoleApp2.ServiceReference1.getCompteResponse getCompte(ConsoleApp2.ServiceReference1.getCompteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/getCompteRequest", ReplyAction="http://ws/BanqueService/getCompteResponse")]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.getCompteResponse> getCompteAsync(ConsoleApp2.ServiceReference1.getCompteRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/ConversionEuroToDHRequest", ReplyAction="http://ws/BanqueService/ConversionEuroToDHResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ConsoleApp2.ServiceReference1.ConversionEuroToDHResponse ConversionEuroToDH(ConsoleApp2.ServiceReference1.ConversionEuroToDHRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/ConversionEuroToDHRequest", ReplyAction="http://ws/BanqueService/ConversionEuroToDHResponse")]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.ConversionEuroToDHResponse> ConversionEuroToDHAsync(ConsoleApp2.ServiceReference1.ConversionEuroToDHRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/listComptesRequest", ReplyAction="http://ws/BanqueService/listComptesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ConsoleApp2.ServiceReference1.listComptesResponse listComptes(ConsoleApp2.ServiceReference1.listComptesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/BanqueService/listComptesRequest", ReplyAction="http://ws/BanqueService/listComptesResponse")]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.listComptesResponse> listComptesAsync(ConsoleApp2.ServiceReference1.listComptesRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws/")]
    public partial class compte : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long codeField;
        
        private bool codeFieldSpecified;
        
        private double soldeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codeSpecified {
            get {
                return this.codeFieldSpecified;
            }
            set {
                this.codeFieldSpecified = value;
                this.RaisePropertyChanged("codeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double solde {
            get {
                return this.soldeField;
            }
            set {
                this.soldeField = value;
                this.RaisePropertyChanged("solde");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompte", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class getCompteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long code;
        
        public getCompteRequest() {
        }
        
        public getCompteRequest(long code) {
            this.code = code;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompteResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class getCompteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ConsoleApp2.ServiceReference1.compte @return;
        
        public getCompteResponse() {
        }
        
        public getCompteResponse(ConsoleApp2.ServiceReference1.compte @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConversionEuroToDH", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class ConversionEuroToDHRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double montant;
        
        public ConversionEuroToDHRequest() {
        }
        
        public ConversionEuroToDHRequest(double montant) {
            this.montant = montant;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConversionEuroToDHResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class ConversionEuroToDHResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double @return;
        
        public ConversionEuroToDHResponse() {
        }
        
        public ConversionEuroToDHResponse(double @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listComptes", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class listComptesRequest {
        
        public listComptesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listComptesResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class listComptesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ConsoleApp2.ServiceReference1.compte[] @return;
        
        public listComptesResponse() {
        }
        
        public listComptesResponse(ConsoleApp2.ServiceReference1.compte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BanqueServiceChannel : ConsoleApp2.ServiceReference1.BanqueService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BanqueServiceClient : System.ServiceModel.ClientBase<ConsoleApp2.ServiceReference1.BanqueService>, ConsoleApp2.ServiceReference1.BanqueService {
        
        public BanqueServiceClient() {
        }
        
        public BanqueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BanqueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BanqueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BanqueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp2.ServiceReference1.getCompteResponse ConsoleApp2.ServiceReference1.BanqueService.getCompte(ConsoleApp2.ServiceReference1.getCompteRequest request) {
            return base.Channel.getCompte(request);
        }
        
        public ConsoleApp2.ServiceReference1.compte getCompte(long code) {
            ConsoleApp2.ServiceReference1.getCompteRequest inValue = new ConsoleApp2.ServiceReference1.getCompteRequest();
            inValue.code = code;
            ConsoleApp2.ServiceReference1.getCompteResponse retVal = ((ConsoleApp2.ServiceReference1.BanqueService)(this)).getCompte(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.getCompteResponse> ConsoleApp2.ServiceReference1.BanqueService.getCompteAsync(ConsoleApp2.ServiceReference1.getCompteRequest request) {
            return base.Channel.getCompteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.getCompteResponse> getCompteAsync(long code) {
            ConsoleApp2.ServiceReference1.getCompteRequest inValue = new ConsoleApp2.ServiceReference1.getCompteRequest();
            inValue.code = code;
            return ((ConsoleApp2.ServiceReference1.BanqueService)(this)).getCompteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp2.ServiceReference1.ConversionEuroToDHResponse ConsoleApp2.ServiceReference1.BanqueService.ConversionEuroToDH(ConsoleApp2.ServiceReference1.ConversionEuroToDHRequest request) {
            return base.Channel.ConversionEuroToDH(request);
        }
        
        public double ConversionEuroToDH(double montant) {
            ConsoleApp2.ServiceReference1.ConversionEuroToDHRequest inValue = new ConsoleApp2.ServiceReference1.ConversionEuroToDHRequest();
            inValue.montant = montant;
            ConsoleApp2.ServiceReference1.ConversionEuroToDHResponse retVal = ((ConsoleApp2.ServiceReference1.BanqueService)(this)).ConversionEuroToDH(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.ConversionEuroToDHResponse> ConsoleApp2.ServiceReference1.BanqueService.ConversionEuroToDHAsync(ConsoleApp2.ServiceReference1.ConversionEuroToDHRequest request) {
            return base.Channel.ConversionEuroToDHAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.ConversionEuroToDHResponse> ConversionEuroToDHAsync(double montant) {
            ConsoleApp2.ServiceReference1.ConversionEuroToDHRequest inValue = new ConsoleApp2.ServiceReference1.ConversionEuroToDHRequest();
            inValue.montant = montant;
            return ((ConsoleApp2.ServiceReference1.BanqueService)(this)).ConversionEuroToDHAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp2.ServiceReference1.listComptesResponse ConsoleApp2.ServiceReference1.BanqueService.listComptes(ConsoleApp2.ServiceReference1.listComptesRequest request) {
            return base.Channel.listComptes(request);
        }
        
        public ConsoleApp2.ServiceReference1.compte[] listComptes() {
            ConsoleApp2.ServiceReference1.listComptesRequest inValue = new ConsoleApp2.ServiceReference1.listComptesRequest();
            ConsoleApp2.ServiceReference1.listComptesResponse retVal = ((ConsoleApp2.ServiceReference1.BanqueService)(this)).listComptes(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.listComptesResponse> ConsoleApp2.ServiceReference1.BanqueService.listComptesAsync(ConsoleApp2.ServiceReference1.listComptesRequest request) {
            return base.Channel.listComptesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.listComptesResponse> listComptesAsync() {
            ConsoleApp2.ServiceReference1.listComptesRequest inValue = new ConsoleApp2.ServiceReference1.listComptesRequest();
            return ((ConsoleApp2.ServiceReference1.BanqueService)(this)).listComptesAsync(inValue);
        }
    }
}
