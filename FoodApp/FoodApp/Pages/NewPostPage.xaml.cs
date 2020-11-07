using FoodApp.Data;
using FoodApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPostPage : ContentPage
    {
        public NewPostPage()
        {
            InitializeComponent();

            var dataService = DependencyService.Resolve<IDataRepository>();

            BindingContext = new NewPostVM(dataService);
        }
    }
}