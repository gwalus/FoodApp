using EdamanService;
using FoodApp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchRecipiesPage : ContentPage
    {
        SearchRecipiesPageVM _viewModel;

        public SearchRecipiesPage()
        {
            InitializeComponent();

            var foodRecipiecService = DependencyService.Resolve<IFoodRecipiesService>();

            _viewModel = new SearchRecipiesPageVM(foodRecipiecService);

            BindingContext = _viewModel;
        }
    }
}