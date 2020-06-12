﻿namespace Wisej.Web.Ext.Kendo.Test.Component
{
	partial class kendoStepper
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoStepper));
			this.kendoStepper1 = new Wisej.Web.Ext.Kendo.kendoStepper();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoStepper1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/stepper/index";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/stepper";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/navigation/stepper/overview";
			// 
			// kendoStepper1
			// 
			this.kendoStepper1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.kendoStepper1.Location = new System.Drawing.Point(40, 122);
			this.kendoStepper1.Name = "kendoStepper1";
			this.kendoStepper1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoStepper1.Options"))));
			this.kendoStepper1.Size = new System.Drawing.Size(373, 68);
			this.kendoStepper1.TabIndex = 0;
			this.kendoStepper1.Text = "kendoStepper1";
			// 
			// kendoStepper
			// 
			this.Name = "kendoStepper";
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoStepper kendoStepper1;
	}
}
