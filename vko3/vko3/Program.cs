using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace vko3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaKiuas();
        }

        //Tehtävän1 Kiuas-luokan testaus
        static void TestaaKiuas()
        {
            //luodaan kiuas olio
            Kiuas kiuas = new JAMK.IT.Kiuas();
            //pistetään kiuas lämpenemään ja asetetaan lämpöä&kosteutta
            kiuas.OnkoPäällä = true;
            kiuas.Lämpötila = 90;
            kiuas.Kosteus = 50;
            //näytetään
            Console.WriteLine("Kiuas on päällä {0}", kiuas.OnkoPäällä);
            Console.WriteLine("Kiukaan lämpötila {0}", kiuas.Lämpötila);
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
            //mitä tapahtuu jos kosteus yli rajojen
            kiuas.Kosteus = 101;
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
        }
    }
}
