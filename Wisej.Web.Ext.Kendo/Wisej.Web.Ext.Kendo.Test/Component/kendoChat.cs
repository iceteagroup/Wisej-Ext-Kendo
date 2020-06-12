using System;
using System.Threading;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Test.Component
{
	public partial class kendoChat : Wisej.Web.Ext.Kendo.Test.Component.TestBase
	{
		private Random rand = new Random();
		public kendoChat()
		{
			InitializeComponent();

			this.kendoChat1.Widget.typingStart += new WidgetEventHandler(kendoChat1_WidgetEvent);
			this.kendoChat1.Widget.actionClick += new WidgetEventHandler(kendoChat1_actionClick);
			this.kendoChat1.Widget.typingEnd += new WidgetEventHandler(kendoChat1_WidgetEvent);
			this.kendoChat1.Widget.toolClick += new WidgetEventHandler(kendoChat1_WidgetEvent);
			this.kendoChat1.Widget.sendMessage += new WidgetEventHandler(kendoChat1_sendMessage);
			this.kendoChat1.Widget.post += new WidgetEventHandler(kendoChat1_WidgetEvent);
		}

		private void kendoChat1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void kendoChat1_sendMessage(object sender, WidgetEventArgs e)
		{
			var response = "";

			var randValue = rand.NextDouble();

			if (randValue < 0.25)
				response = "Wow, cool!";
			else if (randValue >= 0.25 && randValue < 0.5)
				response = "Very nice.";
			else
				response = "All my logic is handled in Wisej!";
			

			Application.StartTask(() => {

				this.kendoChat1.Widget.renderMessage(new
				{
					type = "typing"
				}, new
				{
					id = 2,
					name = "Wisej Chat Bot",
					iconUrl = "Images/Chat/ANTON.jpg"
				});
				Application.Update(this);

				Thread.Sleep(1000);

				this.kendoChat1.Widget.renderMessage(new
				{
					type = "text",
					text = response
				}, new
				{
					id = 2,
					name = "Wisej Chat Bot",
					iconUrl = "Images/Chat/ANTON.jpg"
				});
				Application.Update(this);
			});
		}

		private void kendoChat1_actionClick(object sender, WidgetEventArgs e)
		{
			var message = e.Data;

			var response = "";

			switch (message)
			{
				case "Try Wisej":
					response = "Okay, head on over to wisej.com to get started!";
					break;

				case "This is cool!":
					response = "It is very cool!";
					break;

			}

			Application.StartTask(() => {

				this.kendoChat1.Widget.renderMessage(new
				{
					type = "typing"
				}, new
				{
					id = 2,
					name = "Wisej Chat Bot",
					iconUrl = "Images/Chat/ANTON.jpg"
				});
				Application.Update(this);

				Thread.Sleep(1000);

				this.kendoChat1.Widget.renderMessage(new
				{
					type = "text",
					text = response
				}, new
				{
					id = 2,
					name = "Wisej Chat Bot",
					iconUrl = "Images/Chat/ANTON.jpg"
				});
				Application.Update(this);
			});
		}

		private void kendoChat_Load(object sender, EventArgs e)
		{
			Application.StartTask(() => {

				this.kendoChat1.Widget.renderMessage(new
				{
					type = "typing"
				}, new
				{
					id = 2,
					name = "Wisej Chat Bot",
					iconUrl = "Images/Chat/ANTON.jpg"
				});
				Application.Update(this);

				Thread.Sleep(1000);

				this.kendoChat1.Widget.renderMessage(new
				{
					type = "text",
					text = "Hi, I'm the Wisej Chat Bot! How can I help you?"
				}, new
				{
					id = 2,
					name = "Wisej Chat Bot",
					iconUrl = "Images/Chat/ANTON.jpg"
				});
				this.kendoChat1.Widget.renderSuggestedActions(new[] {
					new {
						title = "Try Wisej",
						value = "Try Wisej"
					}, 
					new
					{
						title = "This is cool!",
						value = "This is cool!"
					} 
				});
				Application.Update(this);
			});
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			var data = await this.kendoChat1.Widget.getUserAsync();

			AlertBox.Show(data.ToString());
		}
	}
}
