using System.ComponentModel;

namespace FoodApp.ViewModel
{
    public class ProfilePageVM : INotifyPropertyChanged
    {
        public string UserName { get; set; } = App.CurrentUser.Email;

#pragma warning disable 67
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 67
    }
}
