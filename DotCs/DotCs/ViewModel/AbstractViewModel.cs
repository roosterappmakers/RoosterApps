using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace DotCs
{
	public class AbstractViewModel
	{
        private INavigation navigation;
        public ICommand CreateCommand { get; set; }

        public AbstractViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            CreateCommand = new BaseCommand(async (object obj) =>
                                            await navigation.PushAsync(new ResultView(null)));
        }

        //private void HandleAction(object obj)
        //{
        //    navigation.PushAsync(new ResultView(null));
        //}
    }
}
