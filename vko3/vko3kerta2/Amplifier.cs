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
        private bool isVolumeValid;
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
                    isVolumeValid = false;
                    volume = 0;
                }

                else if (volume > maxVol)
                {
                    isVolumeValid = false;
                    volume = 100;
                }

                else
                {
                    isVolumeValid = true;
                    volume = value;
                }
            }
        }

       
        public bool IsVolumeValid
        {
            get { return isVolumeValid; }
        }
        public string VolumeMessage()
        {
            if (isVolumeValid)
                return "Current volume " + Volume;
            else
                return "Volume only available from range 0-100";
        }

        public override string ToString()
        {
            if (IsVolumeValid)
            {
                return VolumeMessage();
            }
            else
            {
                return VolumeMessage();
            }
        }
    }
}
