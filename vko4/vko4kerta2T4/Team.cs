using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4kerta2T4
{
    class Team
    {
        public string TeamName { get; set; }
        public string HomeCity { get; set; }
        //    public string Players { get; set; }

        public List<Player> Players { get; }

        public Team()
        {
            Players = new List<Player>();
        }

        //method to add products to fridge
        public void AddPlayer(Player player)
        {
                
                Players.Add(player);
        }

        //method to remove products from fridge
        public void RemovePlayer(Player player)
        {
            Players.Remove(player);
        }

        // override base class ToString()-method
        public override string ToString()
        {
            string s = "Team: " + TeamName + " Homecity: " + HomeCity + "\nPlayers: ";
            foreach (Player p in Players)
            {
                if (s != null) s += "\n-" + p.ToString();
            }
            return s; 
        }
        }
    }
