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
	/// The Map displays geospatial information organized in layers and is supported 
	/// for both desktop and mobile devices.
	/// </summary>
	public class kendoMap : kendoBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="kendoMap"/> class.
		/// </summary>
		public kendoMap() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="kendoMap"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public kendoMap(object options) : base("kendoMap", options)
		{
			this.WidgetWiredEvents = new[] {
				"beforeReset",
				"click",
				"markerActivate",
				"markerCreated",
				"markerClick",
				"pan",
				"panEnd",
				"reset",
				"shapeClick",
				"shapeCreated",
				"shapeFeatureCreated",
				"shapeMouseEnter",
				"shapeMouseLeave",
				"zoomStart",
				"zoomEnd"
			};
		}
	}
}
