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
    /// <summary>
    /// Interaction logic for TablesView.xaml
    /// </summary>
    public partial class EmployeesView : Window
    {
        public EmployeesView()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as EmployeeViewModel;
            if (vm != null)
            {
                vm.DeleteEmployeeCommand.Execute(null);
            }
        }
    }
}
