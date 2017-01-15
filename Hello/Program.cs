using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Harjoitus19();
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
        {
            int luku;

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
            {
                Console.WriteLine("Anna luku " + maara);
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
            int sekunnit, minuutit, tunnit;

            Console.WriteLine("Anna sekunnit: ");
            sekunnit = int.Parse(Console.ReadLine());
            tunnit = sekunnit / 60 / 60;
            sekunnit = sekunnit % 3600;
            minuutit = sekunnit / 60;
            sekunnit = sekunnit % 60;


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
            Array.Sort(luvut); //sortataan luvut

            Console.WriteLine(luvut[2]);

        }

        /* Harjoitus 9, ohjelma kysyy lukuja kunnes käyttäjä syöttää nollan ja tulostaa lopuksi lukujen summan */

        static void Harjoitus9()
        {

            int[] luvut = new int[12];
            int i, sum;
            int x = 1;


            for (i = 0; x != 0; i++)
            {
                Console.WriteLine("Anna luku:");
                x = int.Parse(Console.ReadLine());
                luvut[i] = x;
            }

            sum = luvut.Sum();

            Console.WriteLine("Lukujen summa on: " + sum);
        }

        /* Harjoitus 10, ohjelma näyttää onko luku parillinen */

        static void Harjoitus10()
        {

            int[] luvut = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            int i;

            for (i = 0; i < luvut.Length; i++)
            {
                if (IsOdd(i))
                {
                    Console.WriteLine(luvut[i] + " HEP");
                }
            }
        }

        static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        /* Harjoitus 11, ohjelma kysyy luvun ja tulostaa sen mukaan *-merkkejä */

        static void Harjoitus11()
        {
            int rivinro, sarakenro, luku;

            Console.WriteLine("Syötä luku väliltä 1-9: ");
            luku = int.Parse(Console.ReadLine());

            for (rivinro = 1; rivinro <= luku; rivinro++)
            {

                for (sarakenro = 1; sarakenro <= rivinro; sarakenro++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /* Harjoitus 12, ohjelma kysyy 5 lukua ja tulostaa ne käänteisessä järjestyksessä */

        static void Harjoitus12()
        {

            int[] luvut = new int[5];
            int i;


            for (i = 0; i < luvut.Length; i++)
            {
                Console.WriteLine("Anna luku:");
                luvut[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(luvut);

            for (i = 0; i < 5; i++)
            {
                if (i < 4)
                    //   cout << lottorivi[i] << endl;
                    Console.Write(luvut[i] + ", ");

                else
                    Console.Write(luvut[i] + "\n\n");

            }
        }

        /* Harjoitus 13, ohjelma kysyy arvostelupisteet hypylle ja tulostaa pisteiden summan siten, että summasta on vähennetty pienin ja suurin tyylipiste */

        static void Harjoitus13()
        {

            int[] pisteet = new int[5];
            int sum;


            for (int i = 0; i < pisteet.Length; i++)
            {
                Console.Write("Anna luku:");
                pisteet[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(pisteet); //sortataan luvut
            sum = pisteet.Sum(); //lasketaan pisteet yhteen
            sum = sum - pisteet[0] - pisteet[4]; //miinustetaan pisteistä suurin ja pienin pistemäärä

            Console.WriteLine("Kokonaispisteet ovat: " + sum);

        }

        /* Harjoitus 14, ohjelma kysyy arvosanat ja näyttää montako kpl tuli mitäkin arvosanaa */

     /*      static void Harjoitus14()
           {

               int[] arvosanat = new int[10];
               char nolla = new char[10];


               for (int i = 0; i < arvosanat.Length; i++)
               {
                   Console.Write("Syötä arvosana 0-5:");
                   arvosanat[i] = int.Parse(Console.ReadLine());
               }

               foreach (int luku in arvosanat)
               {
                   if (luku == 0)

               }
           } */

        /* Harjoitus 15, ohjelma kysyy luvun ja tulostaa sen mukaan *-merkkejä */

        static void Harjoitus15()
        {
            int rivinro, sarakenro, luku;

            Console.WriteLine("Syötä luku väliltä 1-9: ");
            luku = int.Parse(Console.ReadLine());

            for (rivinro = 0; rivinro < luku; rivinro++)
            {

                for (sarakenro = 0; sarakenro < luku - rivinro - 1; sarakenro++)
                {
                    Console.Write(" ");
                }

                for (int y = 0; y < rivinro * 2 + 1; y++)
                {

                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.WriteLine(new String(' ', luku - 1) + "*");
            Console.WriteLine(new String(' ', luku - 1) + "*");
        }

        /* Harjoitus 16, arpoo satunnaisluvun väliltä 0-100 ja käyttäjä yrittää arvata lukua vihjeiden avulla */

        static void Harjoitus16()
        {
            int luku, arvaus;
            Random rand = new Random();

            luku = rand.Next(0, 100);

            do
            {
                Console.WriteLine("Arvaa luku väliltä 0-100: ");
                arvaus = Convert.ToInt32(Console.ReadLine());

                if (arvaus > luku)
                    Console.WriteLine("Luku on pienempi.");

                else if (arvaus < luku)
                    Console.WriteLine("Luku on suurempi.");

                else if (arvaus == luku)
                    Console.WriteLine("Onnittelut! Arvasit oikein, luku oli " + luku);

            } while (arvaus != luku);

        }

        /* Harjoitus 17, ohjelma kysyy kaksi eri lukujonoa ja tulostaa ne kolmanteen jonoon suuruusjärjestyksessä */

        static void Harjoitus17()
        {

            int[] luvut1 = new int[5];
            int[] luvut2 = new int[5];
            int[] luvut3 = new int[10];
            int i, j = 0;


            for (i = 0; i < luvut1.Length; i++)
            {
                Console.WriteLine("Anna luku jonoon 1:");
                luvut1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < luvut2.Length; i++)
            {
                Console.WriteLine("Anna luku jonoon 2:");
                luvut2[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < luvut1.Length; i++)
            {
                luvut3[j] = luvut1[i];
                j++;
            }


            for (i = 0; i < luvut2.Length; i++)
            {
                luvut3[j] = luvut2[i];
                j++;
            }

            Array.Sort(luvut3); //sortataan luvut

            Console.Write("Antamasi numerot suuruusjärjestyksessä: ");
            for (i = 0; i < 10; i++)
            {
                if (i <= 8)
                    //   cout << lottorivi[i] << endl;
                    Console.Write(luvut3[i] + ", ");

                else
                    Console.Write(luvut3[i] + "\n\n");
            }

        }

        /* Harjoitus 18, tarkistaa onko käyttäjän merkkijono palindromi. */

        static void Harjoitus18()
        {
            string mjono; // muistipaikka merkkijonolle, 100 merkkiä + NULL

            Console.WriteLine("Anna merkkijono tarkistaaksesi onko se palindromi: ");
            mjono = Console.ReadLine();

            if (mjono.SequenceEqual(mjono.Reverse()))
            {
                Console.WriteLine(mjono + " on palindromi.");
            }

            else
            {
                Console.WriteLine(mjono + " ei ole palindromi.");
            }
        }

        /* Harjoitus 19, hirsipuupeli */

        static void Harjoitus19()
        {

            string sana = "kissa";
            char arvaus;
            char[] apu = new char[5] {' ',' ',' ',' ',' '};
            int i, elama = 5;
            bool oikein = true;



            Console.WriteLine("Hirsipuupeli");

            do
            {
                if (apu.Equals(sana))
                {
                    break;
                }


                Console.WriteLine("Yrityksiä jäljellä: " + elama);
                Console.WriteLine("Arvaa kirjain: ");
                arvaus = char.Parse(Console.ReadLine());

                if (sana.Contains(arvaus))
                {
                    for (i = 0; i < sana.Length; i++)
                    {
                        if (sana[i] == arvaus)
                        { apu[i] = arvaus; }
                    }
                }
                else
                {
                    elama--;
                }
            } while (elama > 0);

            if (apu.Equals(sana))
            {
                Console.WriteLine("Voitit pelin, sana oli " + sana);
            }

            else
                Console.WriteLine("Hävisit pelin, sana oli " + sana);
                }
                
    }
}
