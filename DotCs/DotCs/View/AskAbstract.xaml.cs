using System;
using System.Collections.Generic;
using DotCs.Model;

using Xamarin.Forms;

namespace DotCs
{
    public partial class AskAbstract : ContentPage
    {
        public AskAbstract()
        {
            InitializeComponent();
            this.BindingContext = new AbstractViewModel(this.Navigation);

        }
        //void DoneClicked(object sender, EventArgs e)
        //{
            //string[] properties = new string[] { };
            //string[] methods = new string[] { };
            //string[] events = new string[] { };
            //string classname = null;

            //if (ECclassname.Text != null)
            //{
            //    classname = ECclassname.Text;
            //}
            //if (Eproperties.Text != null)
            //{
            //    properties = Eproperties.Text.Split('\n');
            //}
            //if (Emethods.Text != null)
            //{
            //    methods = Emethods.Text.Split('\n');
            //}
            //if (Eevents.Text != null)
            //{
            //    events = Eevents.Text.Split('\n');
            //}

            //ICreator dpc = new DesignPatternClasses();
            //string result = dpc.AbstractClassCreator(classname, methods, properties, events);

            ////AbstractClassFileGenerator scg = new AbstractClassFileGenerator(ECclassname.Text,
            ////properties, methods, events);

            //// Navigation.PushAsync(new ResultView(scg.GenerateClass()));

            //Navigation.PushAsync(new ResultView(result));
        //}
    }
}
