using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Opiskelija
    {
        // properties
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Syntymäaika { get; set; }
        public string Ryhmä { get; set; }

        // method to display data
        public void PrintData()
        {
            Console.WriteLine("Opiskelijan tiedot: ");
            Console.WriteLine("- Etunimi: " + Etunimi);
            Console.WriteLine("- Sukunimi: " + Sukunimi);
            Console.WriteLine("- Syntymäaika: " + Syntymäaika);
            Console.WriteLine("- Ryhmä: " + Ryhmä);
        }


    }

}