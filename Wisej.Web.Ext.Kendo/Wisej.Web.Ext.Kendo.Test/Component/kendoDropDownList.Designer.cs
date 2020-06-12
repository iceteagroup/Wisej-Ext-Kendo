namespace Wisej.Web.Ext.Kendo.Test.Component
{
	partial class kendoDropDownList
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
			this.kendoDropDownList1 = new Wisej.Web.Ext.Kendo.kendoDropDownList();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoDropDownList1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/dropdownlist/index";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/dropdownlist";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/dropdownlist/overview";
			// 
			// kendoDropDownList1
			// 
			this.kendoDropDownList1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoDropDownList1.Location = new System.Drawing.Point(123, 84);
			this.kendoDropDownList1.Name = "kendoDropDownList1";
			this.kendoDropDownList1.Size = new System.Drawing.Size(207, 145);
			this.kendoDropDownList1.TabIndex = 0;
			this.kendoDropDownList1.Text = "kendoDropDownList1";
			// 
			// kendoDropDownList
			// 
			this.Name = "kendoDropDownList";
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoDropDownList kendoDropDownList1;
	}
}
