namespace Wisej.Web.Ext.Kendo.Test.Component
{
	partial class kendoMenu
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
			this.kendoMenu1 = new Wisej.Web.Ext.Kendo.kendoMenu();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoMenu1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/menu/index";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/menu";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/navigation/menu/overview";
			// 
			// kendoMenu1
			// 
			this.kendoMenu1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoMenu1.Location = new System.Drawing.Point(97, 106);
			this.kendoMenu1.Name = "kendoMenu1";
			this.kendoMenu1.Size = new System.Drawing.Size(259, 100);
			this.kendoMenu1.TabIndex = 0;
			this.kendoMenu1.Text = "kendoMenu1";
			// 
			// kendoMenu
			// 
			this.Name = "kendoMenu";
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoMenu kendoMenu1;
	}
}
