using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DotCs
{
	public partial class ResultView : ContentPage
	{
		

		public ResultView()
		{
			InitializeComponent();
            this.ToolbarItems.Add(new ToolbarItem(" ", "Share.png", async () => await HandleAction(), ToolbarItemOrder.Default, 0));

		}

		public ResultView(string result)
		{
            InitializeComponent();
			ResultEditor.Text = result;
            this.ToolbarItems.Add(new ToolbarItem(" ", "Share.png", async () => await HandleAction(), ToolbarItemOrder.Default, 0));

		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

		}

		async System.Threading.Tasks.Task HandleAction()
		{

			string action = await DisplayActionSheet("Share Via", null, null, "Copy to Clipboard", "Save local");

			switch (action)
			{
				case "Copy to Clipboard":
					//Code to be copied to clipboard written here
					DependencyService.Get<IClipboard>().SendToClipbord(ResultEditor.Text);

					break;
				case "Save local":
					//code to save a local copy with Date time stamp
					string thedate = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ","");
					//string thetime = DateTime.Now.TimeOfDay.ToString().Replace(":", "");
					//string datetimestamp = thedate + thetime;
					string filename = string.Concat(new string[] { thedate, "_DotCS.txt" });
					List<string> content = new List<string>();
					content.Add(ResultEditor.Text);
					string result=DependencyService.Get<ISaveLocal>().SaveLocal(filename,content);
					if (result != null)
					{
						await DisplayAlert("DotCs", "File Saved successfully: " + result, "Ok");
					}
					break;

			}
		}
	}
}
