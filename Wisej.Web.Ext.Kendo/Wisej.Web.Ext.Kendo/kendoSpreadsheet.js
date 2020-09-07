//# sourceURL=wisej.web.ext.KendoWidget.kendoSpreadsheet.js

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
 * Performs additional option configuration.
 * @param {any} options
 */
this.filterOptions = function (options) {

	var serviceUrl = this.getServiceUrl();

	if (!options.excel) {
		options.excel = {
			forceProxy: true,
			proxyURL: serviceUrl + "?export=excel"
		};
	}

	if (options.pdf) {

		if (!options.pdf.proxyURL) {
			options.pdf.forceProxy = true,
			options.pdf.proxyURL = serviceUrl + "?export=pdf"
		}
	} else {

		options.pdf = {
			forceProxy: true,
			proxyURL: serviceUrl + "?export=pdf"
		}
	}
}

/**
 * Updates the widget when the options object changes.
 *
 * @param options {Map} Options map (optional).
 * @param old {Map} Previous options map (optional).
 **/
this.update = function (options, old) {

	// make a copy of the worksheet data.
	var data = this.widget.toJSON();

	this.widget.destroy();
	this.container.innerHTML = "";

	this.init(options);

	// reapply data.
	this.widget.fromJSON(data);
}

/**
 * Filters the event data for Wisej.
 **/
this.filterEventData = function (args) {

	switch (args.type) {

		case "cut":
		case "copy":
		case "change":
		case "select":
		case "changeFormat":
			return args.range.values();

		case "removeSheet":
		case "selectSheet":
			return args.sheet.toJson();

		case "renameSheet":
			return {
				sheet: e.sheet.toJson(),
				newSheetName: e.newSheetName
			};

		case "hideRow":
		case "insertRow":
		case "deleteRow":
		case "unhideRow":
		case "hideColumn":
		case "insertColumn":
		case "deleteColumn":
		case "unhideColumn":
			return {
				index: e.index,
				sheet: e.sheet.toJson()
			};

		default:
			break;

	}
};