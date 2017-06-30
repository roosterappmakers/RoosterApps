using System;
using System.IO;
using System.Collections.Generic;
using Xamasoft.JsonClassGenerator;
using DotCs.Model;

using Xamarin.Forms;

namespace DotCs
{
	public partial class AskJson : ContentPage
	{
		public AskJson()
		{
			InitializeComponent();
		}
		void DoneClicked(object sender, EventArgs e)
		{
			//the result is computed here and shared with result view.
			
            try{
                string FullClass = new DesignPatternClasses().JsonClassCreator(Responseeditor.Text);
                if (FullClass !=null)
                {
					Navigation.PushAsync(new ResultView(FullClass));
                }
                else
                {
                    DisplayAlert("DotCs", "The JSON format seems to be incorrect", "Ok");
                }

			}
			catch (Exception ex)
			{
				
			}
		}

	}
}
