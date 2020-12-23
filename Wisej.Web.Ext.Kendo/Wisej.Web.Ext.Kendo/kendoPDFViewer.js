//# sourceURL=wisej.web.ext.KendoWidget.kendoPDFViewer.js

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

		case "open":
			return {
				name: args.file.name,
				extension: args.file.extension,
				size: args.file.size,
				uid: args.file.uid
			};

		case "error":
			return e.message;
	}
}

/**
 * Overrides default resizing functionality.
 */
this.initWidget = function (options) {

	if (this.widget)
		this.widget.element[0].style.width = "100%";
}