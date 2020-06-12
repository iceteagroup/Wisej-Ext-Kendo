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
	/// The Grid is a powerful control for displaying data in a tabular format.
	/// </summary>
	public class kendoGrid : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoGrid"/> class.
		/// </summary>
		public kendoGrid() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoGrid"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoGrid(object options) : base("kendoGrid", options)
		{
			this.WidgetWiredEvents = new[] {
				"beforeEdit",
				"cancel",
				"cellClose",
				"change",
				"columnHide",
				"columnLock",
				"columnMenuInit",
				"columnMenuOpen",
				"columnReorder",
				"columnResize",
				"columnShow",
				"columnUnlock",
				"dataBinding",
				"dataBound",
				"detailCollapse",
				"detailExpand",
				"detailInit",
				"edit",
				"excelExport",
				"filter",
				"filterMenuInit",
				"filterMenuOpen",
				"group",
				"groupCollapse",
				"groupExpand",
				"navigate",
				"page",
				"pdfExport",
				"remove",
				"save",
				"saveChanges",
				"sort"
			};
		}
	}
}
