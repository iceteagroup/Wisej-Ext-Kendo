using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoScrollView : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoScrollView()
		{
			InitializeComponent();

			this.kendoScrollView1.Widget.change += new WidgetEventHandler(kendoScrollView1_WidgetEvent);
		}

		private void kendoScrollView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
