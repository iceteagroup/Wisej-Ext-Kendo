﻿//# sourceURL=wisej.web.ext.KendoWidget.kendoChart.js

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
 * Overrides the default configuration.
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

/**
 * Handles the promise resulting from saveImage() and returns the image data to the server.
 **/
this.exportImageData = function (type) {

	if (!type)
		return;

	var promise;
	var serviceUrl = this.getServiceUrl();
	switch (type.toLowerCase()) {

		case "svg":
			promise = this.widget.exportSVG();
			break;

		case "png":
			promise = this.widget.exportImage();
			break;

	}

	promise.done(function (data) {
		// data is the png image data uri.
		kendo.saveAs({
			dataURI: data,
			fileName: "chart." + type.toLowerCase(),
			forceProxy: true,
			proxyURL: serviceUrl + "?action=export"
		});
	});
}

/**
 * Filters the event data for Wisej.
 **/
this.filterEventData = function (args) {

	switch (args.type) {

		case "axisLabelClick":
			return {
				index: args.index,
				text: args.text,
				value: args.value
			};

		case "legendItemClick":
			return {
				pointIndex: args.pointIndex,
				seriesIndex: args.seriesIndex,
				text: args.text
			};

		case "noteClick":
			return {
				value: args.value
			};

		case "plotAreaClick":
			return {
				value: args.value,
				x: args.x,
				y: args.y
			};

		case "select":
			return {
				from: args.from,
				to: args.to
			};

		case "seriesClick":
			return {
				category: args.category,
				percentage: args.percentage,
				name: args.series.name,
				value: args.value
			};
	}
};