using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4T3
{
    class Program
    {
        static void Main(string[] args)
        {
            // This doesn't work, object cannot be created from the abstract classes
            //DrawingObject do = new DrawingObject();

            Aikuinen aikuinen1 = new Aikuinen();
            aikuinen1.Nimi = "Teppo";
            aikuinen1.Pituus = 185;
            aikuinen1.Paino = 86;
            aikuinen1.Ika = 34;
            aikuinen1.Auto = "Volvo";

            Vauva vauva1 = new Vauva();
            vauva1.Nimi = "Aatu";
            vauva1.Pituus = 54;
            vauva1.Paino = 4;
            vauva1.Ika = 0;
            vauva1.Vaippa = "Pampers";

            Ihminen ihminen1 = new Ihminen();
            ihminen1.Nimi = "Teppo";
            ihminen1.Pituus = 185;
            ihminen1.Paino = 86;
            ihminen1.Ika = 34;



            // create a list to store objects
            List<Nisakas> nisakkaat = new List<Nisakas>();
            // use polymorphis to store objects
            nisakkaat.Add(aikuinen1);
            nisakkaat.Add(ihminen1);
            nisakkaat.Add(vauva1);


            Console.WriteLine("Loop through all drawing objects in a list:");
                   foreach (Nisakas nisakas in nisakkaat)
                   {
                Console.WriteLine(nisakas.ToString());
                nisakas.Liiku();
                   } 
        }
    }
}
