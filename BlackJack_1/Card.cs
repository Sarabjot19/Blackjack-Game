using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_1
{
    internal class Card
    {
        string Suit;  // Hearts, Diamonds, Spades, Clubs
        int Rank; // 1 for Ace, 2 for 2,... , 11 for Jack, 12 for Queen, 13 for King
        public Card(string suit, int rank)
        {
            Suit = suit;
            Rank = rank;

        }


        public String GetImageFileName()
        {
            if (Rank == 1)
            {
                return "Ace_of_" + Suit + ".png";
            }
            if (Rank == 10)
            {
                return "10_of_" + Suit + ".png";
            }
            if (Rank == 11)
            {
                return "Jack_of_" + Suit + ".png";
            }
            if (Rank == 12)
            {
                return "Queen_of_" + Suit + ".png";
            }
            if (Rank == 13)
            {
                return "King_of_" + Suit + ".png";
            }
            return Rank + "_of_" + Suit + ".png";
        }

        public int GetBlackjackValue()
        {
            if (Rank > 10)
            {
                return 10;
            }

            return Rank;
        }

    }
}
