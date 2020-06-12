using System;
using System.IO;
using System.Net;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoPivotGrid : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoPivotGrid()
		{
			InitializeComponent();

			this.kendoPivotGrid1.Widget.expandMember += new WidgetEventHandler(kendoPivotGrid1_WidgetEvent);
		}

		private void kendoPivotGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			this.kendoPivotGrid1.Widget.saveAsExcel();
		}

		private void kendoPivotGrid1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "export":
					this.ExportDocument(e.Request.Form["base64"], e.Request.Form["fileName"]);
					break;

			}
			e.Response.StatusCode = (int)HttpStatusCode.NoContent;
		}

		private void ExportDocument(string base64, string fileName)
		{
			AlertBox.Show($"Received the file {fileName} on the server.");

			var bytes = Convert.FromBase64String(base64);

			using (var ms = new MemoryStream(bytes))
			{
				Application.Download(ms, fileName);
			}
		}

		private void buttonPDF_Click(object sender, EventArgs e)
		{
			this.kendoPivotGrid1.Widget.saveAsPDF();
		}
	}
}
