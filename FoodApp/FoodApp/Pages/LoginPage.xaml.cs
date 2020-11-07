using FoodApp.Data;
using FoodApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            var userService = DependencyService.Resolve<IUserService>();

            BindingContext = new LoginVM(userService);
        }
    }
}