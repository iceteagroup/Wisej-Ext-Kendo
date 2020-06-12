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
	/// The Breadcrumb is an intuitive UI component that allows navigation within a folder structure or web page. 
	/// It provides an easy way to navigate backwards by one or multiple steps.
	/// </summary>
	public class kendoBreadcrumb : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoBreadcrumb"/> class.
		/// </summary>
		public kendoBreadcrumb() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoBreadcrumb"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoBreadcrumb(object options) : base("kendoBreadcrumb", options)
		{
			this.WidgetWiredEvents = new[] {
				"click",
				"change"
			};
		}
	}
}
