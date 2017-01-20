using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T7
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInstruments();
        }
        static void ShowInstruments()
        {
            // create Guitar object
            Guitar guitar1 = new Guitar();
            guitar1.Manufacturer = "ESP-LTD";
            guitar1.Model = "EC-1000";
            guitar1.ModelYear = 2016;
            guitar1.Pickups = "EMG 81/60";
            guitar1.Frets = "24 XJ";
            Console.WriteLine("Guitar info: \n{0}\n", guitar1.ToString());

            // create Guitar object
            Guitar guitar2 = new Guitar();
            guitar2.Manufacturer = "Jackson";
            guitar2.Model = "JS-32";
            guitar2.ModelYear = 2006;
            guitar2.Pickups = "Jackson humbuckers";
            guitar2.Frets = "22";
            Console.WriteLine("Guitar info: \n{0}\n", guitar2.ToString());

            // create Synthetisator object
            Synthetisator synth1 = new Synthetisator();
            synth1.Manufacturer = "Roland";
            synth1.Model = "Juno-Di";
            synth1.ModelYear = 2008;
            synth1.Keys = 61;
            Console.WriteLine("Synthetisator info: \n{0}\n", synth1.ToString());

        }
    }
}

