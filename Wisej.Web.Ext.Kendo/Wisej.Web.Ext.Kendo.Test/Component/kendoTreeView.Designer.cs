namespace Wisej.Web.Ext.Kendo.Test.Component
{
	partial class kendoTreeView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoTreeView));
			this.kendoTreeView1 = new Wisej.Web.Ext.Kendo.kendoTreeView();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoTreeView1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/treeview/index";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/treeview";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/navigation/treeview/overview";
			// 
			// kendoTreeView1
			// 
			this.kendoTreeView1.Location = new System.Drawing.Point(51, 31);
			this.kendoTreeView1.Name = "kendoTreeView1";
			this.kendoTreeView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoTreeView1.Options"))));
			this.kendoTreeView1.Size = new System.Drawing.Size(350, 250);
			this.kendoTreeView1.TabIndex = 0;
			this.kendoTreeView1.Text = "kendoTreeView1";
			// 
			// kendoTreeView
			// 
			this.Name = "kendoTreeView";
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoTreeView kendoTreeView1;
	}
}
