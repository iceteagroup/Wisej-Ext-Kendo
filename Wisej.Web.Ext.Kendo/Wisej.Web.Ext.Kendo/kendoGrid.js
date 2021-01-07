//# sourceURL=wisej.web.ext.KendoWidget.kendoGrid.js

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
 * Changes configuration before initialization.
 */
this.filterOptions = function (options) {

	var serviceUrl = this.getServiceUrl();

	if (!options.pdf) {

		options.pdf = {
			forceProxy: true,
			proxyURL: serviceUrl + "?action=export",
		}
	}

	if (!options.excel) {

		options.excel = {
			forceProxy: true,
			proxyURL: serviceUrl + "?action=export",
		}
	}

	// remove the event handler or it will create a hierarchical column.
	if (!options.detailTemplate) {
		options.detailInit = null;
	}

	var columns = options.columns;
	if (columns) {
		for (i = 0; i < columns.length; i++) {
			var command = columns[i].command;
			if (command) {
				var click = command.click;
				if (click) {
					command.click = this.initFunction(click);
				}
			}
		}
	}
};

/**
 * Filters the event data for Wisej.
 * @param {any} args
 */
this.filterEventData = function (args) {

	switch (args.type) {

		case "cellClose":
			return args.type;

		case "columnHide":
		case "columnLock":
			return args.column;

		case "columnMenuOpen":
			return args.field;

		case "columnReorder":
			return {
				column: args.column,
				newIndex: args.newIndex,
				oldIndex: args.oldIndex,
			};

		case "columnResize":
			return {
				column: args.column,
				newWidth: args.newWidth,
				oldWidth: args.oldWidth
			};

		case "columnShow":
			return args.column;

		case "columnUnlock":
			return args.column;

	}
}