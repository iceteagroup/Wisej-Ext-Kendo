namespace Wisej.Web.Ext.Kendo.Test.Component
{
	partial class kendoListBox
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
			this.kendoListBox1 = new Wisej.Web.Ext.Kendo.kendoListBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoListBox1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/listbox/index";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/listbox";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/listbox/overview";
			// 
			// kendoListBox1
			// 
			this.kendoListBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoListBox1.Location = new System.Drawing.Point(81, 61);
			this.kendoListBox1.Name = "kendoListBox1";
			this.kendoListBox1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"toolbar\":{\"tools\":[\"moveUp\",\"moveDown\",\"transferTo\",\"transferFrom\",\"transferAll" +
        "To\",\"transferAllFrom\",\"remove\"]}}")));
			this.kendoListBox1.Size = new System.Drawing.Size(290, 191);
			this.kendoListBox1.TabIndex = 0;
			this.kendoListBox1.Text = "kendoListBox1";
			// 
			// kendoListBox
			// 
			this.Name = "kendoListBox";
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoListBox kendoListBox1;
	}
}
