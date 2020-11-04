using FoodApp.Dtos;
using System;
using System.Windows.Input;

namespace FoodApp.ViewModel.Commands
{
    public class UserRegisterCommand : ICommand
    {
        RegisterVM _viewModel;
        public UserRegisterCommand(RegisterVM viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            if (parameter != null)
            {
                var user = (UserForRegisterDto)parameter;

                if (!(string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password) || string.IsNullOrWhiteSpace(user.PasswordConfirm)))
                {
                    if (user.Password == user.PasswordConfirm)
                        return true;
                    return false;
                }
                return false;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            var userToCreate = parameter as UserForRegisterDto;

            _viewModel.Register(userToCreate);
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
