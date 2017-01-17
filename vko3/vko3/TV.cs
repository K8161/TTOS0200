using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class TV
    {
        //properties
        public bool OnkoPaalla { get; set; }
        int kanava;
        public int Kanava {
            get { return kanava; }
            set
            {
                kanava = value;
                if (kanava < 1 || kanava > 30)
                {
                    äänenvoimakkuus = 3;
                }
            }
        }
        int äänenvoimakkuus;
        public int Äänenvoimakkuus
        {
            get { return äänenvoimakkuus; }
            set
            {
                äänenvoimakkuus = value;
                if (äänenvoimakkuus < 0 || äänenvoimakkuus > 100)
                {
                    äänenvoimakkuus = 50;
                }
            }
        }
        //methods
        public void LisääÄäntä()
        {
            äänenvoimakkuus += 10;
        }
        public void LaskeÄäntä()
        {
            äänenvoimakkuus -= 10;
        }

        public void VaihdaKanavaYlös()
        {
            kanava += 1;
        }
        public void VaihdaKanavaAlas()
        {
            äänenvoimakkuus -= 1;
        }
    }
}