namespace Wisej.Web.Ext.Kendo.Test
{
	partial class MainView
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
			this.panel2 = new Wisej.Web.Panel();
			this.panel1 = new Wisej.Web.Panel();
			this.listBox1 = new Wisej.Web.ListBox();
			this.panel3 = new Wisej.Web.Panel();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.label1 = new Wisej.Web.Label();
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.button1 = new Wisej.Web.Button();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Dock = Wisej.Web.DockStyle.Fill;
			this.panel2.HeaderBackColor = System.Drawing.Color.FromArgb(251, 104, 18);
			this.panel2.HeaderSize = 40;
			this.panel2.Location = new System.Drawing.Point(250, 100);
			this.panel2.Name = "panel2";
			this.panel2.ShowCloseButton = false;
			this.panel2.ShowHeader = true;
			this.panel2.Size = new System.Drawing.Size(871, 463);
			this.panel2.TabIndex = 6;
			this.panel2.TabStop = true;
			this.panel2.Text = "Test";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel1.CollapseSide = Wisej.Web.HeaderPosition.Left;
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Dock = Wisej.Web.DockStyle.Left;
			this.panel1.HeaderBackColor = System.Drawing.Color.FromArgb(73, 73, 73);
			this.panel1.HeaderSize = 40;
			this.panel1.Location = new System.Drawing.Point(0, 100);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new Wisej.Web.Padding(20);
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(250, 463);
			this.panel1.TabIndex = 5;
			this.panel1.TabStop = true;
			this.panel1.Text = "Component";
			// 
			// listBox1
			// 
			this.listBox1.BorderStyle = Wisej.Web.BorderStyle.None;
			this.listBox1.DisplayMember = "Name";
			this.listBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.listBox1.IconMember = "Icon";
			this.listBox1.Location = new System.Drawing.Point(20, 20);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(208, 381);
			this.listBox1.TabIndex = 0;
			this.listBox1.ValueMember = "Name";
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.comboBox2);
			this.panel3.Controls.Add(this.comboBox1);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Dock = Wisej.Web.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1121, 100);
			this.panel3.TabIndex = 4;
			this.panel3.TabStop = true;
			// 
			// comboBox2
			// 
			this.comboBox2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.comboBox2.AutoSize = false;
			this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
            "en-US",
            "de-DE",
            "it-IT",
            "pt-PT",
            "fr-FR",
            "es-ES"});
			this.comboBox2.Location = new System.Drawing.Point(698, 49);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(193, 35);
			this.comboBox2.TabIndex = 5;
			this.comboBox2.Text = "en-US";
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "black",
            "blueopal",
            "bootstrap-v4",
            "bootstrap",
            "common-bootstrap",
            "common-fiori",
            "common-material",
            "common-nova",
            "common-office365",
            "common",
            "dataviz.black",
            "dataviz.blueopal",
            "dataviz.bootstrap",
            "dataviz.default",
            "dataviz.fiori",
            "dataviz.flat",
            "dataviz.highcontrast",
            "dataviz.material",
            "dataviz.materialblack",
            "dataviz.metro",
            "dataviz.metroblack",
            "dataviz",
            "dataviz.moonlight",
            "dataviz.nova",
            "dataviz.office365",
            "dataviz.silver",
            "dataviz.uniform",
            "dataviz.default-v2",
            "default",
            "fiori",
            "flat",
            "highcontrast",
            "material-v2",
            "material",
            "materialblack",
            "metro",
            "metroblack",
            "mobile.all",
            "nova",
            "office365",
            "rtl",
            "silver",
            "uniform"});
			this.comboBox1.Location = new System.Drawing.Point(897, 49);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(193, 35);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.Text = "common";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("default, Verdana", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(43, 53, 124);
			this.label1.Location = new System.Drawing.Point(129, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(575, 48);
			this.label1.TabIndex = 1;
			this.label1.Text = "KendoUI Integration Tests";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.ImageSource = "Images\\kendo.png";
			this.pictureBox1.Location = new System.Drawing.Point(21, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(71, 69);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(583, 50);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 27);
			this.button1.TabIndex = 9;
			this.button1.Text = "button1";
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Name = "MainView";
			this.Size = new System.Drawing.Size(1121, 563);
			this.Text = "Wisej KendoUI Integration Tests";
			this.Load += new System.EventHandler(this.MainView_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel2;
		private Panel panel1;
		private ListBox listBox1;
		private Panel panel3;
		private ComboBox comboBox1;
		private Label label1;
		private PictureBox pictureBox1;
		private ComboBox comboBox2;
		private Button button1;
	}
}

