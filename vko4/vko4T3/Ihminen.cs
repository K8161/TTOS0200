using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4T3
{
    class Ihminen : Nisakas
    {
        public string nimi;
        public int paino;
        public int pituus;

        public override void Liiku()
        {
            Console.WriteLine("Liikun");
        }

        public void Kasva()
        {
            Ika++;
        }
    }
}
