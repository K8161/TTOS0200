using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fishingfun();
        }

        static void Fishingfun()
        {
            List<Fisher>Fishers = new List<Fisher>();
            //create fisher
            Fisher fisher1 = new Fisher();
            fisher1.Name = "Pekka Siitoin";
            fisher1.PhoneNumber = "040 666";

            Fishers.Add(fisher1);

            //create fish
            Fish salmon1 = new Fish();
            salmon1.Specie = "Salmon";
            salmon1.Length = "57";
            salmon1.Weight = "5";
            salmon1.Place = "Unknown";
            salmon1.Location = "Norway";


            //create another fish
            Fish redsnap1 = new Fish();
            redsnap1.Specie = "Red Snapper";
            redsnap1.Length = "15";
            redsnap1.Weight = "0,5";
            redsnap1.Place = "Adrians Sea";
            redsnap1.Location = "Croatia";

            Console.WriteLine("A new fisherman added to register: " + fisher1.Name + " Phone: " + fisher1.PhoneNumber);

            //adding fishes to fisher
            fisher1.AddFish(salmon1);
            fisher1.AddFish(redsnap1);

            foreach (var item in Fishers)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
