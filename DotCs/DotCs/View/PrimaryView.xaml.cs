using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DotCs
{
	public partial class PrimaryView : ContentPage
	{
		public PrimaryView()
		{
			InitializeComponent();

		}
		void JsonButtonClicked(object sender, System.EventArgs e)
		{

			Navigation.PushAsync(new AskJson());
		}

		void SimpleButtonClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AskSimple());
		}
		void MVVMButtonClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AskViewModel());
		}

		void AbstractButtonClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AskAbstract());
		}

		void InterfaceButtonClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AskInterface());
		}

	}
}
