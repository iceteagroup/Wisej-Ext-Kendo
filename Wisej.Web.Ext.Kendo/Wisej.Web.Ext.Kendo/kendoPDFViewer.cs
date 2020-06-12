///////////////////////////////////////////////////////////////////////////////
//
// (C) 2020 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////

namespace Wisej.Web.Ext.Kendo
{
	/// <summary>
	/// The PDFViewer displays PDF files in the browser and consists of a toolbar 
	/// and a scrollable container that wraps the page elements.
	/// </summary>
	public class kendoPDFViewer : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoPDFViewer"/> class.
		/// </summary>
		public kendoPDFViewer() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoPDFViewer"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoPDFViewer(object options) : base("kendoPDFViewer", options)
		{
			this.Packages.Add(new Package()
			{
				Name = "kendo.pdfviewer.js",
				Source = this.GetResourceURL($"{RESOURCES_ROOT}/pdfjs/pdf.js")
			});

			this.WidgetWiredEvents = new[] {
				"open",
				"error"
			};
		}
	}
}
