//# sourceURL=wisej.web.ext.KendoWidget.kendoDiagram.js

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

		//case "change":
		//	return {
		//		added: args.added,
		//		removed: args.removed
		//	};
			
		//case "click":
		//	return {
		//		item: args.item,
		//		point: args.point
		//	};

		//case "itemBoundsChange":
		//	return args.bounds;

		//case "select":
		//	return {
		//		selected: args.selected,
		//		deselected: args.deselected
		//	};

		case "toolBarclick":
			return args.action;

	}
}