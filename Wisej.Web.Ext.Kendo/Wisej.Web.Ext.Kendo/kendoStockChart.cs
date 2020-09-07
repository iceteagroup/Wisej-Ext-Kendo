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
	/// The StockChart is a specialized control visualizing the price movement of any 
	/// financial instrument over a certain period of time.
	/// </summary>
	public class kendoStockChart : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoStockChart"/> class.
		/// </summary>
		public kendoStockChart() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoStockChart"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoStockChart(object options) : base("kendoStockChart", options)
		{
			this.WiredEvents = new[] {
				"axisLabelClick",
				"dataBound",
				"dragStart",
				"drag",
				"dragEnd",
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
				"zoomStart",
				"zoom",
				"zoomEnd"
			};
		}
	}
}
