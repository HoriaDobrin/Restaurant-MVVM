using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTema1.Models
{
   public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role{ get; set; } // poate fi "Admin" sau "Waiter"
        public int employeeid { get; set; }
        public virtual Employee employee { get; set; }
    }
}
