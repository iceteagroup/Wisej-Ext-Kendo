namespace Wisej.Web.Ext.Kendo.Test.Component
{
	partial class kendoScrollView
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
			this.kendoScrollView1 = new Wisej.Web.Ext.Kendo.kendoScrollView();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoScrollView1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/scrollview/index";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/scrollview";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/media/scrollview/overview";
			// 
			// kendoScrollView1
			// 
			this.kendoScrollView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoScrollView1.Location = new System.Drawing.Point(24, 22);
			this.kendoScrollView1.Name = "kendoScrollView1";
			this.kendoScrollView1.Size = new System.Drawing.Size(404, 268);
			this.kendoScrollView1.TabIndex = 0;
			this.kendoScrollView1.Text = "kendoScrollView1";
			// 
			// kendoScrollView
			// 
			this.Name = "kendoScrollView";
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoScrollView kendoScrollView1;
	}
}
