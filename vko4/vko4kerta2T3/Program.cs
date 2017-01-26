using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace vko4kerta2T3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0; //int used for list index

            //creating list for cards to simulate deck
            List<Card> deck = new List<Card>();

            //first for loop for four different suites
            for (int i = 1; i < 5; i++)
            {
                //second loop for 13 different cards per suite
                for (int j = 1; j < 14; j++)
                {
                    
                if (i == 1)
                    { deck.Add(new Hearts());
                        deck[k].Number = j;
                    }

                else if (i == 2)
                    { deck.Add(new Diamonds());
                        deck[k].Number = j;
                    }

                else if (i == 3)
                    { deck.Add(new Clubs());
                        deck[k].Number = j;
                    }

                else if (i == 4)
                    { deck.Add(new Spades());
                        deck[k].Number = j;
                    }
                    k++;
                } }

            Console.WriteLine("Show contents of deck");
            foreach (Card card in deck)
            {
                card.ShowCard(); // Shows every card in deck
            }
        }
    }
}
