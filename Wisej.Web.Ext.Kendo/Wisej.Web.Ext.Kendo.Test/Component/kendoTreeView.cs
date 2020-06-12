using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoTreeView : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoTreeView()
		{
			InitializeComponent();

			this.kendoTreeView1.Widget.change += new WidgetEventHandler(kendoTreeView1_WidgetEvent);
			this.kendoTreeView1.Widget.check += new WidgetEventHandler(kendoTreeView1_WidgetEvent);
		}

		private void kendoTreeView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
