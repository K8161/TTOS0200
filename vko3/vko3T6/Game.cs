using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T6
{
    class Game : BasicInfo
    {
        public string BoatType { get; set; }
        public int SeatCount { get; set; }

        // default constructor
        public Boat()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Boat(string name, string model, int modelyear, string color, string boattype, int seatcount)
            : base(name, model, modelyear, color)
        {
            BoatType = boattype;
            SeatCount = seatcount;
        }

        // just testing methods 
        public void BoatMethod()
        {
            Console.WriteLine("This method belongs to Boat!");
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " BoatType: " + BoatType + " SeatCount: " + SeatCount;
        }
    }
}