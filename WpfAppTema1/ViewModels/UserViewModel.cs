using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppTema1.Models;

namespace WpfAppTema1.ViewModels
{
    internal class UserViewModel : BaseViewModel
    {
        private RestaurantContext _context;

        public ObservableCollection<User> Users { get; set; }

        public UserViewModel()
        {
            _context = new RestaurantContext();
            LoadUsers();
        }

        private void LoadUsers()
        {
            Users = new ObservableCollection<User>(_context.Users);
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            Users.Add(user);
        }

        public void UpdateUser(User user)
        {
            _context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
            Users.Remove(user);
        }
    }
}
