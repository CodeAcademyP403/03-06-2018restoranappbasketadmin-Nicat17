using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Product
    {
        public string name { get; set; }
        public byte count { get; set; }
        public int id { get; set; }
        public decimal price { get; set; }
        public Category category { get; set; }

        public Product()
        {
            count = 1;
        }
    }
}
