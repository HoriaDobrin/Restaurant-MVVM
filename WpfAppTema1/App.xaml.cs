using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfAppTema1.ViewModels;
using WpfAppTema1.Views;

namespace WpfAppTema1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Frame MainFrame { get; private set; }

        /*protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            NavigationWindow navigationWindow = new NavigationWindow();
            navigationWindow.NavigationService.Navigate(new LoginView(new LoginViewModel(navigationWindow.NavigationService)));
            MainWindow = navigationWindow;
            MainWindow.Show();
        }*/
        
    }
}
