using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppTema1.Models;

namespace WpfAppTema1.ViewModels
{
    internal class OrderViewModel : BaseViewModel
    {
        private RestaurantContext _context;

        public ObservableCollection<Order> Orders { get; set; }

        public OrderViewModel()
        {
            _context = new RestaurantContext();
            LoadOrders();
        }

        private void LoadOrders()
        {
            
            Orders = new ObservableCollection<Order>(_context.Orders);
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            Orders.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            _context.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
            Orders.Remove(order);
        }
    }
}
