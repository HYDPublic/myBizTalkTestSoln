namespace SendingHTMLEmail {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry",@"ContentRepository")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "MediaItem.AffiliateMediaItems.AffiliateMediaItem.affiliateDomain", XPath = @"/*[local-name()='ContentRepository' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/*[local-name()='MediaItem' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/*[local-name()='AffiliateMediaItems' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/*[local-name()='AffiliateMediaItem' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/@*[local-name()='affiliateDomain' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::SendingHTMLEmail.affiliate), XPath = @"/*[local-name()='ContentRepository' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/*[local-name()='MediaItem' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/*[local-name()='AffiliateMediaItems' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/*[local-name()='AffiliateMediaItem' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/@*[local-name()='affiliateDomain' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ContentRepository"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SendingHTMLEmail.PropertySchema", typeof(global::SendingHTMLEmail.PropertySchema))]
    public sealed class EntryPoint : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsd:schema xmlns=""http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <xsd:annotation>
    <xsd:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema"" location=""SendingHTMLEmail.PropertySchema"" />
      </b:imports>
    </xsd:appinfo>
  </xsd:annotation>
  <xsd:element name=""ContentRepository"">
    <xsd:annotation>
      <xsd:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='ContentRepository' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/*[local-name()='MediaItem' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/*[local-name()='AffiliateMediaItems' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/*[local-name()='AffiliateMediaItem' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/@*[local-name()='affiliateDomain' and namespace-uri()='']"" />
          <b:property name=""ns0:affiliate"" xpath=""/*[local-name()='ContentRepository' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/*[local-name()='MediaItem' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/*[local-name()='AffiliateMediaItems' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/*[local-name()='AffiliateMediaItem' and namespace-uri()='http://Piksel.MediaServicesFramework.Workflow.Schemas.NoEntry']/@*[local-name()='affiliateDomain' and namespace-uri()='']"" />
        </b:properties>
      </xsd:appinfo>
    </xsd:annotation>
    <xsd:complexType>
      <xsd:sequence>
        <xsd:element name=""MediaItem"">
          <xsd:complexType>
            <xsd:sequence>
              <xsd:element name=""AffiliateMediaItems"">
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element name=""AffiliateMediaItem"">
                      <xsd:complexType>
                        <xsd:attribute name=""affiliateDomain"" type=""xsd:string"" use=""required"" />
                      </xsd:complexType>
                    </xsd:element>
                  </xsd:sequence>
                </xsd:complexType>
              </xsd:element>
            </xsd:sequence>
          </xsd:complexType>
        </xsd:element>
      </xsd:sequence>
    </xsd:complexType>
  </xsd:element>
</xsd:schema>";
        
        public EntryPoint() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ContentRepository";
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
}
