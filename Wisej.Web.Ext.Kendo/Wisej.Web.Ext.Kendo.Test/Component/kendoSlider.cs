﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoSlider : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoSlider()
		{
			InitializeComponent();

			this.kendoSlider1.Widget.change += new WidgetEventHandler(kendoSlider1_WidgetEvent);
		}

		private void kendoSlider1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
