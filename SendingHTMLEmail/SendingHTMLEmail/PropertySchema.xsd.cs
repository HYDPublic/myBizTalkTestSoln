namespace SendingHTMLEmail {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AssetLocation", @"AssetID", @"EncryptionKey", @"LangCode", @"SupplierReference", @"ingestTypeId", @"affiliate", @"TestName"})]
    public sealed class PropertySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Ioko.MediaServicesFramework.Workflow.Schemas.PropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema"" targetNamespace=""https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""AssetLocation"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""cc697973-ec6d-43c2-8869-5c2ee0bfac3e"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""AssetID"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""ae1cf4e7-8147-4edd-887c-63710284b634"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""EncryptionKey"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""fd389204-0f4f-4218-9351-5af7f007a280"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""LangCode"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""e6ba7dff-5237-45d1-88da-4d0c6c26a3f9"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""SupplierReference"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""db853ddc-66ca-46ad-b45f-548ed2a2106d"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ingestTypeId"" type=""xs:int"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""28db8c29-0bb2-4e74-8e0d-170c90300a47"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""affiliate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""2fdf4777-87c5-40bb-ad7b-86ff1837444f"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""TestName"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""3d1dee39-f131-4f34-9467-be6fbe576c5a"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public PropertySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [8];
                _RootElements[0] = "AssetLocation";
                _RootElements[1] = "AssetID";
                _RootElements[2] = "EncryptionKey";
                _RootElements[3] = "LangCode";
                _RootElements[4] = "SupplierReference";
                _RootElements[5] = "ingestTypeId";
                _RootElements[6] = "affiliate";
                _RootElements[7] = "TestName";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"AssetLocation",@"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"cc697973-ec6d-43c2-8869-5c2ee0bfac3e")]
    public sealed class AssetLocation : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"AssetLocation", @"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"AssetID",@"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"ae1cf4e7-8147-4edd-887c-63710284b634")]
    public sealed class AssetID : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"AssetID", @"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"EncryptionKey",@"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"fd389204-0f4f-4218-9351-5af7f007a280")]
    public sealed class EncryptionKey : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"EncryptionKey", @"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"LangCode",@"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"e6ba7dff-5237-45d1-88da-4d0c6c26a3f9")]
    public sealed class LangCode : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"LangCode", @"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"SupplierReference",@"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"db853ddc-66ca-46ad-b45f-548ed2a2106d")]
    public sealed class SupplierReference : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"SupplierReference", @"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"ingestTypeId",@"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema","int","System.Int32")]
    [PropertyGuidAttribute(@"28db8c29-0bb2-4e74-8e0d-170c90300a47")]
    public sealed class ingestTypeId : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"ingestTypeId", @"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema");
        
        private static int PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(int);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"affiliate",@"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"2fdf4777-87c5-40bb-ad7b-86ff1837444f")]
    public sealed class affiliate : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"affiliate", @"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"TestName",@"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"3d1dee39-f131-4f34-9467-be6fbe576c5a")]
    public sealed class TestName : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"TestName", @"https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
}
