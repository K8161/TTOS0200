using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4T3
{
    class Vauva : Ihminen
    {
        public string Vaippa { get; set; }

        public Vauva()
        {
        }

        public Vauva(string nimi, int paino, int pituus, string vaippa) 
            : base(nimi, paino, pituus)
        {
            vaippa = Vaippa;
        }


        public override void Liiku()
        {
            Console.WriteLine("Konttaa");
        }

        public override string ToString()
        {
            return base.ToString() + " Vaippa: " + Vaippa;
        }
    }
}
