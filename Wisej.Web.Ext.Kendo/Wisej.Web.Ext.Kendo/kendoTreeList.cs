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
	/// The TreeList enables the display of self-referencing tabular data and allows sorting, 
	/// filtering, and data editing.
	/// </summary>
	public class kendoTreeList : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoTreeList"/> class.
		/// </summary>
		public kendoTreeList() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoTreeList"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoTreeList(object options) : base("kendoTreeList", options)
		{
			this.WiredEvents = new[] {
				"beforeEdit",
				"cancel",
				"cellClose",
				"change",
				"collapse",
				"dataBinding",
				"dataBound",
				"dragstart",
				"drag",
				"dragend",
				"drop",
				"edit",
				"excelExport",
				"expand",
				"filterMenuInit",
				"filterMenuOpen",
				"pdfExport",
				"remove",
				"save",
				"saveChanges",
				"columnShow",
				"columnHide",
				"columnReorder",
				"columnResize",
				"columnMenuInit",
				"columnMenuOpen",
				"columnLock",
				"columnUnlock"
			};
		}
	}
}
