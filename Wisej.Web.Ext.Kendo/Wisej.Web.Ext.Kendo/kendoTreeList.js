//# sourceURL=wisej.web.ext.KendoWidget.kendoTreeList.js

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
 * Process the options map before it is used to
 * create or update the widget.
 */
this.filterOptions = function (options) {

	var columns = options.columns;
	if (columns) {
		for (var i = 0; i < columns.length; i++) {
			var column = columns[i];
			var template = column.template;
			if (template) {
				// convert string to html dom element.
				column.template = $(template).html();
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

		case "columnShow":
		case "columnHide":
		case "columnLock":
		case "columnUnlock":
		case "columnMenuInit":
		case "columnMenuOpen":
			return {
				column: args.column,
				field: args.field,
			};

		case "columnReorder":
			return {
				column: args.column,
				newIndex: args.newIndex,
				oldIndex: args.oldIndex
			};

		case "columnResize":
			return {
				column: args.column,
				newWidth: args.newWidth,
				oldWidth: args.oldWidth
			};
	}
}