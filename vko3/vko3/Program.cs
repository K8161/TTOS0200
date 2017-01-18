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
            //TestNations();
            //TestaaOpiskelija2();
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
            //luodaan pesuokne olio
            Pesukone pesukone = new JAMK.IT.Pesukone();
            //pesukone päälle, pesulämpötila ja pesuohjelma
            pesukone.OnkoPaalla = true;
            pesukone.Pesulampotila = 50;
            pesukone.Pesuohjelma = "kirjopyykki";
            //näytetään tiedot
            Console.WriteLine("Pesukone on päällä {0}", pesukone.OnkoPaalla);
            Console.WriteLine("Pesukoneen pesulämpötila {0}", pesukone.Pesulampotila);
            Console.WriteLine("Pesukoneen pesuohjelma {0}", pesukone.Pesuohjelma);
            //nostetaan lämpötilaa
            pesukone.NostaLampotila();
            Console.WriteLine("Pesukoneen pesulampotila {0}", pesukone.Pesulampotila);
        }

        static void TestaaTV()
        {
            //luodaan tv olio
            TV tv = new JAMK.IT.TV();
            //pistetään tv päälle ja annetaan kanava & äänenvoimakkuus
            tv.OnkoPaalla = true;
            tv.Kanava = 3;
            tv.Äänenvoimakkuus = 25;
            //näytetään tv:n tiedot
            Console.WriteLine("TV on päällä {0}", tv.OnkoPaalla);
            Console.WriteLine("TV:n kanava on {0}", tv.Kanava);
            Console.WriteLine("TV:n äänenvoimakkuus on {0}", tv.Äänenvoimakkuus);
            //mvaihdetaan kanavaa ja äänenvoimakkuutta
            tv.LisääÄäntä();
            tv.VaihdaKanavaYlös();
            Console.WriteLine("TV:n kanava on {0}", tv.Kanava);
            Console.WriteLine("TV:n äänenvoimakkuus on {0}", tv.Äänenvoimakkuus);
        }

        static void TestVehicle()
        {
            {
                // create car for test purposes
                Vehicle toyota = new Vehicle();
                toyota.Name = "Toyota Corolla";
                toyota.Color = "White";
                toyota.Speed = 0;
                toyota.Tyres = 4;
                // display car data
                toyota.PrintData();
                Console.ReadLine();
                // accelerate, change cars speed value and color to black
                toyota.Accelerate();
                toyota.Blacken();
                // display car data again
                toyota.PrintData();
                Console.ReadLine();

                Console.WriteLine(toyota.ToString());
            }
        }

        static void TestaaOpiskelija()
        {
            {
                List<Opiskelija> Opiskelijat = new List<Opiskelija>();

                /* Opiskelija[] opiskelija = new Opiskelija []
                 * opiskelija[1].Etunimi = "Jorma"
                 * opiskelija[1].Sukunimi = "Jakkara"
                 * jne */
                
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
                // create nation for test purposes
                Nation USA = new Nation();
                USA.Name = "United States of America";
                USA.Population = 324720797;
                USA.GDP = 18.558;
                USA.NuclearWeapons = 6970;
                // display data
                USA.PrintData();
                Console.ReadLine();
            }
        }

        static void TestaaOpiskelija2()
        {
            {   //Kaksiulotteinen taulukko oppilaiden tietoja varten
                string[,] oppilaat = new string[5, 4];
                
                //Lisätään opiskelijat taulukkoon                
                // Opiskelija1
                oppilaat[0, 0] = "Pekka";
                oppilaat[0, 1] = "Perälä";
                oppilaat[0, 2] = "1.1.1986";
                oppilaat[0, 3] = "1";
                // Opiskelija2
                oppilaat[1, 0] = "Mauri";
                oppilaat[1, 1] = "Mäyrä";
                oppilaat[1, 2] = "6.4.1997";
                oppilaat[1, 3] = "4";
                // Opiskelija3
                oppilaat[2, 0] = "Kalle";
                oppilaat[2, 1] = "Käyrä";
                oppilaat[2, 2] = "17.12.1990";
                oppilaat[2, 3] = "1";
                // Opiskelija4
                oppilaat[3, 0] = "Tiina";
                oppilaat[3, 1] = "Turma";
                oppilaat[3, 2] = "23.10.1993";
                oppilaat[3, 3] = "2";
                // Opiskelija5
                oppilaat[4, 0] = "Antti";
                oppilaat[4, 1] = "Alava";
                oppilaat[4, 2] = "3.9.1995";
                oppilaat[4, 3] = "4";


                  //tulostetaan tiedot kahden for loopin avulla
                  for (int i = 0; i < oppilaat.GetLength(0); i++)
                  {
                      for (int j = 0; j < oppilaat.GetLength(1); j++)
                      {
                        string s = oppilaat[i, j];

                        if (j == 0)
                        { Console.WriteLine("Etunimi: " + s); }

                        else if (j == 1)
                        { Console.WriteLine("Sukunimi: " + s); }

                        else if (j == 2)
                        { Console.WriteLine("Syntymäaika: " + s); }

                        else if (j == 3)
                        { Console.WriteLine("Ryhmätunnus: " + s + "\n"); }

                    }

                  } 
            }
        }
    }
}