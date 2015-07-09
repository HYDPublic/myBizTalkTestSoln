using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.BizTalk.Component.Interop;
using System.ComponentModel;
using Microsoft.BizTalk.Message.Interop;
using System.IO;
using System.Xml.Xsl;
using System.Xml;
using Microsoft.Win32;
using System.Collections;

namespace XslTransformPipeline
{
	[ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
	[ComponentCategory(CategoryTypes.CATID_Encoder)]
	[System.Runtime.InteropServices.Guid("FA7F9C55-6E8E-4855-8DAC-FA1BC8A499E2")]
	public class XslTransformer : Microsoft.BizTalk.Component.Interop.IBaseComponent,
									  Microsoft.BizTalk.Component.Interop.IComponent,
									  Microsoft.BizTalk.Component.Interop.IPersistPropertyBag,
									  Microsoft.BizTalk.Component.Interop.IComponentUI
	{

		private string xsltPath = @"D:\GIT\Whitebeam\digitalshowcase-workflow\TestXxlTransformPipeline\transform.xsl";




		#region IBaseComponent

		/// <summary>
		/// Name of the component.
		/// </summary>
		[Browsable(false)]
		public string Name
		{
			get { return "XSL Transform Component"; }
		}

		/// <summary>
		/// Version of the component.
		/// </summary>
		[Browsable(false)]
		public string Version
		{
			get { return "1.0"; }
		}

		/// <summary>
		/// Description of the component.
		/// </summary>
		[Browsable(false)]
		public string Description
		{
			get { return "XSL Transform Pipeline Component"; }
		}

		#endregion

		#region IComponent

		/// <summary>
		/// Implements IComponent.Execute method.
		/// </summary>
		/// <param name="pc">Pipeline context</param>
		/// <param name="inmsg">Input message.</param>
		/// <returns>Converted to HTML input message.</returns>
		/// <remarks>
		/// IComponent.Execute method is used to convert XML messages
		/// to HTML messages using provided Xslt file.
		/// It also sets the content type of the message part to be "text/html"
		/// which is necessary for client mail applications to correctly render
		/// the message
		/// </remarks>
		public IBaseMessage Execute(IPipelineContext pc, IBaseMessage inmsg)
		{
			inmsg.BodyPart.Data = TransformMessage(inmsg.BodyPart.Data);
			inmsg.BodyPart.ContentType = "text/html";
			return inmsg;
		}
		#endregion

		#region Helper function
		/// <summary>
		/// Transforms XML message in input stream to HTML message
		/// </summary>
		/// <param name="stm">Stream with input XML message</param>
		/// <returns>Stream with output HTML message</returns>
		private Stream TransformMessage(Stream stm)
		{
			MemoryStream ms = null;
			string validXsltPath = null;

			try
			{
				// Get the full path to the Xslt file
				validXsltPath = xsltPath;

				// Load transform
				XslTransform transform = new XslTransform();
				transform.Load(validXsltPath);

				//Load Xml stream in XmlDocument.
				XmlDocument doc = new XmlDocument();
				doc.Load(stm);

				//Create memory stream to hold transformed data.
				ms = new MemoryStream();

				//Preform transform
				transform.Transform(doc, null, ms, null);
				ms.Seek(0, SeekOrigin.Begin);
			}
			catch (Exception e)
			{
				System.Diagnostics.Trace.WriteLine(e.Message);
				System.Diagnostics.Trace.WriteLine(e.StackTrace);
				throw e;
			}

			return ms;
		}



		#endregion


		#region IPersistPropertyBag

		/// <summary>
		/// Gets class ID of component for usage from unmanaged code.
		/// </summary>
		/// <param name="classid">Class ID of the component.</param>
		public void GetClassID(out Guid classid)
		{
			classid = new System.Guid("FA7F9C55-6E8E-4855-8DAC-FA1BC8A499E2");
		}

		/// <summary>
		/// Not implemented.
		/// </summary>
		public void InitNew()
		{
		}

		public void Load(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, Int32 errlog)
		{
			string val = (string)ReadPropertyBag(pb, "XsltFilePath");
			if (val != null) xsltPath = val;
		}

		/// <summary>
		/// Saves the current component configuration into the property bag.
		/// </summary>
		/// <param name="pb">Configuration property bag.</param>
		/// <param name="fClearDirty">Not used.</param>
		/// <param name="fSaveAllProperties">Not used.</param>
		public void Save(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, Boolean fClearDirty, Boolean fSaveAllProperties)
		{
			object val = (object)xsltPath;
			WritePropertyBag(pb, "XsltFilePath", val);
		}

		/// <summary>
		/// Reads property value from property bag.
		/// </summary>
		/// <param name="pb">Property bag.</param>
		/// <param name="propName">Name of property.</param>
		/// <returns>Value of the property.</returns>
		private static object ReadPropertyBag(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, string propName)
		{
			object val = null;
			try
			{
				pb.Read(propName, out val, 0);
			}

			catch (System.ArgumentException)
			{
				return val;
			}
			catch (Exception ex)
			{
				throw new ApplicationException(ex.Message);
			}
			return val;
		}

		private static void WritePropertyBag(Microsoft.BizTalk.Component.Interop.IPropertyBag pb, string propName, object val)
		{
			try
			{
				pb.Write(propName, ref val);
			}
			catch (Exception ex)
			{
				throw new ApplicationException(ex.Message);
			}
		}

		#endregion

		#region IComponentUI
		/// <summary>
		/// Component icon to use in BizTalk Editor.
		/// </summary>
		[Browsable(false)]
		public IntPtr Icon
		{
			get { return IntPtr.Zero; }
		}

		/// <summary>
		/// The Validate method is called by the BizTalk Editor during the build 
		/// of a BizTalk project.
		/// </summary>
		/// <param name="obj">Project system.</param>
		/// <returns>
		/// A list of error and/or warning messages encounter during validation
		/// of this component.
		/// </returns>
		public IEnumerator Validate(object projectSystem)
		{
			if (projectSystem == null)
				throw new System.ArgumentNullException("No project system");

			IEnumerator enumerator = null;
			ArrayList strList = new ArrayList();

			

			return enumerator;
		}

		#endregion


	}
}
