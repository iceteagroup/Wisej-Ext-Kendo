using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoListView : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoListView()
		{
			InitializeComponent();

			this.kendoListView1.Instance.change += new WidgetEventHandler(kendoListView1_WidgetEvent);
			this.kendoListView1.Instance.edit += new WidgetEventHandler(kendoListView1_WidgetEvent);
		}
		private void kendoListView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoListView1.Options.bordered = this.checkBox1.Checked;
			this.kendoListView1.Options.scrollable = this.checkBox2.Checked;
			this.kendoListView1.Options.navigatable = this.checkBox3.Checked;
			this.kendoListView1.Options.selectable = this.checkBox4.Checked;

			this.kendoListView1.Update();
		}
	}
}
