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
	/// The Gantt displays a set of tasks and dependencies which are used to visualize project-planning data.
	/// </summary>
	public class kendoGantt : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoGantt"/> class.
		/// </summary>
		public kendoGantt() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoGantt"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoGantt(object options) : base("kendoGantt", options)
		{
			this.WidgetWiredEvents = new[] {
				"dataBinding",
				"dataBound",
				"add",
				"edit",
				"remove",
				"cancel",
				"save",
				"change",
				"columnResize",
				"navigate",
				"moveStart",
				"move",
				"moveEnd",
				"pdfExport",
				"resizeStart",
				"resize",
				"resizeEnd"
			};
		}
	}
}
