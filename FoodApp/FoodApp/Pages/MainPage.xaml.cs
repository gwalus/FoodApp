using FoodApp.ViewModel;
using Xamarin.Forms;

namespace FoodApp
{
    public partial class MainPage : TabbedPage
    {
        MainVM _viewModel;

        public MainPage()
        {
            InitializeComponent();

            _viewModel = new MainVM();
            BindingContext = _viewModel;
        }
    }
}
