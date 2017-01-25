using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4kerta2T2
{
    class CD
    {
        public string Artist { get; set; }
        public string AlbumName { get; set; }
        public List<Song> Songs { get; }

        public CD()
        {
            Songs = new List<Song>();
        }
    }
}
