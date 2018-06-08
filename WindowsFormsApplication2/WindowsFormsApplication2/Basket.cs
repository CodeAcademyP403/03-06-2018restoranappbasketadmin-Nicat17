using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication2
{   
    public class ProductsAtBasket
    {
        public int id { get; set; }
        public string Name { get; set; }
        public byte Count { get; set; }
        public decimal TotalPrice { get; set; }
    }
    public class Basket
    {
        public ArrayList productsItems { get; set; }

        public Basket()
        {
            productsItems = new ArrayList();
        }
    }

}
