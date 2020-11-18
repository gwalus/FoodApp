using EdamanService.Models;
using FoodApp.ViewModel.Commands;
using System;
using System.ComponentModel;
using System.Drawing;

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

        private Color isFavourite = Color.White;

        public Color IsFavourite
        {
            get { return isFavourite; }
            set
            {
                isFavourite = value;
                OnPropertyChanged("IsFavourite");
            }
        }

        public AddToFavouritesCommand AddToFavouritesCommand { get; set; }

        public RecipeDetailedPageVM(Recipe recipe)
        {
            Recipe = recipe;
            ComponentsHeight = SetHeight(Recipe.ingredients.Count);
            AddToFavouritesCommand = new AddToFavouritesCommand(this);
        }

        private int SetHeight(int count)
        {
            return count * 20 + 30;
        }

        public void AddToFavourite()
        {
            if (IsFavourite == Color.White)
                IsFavourite = Color.FromArgb(230, 230, 0);

            else IsFavourite = Color.White;
        }

        private void OnPropertyChanged(string memberName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}
