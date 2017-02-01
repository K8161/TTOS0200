using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T2
{
    class Product
    {
            public string Name { get; set; }
            public double Price { get; set; }

        // override base class ToString()-method
        public override string ToString()
        {
            return "- product : " + Name + " " + Price + " e";
        }
    }
}
