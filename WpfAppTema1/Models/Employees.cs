using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTema1.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
