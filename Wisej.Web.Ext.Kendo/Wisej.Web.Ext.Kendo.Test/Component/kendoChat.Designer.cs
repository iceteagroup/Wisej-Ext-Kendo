namespace Wisej.Web.Ext.Kendo.Test.Component
{
	partial class kendoChat
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
			this.kendoChat1 = new Wisej.Web.Ext.Kendo.kendoChat();
			this.button1 = new Wisej.Web.Button();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoChat1);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/chat/index";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/chat";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/conversational-ui/chat/overview";
			// 
			// kendoChat1
			// 
			this.kendoChat1.Dock = Wisej.Web.DockStyle.Fill;
			this.kendoChat1.Location = new System.Drawing.Point(8, 8);
			this.kendoChat1.Name = "kendoChat1";
			this.kendoChat1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"user\":{\"name\":\"Wisej User\",\"iconUrl\":\"Images/Chat/ANATR.jpg\"},\"toolbar\":{\"toggl" +
        "eable\":true,\"buttons\":[{\"name\":\"sendimage\",\"iconClass\":\"k-icon k-i-image\"}]}}")));
			this.kendoChat1.Size = new System.Drawing.Size(437, 297);
			this.kendoChat1.TabIndex = 0;
			this.kendoChat1.Text = "kendoChat1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 188);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 27);
			this.button1.TabIndex = 1;
			this.button1.Text = "Get User";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// kendoChat
			// 
			this.Name = "kendoChat";
			this.Load += new System.EventHandler(this.kendoChat_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoChat kendoChat1;
		private Button button1;
	}
}
