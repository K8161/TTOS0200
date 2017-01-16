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
            //TestaaKiuas();
            //TestaaPesukone();
            //TestaaTV();
            //TestVehicle();
            //TestaaOpiskelija();
            TestNations();
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

        static void TestaaPesukone()
        {
            //luodaan kiuas olio
            Pesukone pesukone = new JAMK.IT.Pesukone();
            //pistetään kiuas lämpenemään ja asetetaan lämpöä&kosteutta
            pesukone.OnkoPaalla = true;
            pesukone.Pesulampotila = 50;
            pesukone.Pesuohjelma = "kirjopyykki";
            //näytetään
            Console.WriteLine("Pesukone on päällä {0}", pesukone.OnkoPaalla);
            Console.WriteLine("Pesukoneen pesulämpötila {0}", pesukone.Pesulampotila);
            Console.WriteLine("Pesukoneen pesuohjelma {0}", pesukone.Pesuohjelma);
            //mitä tapahtuu jos kosteus yli rajojen
            pesukone.NostaLampotila();
            Console.WriteLine("Pesukoneen pesulampotila {0}", pesukone.Pesulampotila);
        }

        static void TestaaTV()
        {
            //luodaan kiuas olio
            TV tv = new JAMK.IT.TV();
            //pistetään kiuas lämpenemään ja asetetaan lämpöä&kosteutta
            tv.OnkoPaalla = true;
            tv.Kanava = 3;
            tv.Äänenvoimakkuus = 25;
            //näytetään
            Console.WriteLine("TV on päällä {0}", tv.OnkoPaalla);
            Console.WriteLine("TV:n kanava on {0}", tv.Kanava);
            Console.WriteLine("TV:n äänenvoimakkuus on {0}", tv.Äänenvoimakkuus);
            //mitä tapahtuu jos kosteus yli rajojen
            tv.LisääÄäntä();
            tv.VaihdaKanavaYlös();
            Console.WriteLine("TV:n kanava on {0}", tv.Kanava);
            Console.WriteLine("TV:n äänenvoimakkuus on {0}", tv.Äänenvoimakkuus);
        }

        static void TestVehicle()
        {
            {
                // create car for test purposes
                Vehicle Toyota = new Vehicle();
                Toyota.Name = "Toyota Corolla";
                Toyota.Color = "White";
                Toyota.Speed = 0;
                Toyota.Tyres = 4;
                // display car data
                Toyota.PrintData();
                Console.ReadLine();
                // accelerate, change car's speed value and color to black
                Toyota.Accelerate();
                Toyota.Blacken();
                // display car data again, notice changed speed value!
                Toyota.PrintData();
                Console.ReadLine();
            }
        }

        static void TestaaOpiskelija()
        {
            {
                List<Opiskelija> Opiskelijat = new List<Opiskelija>();
                
                // Opiskelija1
                Opiskelija Opiskelija1 = new Opiskelija();
                Opiskelija1.Etunimi = "Pekka";
                Opiskelija1.Sukunimi = "Perälä";
                Opiskelija1.Syntymäaika = "1.1.1986";
                Opiskelija1.Ryhmä = "1";
                // Opiskelija2
                Opiskelija Opiskelija2 = new Opiskelija();
                Opiskelija2.Etunimi = "Mauri";
                Opiskelija2.Sukunimi = "Mäyrä";
                Opiskelija2.Syntymäaika = "6.4.1997";
                Opiskelija2.Ryhmä = "4";
                // Opiskelija3
                Opiskelija Opiskelija3 = new Opiskelija();
                Opiskelija3.Etunimi = "Kalle";
                Opiskelija3.Sukunimi = "Käyrä";
                Opiskelija3.Syntymäaika = "17.12.1990";
                Opiskelija3.Ryhmä = "1";
                // Opiskelija4
                Opiskelija Opiskelija4 = new Opiskelija();
                Opiskelija4.Etunimi = "Tiina";
                Opiskelija4.Sukunimi = "Turma";
                Opiskelija4.Syntymäaika = "23.10.1993";
                Opiskelija4.Ryhmä = "2";
                // Opiskelija5
                Opiskelija Opiskelija5 = new Opiskelija();
                Opiskelija5.Etunimi = "Antti";
                Opiskelija5.Sukunimi = "Alava";
                Opiskelija5.Syntymäaika = "3.9.1995";
                Opiskelija5.Ryhmä = "4";


                Opiskelijat.Add(Opiskelija1);
                Opiskelijat.Add(Opiskelija2);
                Opiskelijat.Add(Opiskelija3);
                Opiskelijat.Add(Opiskelija4);
                Opiskelijat.Add(Opiskelija5);

                Opiskelija1.PrintData();
                Console.ReadLine();
                Opiskelija2.PrintData();
                Console.ReadLine();
                Opiskelija3.PrintData();
                Console.ReadLine();
                Opiskelija4.PrintData();
                Console.ReadLine();
                Opiskelija5.PrintData();
                Console.ReadLine();
                //List<Opiskelija>.ForEach(Opiskelija => Console.Write(Opiskelija));
            }
        }

        static void TestNations()
        {
            {
                // create car for test purposes
                Nation USA = new Nation();
                USA.Name = "United States of America";
                USA.Population = 324720797;
                USA.GDP = 18.558;
                USA.NuclearWeapons = 6970;
                // display car data
                USA.PrintData();
                Console.ReadLine();
            }
        }
    }
}