using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T6
{
    class Book : BasicInfo
    {
        public string Author { get; set; }

        // default constructor
        public Book()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Book(string productName, int releaseYear, string genre, string author)
            : base(productName, releaseYear, genre)
        {
            Author = author;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " Author: " + Author;
        }
    }
}
