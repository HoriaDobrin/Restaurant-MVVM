using System;
using System.Windows.Input;
using WpfAppTema1.ViewModels.WpfAppTema1.ViewModels;
using WpfAppTema1.Views;

namespace WpfAppTema1.ViewModels
{
    public class AdminWindowViewModel
    {
        public ICommand NavigateToEmployeesCommand { get; private set; }
        public ICommand NavigateToProductsCommand { get; private set; }
        public ICommand NavigateToTablesCommand { get; private set; }

        public AdminWindowViewModel()
        {
            NavigateToEmployeesCommand = new RelayCommand(NavigateToEmployees);
            NavigateToProductsCommand = new RelayCommand(NavigateToProducts);
            NavigateToTablesCommand = new RelayCommand(NavigateToTables);
        }

        private void NavigateToEmployees()
        {
            EmployeesView employeesView = new EmployeesView();
            employeesView.Show();
        }

        private void NavigateToProducts()
        {
            ProductsView productsView = new ProductsView();
            productsView.Show();
        }

        private void NavigateToTables()
        {
            TablesView tablesView = new TablesView();
            tablesView.Show();
        }
    }
}
