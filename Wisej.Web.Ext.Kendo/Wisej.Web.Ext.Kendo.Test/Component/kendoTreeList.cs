using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoTreeList : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoTreeList()
		{
			InitializeComponent();

			this.kendoTreeList1.Instance.change += new WidgetEventHandler(kendoTreeList1_WidgetEvent);
		}

		private void kendoTreeList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
