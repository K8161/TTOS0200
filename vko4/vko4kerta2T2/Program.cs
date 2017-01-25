using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4kerta2T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cdtiedot();
        }
        static void Cdtiedot()
        {
            //Creating cd
            CD cd1  = new CD { Artist = "Nightwish", AlbumName = "Endless Forms Most Beautiful"};

            //Creating songs
            Song song1 = new Song { SongName = "Shudder Before the Beautiful", SongLength = "6:29"};
            Song song2 = new Song { SongName = "Weak Fantasy", SongLength = "5:23" };
            Song song3 = new Song { SongName = "Elan", SongLength = "4:45" };
            Song song4 = new Song { SongName = "Yours Is an Empty Hope", SongLength = "5:34" };
            Song song5 = new Song { SongName = "Our Decades in the Sun", SongLength = "6:37" };
            Song song6 = new Song { SongName = "My Walden", SongLength = "4:38" };
            Song song7 = new Song { SongName = "Endless Forms Most Beautiful", SongLength = "5:07" };
            Song song8 = new Song { SongName = "Edema Ruh", SongLength = "5:15" };
            Song song9 = new Song { SongName = "Alpenglow", SongLength = "4:45" };
            Song song10 = new Song { SongName = "The Eyes of Sharbat Gula", SongLength = "6:03" };
            Song song11 = new Song { SongName = "The Greatest Show on Earth", SongLength = "24:00" };

            //Adding songs to album
            cd1.AddSong(song1);
            cd1.AddSong(song2);
            cd1.AddSong(song3);
            cd1.AddSong(song4);
            cd1.AddSong(song5);
            cd1.AddSong(song6);
            cd1.AddSong(song7);
            cd1.AddSong(song8);
            cd1.AddSong(song9);
            cd1.AddSong(song10);
            cd1.AddSong(song11);

            //Show album data
            Console.WriteLine(cd1);
            //And then songs on album
            foreach (var item in cd1.Songs)
            {
                Console.WriteLine("{0}", item.ToString());
            }
        }
    }
}