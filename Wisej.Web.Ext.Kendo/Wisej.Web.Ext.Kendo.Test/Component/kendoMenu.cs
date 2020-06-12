using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoMenu : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoMenu()
		{
			InitializeComponent();

			this.kendoMenu1.Widget.select += new WidgetEventHandler(kendoMenu1_WidgetEvent);
		}

		private void kendoMenu1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
