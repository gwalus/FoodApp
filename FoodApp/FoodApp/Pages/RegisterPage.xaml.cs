using FoodApp.Data;
using FoodApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();

            var userService = DependencyService.Resolve<IUserService>();

            BindingContext = new RegisterVM(userService);
        }
    }
}