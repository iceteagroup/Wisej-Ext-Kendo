﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoPDFViewer : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoPDFViewer()
		{
			InitializeComponent();

			this.kendoPDFViewer1.Instance.open += new WidgetEventHandler(kendoPDFViewer1_WidgetEvent);
		}

		private void kendoPDFViewer1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
