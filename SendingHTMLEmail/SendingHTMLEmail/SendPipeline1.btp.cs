namespace SendingHTMLEmail
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class SendPipeline1 : Microsoft.BizTalk.PipelineOM.SendPipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>8c6b051c-0ff5-4fc2-9ae5-5016cb726282</CategoryId>  <FriendlyName>Transmit</FriendlyName"+
">  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Pre-Assemble\" minO"+
"ccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4101-4cce-4536-83fa-4a5040674ad6\" />      <Co"+
"mponents />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Assemb"+
"le\" minOccurs=\"0\" maxOccurs=\"1\" execMethod=\"All\" stageId=\"9d0e4107-4cce-4536-83fa-4a5040674ad6\" />  "+
"    <Components>        <Component>          <Name>Microsoft.BizTalk.Component.XmlAsmComp,Microsoft."+
"BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name"+
">          <ComponentName>XML assembler</ComponentName>          <Description>XML assembler componen"+
"t.</Description>          <Version>1.0</Version>          <Properties>            <Property Name=\"En"+
"velopeDocSpecNames\">              <Value xsi:type=\"xsd:string\" />            </Property>            "+
"<Property Name=\"EnvelopeSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\" />         "+
"   </Property>            <Property Name=\"DocumentSpecNames\">              <Value xsi:type=\"xsd:stri"+
"ng\" />            </Property>            <Property Name=\"DocumentSpecTargetNamespaces\">             "+
" <Value xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"XmlAsmProcessingI"+
"nstructions\" />            <Property Name=\"ProcessingInstructionsOptions\">              <Value xsi:t"+
"ype=\"xsd:int\">0</Value>            </Property>            <Property Name=\"ProcessingInstructionsScop"+
"e\">              <Value xsi:type=\"xsd:int\">0</Value>            </Property>            <Property Nam"+
"e=\"AddXmlDeclaration\">              <Value xsi:type=\"xsd:boolean\">true</Value>            </Property"+
">            <Property Name=\"TargetCharset\">              <Value xsi:type=\"xsd:string\" />           "+
" </Property>            <Property Name=\"TargetCodePage\">              <Value xsi:type=\"xsd:int\">0</V"+
"alue>            </Property>            <Property Name=\"PreserveBom\">              <Value xsi:type=\""+
"xsd:boolean\">true</Value>            </Property>            <Property Name=\"HiddenProperties\">      "+
"        <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTargetNamespaces,Targe"+
"tCodePage</Value>            </Property>          </Properties>          <CachedDisplayName>XML asse"+
"mbler</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </Component>      "+
"</Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Enco"+
"de\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4108-4cce-4536-83fa-4a5040674ad6\" /> "+
"     <Components>        <Component>          <Name>TestXslTransformPipeline.XslTransformer,TestXxlT"+
"ransformPipeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d8114c620005aaa0</Name>          "+
"<ComponentName>XSL Transform Component</ComponentName>          <Description>XSL Transform Pipeline "+
"Component</Description>          <Version>1.0</Version>          <Properties>            <Property N"+
"ame=\"XsltFilePath\">              <Value xsi:type=\"xsd:string\">D:\\GIT\\Whitebeam\\digitalshowcase-workf"+
"low\\TestXxlTransformPipeline\\transform.xsl</Value>            </Property>          </Properties>    "+
"      <CachedDisplayName>XSL Transform Component</CachedDisplayName>          <CachedIsManaged>true<"+
"/CachedIsManaged>        </Component>      </Components>    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "f574c976-0445-4d62-b12b-aa9d2e9c5499";
        
        public SendPipeline1()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4107-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlAsmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeDocSpec"+
"Names\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"EnvelopeSpecTargetNam"+
"espaces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecNames\">"+
"      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecTargetNamespaces"+
"\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"XmlAsmProcessingInstructio"+
"ns\" />    <Property Name=\"ProcessingInstructionsOptions\">      <Value xsi:type=\"xsd:int\">0</Value>  "+
"  </Property>    <Property Name=\"ProcessingInstructionsScope\">      <Value xsi:type=\"xsd:int\">0</Val"+
"ue>    </Property>    <Property Name=\"AddXmlDeclaration\">      <Value xsi:type=\"xsd:boolean\">true</V"+
"alue>    </Property>    <Property Name=\"TargetCharset\">      <Value xsi:type=\"xsd:string\" />    </Pr"+
"operty>    <Property Name=\"TargetCodePage\">      <Value xsi:type=\"xsd:int\">0</Value>    </Property> "+
"   <Property Name=\"PreserveBom\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <"+
"Property Name=\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,Doc"+
"umentSpecTargetNamespaces,TargetCodePage</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            stage = this.AddStage(new System.Guid("9d0e4108-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("TestXslTransformPipeline.XslTransformer,TestXxlTransformPipeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d8114c620005aaa0");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"XsltFilePath\"> "+
"     <Value xsi:type=\"xsd:string\">D:\\GIT\\Whitebeam\\digitalshowcase-workflow\\TestXxlTransformPipeline"+
"\\transform.xsl</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
