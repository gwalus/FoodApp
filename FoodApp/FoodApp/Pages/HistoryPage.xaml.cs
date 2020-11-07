using FoodApp.Data;
using FoodApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        HistoryPageVM _viewModel;

        public HistoryPage()
        {
            InitializeComponent();

            var dataService = DependencyService.Resolve<IDataRepository>();

            _viewModel = new HistoryPageVM(dataService);
            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _viewModel.LoadPosts();
        }
    }
}