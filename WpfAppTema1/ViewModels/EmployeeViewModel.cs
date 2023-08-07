using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppTema1.Models;
using WpfAppTema1.ViewModels.WpfAppTema1.ViewModels;
using WpfAppTema1.Views;

namespace WpfAppTema1.ViewModels
{
    internal class EmployeeViewModel : BaseViewModel
    {
        public ICommand AddEmployeeCommand { get; }
        public ICommand UpdateEmployeeCommand { get; private set; }
        public ICommand DeleteEmployeeCommand { get; }

        private RestaurantContext _context;

        public ObservableCollection<Employee> Employees { get; set; }

        private Employee _selectedEmployee;
        private UpdateEmployeeDialog _updateEmployeeDialog;

        private void LoadEmployees()
        {
            Employees = new ObservableCollection<Employee>(_context.Employees);
        }
        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged(nameof(SelectedEmployee));
            }
        }
        public EmployeeViewModel()
        {
            _context = new RestaurantContext();
            _updateEmployeeDialog = new UpdateEmployeeDialog();
            LoadEmployees();

            AddEmployeeCommand = new RelayCommand(AddEmployeeCommandExecute);
            DeleteEmployeeCommand = new RelayCommand(DeleteEmployeeCommandExecute);
            UpdateEmployeeCommand = new RelayCommand(UpdateEmployeeCommandExecute);
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            Employees.Add(employee);
        }

        private void AddEmployeeCommandExecute(object parameter)
        {
            var dialog = new AddEmployeeDialog();
            if (dialog.ShowDialog() == true)
            {
                var newEmployee = new Employee
                {
                    name = dialog.txtName.Text,
                    position = dialog.txtPosition.Text,
                    username = dialog.txtUsername.Text,
                    password = dialog.txtPassword.Text
                };

                AddEmployee(newEmployee);
            }
        }

        private void DeleteEmployeeCommandExecute()
        {
            if (SelectedEmployee != null && Employees.Contains(SelectedEmployee))
            {
                var employeeToDelete = _context.Employees.FirstOrDefault(p => p.id == SelectedEmployee.id);

                if (employeeToDelete != null)
                {
                    _context.Employees.Remove(employeeToDelete);
                    _context.SaveChanges();
                }

                Employees.Remove(SelectedEmployee);
            }
        }

        private void UpdateEmployeeCommandExecute()
        {
            if (SelectedEmployee != null)
            {  
                _updateEmployeeDialog.ShowDialog();
                
                if (_updateEmployeeDialog.Name != "") { SelectedEmployee.name = _updateEmployeeDialog.Name; }
                if (_updateEmployeeDialog.Position != "") { SelectedEmployee.position = _updateEmployeeDialog.Position; }
                if (_updateEmployeeDialog.Username != "") { SelectedEmployee.username = _updateEmployeeDialog.Username; }
                if (_updateEmployeeDialog.Password != "") { SelectedEmployee.password = _updateEmployeeDialog.Password; }

                _context.SaveChanges();

                int index = Employees.IndexOf(SelectedEmployee);

                if (index != -1)
                {
                    Employees[index] = SelectedEmployee;
                }
                OnPropertyChanged(nameof(SelectedEmployee));
                
            }
        }



    }
}
