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
	/// The Kendo UI ListView enables you to display a custom layout of data-bound items.
	/// </summary>
	public class kendoListView : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoListView"/> class.
		/// </summary>
		public kendoListView() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoListView"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoListView(object options) : base("kendoListView", options)
		{
			this.WidgetWiredEvents = new[] {
				"cancel",
				"change",
				"dataBound",
				"dataBinding",
				"edit",
				"remove",
				"save"
			};
		}
	}
}
