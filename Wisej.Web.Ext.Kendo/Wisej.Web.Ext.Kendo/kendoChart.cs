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
	/// The Kendo UI Chart uses modern browser technologies to render high-quality data visualizations.
	/// </summary>
	public class kendoChart : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoChart"/> class.
		/// </summary>
		public kendoChart() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoChart"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoChart(object options) : base("kendoChart", options)
		{
			this.WidgetWiredEvents = new[] {
				"axisLabelClick",
				"dataBound",
				"drag",
				"dragEnd",
				"dragStart",
				"legendItemClick",
				"legendItemHover",
				"legendItemLeave",
				"noteClick",
				"noteHover",
				"noteLeave",
				"plotAreaClick",
				"plotAreaHover",
				"plotAreaLeave",
				"select",
				"selectEnd",
				"selectStart",
				"seriesClick",
				"seriesHover",
				"seriesOver",
				"seriesLeave",
				"zoom",
				"zoomEnd",
				"zoomStart"
			};
		}
	}
}
