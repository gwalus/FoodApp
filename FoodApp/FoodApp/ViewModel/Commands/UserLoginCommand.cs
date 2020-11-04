using FoodApp.Dtos;
using System;
using System.Windows.Input;

namespace FoodApp.ViewModel
{
    public class UserLoginCommand : ICommand
    {
        private LoginVM _viewModel;

        public UserLoginCommand(LoginVM viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            if (parameter != null)
            {
                var user = (UserForLoginDto)parameter;

                if (string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
                    return false;
                else
                    return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            _viewModel.Login();
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
