using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T6
{
    class Game : BasicInfo
    {
        public string Developer { get; set; }
        public string Platform { get; set; }

        // default constructor
        public Game()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Game(string productName, int releaseYear, string genre, string developer, string platform)
            : base(productName, releaseYear, genre)
        {
            Developer = developer;
            Platform = platform;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " Developer: " + Developer + " Platform: " + Platform;
        }
    }
}