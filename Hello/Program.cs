using System;
/*
 * Taulukko
 * 9.1.2017 */
namespace Hello
{ //testikommentti
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
            ShowNames();
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
    }
}
