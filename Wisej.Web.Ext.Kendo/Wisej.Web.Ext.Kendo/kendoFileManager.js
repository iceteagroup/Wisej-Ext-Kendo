﻿//# sourceURL=wisej.web.ext.KendoWidget.FileManager.js

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
 * @param {any} args
 */
this.filterEventData = function (args) {

	switch (args.type) {

		case "navigate":
			return args.path;

		case "select":
			var entries = [];
			args.entries.forEach(function (e) { entries.push(e.id); }, this);
			return entries;

		case "open":
			return args.entry.id;

		case "execute":
			return {
				command: args.command,
				options: args.options
			};

		case "drop":
			return {
				target: args.target,
				items: args.items
			};
	}
}