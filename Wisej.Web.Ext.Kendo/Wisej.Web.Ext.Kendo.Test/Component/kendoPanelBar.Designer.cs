namespace Wisej.Web.Ext.Kendo.Test.Component
{
	partial class kendoPanelBar
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
			this.kendoPanelBar1 = new Wisej.Web.Ext.Kendo.kendoPanelBar();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoPanelBar1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/panelbar/index";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/panelbar";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/navigation/panelbar/overview";
			// 
			// kendoPanelBar1
			// 
			this.kendoPanelBar1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoPanelBar1.Location = new System.Drawing.Point(84, 63);
			this.kendoPanelBar1.Name = "kendoPanelBar1";
			this.kendoPanelBar1.Size = new System.Drawing.Size(284, 187);
			this.kendoPanelBar1.TabIndex = 0;
			this.kendoPanelBar1.Text = "kendoPanelBar1";
			// 
			// kendoPanelBar
			// 
			this.Name = "kendoPanelBar";
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoPanelBar kendoPanelBar1;
	}
}
