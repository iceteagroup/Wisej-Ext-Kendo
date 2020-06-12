using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoDropDownList : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoDropDownList()
		{
			InitializeComponent();

			this.kendoDropDownList1.Widget.change += new WidgetEventHandler(kendoDropDownList1_WidgetEvent);
			this.kendoDropDownList1.Widget.select += new WidgetEventHandler(kendoDropDownList1_WidgetEvent);
		}

		private void kendoDropDownList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
