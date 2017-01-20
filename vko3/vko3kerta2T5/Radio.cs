using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T5
{
    class Radio
    {
        private int volume;
        private float frequency;
        private int isVolumeValid;
        private int isFrequencyValid;
        private const int maxVol = 9;
        private const int minVol = 0;
        private const float maxFreq = 26000f;
        private const float minFreq = 2000f;
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
                    isVolumeValid = 0;
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
                return "Minimum Volume is 0. Volume set to " + volume;
            else if (isVolumeValid == 2)
                return "Maximum Volume is 9. Volume set to " + volume;
            else
                return "Volume set to " + Volume;
        }

        public float Frequency
        {
            get { return frequency; }
            set
            {
                frequency = value;

                if (frequency < minFreq)
                {
                    isFrequencyValid = 1;
                    frequency = 2000;
                }

                else if (frequency > maxFreq)
                {
                    isFrequencyValid = 2;
                    frequency = 26000;
                }

                else
                {
                    isFrequencyValid = 0;
                    frequency = value;
                }
            }
        }

        public int IsFrequencyValid
        {
            get { return isFrequencyValid; }
        }
        public string FrequencyMessage()
        {
            if (isFrequencyValid == 1)
                return "Minimum Frequency is 2000. Frequency set to " + frequency;
            else if (isFrequencyValid == 2)
                return "Maximum Frequency is 26000. Frequency set to " + frequency;
            else
                return "Frequency set to " + Frequency;
        }


        public override string ToString()
        {
            return VolumeMessage() + "\n" + FrequencyMessage();
        }
    }
}