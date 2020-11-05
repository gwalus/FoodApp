using FoodApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPostPage : ContentPage
    {
        NewPostVM _viewModel;
        public NewPostPage()
        {
            InitializeComponent();
            _viewModel = new NewPostVM();
            BindingContext = _viewModel;
        }
    }
}