using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoStepper : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoStepper()
		{
			InitializeComponent();

			this.kendoStepper1.Widget.select += new WidgetEventHandler(kendoStepper1_WidgetEvent);
		}

		private void kendoStepper1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
