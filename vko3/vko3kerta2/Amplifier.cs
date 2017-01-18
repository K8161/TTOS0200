using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2
{
    class Amplifier
    {
        private int volume;
        private const int maxVol = 100;
        private const int minVol = 0;
        public int Volume
        {
            get { return volume; }
            set
            {
                volume = value;

                if (volume < minVol)
                {
                    volume = 0;
                }

                else if (volume > maxVol)
                {
                    volume = 100;
                }

                else
                {
                    volume = value;
                }
            }
        }

        public override string ToString()
        {
            if (Volume < minVol)
            {
                return "Too low volume -Amplifier volume is set to minimum: " + Volume;
            }

            else if (Volume > maxVol)
            {
                return "Too much volume -Amplifier volume is set to maximum: " + Volume;
            }

            else
            return "Amplifier volume is set to " + Volume;
        }
    }
}
