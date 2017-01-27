using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4kerta2T4
{
    class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TimeOfBirth { get; set; }
        public int PlayerNumber { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + TimeOfBirth + " " + PlayerNumber;
        }

        Player player1 = new Player { FirstName = "testi", LastName = "joku", TimeOfBirth = "6.6.1966", PlayerNumber = 14};
    }
}
