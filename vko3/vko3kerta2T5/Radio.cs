using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T5
{
    class Radio
    {
        private int volume, frequency;
        private int isVolumeValid;
        private int isFrequencyValid;
        private const int maxVol = 100;
        private const int minVol = 0;
        private const float maxFreq = 26000;
        private const float minFreq = 2000;
        public int Volume
        {
            get { return volume; }
            set
            {
                volume = value;

                if (volume < minVol)
                {
                    isVolumeValid = 1;
                    volume = 0;
                }

                else if (volume > maxVol)
                {
                    isVolumeValid = 2;
                    volume = 100;
                }

                else
                {
                    isVolumeValid = 3;
                    volume = value;
                }
            }
        }


        public int IsVolumeValid
        {
            get { return isVolumeValid; }
        }
        public string VolumeMessage()
        {
            if (isVolumeValid == 1)
                return "Current volume " + Volume;
            else
                return "Volume only available from range 0-100";
        }

        public int Frequency
        {
            get { return frequency; }
            set
            {
                frequency = value;

                if (frequency < minFreq)
                {
                    isFrequencyValid = false;
                    volume = 0;
                }

                else if (frequency > maxFreq)
                {
                    isFrequencyValid = false;
                    volume = 100;
                }

                else
                {
                    isFrequencyValid = true;
                    volume = value;
                }
            }
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