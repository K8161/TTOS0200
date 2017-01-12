using System;
/*
 * Taulukko
 * 9.1.2017 */
//testikommentti
// Toinen muutos kommenttiin
namespace Hello
{ 
    class Henkilo
    {
        public string Nimi { get; set; }
        public int Ika { get; set; }

    }
    class Testi
    {
        static void Main(string[] args)
        {
            //SayHello();
            //ShowNames();
            Harjoitus8();
        }

        static void ShowNames()
        {
            //TODO
            //Tee ohjelma joka kysyy käyttäjältä viisi käyttäjänimeä ja tallentaa ne
            //Ohjelma voisi tulostaa annetut nimet konsolille aakkosjärjestyksessä.
            string[] nimet = new string[5]; // määritetään ja alustetaan taulukko viittä henkilöä varten


            for (int i = 0; i < nimet.Length; i++) // kysytään nimet ja tallennetaan ne taulukkoon
            {
                Console.WriteLine("Anna nimi:");
                nimet[i] = Console.ReadLine();
            }

      /*      for (int i = 0; i < nimet.Length; i++) // näytetään nimet
            {
                Console.WriteLine(nimet[i]);
            } */

            Console.WriteLine("Annetut nimet aakkosjärjestyksessä:");
            Array.Sort(nimet); //sortataan nimet
            for (int i = 0; i < nimet.Length; i++) // näytetään nimet
            {
                Console.WriteLine(nimet[i]);
            }
        }
        static void SayHello()
        {
            //määritellään muuttuja
            string nimi = "Jack Russell";
            //luodaan olio Henkilo-luokasta
            Henkilo hlo = new Henkilo();
            hlo.Ika = 42;
            hlo.Nimi = "Max Mickelson";
            //konsolille
            Console.WriteLine("Terve: {0} ikäsi on: {1}", hlo.Nimi, hlo.Ika);
            //pidetään sovelluksen ajoikkuna auki
            Console.ReadLine();
        }

        /* Harjoitus 1, ohjelma tulostaa käyttäjän antaman luvun sanana. */

        static void Harjoitus1()
        { int luku;

            Console.WriteLine("Anna luku: ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi."); 
             }
            else if (luku == 2)
            {
                Console.WriteLine("Annoit luvun kaksi.");
            }

            else if (luku == 3)
            {
                Console.WriteLine("Annoit luvun kolme.");
            }

            else 
            {
                Console.WriteLine("Annoit jonkin muun luvun.");
            }
        }

/* Harjoitus 2, ohjelma antaa oppilaalle koulunumeron pisteiden mukaan. */

        static void Harjoitus2()
        {
            int luku;

            Console.WriteLine("Anna pistemäärä: ");
            luku = int.Parse(Console.ReadLine());

            if (luku < 2)
            {
                Console.WriteLine("Arvosanasi on 0.");
            }
            else if (luku < 4)
            {
                Console.WriteLine("Arvosanasi on 1.");
            }

            else if (luku < 6)
            {
                Console.WriteLine("Arvosanasi on 2.");
            }

            else if (luku < 8)
            {
                Console.WriteLine("Arvosanasi on 3.");
            }

            else if (luku < 10)
            {
                Console.WriteLine("Arvosanasi on 4.");
            }

            else if (luku == 10 && luku < 12)
            {
                Console.WriteLine("Arvosanasi on 5.");
            }

            else
            {
                Console.WriteLine("Pistemäärä ei kelpaa");
            }
        }

        /* Harjoitus 3, ohjelma kysyy kolme lukua ja tulostaa näiden summan ja keskiarvon */

        static void Harjoitus3()
        {
            int[] luvut = new int[3];
            int i, summa, keskiarvo;
            int maara = 1;
           

            for (i = 0; i < 3; i++)
            { Console.WriteLine("Anna luku " + maara);
            luvut[i] = int.Parse(Console.ReadLine());
                maara++;
            }

            summa = luvut[0] + luvut[1] + luvut[2];
            keskiarvo = summa / 3;

            Console.WriteLine("Antamiesi lukujen summa on: " + summa);
            Console.WriteLine("Antamiesi lukujen keskiarvo on: " + keskiarvo);
        }

        /* Harjoitus 4, ohjelma kysyy käyttäjän iän ja tulostaa vastauksen sen mukaan. */

        static void Harjoitus4()
        {
            int ika;

            Console.WriteLine("Anna ikäsi: ");
            ika = int.Parse(Console.ReadLine());

            if (ika < 18)
            {
                Console.WriteLine("Alaikäban.");
            }
            else if (ika > 18 && ika < 65)
            {
                Console.WriteLine("Aikuinen");
            }

            else
            {
                Console.WriteLine("Seniori");
            }
        }

        /* Harjoitus 5, ohjelma kysyy sekuntimäärän ja ilmoittaa sen tunteina, minuutteina ja sekunteina */

        static void Harjoitus5()
        {
            int sekunnit, minuutit, tunnit, apu;
            
                Console.WriteLine("Anna sekunnit: ");
                apu = int.Parse(Console.ReadLine());
                tunnit = apu / 60 / 60;
                minuutit = apu / 60 - tunnit * 60;
                sekunnit = apu - minuutit * 60 - tunnit * 60;  
            

            Console.WriteLine("Antamasi aika voidaan ilmaista muodossa: " + tunnit + " tuntia " + minuutit + " minuuttia " + sekunnit + " sekuntia.");
        }

        /* Harjoitus 6, ohjelma kysyy ajomatkan kilometreinä ja kertoo paljonko tähän kuluu polttoainetta ja rahaa */

        static void Harjoitus6()
        {
            int matka;
            double polttoaine, hinta;

            Console.WriteLine("Anna matka: ");
            matka = int.Parse(Console.ReadLine());
            polttoaine = matka * 0.0702;
            hinta = polttoaine * 1.595;


            Console.WriteLine("Bensaa kuluu: " + polttoaine + " litraa, kustannus " + hinta + " euroa.");
        }

        /* Harjoitus 7, ohjelma kysyy vuosiluvun ja tarkistaa onko kyseessä karkausvuosi */

        static void Harjoitus7()
        {
            int vuosi;

            Console.WriteLine("Anna vuosi: ");
            vuosi = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(vuosi))
                Console.WriteLine(vuosi + " on karkausvuosi.");

            else
                Console.WriteLine(vuosi + " ei ole karkausvuosi.");

        }

        /* Harjoitus 8, ohjelma kysyy kolme lukua ja näyttää niistä suurimman */

        static void Harjoitus8()
        {
           
            int[] luvut = new int[3]; 


            for (int i = 0; i < luvut.Length; i++) 
            {
                Console.WriteLine("Anna luku:");
                luvut[i] = int.Parse(Console.ReadLine());
            }
                        
            Console.WriteLine("Suurin antamasi luku:");
            Array.Sort(luvut); //sortataan nimet
            
            Console.WriteLine(luvut[2]);
            
        }
    }
}
