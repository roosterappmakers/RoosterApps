using System;
using Xamarin.Forms;

namespace MappyRoads
{
    public class MappyRoadViewModel : BaseViewModel
    {
        public MappyRoadViewModel()
        {
            //height = DependencyService.Get<IDevice>().getheight() - 200;
            //width = DependencyService.Get<IDevice>().getwidth();

			height = 800;
			width = 20;
        }
        private int _width;
        public int width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                RaisePropertyChanged("width");
            }
        }
        private int _height;
        public int height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                RaisePropertyChanged("height");
            }
        }
    }
}
