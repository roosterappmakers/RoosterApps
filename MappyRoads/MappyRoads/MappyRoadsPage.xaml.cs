using Xamarin.Forms;

namespace MappyRoads
{
    public partial class MappyRoadsPage : ContentPage
    {
        public MappyRoadsPage()
        {
            InitializeComponent();
            BindingContext = new MappyRoadViewModel();
          
        }
    }
}
