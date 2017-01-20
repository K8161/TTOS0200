using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stuff();
        }
        static void Stuff()
        {
            // create Game object
            Game game1 = new Game();
            game1.ProductName = "Medieval II: Total War";
            game1.ReleaseYear = 2006;
            game1.Genre = "Real-time tactics, Turn-based strategy";
            game1.Developer = "Creative Assembly";
            game1.Platform = "Windows, OS X, Linux";
            Console.WriteLine("Game info: \n{0}\n", game1.ToString());

            // create Book object
            Book book1 = new Book();
            book1.ProductName = "The Complete Fiction of H.P. Lovecraft";
            book1.ReleaseYear = 2014;
            book1.Genre = "Horror";
            book1.Author = "H. P. Lovecraft";
            Console.WriteLine("Book info: \n{0}\n", book1.ToString());

            // create Magazine object
            Magazine magazine1 = new Magazine();
            magazine1.ProductName = "Aku Ankka";
            magazine1.ReleaseYear = 2001;
            magazine1.Genre = "Comic";
            magazine1.Issue = 36;
            Console.WriteLine("Magazine info: \n{0}\n ", magazine1.ToString());


        }
    }
}
