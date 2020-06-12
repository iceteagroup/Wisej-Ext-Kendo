﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoFileManager : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoFileManager()
		{
			InitializeComponent();

			this.kendoFileManager1.Widget.navigate += new WidgetEventHandler(kendoFileManager1_WidgetEvent);
			this.kendoFileManager1.Widget.select += new WidgetEventHandler(kendoFileManager1_WidgetEvent);
			this.kendoFileManager1.Widget.execute += new WidgetEventHandler(kendoFileManager1_WidgetEvent);
		}

		private void kendoFileManager1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
