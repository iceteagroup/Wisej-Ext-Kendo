﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoTimeline : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoTimeline()
		{
			InitializeComponent();

			this.kendoTimeline1.Widget.change += new WidgetEventHandler(kendoTimeline1_WidgetEvent);
		}

		private void kendoTimeline1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
