using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppTema1.Models;

namespace WpfAppTema1.ViewModels
{
    internal class TableViewModel : BaseViewModel
    {
        private RestaurantContext _context;

        public ObservableCollection<Table> Tables { get; set; }

        public TableViewModel()
        {
            _context = new RestaurantContext();
            LoadTables();
        }



        private void LoadTables()
        {
            var Employeeeee = _context.Tables.ToList();
            Tables = new ObservableCollection<Table>(_context.Tables);
            // Accesarea datelor din tabela Employees prin coloana employeeid din tabela Tables
            foreach (var table in Tables)
            {
                if (table.employee != null)
                {
                    string employeeName = table.employee.name;
                    string employeePosition = table.employee.position;
                    string employeeUsername = table.employee.username;

                    // Utilizarea datelor din tabela Employees
                    Console.WriteLine($"Table ID: {table.id}");
                    Console.WriteLine($"Waiter: {employeeName}");
                    Console.WriteLine($"Waiter Position: {employeePosition}");
                    Console.WriteLine($"Waiter Username: {employeeUsername}");
                    Console.WriteLine();
                }
            }


        }

        public void AddTable(Table table)
        {
            _context.Tables.Add(table);
            _context.SaveChanges();
            Tables.Add(table);
        }

        public void UpdateTable(Table table)
        {
            _context.SaveChanges();
        }

        public void DeleteTable(Table table)
        {
            _context.Tables.Remove(table);
            _context.SaveChanges();
            Tables.Remove(table);
        }
    }
}
