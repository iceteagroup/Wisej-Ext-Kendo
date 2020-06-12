using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoPanelBar : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoPanelBar()
		{
			InitializeComponent();

			this.kendoPanelBar1.Widget.select += new WidgetEventHandler(kendoPanelBar1_WidgetEvent);
		}

		private void kendoPanelBar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
