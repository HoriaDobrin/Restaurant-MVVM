using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Navigation;
using WpfAppTema1.ViewModels.WpfAppTema1.ViewModels;
using System.Linq;
using WpfAppTema1.Views;
using WpfAppTema1.Models;
using System.Windows;

namespace WpfAppTema1.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string username;
        private string password;
        private string errorMessage;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        public ICommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login);
        }

        private void Login()
        {
            // Verifică credențialele în baza de date și redirecționează în funcție de rol
            using (var context = new RestaurantContext())
            {
                User user = context.Users.FirstOrDefault(u => u.username == Username && u.password == Password);
                if (user != null)
                {
                    if (user.role == "Admin")
                    {

                        AdminWindow adminWindow = Application.Current.Windows.OfType<AdminWindow>().FirstOrDefault();
                        if (adminWindow == null)
                        {
                            // Dacă nu există, creează și afișează fereastra AdminWindow
                            adminWindow = new AdminWindow();
                            adminWindow.Show();
                        }
                        else
                        {
                            // Dacă există, aduce fereastra în față
                            adminWindow.Focus();
                        }

                    }
                    else if (user.role == "Waiter")
                    {
                        WaiterWindow waiterWindow = Application.Current.Windows.OfType<WaiterWindow>().FirstOrDefault();
                        if (waiterWindow == null)
                        {
                            // Dacă nu există, creează și afișează fereastra AdminWindow
                            waiterWindow = new WaiterWindow();
                            waiterWindow.Show();
                        }
                        else
                        {
                            // Dacă există, aduce fereastra în față
                            waiterWindow.Focus();
                        }
                    }

                }
                else
                {
                    ErrorMessage = "Credențiale incorecte sau utilizator inexistent.";
                }
            }
        }
    }
}
