# <img src="https://wisej.com/wp-content/uploads/2018/09/Wisej-Black.png" height="42" align="top"/> Wisej-Kendo

Kendo UI is a comprehensive HTML5 user interface framework for building interactive and high-performance websites and applications. It comes with a library of 70+ UI widgets, an abundance of data-visualization gadgets, client-side data source, and a built-in MVVM (Model-View-ViewModel) library.


## Concept
For the premium Syncfusion, DevExtreme, Ignite UI, and Telerik KendoUI integration packages we have used an approach different from the other integrations we publish on the open Wisej repositories. In this case we wanted to use all the features that are available to javascript, angular, react, blazor developers instead of trying to build a limited .NET object hierarchy.

When you look at the code, you will find a common base class **kendoBase** for all the widgets classes. Overloaded constructors that indicate which kendo1 class to use, and a number of initialization options that may be different for some widgets.

The kendoBase class uses a custom **wisej.web.ext.Kendo** implementation that takes care of the creation and registration of events, methods, and templates. It also provides some simple methods to override in each derived class.

Each specific class has it's own nested .js file that may add specific functionality to filter event data to make it serializable for the server, make sure the wrapped widget fits the container, and whatever else may be needed to make the integration as smooth as possible.

All the premium extensions are open projects, meaning that we will keep adding, fixing, changing, and expanding them according to the requirements of our Technology Partners and needs we find on our projects using these extensions.

## License
To use this extension you need to acquire at least a **JavaScript Bundle** license from Infragistics: https://www.telerik.com/purchase/kendo-ui.

## Demo
Coming soon...

## Work in progress
The library and test are in progress - we are adding every available widget to the test app and will keep refining the intergration for the foreseable future.

## How to use
All the integrated widgets have 3 types of members: options, methods, and events. The options (you'll find them under "Configuration" in the API Reference documentation) are represented by a single javascript map. Methods are javascript functions. Events in the Kendo widgets are callback methods defined in the options map.

## Support

To log issues related to this extension, please use the Issues section of this repository. To log issues related to the usage of this extension in your projects, please use the Issues section in your Technology Partner repository.

You may also fork this project and modify it to fit your needs and if you want to share a change or fix, please create a pull request.

## Documentation

Kendo UI Documentation:

https://docs.telerik.com/kendo-ui/introduction

Kendo UI API:

https://docs.telerik.com/kendo-ui/api/javascript/kendo

Kendo UI Demos:

https://demos.telerik.com/kendo-ui/


## Redistribution

We have bundled the entire set of JS widgets, themes, and assets in the Wisej.Web.Ext.Kendo assembly as embedded resources. You need to deploy only 1 assembly and your client devices don't need an open internet connection.

## Update

The Kendo UI assets are located in /JavaScript using the same directory structure used in the installation zip you receive from Telerik when you purchase the license. To update the version of the JS library, simply copy the files over and recompile the project.



---
<img src="http://iceteagroup.com/wp-content/uploads/2017/01/Square-64x64-trasp.png" height="20" align="top"> Copyright (C) ICE TEA GROUP LLC, All rights reserved.
