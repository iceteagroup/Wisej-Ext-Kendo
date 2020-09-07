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
	/// The Scheduler displays a set of events, appointments, or tasks.
	/// </summary>
	public class kendoScheduler : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoScheduler"/> class.
		/// </summary>
		public kendoScheduler() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoScheduler"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoScheduler(object options) : base("kendoScheduler", options)
		{
			this.WiredEvents = new[] {
				"add",
				"cancel",
				"change",
				"dataBinding",
				"dataBound",
				"edit",
				"moveStart",
				"move",
				"moveEnd",
				"navigate",
				"pdfExport",
				"remove",
				"resizeStart",
				"resize",
				"resizeEnd",
				"save"
			};
		}
	}
}
