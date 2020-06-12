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
	/// The Kendo UI PivotGrid represents multidimensional data in a cross-tabular format.
	/// </summary>
	public class kendoPivotGrid : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoPivotGrid"/> class.
		/// </summary>
		public kendoPivotGrid() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoPivotGrid"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoPivotGrid(object options) : base("kendoPivotGrid", options)
		{
			this.WidgetWiredEvents = new[] {
				"dataBinding",
				"dataBound",
				"expandMember",
				"collapseMember",
				"excelExport",
				"pdfExport"
			};
		}
	}
}
