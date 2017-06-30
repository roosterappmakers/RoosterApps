using System;
using System.Collections.Generic;
using DotCs.Model;

using Xamarin.Forms;

namespace DotCs
{
    public partial class AskSimple : ContentPage
    {
        public AskSimple()
        {
            InitializeComponent();

        }
        void DoneClicked(object sender, EventArgs e)
        {
            //Generate Class file
            string[] properties = new string[] { };
            string[] methods = new string[] { };
            string[] events = new string[] { };
            string classname = null;

            if (ECclassname.Text != null)
            {
                classname = ECclassname.Text;
            }


            if (Eproperties.Text != null)
            {
                properties = Eproperties.Text.Split('\n');
            }
            if (Emethods.Text != null)
            {
                methods = Emethods.Text.Split('\n');
            }
            if (Eevents.Text != null)
            {
                events = Eevents.Text.Split('\n');
            }



            Navigation.PushAsync(new ResultView(new DesignPatternClasses().
                                                SimpleClassCreator(classname,
                                                                   methods,properties,events)));
        }
    }
}
