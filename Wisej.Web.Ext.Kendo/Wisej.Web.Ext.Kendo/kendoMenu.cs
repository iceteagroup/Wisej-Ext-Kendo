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
	/// The Menu displays hierarchical data as a multi-level menu.
	/// </summary>
	public class kendoMenu : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoMenu"/> class.
		/// </summary>
		public kendoMenu() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoMenu"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoMenu(object options) : base("kendoMenu", options)
		{
			this.WiredEvents = new[] {
				"close",
				"dataBound",
				"open",
				"activate",
				"deactivate",
				"select"
			};
		}
	}
}
