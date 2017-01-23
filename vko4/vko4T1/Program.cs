using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Teht1();
        }
        static void Teht1()
        {
            //create Tyre object
            Tyre tyre1 = new Tyre();
            tyre1.Name = "Nokia";
            tyre1.Model = "Hakkapeliitta";
            tyre1.TyreSize = "205R16";

            //create other Tyre object
            Tyre tyre2 = new Tyre();
            tyre2.Name = "MIC";
            tyre2.Model = "Pilot";
            tyre2.TyreSize = "160R17";

            //create car object
            Vehicle vehicle1 = new Vehicle();
            vehicle1.VehicleType = "Car";
            vehicle1.Name = "Porsche";
            vehicle1.Model = "911";
            vehicle1.Year = 1989;

            List<Tyre> Porsche = new List<Tyre>();
            // use polymorphis to store objects
            Porsche.Add(tyre1);
            Porsche.Add(tyre1);
            Porsche.Add(tyre1);
            Porsche.Add(tyre1);

            vehicle1.AddTyre(tyre1);
            vehicle1.AddTyre(tyre1);
            vehicle1.AddTyre(tyre1);
            vehicle1.AddTyre(tyre1);
            Console.WriteLine(vehicle1.ToString());
        }
    }
}
