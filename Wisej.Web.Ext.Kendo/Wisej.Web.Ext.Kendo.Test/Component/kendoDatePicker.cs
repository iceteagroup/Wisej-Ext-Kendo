using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoDatePicker : TestBase
	{
		public kendoDatePicker()
		{
			InitializeComponent();

			this.kendoDatePicker1.Widget.change += new WidgetEventHandler(kendoDatePicker1_WidgetEvent);
		}

		private void kendoDatePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
