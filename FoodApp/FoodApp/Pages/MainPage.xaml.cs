using FoodApp.Data;
using FoodApp.ViewModel;
using Xamarin.Forms;

namespace FoodApp
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            var dataContext = DependencyService.Resolve<FoodAppContext>();
            var dataService = DependencyService.Resolve<IDataRepository>();

            BindingContext = new MainVM(dataContext, dataService);
        }
    }
}
