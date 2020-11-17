using EdamanService.Models;
using System.ComponentModel;

namespace FoodApp.ViewModel
{
    public class RecipeDetailedPageVM : INotifyPropertyChanged
    {
        private Recipe recipe;

        public event PropertyChangedEventHandler PropertyChanged;

        public Recipe Recipe
        {
            get { return recipe; }
            set
            {
                recipe = value;
                OnPropertyChanged("Recipe");
            }
        }

        private int componentsHeight;

        public int ComponentsHeight
        {
            get { return componentsHeight; }
            set
            {
                componentsHeight = value;
                OnPropertyChanged("ComponentsHeight");
            }
        }

        int _height;

        public int Height

        {
            get { return _height; }
            set
            {
                _height = value;
                OnPropertyChanged("Height");
            }
        }

        public RecipeDetailedPageVM(Recipe recipe)
        {
            Recipe = recipe;
            ComponentsHeight = SetHeight(Recipe.ingredients.Count);
        }

        private int SetHeight(int count)
        {
            return count * 20 + 30;
        }

        private void OnPropertyChanged(string memberName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}
