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
	/// The DropDownList displays a list of values and allows for a single selection from the list.
	/// </summary>
	public class kendoDropDownList : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoDropDownList"/> class.
		/// </summary>
		public kendoDropDownList() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoDropDownList"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoDropDownList(object options) : base("kendoDropDownList", options)
		{
			this.WiredEvents = new[] {
				"change",
				"close",
				"dataBound",
				"filtering",
				"open",
				"select",
				"cascade"
			};
		}
	}
}
