using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoSpreadsheet : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoSpreadsheet()
		{
			InitializeComponent();

			this.kendoSpreadsheet1.Widget.select += new WidgetEventHandler(kendoSpreadsheet1_WidgetEvent);
			this.kendoSpreadsheet1.Widget.change += new WidgetEventHandler(kendoSpreadsheet1_WidgetEvent);
		}

		private void kendoSpreadsheet1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
