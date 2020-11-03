using FoodApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        RegisterVM _viewModel;

        public RegisterPage()
        {
            InitializeComponent();

            _viewModel = new RegisterVM();
            BindingContext = _viewModel;
        }
    }
}