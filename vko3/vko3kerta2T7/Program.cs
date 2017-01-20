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
            guitar1.ProductName = "Medieval II: Total War";
            guitar1.ReleaseYear = 2006;
            guitar1.Genre = "Real-time tactics, Turn-based strategy";
            guitar1.Developer = "Creative Assembly";
            guitar1.Platform = "Windows, OS X, Linux";
            Console.WriteLine("Game info: \n{0}\n", guitar1.ToString());

            // create Guitar object
            Guitar guitar2 = new Guitar();
            guitar2.ProductName = "Medieval II: Total War";
            guitar2.ReleaseYear = 2006;
            guitar2.Genre = "Real-time tactics, Turn-based strategy";
            guitar2.Developer = "Creative Assembly";
            guitar2.Platform = "Windows, OS X, Linux";
            Console.WriteLine("Game info: \n{0}\n", guitar1.ToString());

            // create Synthetisator object
            Synthetisator synth1 = new Synthetisator();
            synth1.ProductName = "The Complete Fiction of H.P. Lovecraft";
            synth1.ReleaseYear = 2014;
            synth1.Genre = "Horror";
            synth1.Author = "H. P. Lovecraft";
            Console.WriteLine("Book info: \n{0}\n", book1.ToString());

        }
    }
}

