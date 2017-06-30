using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DotCs
{
    public partial class Results : ContentPage
    {
        public Results()
        {
            InitializeComponent();
            List<string> listoffiles = DependencyService.Get<ISaveLocal>().GetAllFiles();
            List<ShowItem> listitems = new List<ShowItem>();
            foreach (var item in listoffiles)
            {
                listitems.Add(new ShowItem(item));
            }
            savedfilelist.ItemsSource = listitems;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ResultViewModel.instance.LoadList();
            savedfilelist.ItemsSource = null;
            List<string> listoffiles = DependencyService.Get<ISaveLocal>().GetAllFiles();
            List<ShowItem> listitems = new List<ShowItem>();
            foreach (var item in listoffiles)
            {
                listitems.Add(new ShowItem(item));
            }
            savedfilelist.ItemsSource = listitems;
        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            try
            {
                ShowItem1 si = e.Item as ShowItem1;
                var fileselected = si.thetext.ToString();
                savedfilelist.SelectedItem = null;
                string content = DependencyService.Get<ISaveLocal>().Getcontents(fileselected);
                ResultView rv = new ResultView(content);
                rv.Title = fileselected;
                Navigation.PushAsync(rv);
            }
            catch (Exception ex)
            {
            }
        }



        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Button theb = sender as Button;
            ShowItem1 item = (ShowItem1)theb.BindingContext;
            var fileselected = item.thetext.ToString();

            DependencyService.Get<ISaveLocal>().DeleteFile(fileselected);
            ResultViewModel.instance.LoadList();

        }


        void Handle_Tapped(object sender, System.EventArgs e)
        {
            Image theb = sender as Image;
            ShowItem1 item = (ShowItem1)theb.BindingContext;
            var fileselected = item.thetext.ToString();

            DependencyService.Get<ISaveLocal>().DeleteFile(fileselected);
            ResultViewModel.instance.LoadList();

        }
    }

    public class ShowItem
    {
        public ShowItem(string thetext)
        {
            StackLayout sl = new StackLayout();
            sl.Orientation = StackOrientation.Horizontal;

            Label thelabel = new Label();
            thelabel.Text = thetext;

            thelabel.HorizontalTextAlignment = TextAlignment.Center;
            Button theb = new Button();
            theb.Text = "Delete";
            theb.HorizontalOptions = LayoutOptions.EndAndExpand;

            sl.Children.Add(thelabel);
            sl.Children.Add(theb);
        }


    }
}
