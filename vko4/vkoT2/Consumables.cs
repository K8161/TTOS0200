using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkoT2
{
    class Consumable
    {
        public string ProductType { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public Consumable()
        {
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return " Product type: " + ProductType + " Name: " + Name + " Size: " + Size;
        }
    }
}