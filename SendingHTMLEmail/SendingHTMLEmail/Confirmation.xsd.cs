namespace SendingHTMLEmail {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SendingHtmlEmails",@"Confirmation")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::SendingHTMLEmail.TestName), XPath = @"/*[local-name()='Confirmation' and namespace-uri()='http://SendingHtmlEmails']/*[local-name()='Name' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Name", XPath = @"/*[local-name()='Confirmation' and namespace-uri()='http://SendingHtmlEmails']/*[local-name()='Name' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::SendingHTMLEmail.affiliate), XPath = @"/*[local-name()='Confirmation' and namespace-uri()='http://SendingHtmlEmails']/@*[local-name()='Affiliate' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Confirmation"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SendingHTMLEmail.PropertySchema", typeof(global::SendingHTMLEmail.PropertySchema))]
    public sealed class Confirmation : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SendingHtmlEmails"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema"" targetNamespace=""http://SendingHtmlEmails"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Piksel.MediaServicesFramework.Workflow.Schemas.PropertySchema"" location=""SendingHTMLEmail.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Confirmation"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:TestName"" xpath=""/*[local-name()='Confirmation' and namespace-uri()='http://SendingHtmlEmails']/*[local-name()='Name' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Confirmation' and namespace-uri()='http://SendingHtmlEmails']/*[local-name()='Name' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Confirmation' and namespace-uri()='http://SendingHtmlEmails']/@*[local-name()='Affiliate' and namespace-uri()='']"" />
          <b:property name=""ns0:affiliate"" xpath=""/*[local-name()='Confirmation' and namespace-uri()='http://SendingHtmlEmails']/@*[local-name()='Affiliate' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Name"" type=""xs:string"" />
        <xs:element name=""Date"" type=""xs:string"" />
        <xs:element name=""Item"" type=""xs:string"" />
        <xs:element name=""Quantity"" type=""xs:string"" />
        <xs:element name=""Price"" type=""xs:string"" />
        <xs:element name=""Affiliate"" type=""xs:string"" />
        <xs:element name=""SupplierReference"" type=""xs:string"" />
        <xs:element name=""IsSuccess"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Confirmation() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Confirmation";
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
