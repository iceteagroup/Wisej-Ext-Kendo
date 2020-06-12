using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoAutoComplete : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoAutoComplete()
		{
			InitializeComponent();

			this.kendoAutoComplete1.Widget.change += new WidgetEventHandler(kendoAutoComplete1_WidgetEvent);
			this.kendoAutoComplete1.Widget.select += new WidgetEventHandler(kendoAutoComplete1_WidgetEvent);
		}

		private void kendoAutoComplete1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			// enable / disable animations.
			if (this.checkBox1.Checked)
			{
				this.kendoAutoComplete1.Options.animation = new
				{
					close = new 
					{
						effects = "fadeOut zoom:out",
						duration = 300
					},
					open = new
					{
						effects = "fadeIn zoom:in",
						duration = 300
					}
				};
			}
			else
			{
				this.kendoAutoComplete1.Options.animation = false;
			}

			this.kendoAutoComplete1.Update();
		}
	}
}
