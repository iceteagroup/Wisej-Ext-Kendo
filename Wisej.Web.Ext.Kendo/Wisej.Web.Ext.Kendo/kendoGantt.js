//# sourceURL=wisej.web.ext.KendoWidget.kendoGantt.js

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

/**
 * Check for string dataSource
 */
this.filterOptions = function (options) {

	if (typeof (options.dataSource) === "string") {

		var url = options.dataSource;
		options.dataSource = new kendo.data.GanttDataSource({
			transport: {
				read: {
					url: url,
					dataType: "jsonp"
				}
			}
		});
	}

	if (!options.pdf) {

		var serviceUrl = this.getServiceUrl();
		options.pdf = {
			proxyURL: serviceUrl + "?action=export",
			forceProxy: true,
		}
	}
}

/**
 * Filters the event data for Wisej.
 * @param {any} args
 */
this.filterEventData = function (args) {

	switch (args.type) {

		case "save":
			return {
				values: args.values
			};

		case "columnResize":
			return {
				newWidth: args.newWidth,
				oldWidth: args.oldWidth,
			};

		case "navigate":
			return args.view;

		case "move":
			return {
				start: args.start,
				end: args.end
			};

		case "resize":
			return {
				start: args.start,
				end: args.end
			};

	}
}