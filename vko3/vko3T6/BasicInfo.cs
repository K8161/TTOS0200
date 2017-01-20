using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T6
{
        class BasicInfo
        {

            public string ProductName { get; set; }
            public int ReleaseYear { get; set; }
            public string Genre { get; set; }

            // default constructor
            public BasicInfo()
            {
            }

            // constructor takes person firstname and lastname as a parameter
            public BasicInfo(string productName, int releaseYear, string genre)
            {
                ProductName = productName;
                ReleaseYear = releaseYear;
                Genre = genre;
            }

            // return BasicInfo as a one string, override Object class ToString()-method
            public override string ToString()
            {
                return "Name: " + ProductName + " Year of release: " + ReleaseYear + " Genre: " + Genre;
            }
        }
    }