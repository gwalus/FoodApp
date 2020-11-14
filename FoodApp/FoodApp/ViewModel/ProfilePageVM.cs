using System.ComponentModel;

namespace FoodApp.ViewModel
{
    public class ProfilePageVM : INotifyPropertyChanged
    {
        public string UserName { get; set; } = App.CurrentUser.Email;


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
