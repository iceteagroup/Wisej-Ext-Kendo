using System;
using System.IO;
using System.Net;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoChart : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoChart()
		{
			InitializeComponent();

			this.kendoChart1.Widget.legendItemClick += new WidgetEventHandler(kendoChart1_WidgetEvent);
			this.kendoChart1.Widget.seriesClick += new WidgetEventHandler(kendoChart1_WidgetEvent);
			this.kendoChart1.Widget.select += new WidgetEventHandler(kendoChart1_WidgetEvent);
		}

		private void kendoChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			var format = this.comboBox1.SelectedItem.ToString();
			switch (format)
			{
				case "SVG":
				case "PNG":
					// see wisej implementation in kendoChart.js.
					this.kendoChart1.Call("exportImageData", format);
					break;
				
				case "PDF":
					this.kendoChart1.Widget.exportPDF();
					break;
			}
		}

		private void kendoChart1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "export":
					HandleFile(e.Request.Form["contentType"], e.Request.Form["base64"], e.Request.Form["fileName"]);
					break;

			}
			e.Response.StatusCode = (int)HttpStatusCode.NoContent;
		}

		private void HandleFile(string contentType, string base64Data, string fileName)
		{
			AlertBox.Show($"Received {fileName} on the server.");

			var data = Convert.FromBase64String(base64Data);

			using (var ms = new MemoryStream(data))
			{
				Application.Download(ms, fileName);
			}
		}
	}
}
