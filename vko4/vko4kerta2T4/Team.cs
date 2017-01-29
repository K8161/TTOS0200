using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace vko4kerta2T4
{
    class Team
    {
       // List<Player> players;

        public string TeamName { get; set; }
        public string HomeCity { get; set; }

        public List<Player> Players { get; set; }


        public Team()
        {
            Players = new List<Player>();
            GetPlayers();
        }

        private void GetPlayers()
        {
            string line;
            string[] words;

            Player player;


            using (StreamReader fr = new StreamReader("Players.txt"))
            {

                while ((line = fr.ReadLine()) != null)
                {
                    player = new Player();
                    words = line.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

                    player.PlayerNumber = int.Parse(words[0]);
                    player.LastName = words[1];
                    player.FirstName = words[2];
                    player.TimeOfBirth = words[3];

                    Players.Add(player);

                }


            }
        }

        public override string ToString()
        {
            string s = "Team: " + TeamName + " Origin: " + HomeCity + "\nPlayers: ";
            Console.WriteLine(s);
            foreach (Player player in Players)
            {
                s = "PlayerNumber: " + player.PlayerNumber.ToString() + " Last Name: " + player.LastName + " First Name: " + player.FirstName + " Time of Birth " + player.TimeOfBirth;
                Console.WriteLine(s);
            }
            return s;
        }

        public void SaveTeam()
        {
            string s = "Team: " + TeamName + " Origin: " + HomeCity + "\nPlayers: ";
            using (StreamWriter fs = new StreamWriter("joukkue.txt"))
            {
                foreach (Player player in Players)
                {
                    s = player.PlayerNumber.ToString() + " " + player.LastName + " " + player.FirstName + " " + player.TimeOfBirth;
                    fs.WriteLine(s);

                }
            }
        }
}
}
