using EdamanService;
using FoodApp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        SearchPageVM _viewModel;

        public SearchPage()
        {
            InitializeComponent();

            var foodInfoService = DependencyService.Resolve<IFoodInfoService>();

            _viewModel = new SearchPageVM(foodInfoService);

            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _viewModel.OnAppering();
        }
    }
}