using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4T3
{
    class Ihminen : Nisakas
    {
        public string Nimi { get; set; }
        public int Paino { get; set; }
        public int Pituus { get; set; }

        public Ihminen()
        {
        }

        public Ihminen(string nimi, int paino, int pituus)
        {
            Nimi = nimi;
            Paino = paino;
            Pituus = pituus;
        }

        public override void Liiku()
        {
            Console.WriteLine("Liikun");
        }

        public void Kasva()
        {
            base.Ika++;
        }

        public override string ToString()
        {
            return "Nimi: " + Nimi + " Pituus: " + Pituus + "cm Paino " + Paino + "kg Ika " + Ika;
        }
    }
}
