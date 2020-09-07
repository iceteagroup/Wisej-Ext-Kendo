﻿///////////////////////////////////////////////////////////////////////////////
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
	/// The MultiColumnComboBox visualizes huge sets of data in a grid-like table.
	/// </summary>
	public class kendoMultiColumnComboBox : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoMultiColumnComboBox"/> class.
		/// </summary>
		public kendoMultiColumnComboBox() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoMultiColumnComboBox"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoMultiColumnComboBox(object options) : base("kendoMultiColumnComboBox", options)
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
