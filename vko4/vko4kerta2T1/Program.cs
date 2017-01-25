using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.vko4kerta2T1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaHenkiloRekisteri();
        }

        static void TestaaHenkiloRekisteri()
        {
            //luodaan muutama testihenkilo
            Henkilot poppoo = new Henkilot();
            Henkilo hlo = new Henkilo { Etunimi = "Jaska", Sukunimi = "Ruska", Hetu = "311086-123A" };
            Henkilo hlo1 = new Henkilo { Etunimi = "Kikki", Sukunimi = "Hiiri", Hetu = "040643-666B" };
            Henkilo hlo2 = new Henkilo { Etunimi = "Pertti", Sukunimi = "Pulla", Hetu = "010190-432C" };
            //Lisataan henkilot poppooseen
            poppoo.LisaaHenkilo(hlo);
            poppoo.LisaaHenkilo(hlo1);
            poppoo.LisaaHenkilo(hlo2);

            //tulostetaan poppoo naytolle
            foreach (Henkilo h in poppoo.Henkilolista) //var item kay myos
            {
                Console.WriteLine("{0}", h.ToString());
            }


            //TODO kysy kayttajalta hetu ja hae sitä vastaava henkilo naytolle
            Console.WriteLine("\nHae henkilotunnuksella: ");
            string haku = Console.ReadLine();

            Console.WriteLine(poppoo.HaeHenkiloHetulla(haku));


        }
    }
}
