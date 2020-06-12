﻿namespace Wisej.Web.Ext.Kendo.Test.Component
{
	partial class kendoDiagram
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoDiagram));
			this.kendoDiagram1 = new Wisej.Web.Ext.Kendo.kendoDiagram();
			this.buttonExport = new Wisej.Web.Button();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoDiagram1);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonExport);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExport, 0);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/diagram/index";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/diagram";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/diagrams-and-maps/diagram/overview";
			// 
			// kendoDiagram1
			// 
			this.kendoDiagram1.Dock = Wisej.Web.DockStyle.Fill;
			this.kendoDiagram1.Location = new System.Drawing.Point(8, 8);
			this.kendoDiagram1.Name = "kendoDiagram1";
			this.kendoDiagram1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoDiagram1.Options"))));
			this.kendoDiagram1.Size = new System.Drawing.Size(437, 297);
			this.kendoDiagram1.TabIndex = 0;
			this.kendoDiagram1.Text = "kendoDiagram1";
			this.kendoDiagram1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoDiagram1_WebRequest);
			// 
			// buttonExport
			// 
			this.buttonExport.Display = Wisej.Web.Display.Icon;
			this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-image.svg";
			this.buttonExport.Location = new System.Drawing.Point(28, 186);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(42, 42);
			this.buttonExport.TabIndex = 13;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "SVG",
            "PDF",
            "PNG"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Export Format";
			this.comboBox1.Location = new System.Drawing.Point(28, 120);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 12;
			// 
			// kendoDiagram
			// 
			this.Name = "kendoDiagram";
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoDiagram kendoDiagram1;
		private Button buttonExport;
		private ComboBox comboBox1;
	}
}
