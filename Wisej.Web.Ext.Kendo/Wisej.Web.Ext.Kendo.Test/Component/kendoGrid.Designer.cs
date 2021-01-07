﻿namespace Wisej.Web.Ext.Kendo.Test.Component
{
	partial class kendoGrid
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoGrid));
			Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction();
			this.buttonPDF = new Wisej.Web.Button();
			this.buttonExport = new Wisej.Web.Button();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.kendoGrid1 = new Wisej.Web.Ext.Kendo.kendoGrid();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoGrid1);
			this.panel.Size = new System.Drawing.Size(683, 496);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.buttonPDF);
			this.groupBox1.Controls.Add(this.buttonExport);
			this.groupBox1.Size = new System.Drawing.Size(250, 496);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExport, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonPDF, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 405);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/grid/index";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/grid";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/data-management/grid/overview";
			// 
			// buttonPDF
			// 
			this.buttonPDF.Display = Wisej.Web.Display.Icon;
			this.buttonPDF.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-pdf-file.svg";
			this.buttonPDF.Location = new System.Drawing.Point(76, 338);
			this.buttonPDF.Name = "buttonPDF";
			this.buttonPDF.Size = new System.Drawing.Size(42, 42);
			this.buttonPDF.TabIndex = 12;
			this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
			// 
			// buttonExport
			// 
			this.buttonExport.Display = Wisej.Web.Display.Icon;
			this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/microsoft-excel-logo.svg";
			this.buttonExport.Location = new System.Drawing.Point(28, 338);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(42, 42);
			this.buttonExport.TabIndex = 11;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Location = new System.Drawing.Point(28, 29);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 31);
			this.checkBox1.TabIndex = 18;
			this.checkBox1.Text = "Allow Copy";
			// 
			// kendoGrid1
			// 
			this.kendoGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoGrid1.Location = new System.Drawing.Point(23, 23);
			this.kendoGrid1.Name = "kendoGrid1";
			this.kendoGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoGrid1.Options"))));
			this.kendoGrid1.Size = new System.Drawing.Size(633, 446);
			this.kendoGrid1.TabIndex = 0;
			this.kendoGrid1.Text = "kendoGrid1";
			widgetFunction1.Name = "onDataBound";
			widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
			this.kendoGrid1.WidgetFunctions = new Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction[] {
        widgetFunction1};
			this.kendoGrid1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoGrid1_WebRequest);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.numericUpDown1.Label.Size = 50;
			this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown1.LabelText = "Column Resize Handle";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 253);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 60);
			this.numericUpDown1.TabIndex = 19;
			this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 85);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 31);
			this.checkBox2.TabIndex = 20;
			this.checkBox2.Text = "Mobile";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Location = new System.Drawing.Point(28, 141);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 31);
			this.checkBox3.TabIndex = 21;
			this.checkBox3.Text = "Navigatable";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Location = new System.Drawing.Point(28, 197);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(195, 31);
			this.checkBox4.TabIndex = 22;
			this.checkBox4.Text = "Persist Selection";
			// 
			// kendoGrid
			// 
			this.Name = "kendoGrid";
			this.Size = new System.Drawing.Size(1092, 686);
			this.Load += new System.EventHandler(this.kendoGrid_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoGrid kendoGrid1;
		private Button buttonPDF;
		private Button buttonExport;
		private CheckBox checkBox1;
		private NumericUpDown numericUpDown1;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
	}
}
