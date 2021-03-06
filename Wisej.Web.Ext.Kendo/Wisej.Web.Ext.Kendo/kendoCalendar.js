﻿//# sourceURL=wisej.web.ext.KendoWidget.kendoCalendar.js

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
 * Performs additional widget configuration.
 * @param {any} options
 */
this.initWidget = function (options) {

	this.getContentElement().setStyle("text-align", "center");
}

/**
 * Override the default resizing functionality. 
 **/
this.resizeWidget = function () {
}

/**
 * Filters the event data for Wisej.
 **/
this.filterEventData = function (args) {

	switch (args.type) {

		case "change":
			return args.sender.value();

		case "navigate":
			return args.sender.view().name;

	}
};