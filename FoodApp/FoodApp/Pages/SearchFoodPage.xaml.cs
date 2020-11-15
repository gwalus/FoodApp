using EdamanService;
using FoodApp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchFoodPage : ContentPage
    {
        SearchFoodPageVM _viewModel;

        public SearchFoodPage()
        {
            InitializeComponent();

            var foodInfoService = DependencyService.Resolve<IFoodInfoService>();

            _viewModel = new SearchFoodPageVM(foodInfoService);

            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _viewModel.OnAppering();
        }
    }
}