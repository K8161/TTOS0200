using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4kerta2T3
{
    abstract class Card
    {
        public int Number { get; set; }
        public virtual string Suit { get; set; }

        public Card()
        { }

        public Card(int number)
        {
            Number = number;
        }

        public abstract void ShowCard();
    }
    //Hearts class
    class Hearts : Card
    {
        public override string Suit
        {
            get
            {
                return "Hearts";
            }

            set
            {
                Suit = value;
            }
        }


        public override void ShowCard()
        {
            Console.WriteLine(Number + " of " + Suit);
        }
    }

    //Diamonds class
    class Diamonds : Card
    {
        public override string Suit
        {
            get
            {
                return "Hearts";
            }

            set
            {
                Suit = value;
            }
        }

        public override void ShowCard()
        {
            Console.WriteLine(Number + " of " + Suit);
        }
    }
    //Clubs class
    class Clubs : Card
    {
        public override string Suit
        {
            get
            {
                return "Hearts";
            }

            set
            {
                Suit = value;
            }
        }

        public override void ShowCard()
        {
            Console.WriteLine(Number + " of " + Suit);
        }
    }

                //Spades class
                class Spades : Card
                {
                    public override string Suit
                    {
                        get
                        {
                            return "Hearts";
                        }

                        set
                        {
                            Suit = value;
                        }
                    }

                    public override void ShowCard()
                    {
                        Console.WriteLine(Number + " of " + Suit);
                    }
                }
            }   
