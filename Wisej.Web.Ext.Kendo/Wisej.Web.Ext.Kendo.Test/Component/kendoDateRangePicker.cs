﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoDateRangePicker : TestBase
	{
		public kendoDateRangePicker()
		{
			InitializeComponent();

			this.kendoDateRangePicker1.Instance.change += new WidgetEventHandler(kendoDateRangePicker1_WidgetEvent);
		}

		private void kendoDateRangePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
