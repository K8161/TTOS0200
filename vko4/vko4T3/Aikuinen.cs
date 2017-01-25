using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4T3
{
    class Aikuinen : Ihminen
    {
        public string Auto { get; set; }

        public Aikuinen()
        {
        }

        public Aikuinen(string nimi, int paino, int pituus, string auto) 
            : base(nimi, paino, pituus)
        {
            auto = Auto;
        }


        public override void Liiku()
        {
            Console.WriteLine("Kävelee");
        }

        public override string ToString()
        {
            return base.ToString() + " Auto: " + Auto;
        }
    }
}
