namespace Wisej.Web.Ext.Kendo.Test.Component
{
	partial class kendoDateTimePicker
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.kendoDateTimePicker1 = new Wisej.Web.Ext.Kendo.kendoDateTimePicker();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoDateTimePicker1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/datetimepicker/index";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/datetimepicker";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/datetimepicker/overview";
			// 
			// kendoDateTimePicker1
			// 
			this.kendoDateTimePicker1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoDateTimePicker1.Location = new System.Drawing.Point(119, 139);
			this.kendoDateTimePicker1.Name = "kendoDateTimePicker1";
			this.kendoDateTimePicker1.Size = new System.Drawing.Size(214, 35);
			this.kendoDateTimePicker1.TabIndex = 0;
			this.kendoDateTimePicker1.Text = "kendoDateTimePicker1";
			// 
			// kendoDateTimePicker
			// 
			this.Name = "kendoDateTimePicker";
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoDateTimePicker kendoDateTimePicker1;
	}
}
