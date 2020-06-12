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
	/// The AutoComplete provides suggestions depending on the typed text and allows multiple value entries.
	/// </summary>
	public class kendoAutoComplete : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoAutoComplete"/> class.
		/// </summary>
		public kendoAutoComplete() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoAutoComplete"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoAutoComplete(object options) : base("kendoAutoComplete", "<input style='width:100%;height:100%;box-sizing:border-box;'>", options)
		{
			this.WidgetWiredEvents = new[] {
				"change",
				"close",
				"dataBound",
				"filtering",
				"open",
				"select"
			};
		}
	}
}
