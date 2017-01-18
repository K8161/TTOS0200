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
        private bool isFloorValid;
        public int Floor
        {
            get { return floor; }
            set
            {
                floor = value;

                if (floor < 1)
                {
                    isFloorValid = false;
                    floor = 1;
                }

                else if (floor > 5)
                {
                    isFloorValid = false;
                    floor = 5;
                }

                else
                {
                    isFloorValid = true;
                    floor = value;
                }
            }
        }
        public bool IsFloorValid
        {
            get { return isFloorValid; }
        }
        public string FloorMessage()
        {
            if (isFloorValid)
                return "Current floor " + floor;
            else
            return "Selected floor not available";
        }

                public override string ToString()
        {
            if (IsFloorValid)
            {
                return FloorMessage();
            }
            else
            {
                return FloorMessage();
            }
        }
    }
        }

 