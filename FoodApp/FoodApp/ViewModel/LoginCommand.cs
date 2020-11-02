﻿using FoodApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace FoodApp.ViewModel
{
    public class LoginCommand : ICommand
    {
        private LoginVM _viewModel;

        public LoginCommand(LoginVM viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            if (parameter != null)
            {
                User user = (User)parameter;

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

        public event EventHandler CanExecuteChanged;
    }
}