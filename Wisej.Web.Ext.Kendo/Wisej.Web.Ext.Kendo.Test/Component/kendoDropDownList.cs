using System;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoDropDownList : TestBase
	{
		public kendoDropDownList()
		{
			InitializeComponent();

			this.kendoDropDownList1.Instance.change += new WidgetEventHandler(kendoDropDownList1_WidgetEvent);
			this.kendoDropDownList1.Instance.select += new WidgetEventHandler(kendoDropDownList1_WidgetEvent);
		}

		private void kendoDropDownList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void kendoDropDownList_Load(object sender, EventArgs e)
		{
			this.kendoDropDownList1.Options.dataSource = new[] {
				new { name = "Apples" },
				new { name = "Oranges" }
			};
			this.kendoDropDownList1.Options.dataTextField = "name";
			this.kendoDropDownList1.Options.dataValueField = "name";
		}
	}
}
