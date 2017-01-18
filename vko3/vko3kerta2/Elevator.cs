using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2
{
    class Elevator
    {
        private int floor;
        public int Floor
        {
            get { return floor; }
            set
            {
                floor = value;

                if (floor < 1)
                {
                    floor = 1;
                }

                else if (floor > 5)
                {
                    floor = 5;
                }

                else
                {
                    floor = value;
                }
            }
        }

                public override string ToString()
        {
            return "Now on floor: " + Floor;
        }
    }
        }

 