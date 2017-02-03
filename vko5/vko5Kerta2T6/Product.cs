using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T6
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }

        // override base class ToString()-method
        public override string ToString()
        {
            Total = Price * Quantity;
            return " Product " + Name + " " + Price + "e  " + Quantity + "pcs  Total " + Total;
        }
    }
}
