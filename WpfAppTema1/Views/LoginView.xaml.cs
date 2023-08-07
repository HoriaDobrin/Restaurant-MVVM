using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppTema1.ViewModels;

namespace WpfAppTema1.Views
{
    
    public partial class LoginView : Window
    {
        private LoginViewModel viewModel;

        public LoginView()
        {
            InitializeComponent();
            viewModel = (LoginViewModel)DataContext;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Password = passwordBox.Password;
            viewModel.LoginCommand.Execute(null);
        }




    }
}

