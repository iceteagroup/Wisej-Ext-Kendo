//# sourceURL=wisej.web.ext.KendoWidget.kendoScheduler.js

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
 * Filters the event data for Wisej.
 **/
this.filterEventData = function (args) {

	switch (args.type) {

		case "add":
		case "move":
		case "save":
		case "remove":
			return {
				id: args.event.id,
				title: args.event.title,
				description: args.event.description,
				start: args.event.start,
				end: args.event.end,
				recurrenceRule: args.event.recurrenceRule,
				startTimezone: args.event.startTimezone,
				uid: args.event.uid
			};

		case "change":
			return {
				start: args.start,
				end: args.end,
			};
	}
}

/**
 * Override default functionality.
 * @param {any} options The widget's configuration.
 */
this.filterOptions = function (options) {

	if (!options.pdf) {

		var serviceUrl = this.getServiceUrl();
		options.pdf = {
			proxyURL: serviceUrl + "?action=export",
			forceProxy: true
		}
	}
}