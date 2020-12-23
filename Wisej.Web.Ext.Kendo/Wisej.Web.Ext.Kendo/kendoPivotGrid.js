//# sourceURL=wisej.web.ext.KendoWidget.kendoPivotGrid.js

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

		case "expandMember":
		case "collapseMember":
			return {
				axis: args.axis,
				path: args.path
			};
	}
}

/**
 * Changes configuration before initialization.
 */
this.filterOptions = function (options) {

	var serviceUrl = this.getServiceUrl();

	if (!options.pdf) {

		options.pdf = {
			proxyURL: serviceUrl + "?action=export",
			forceProxy: true
		}
	}

	if (!options.excel) {

		options.excel = {
			proxyURL: serviceUrl + "?action=export",
			forceProxy: true
		}
	}
};