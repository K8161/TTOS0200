using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4T3
{
    class Aikuinen : Ihminen
    {
        public string Auto;

        public override void Liiku()
        {
            Console.WriteLine("Kävelee");
        }
    }
}
