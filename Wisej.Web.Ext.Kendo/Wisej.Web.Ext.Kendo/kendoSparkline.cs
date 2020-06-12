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
	/// The Kendo UI Sparkline is a very small chart that is drawn without axes, coordinates, 
	/// legends, titles, or other chart-specific elements.
	/// </summary>
	public class kendoSparkline : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoSparkline"/> class.
		/// </summary>
		public kendoSparkline() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoSparkline"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoSparkline(object options) : base("kendoSparkline", options)
		{
			this.WidgetWiredEvents = new[] {
				"axisLabelClick",
				"dataBound",
				"dragStart",
				"drag",
				"dragEnd",
				"plotAreaClick",
				"plotAreaHover",
				"plotAreaLeave",
				"seriesClick",
				"seriesHover",
				"seriesOver",
				"seriesLeave",
				"zoomStart",
				"zoom",
				"zoomEnd"
			};
		}
	}
}
