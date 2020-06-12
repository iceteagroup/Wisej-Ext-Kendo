namespace Wisej.Web.Ext.Kendo.Test.Component
{
	partial class kendoChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoChart));
			this.kendoChart1 = new Wisej.Web.Ext.Kendo.kendoChart();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.buttonExport = new Wisej.Web.Button();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoChart1);
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
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/chart-api/index";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/chart";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/charts/overview";
			// 
			// kendoChart1
			// 
			this.kendoChart1.Dock = Wisej.Web.DockStyle.Fill;
			this.kendoChart1.Location = new System.Drawing.Point(8, 8);
			this.kendoChart1.Name = "kendoChart1";
			this.kendoChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoChart1.Options"))));
			this.kendoChart1.Size = new System.Drawing.Size(437, 297);
			this.kendoChart1.TabIndex = 0;
			this.kendoChart1.Text = "kendoChart1";
			this.kendoChart1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoChart1_WebRequest);
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
			this.comboBox1.TabIndex = 8;
			// 
			// buttonExport
			// 
			this.buttonExport.Display = Wisej.Web.Display.Icon;
			this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-image.svg";
			this.buttonExport.Location = new System.Drawing.Point(28, 186);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(42, 42);
			this.buttonExport.TabIndex = 11;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// kendoChart
			// 
			this.Name = "kendoChart";
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoChart kendoChart1;
		private ComboBox comboBox1;
		private Button buttonExport;
	}
}
