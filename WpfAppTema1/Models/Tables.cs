using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTema1.Models
{
    public class Table
    {
        public int id { get; set; }
        public int seats { get; set; }
        public int occupiedseats { get; set; }
        public int employeeid { get; set; }
        public virtual Employee employee { get; set; }
        public virtual ICollection<Order> orders { get; set; }
    }
}
