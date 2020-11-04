using FoodApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginVM viewModel;

        public LoginPage()
        {
            InitializeComponent();

            viewModel = new LoginVM();
            BindingContext = viewModel;
        }
    }
}