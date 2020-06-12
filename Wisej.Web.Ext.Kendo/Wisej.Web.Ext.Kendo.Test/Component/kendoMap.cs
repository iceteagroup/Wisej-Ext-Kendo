using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoMap : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoMap()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoMap1.Options.pannable = this.checkBox1.Checked;
			this.kendoMap1.Options.wraparound = this.checkBox2.Checked;
			this.kendoMap1.Options.zoomable = this.checkBox3.Checked;
			this.kendoMap1.Options.minZoom = this.numericUpDown1.Value;
			this.kendoMap1.Options.maxZoom = this.numericUpDown2.Value;
			this.kendoMap1.Options.zoom = this.numericUpDown3.Value;

			this.kendoMap1.Update();
		}
	}
}
