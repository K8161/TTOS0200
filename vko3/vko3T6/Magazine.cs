using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T6
{
    class Magazine : BasicInfo
    {
        public int Issue { get; set; }

        // default constructor
        public Magazine()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Magazine(string productName, int releaseYear, string genre, int issue)
            : base(productName, releaseYear, genre)
        {
            Issue = issue;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " Issue: " + Issue;
        }
    }
}
