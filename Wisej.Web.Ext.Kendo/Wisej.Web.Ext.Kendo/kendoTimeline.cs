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
	/// The Kendo UI Timeline widget displays a collection of events and their data in a chronological 
	/// succession for each year.
	/// </summary>
	public class kendoTimeline : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoTimeline"/> class.
		/// </summary>
		public kendoTimeline() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoTimeline"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoTimeline(object options) : base("kendoTimeline", options)
		{
			this.WidgetWiredEvents = new[] {
				"change",
				"dataBound",
				"expand",
				"collapse",
				"actionClick",
				"navigate"
			};
		}
	}
}
