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
	/// The Spreadsheet allows you to edit and visualize tabular data by using cell formatting 
	/// options, styles, and themes.
	/// </summary>
	public class kendoSpreadsheet : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoSpreadsheet"/> class.
		/// </summary>
		public kendoSpreadsheet() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoSpreadsheet"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoSpreadsheet(object options) : base("kendoSpreadsheet", options)
		{
			this.WiredEvents = new[] {
				"insertSheet",
				"removeSheet",
				"renameSheet",
				"selectSheet",
				"unhideColumn",
				"unhideRow",
				"hideColumn",
				"hideRow",
				"deleteColumn",
				"deleteRow",
				"insertColumn",
				"insertRow",
				"select",
				"changeFormat",
				"changing",
				"change",
				"excelExport",
				"excelImport",
				"pdfExport",
				"copy",
				"cut",
				"paste",
				"dataBinding",
				"dataBound"
			};
		}
	}
}
