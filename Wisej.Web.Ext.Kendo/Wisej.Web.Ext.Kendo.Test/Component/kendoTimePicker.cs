﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoTimePicker : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoTimePicker()
		{
			InitializeComponent();

			this.kendoTimePicker1.Widget.change += new WidgetEventHandler(kendoTimePicker1_WidgetEvent);
		}

		private void kendoTimePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
