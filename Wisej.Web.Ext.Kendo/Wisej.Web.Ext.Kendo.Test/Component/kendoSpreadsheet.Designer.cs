﻿namespace Wisej.Web.Ext.Kendo.Test.Component
{
	partial class kendoSpreadsheet
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
			this.kendoSpreadsheet1 = new Wisej.Web.Ext.Kendo.kendoSpreadsheet();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoSpreadsheet1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/spreadsheet/index";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/spreadsheet";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/data-management/spreadsheet/overview";
			// 
			// kendoSpreadsheet1
			// 
			this.kendoSpreadsheet1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoSpreadsheet1.Location = new System.Drawing.Point(18, 18);
			this.kendoSpreadsheet1.Name = "kendoSpreadsheet1";
			this.kendoSpreadsheet1.Size = new System.Drawing.Size(416, 277);
			this.kendoSpreadsheet1.TabIndex = 0;
			this.kendoSpreadsheet1.Text = "kendoSpreadsheet1";
			// 
			// kendoSpreadsheet
			// 
			this.Name = "kendoSpreadsheet";
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoSpreadsheet kendoSpreadsheet1;
	}
}
