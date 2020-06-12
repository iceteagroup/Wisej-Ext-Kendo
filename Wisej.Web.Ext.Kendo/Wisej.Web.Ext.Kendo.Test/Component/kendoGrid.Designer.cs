namespace Wisej.Web.Ext.Kendo.Test.Component
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
			this.kendoGrid1 = new Wisej.Web.Ext.Kendo.kendoGrid();
			this.buttonPDF = new Wisej.Web.Button();
			this.buttonExport = new Wisej.Web.Button();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoGrid1);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonPDF);
			this.groupBox1.Controls.Add(this.buttonExport);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExport, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonPDF, 0);
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
			// kendoGrid1
			// 
			this.kendoGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoGrid1.Location = new System.Drawing.Point(23, 23);
			this.kendoGrid1.Name = "kendoGrid1";
			this.kendoGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoGrid1.Options"))));
			this.kendoGrid1.Size = new System.Drawing.Size(407, 267);
			this.kendoGrid1.TabIndex = 0;
			this.kendoGrid1.Text = "kendoGrid1";
			this.kendoGrid1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoGrid1_WebRequest);
			// 
			// buttonPDF
			// 
			this.buttonPDF.Display = Wisej.Web.Display.Icon;
			this.buttonPDF.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-pdf-file.svg";
			this.buttonPDF.Location = new System.Drawing.Point(76, 186);
			this.buttonPDF.Name = "buttonPDF";
			this.buttonPDF.Size = new System.Drawing.Size(42, 42);
			this.buttonPDF.TabIndex = 12;
			this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
			// 
			// buttonExport
			// 
			this.buttonExport.Display = Wisej.Web.Display.Icon;
			this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/microsoft-excel-logo.svg";
			this.buttonExport.Location = new System.Drawing.Point(28, 186);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(42, 42);
			this.buttonExport.TabIndex = 11;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// kendoGrid
			// 
			this.Name = "kendoGrid";
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoGrid kendoGrid1;
		private Button buttonPDF;
		private Button buttonExport;
	}
}
