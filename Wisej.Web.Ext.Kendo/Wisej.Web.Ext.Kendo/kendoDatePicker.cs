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
	/// The DatePicker enables the user to select a date from a calendar or through a direct input.
	/// </summary>
	public class kendoDatePicker : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoDatePicker"/> class.
		/// </summary>
		public kendoDatePicker() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoDatePicker"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoDatePicker(object options) : base("kendoDatePicker", "<input style='width:100%;height:100%;'>", options)
		{
			this.WiredEvents = new[] {
				"change",
				"close",
				"open"
			};
		}
	}
}
