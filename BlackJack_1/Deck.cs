using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_1
{
    internal class Deck
    {
        string[] suits = new string[] { "Hearts", "Diamonds", "Spades", "Clubs" };

        List<Card> cards = new List<Card>();
        Random rand = new Random();

        public void Init()
        {
            foreach (string suit in suits)
            {
                for (int i = 1; i < 14; i++)
                {
                    Card c = new Card(suit, i);
                    cards.Add(c);
                }
            }
            // Shuffle the deck after it's initialized
            Shuffle();
        }


        // Shuffle the deck using Fisher-Yates algorithm
        private void Shuffle()
        {
            cards = cards.OrderBy(x => rand.Next()).ToList();
        }

        public Card RequestCard()
        {
            Card c = cards[0];
            cards.Remove(c);
            return c;
        }


    }
}