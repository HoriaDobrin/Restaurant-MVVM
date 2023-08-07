using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTema1.Models
{
    public class Order
    {
        public int id { get; set; }
        public int tableid { get; set; }
        public virtual Table table { get; set; }
        public int productid { get; set; }
        public virtual Product product { get; set; }
        public string status { get; set; } // poate fi "Paid", "Unpaid" sau "Cancelled"
        public double total { get; set; }
    }
}
