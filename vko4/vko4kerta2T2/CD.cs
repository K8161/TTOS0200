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

        public override string ToString()
        {
            return Artist + ": " + AlbumName;
        }

        public CD()
        {
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
                Songs.Add(song);
            
        }
    }
}
