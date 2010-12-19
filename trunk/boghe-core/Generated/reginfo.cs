﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3615
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace BogheCore.Generated.regingo {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:ietf:params:xml:ns:reginfo")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:ietf:params:xml:ns:reginfo", IsNullable=false)]
    public partial class reginfo {
        
        private registration[] registrationField;
        
        private System.Xml.XmlElement[] anyField;
        
        private string versionField;
        
        private reginfoState stateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("registration", Order=0)]
        public registration[] registration {
            get {
                return this.registrationField;
            }
            set {
                this.registrationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public reginfoState state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:ietf:params:xml:ns:reginfo")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:ietf:params:xml:ns:reginfo", IsNullable=false)]
    public partial class registration {
        
        private contact[] contactField;
        
        private System.Xml.XmlElement[] anyField;
        
        private string aorField;
        
        private string idField;
        
        private registrationState stateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact", Order=0)]
        public contact[] contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string aor {
            get {
                return this.aorField;
            }
            set {
                this.aorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public registrationState state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:ietf:params:xml:ns:reginfo")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:ietf:params:xml:ns:reginfo", IsNullable=false)]
    public partial class contact {
        
        private string uriField;
        
        private contactDisplayname displaynameField;
        
        private contactUnknownparam[] unknownparamField;
        
        private System.Xml.XmlElement[] anyField;
        
        private contactState stateField;
        
        private contactEvent eventField;
        
        private ulong durationregisteredField;
        
        private bool durationregisteredFieldSpecified;
        
        private ulong expiresField;
        
        private bool expiresFieldSpecified;
        
        private ulong retryafterField;
        
        private bool retryafterFieldSpecified;
        
        private string idField;
        
        private string qField;
        
        private string callidField;
        
        private ulong cseqField;
        
        private bool cseqFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string uri {
            get {
                return this.uriField;
            }
            set {
                this.uriField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("display-name", Order=1)]
        public contactDisplayname displayname {
            get {
                return this.displaynameField;
            }
            set {
                this.displaynameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("unknown-param", Order=2)]
        public contactUnknownparam[] unknownparam {
            get {
                return this.unknownparamField;
            }
            set {
                this.unknownparamField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=3)]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public contactState state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public contactEvent @event {
            get {
                return this.eventField;
            }
            set {
                this.eventField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("duration-registered")]
        public ulong durationregistered {
            get {
                return this.durationregisteredField;
            }
            set {
                this.durationregisteredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool durationregisteredSpecified {
            get {
                return this.durationregisteredFieldSpecified;
            }
            set {
                this.durationregisteredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong expires {
            get {
                return this.expiresField;
            }
            set {
                this.expiresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expiresSpecified {
            get {
                return this.expiresFieldSpecified;
            }
            set {
                this.expiresFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("retry-after")]
        public ulong retryafter {
            get {
                return this.retryafterField;
            }
            set {
                this.retryafterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool retryafterSpecified {
            get {
                return this.retryafterFieldSpecified;
            }
            set {
                this.retryafterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string q {
            get {
                return this.qField;
            }
            set {
                this.qField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string callid {
            get {
                return this.callidField;
            }
            set {
                this.callidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong cseq {
            get {
                return this.cseqField;
            }
            set {
                this.cseqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cseqSpecified {
            get {
                return this.cseqFieldSpecified;
            }
            set {
                this.cseqFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:ietf:params:xml:ns:reginfo")]
    public partial class contactDisplayname {
        
        private string langField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
        public string lang {
            get {
                return this.langField;
            }
            set {
                this.langField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:ietf:params:xml:ns:reginfo")]
    public partial class contactUnknownparam {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:ietf:params:xml:ns:reginfo")]
    public enum contactState {
        
        /// <remarks/>
        active,
        
        /// <remarks/>
        terminated,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:ietf:params:xml:ns:reginfo")]
    public enum contactEvent {
        
        /// <remarks/>
        registered,
        
        /// <remarks/>
        created,
        
        /// <remarks/>
        refreshed,
        
        /// <remarks/>
        shortened,
        
        /// <remarks/>
        expired,
        
        /// <remarks/>
        deactivated,
        
        /// <remarks/>
        probation,
        
        /// <remarks/>
        unregistered,
        
        /// <remarks/>
        rejected,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:ietf:params:xml:ns:reginfo")]
    public enum registrationState {
        
        /// <remarks/>
        init,
        
        /// <remarks/>
        active,
        
        /// <remarks/>
        terminated,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:ietf:params:xml:ns:reginfo")]
    public enum reginfoState {
        
        /// <remarks/>
        full,
        
        /// <remarks/>
        @partial,
    }
}
