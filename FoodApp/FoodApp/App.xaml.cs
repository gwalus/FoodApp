using EdamanService;
using FoodApp.Data;
using FoodApp.Dtos;
using Xamarin.Forms;

namespace FoodApp
{
    public partial class App : Application
    {
        public static UserReturnedDto CurrentUser { get; set; }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<IUserService, UserService>();
            DependencyService.Register<IDataRepository, DataRepository>();
            DependencyService.Register<IFoodInfoService, FoodInfoService>();
            DependencyService.Register<IFoodRecipiesService, FoodRecipiesService>();
            DependencyService.Register<FoodAppContext>();

            MainPage = new NavigationPage(new LoginPage());

            CurrentUser = new UserReturnedDto();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
