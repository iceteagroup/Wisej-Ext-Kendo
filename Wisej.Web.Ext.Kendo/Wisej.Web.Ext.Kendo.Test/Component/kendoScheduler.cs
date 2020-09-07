using System;
using System.IO;
using System.Net;
using System.Web.UI.WebControls;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoScheduler : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		public kendoScheduler()
		{
			InitializeComponent();

			this.kendoScheduler1.Instance.add += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
			this.kendoScheduler1.Instance.change += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
		}

		private void kendoScheduler1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			this.kendoScheduler1.Instance.saveAsPDF();
		}

		private void kendoScheduler1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "export":
					// do whatever you want with the file.
					HandleFile(e.Request.Form["contentType"], e.Request.Form["base64"], e.Request.Form["fileName"]);
					break;

			}
			// returns a response to the client that the request is finished.
			e.Response.StatusCode = (int)HttpStatusCode.NoContent;
		}

		private void HandleFile(string contentType, string base64Data, string fileName)
		{
			AlertBox.Show("Received the PDF on the server.");

			var data = Convert.FromBase64String(base64Data);

			using (var ms = new MemoryStream(data))
			{
				Application.Download(ms, fileName);
			}
		}
	}
}
