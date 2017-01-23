using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4T3
{
    abstract class Nisakas
    {
        public int Ika { get; set; }

        public Nisakas()
        {
        }

        public DrawingObject(string name)
        {
            Name = name;
        }


        public abstract void Liiku();
    }
}

