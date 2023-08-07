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
using WpfAppTema1.Models;
using WpfAppTema1.ViewModels;

namespace WpfAppTema1.Views
{
    /// <summary>
    /// Interaction logic for AddEmployeeDialog.xaml
    /// </summary>
    public partial class AddEmployeeDialog : Window
    {
        public AddEmployeeDialog()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Obțineți valorile introduse de utilizator din controalele TextBox
            string name = txtName.Text;
            string position = txtPosition.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validează datele introduse (opțional)
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(position) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Creați un nou obiect Employee cu valorile introduse
            var newEmployee = new Employee
            {
                name = name,
                position = position,
                username = username,
                password = password
            };

            // Adăugați angajatul nou în colecția Employees
           /* var viewModel = DataContext as EmployeeViewModel;
            viewModel.AddEmployee(newEmployee);*/

            // Închideți fereastra de dialog
            DialogResult = true;
        }

    }


}
