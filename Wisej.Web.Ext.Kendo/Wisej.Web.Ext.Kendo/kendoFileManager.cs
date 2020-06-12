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
	/// The Kendo UI FileManager allows you to manage the file system and to perform the most common folder/file operations.
	/// </summary>
	public class kendoFileManager : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoFileManager"/> class.
		/// </summary>
		public kendoFileManager() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoFileManager"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoFileManager(object options) : base("kendoFileManager", options)
		{
			this.WidgetWiredEvents = new[] {
				"navigate",
				"select",
				"open",
				"execute",
				"error",
				"dataBinding",
				"dataBound",
				"drop"
			};
		}
	}
}
