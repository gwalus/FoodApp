using EdamanService.Models;
using FoodApp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeDetailedPage : ContentPage
    {
        public RecipeDetailedPage(Recipe recipe)
        {
            InitializeComponent();

            BindingContext = new RecipeDetailedPageVM(recipe);
        }
    }
}