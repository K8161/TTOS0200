using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T6
{
    class Program
    {
        static void Main(string[] args)
        {
            TestRide();
        }
        static void TestRide()
        {
            // create first Bike object
            Bike bike1 = new Bike();
            bike1.Name = "Helkama";
            bike1.Model = "Mummopyörä";
            bike1.ModelYear = 1954;
            bike1.Color = "Red";
            bike1.GearWheels = false;
            bike1.GearName = " ";
            Console.WriteLine("Bike info: \n{0}\n", bike1.ToString());

            // create second Bike object
            Bike bike2 = new Bike();
            bike2.Name = "Cube Attain";
            bike2.Model = "Road";
            bike2.ModelYear = 2016;
            bike2.Color = "Black/Yellow";
            bike2.GearWheels = true;
            bike2.GearName = "Shimano";
            Console.WriteLine("Bike info: \n{0}\n", bike2.ToString());

            // create first Boat object
            Boat boat1 = new Boat();
            boat1.Name = "Jolla";
            boat1.Model = "Unknown";
            boat1.ModelYear = 1976;
            boat1.Color = "Ugly green";
            boat1.BoatType = "Rowboat";
            boat1.SeatCount = 3;
            Console.WriteLine("Boat info: \n{0}\n ", boat1.ToString());

            // create second Boat object
            Boat boat2 = new Boat();
            boat2.Name = "MermaidHunter";
            boat2.Model = "Lagoon 42";
            boat2.ModelYear = 2016;
            boat2.Color = "White";
            boat2.BoatType = "Catamaran";
            boat2.SeatCount = 8;
            Console.WriteLine("Boat info: \n{0}\n", boat2.ToString());


            // do something methods (unused)
            //ride.RideMethod(); // This method belongs to Ride!
            //bike1.BikeMethod(); // This method belongs to Bike! (derived class can use it!)
        }
    }
}
