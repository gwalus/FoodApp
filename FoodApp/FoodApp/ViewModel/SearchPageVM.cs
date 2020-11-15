using EdamanService;
using EdamanService.Models;
using FoodApp.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.ViewModel
{
    public class SearchPageVM : INotifyPropertyChanged
    {
        private readonly IFoodInfoService _foodInfoService;

        private Food food;

        public Food Food
        {
            get { return food; }
            set
            {
                food = value;
                OnPropertyChanged("Food");
            }
        }

        private IList<Parsed> lista;

        public IList<Parsed> Lista
        {
            get { return lista; }
            set
            {
                lista = value;
                OnPropertyChanged("Lista");
            }
        }

        private bool collectionVisible;

        public bool CollectionVisible
        {
            get { return collectionVisible; }
            set
            {
                collectionVisible = value;
                OnPropertyChanged("CollectionVisible");
            }
        }

        private bool notFoundVisible = false;

        public bool NotFoundVisible
        {
            get { return notFoundVisible; }
            set
            {
                notFoundVisible = value;
                OnPropertyChanged("NotFoundVisible");
            }
        }

        public SearchCommand SearchCommand { get; set; }

        public SearchPageVM(IFoodInfoService foodInfoService)
        {
            SearchCommand = new SearchCommand(this);
            _foodInfoService = foodInfoService;
        }

        public async void GetFoodInfo(string name)
        {
            var infoAboutFood = await _foodInfoService.GetFoodInfo(name);

            if (infoAboutFood.Count != 0)
            {
                Lista = infoAboutFood.ToList();
                CollectionVisible = true;
                NotFoundVisible = false;
            }
            else
            {
                CollectionVisible = false;
                NotFoundVisible = true;
            }
        }

        public void OnAppering()
        {
            CollectionVisible = false;
            NotFoundVisible = false;
        }

        private void OnPropertyChanged(string memberName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
