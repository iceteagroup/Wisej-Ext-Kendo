using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoListBox : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoListBox()
		{
			InitializeComponent();

			this.kendoListBox1.Widget.add += new WidgetEventHandler(kendoListBox1_WidgetEvent);
			this.kendoListBox1.Widget.change += new WidgetEventHandler(kendoListBox1_WidgetEvent);
		}

		private void kendoListBox1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
