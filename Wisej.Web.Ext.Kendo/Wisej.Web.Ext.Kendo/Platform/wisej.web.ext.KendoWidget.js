﻿///////////////////////////////////////////////////////////////////////////////
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
 * wisej.web.ext.KendoWidget
 *
 * Wraps all the basic functionality of KendoUI.
 */
qx.Class.define("wisej.web.ext.KendoWidget", {

	extend: wisej.web.Widget,

	construct: function () {

		this.base(arguments);

		this.addListener("focus", this._onFocus);
	},

	properties: {

		/**
		 * The culture that gets applied to the widget.
		 */
		culture: { init: null, check: "String" },

		/**
		 * WidgetClass property.
		 *
		 * The name of the actual kn javascript class.
		 */
		widgetClass: { init: null, check: "String" },

		/**
		 * Additional HTML to add to the inner container that may be needed by the widget.
		 */
		widgetHtml: { init: null, check: "String" },

		/**
		 * Collection of event handlers to attach to the widget's events.
		 */
		widgetEvents: { init: [], check: "Array" },

		/**
		 * Collection of additional javascript methods to add to the widget.
		 */
		widgetFunctions: { init: [], check: "Array", apply: "_applyWidgetFunctions" },

		/**
		 * Collection of template scripts to register with the browser.
		 */
		widgetTemplates: { init: [], check: "Array", apply: "_applyWidgetTemplates" }
	},

	members: {

		/**
		 * Initializes the widget.
		 *
		 * This function is called when the InitScript property of
		 * wisej.web.Widget changes.
		 *
		 * 'this' refers to the container which is a wisej.web.Widget instance.
		 *
		 * 'this.container' refers to the DOM element and can be used to initialize
		 * the third party javascript widget.
		 *
		 * @param options {Map} Options map (optional).
		 */
		init: function (options) {

			var currentCulture = this.getCulture();
			var kendoCulture = kendo.getCulture().name;

			if (currentCulture !== kendoCulture) {
				kendo.culture(currentCulture);
			}

			var html = this.getWidgetHtml();
			if (html) {
				this.container.innerHTML = html;
				this.container = this.container.firstChild;
			}

			if (this.filterOptions)
				this.filterOptions(options);

			this._registerEventHandlers(options);
			var className = this.getWidgetClass();
			this.widget = $(this.container)[className](options).data(className);

			// make all Kendo UI widgets fit nicely in Wisej Widget containers.
			this.widget.element[0].style.boxSizing = "border-box";

			// resize the hosted widget when this is resized.
			this.addListener("resize", function (e) {

				// force the DOM update now, or the hosted
				// widget will find the container element with the previous size.
				qx.ui.core.queue.Manager.flush();

				qx.event.Timer.once(this.resizeWidget, this, 0);
			});

			qx.event.Timer.once(this.resizeWidget, this, 0);
		},

		/**
		 * Updates the widget when the options object changes.
		 *
		 * @param options {Map} Options map (optional).
		 * @param old {Map} Previous options map (optional).
		 */
		update: function (options, old) {

			if (this.filterOptions)
				this.filterOptions(options, old);

			this.widget.setOptions(options);
		},

		/**
		 * Resizes the hosted widget to always fit our container.
		 */
		resizeWidget: function () {

			if (this.widget)
				this.widget.resize();
		},

		// registers the user functions with this widget class.
		// if their names collide with existing functions they will
		// override them. collisions are logged in the console.
		_registerFunctions: function (functions) {

			var name, source;

			if (functions && functions.length > 0) {
				for (var i = 0; i < functions.length; i++) {
					name = functions[i].name;
					if (!name) continue;
					source = functions[i].source;
					if (!source) continue;

					var func = new Function("//# sourceURL=" + this.getName() + "." + name +
						"\r\n\r\n" + source);

					if (this[name] !== undefined)
						this.core.logWarning("Function " + name + " is being overridden.");

					this[name] = this._makeFunctionWrapper(name, func);
				}
			}
		},

		// creates a wrapper for the user function.
		_makeFunctionWrapper: function (name, func) {

			var me = this;
			function wrapper() {

				if (!me.widget) {
					var args = Array.prototype.slice.call(arguments);
					me.addListenerOnce('initialized', function (e) {
						func.apply(me, args);
					});
					return;
				}

				return func.apply(me, arguments);
			};

			return wrapper;
		},

		// attaches the specified event callback functions
		// to the options map.
		_registerEventHandlers: function (options) {

			var name, source, eventName;
			var wiredEvents = this.getEvents();
			var handlers = this.getWidgetEvents();

			if (handlers && handlers.length > 0) {
				for (var i = 0; i < handlers.length; i++) {
					name = handlers[i].name;
					if (!name) continue;

					source = handlers[i].source;
					if (!source) continue;

					eventName = qx.lang.String.camelCase(name);

					var handler = new Function("e",
						"//# sourceURL=" + this.getName() + "." + eventName +
						"\r\n\r\n" + source);

					options[eventName] = this._makeEventHandler(handler, name);
				}
			}

			if (wiredEvents && wiredEvents.length > 0) {
				for (var i = 0; i < wiredEvents.length; i++) {
					for (var i = 0; i < wiredEvents.length; i++) {
						name = wiredEvents[i];
						if (!name) continue;

						eventName = qx.lang.String.camelCase(name);

						if (options[eventName] === undefined) {
							options[eventName] = this._makeEventHandler(null, name);
						}
					}
				}
			}
		},

		//creates a closure to handle a widget's event callback.
		_makeEventHandler: function (handler, type) {

			var me = this;
			var eventType = type;

			function callback(args) {

				args.container = me;

				if (handler)
					handler.call(this, args);

				var wiredEvents = me.getEvents();
				if (wiredEvents && wiredEvents.indexOf(eventType) > -1) {

					// make sure there is always one field or
					// the wisej system sends null instead of {}.
					args.type = eventType;
					var eventData = me.filterEventData(args);

					me.fireWidgetEvent(
						eventType,
						eventData);
				}
			};

			return callback;
		},

		/**
		 * Initializes a function specified in the widgetFunctions array
		 * without waiting for the widget to be initialized.
		 */
		initFunction: function (name) {

			if (typeof (name) === "function")
				return name;

			if (typeof (name) === "string") {

				var functions = this.getWidgetFunctions();
				for (var i = 0; i < functions.length; i++) {
					if (functions[i].name == name) {

						var func = new Function("//# sourceURL=" + this.getName() + "." + name +
							"\r\n\r\n" + functions[i].source);

						return func.bind(this);
					}
				}
			}
		},

		initStyle: function (name) {

			if (typeof (name) === "string") {

				return $("#" + name);
			}
		},

		/**
		 * Returns a data map that can be converted to JSON.
		 */
		filterEventData: function (args) {
			return {};
		},

		/**
		 * Applies the WidgetFunctions property.
		 *
		 * Creates the user function on this widget.
		 */
		_applyWidgetFunctions: function (value, old) {

			this._registerFunctions(value);
		},

		/**
		 * Applies the WidgetTemplates property.
		 *
		 * Registers the custom templates functions received from the app.
		 */
		_applyWidgetTemplates: function (value, old) {

			var templates = value;
			if (!templates || templates.length == 0)
				return;

			var tpl, t;
			for (var i = 0; i < templates.length; i++) {

				t = templates[i];
				if (!t.id || !t.template)
					continue;

				// build the template <script id="id" type="text/x-jsrender">template</script>.
				tpl = document.createElement("script");
				tpl.id = t.id;
				tpl.innerHTML = t.template;
				tpl.type = t.type || "text/x-jsrender";
				document.body.appendChild(tpl);
			}

		},

		// fires the "render" event when in design mode to notify
		// the html renderer that the widget has been initialized.
		//
		// widgets may replace this function to fire the "render" event
		// according to the widget's implementation.
		//
		_onInitialized: function () {

			this.base(arguments);

			if (this.initWidget)
				this.initWidget();
		},

		// handles the "focus" event to try and set the
		// focus to the inner widget.
		_onFocus: function (e) {

			try {
				if (this.widget) {
					if (this.widget.wrapper)
						this.widget.wrapper.focus();
					else if (this.widget.element)
						this.widget.element.focus();
				}
			} catch (ex) { }
		}
	},

	destruct: function () {

		if (this.widget) {
			this.widget.destroy();
			this.widget = null;
		}
	}
});

