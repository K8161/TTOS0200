using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Pesukone
    {
        //properties
        public bool OnkoPaalla { get; set; }
        public string Pesuohjelma { get; set; }
        float pesulampotila;
        public float Pesulampotila
        {
            get { return pesulampotila; }
            set
            {
                pesulampotila = value;
                if (pesulampotila < 0 || pesulampotila >= 90)
                {
                    pesulampotila = 50;
                }
            }
        }
        //methods
        public void NostaLampotila()
        {
            pesulampotila += 10;
        }
        public void LaskeLampotila()
        {
            pesulampotila -= 10;
        }
    }
}
