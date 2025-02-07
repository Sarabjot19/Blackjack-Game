using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace BlackJack_1
{
    internal class BJEngine
    {
        Deck deck = new Deck();

        public List<Card> playerCards = new List<Card>();
        public List<Card> dealerCards = new List<Card>();

        //Assginment 1
        //Starting chips
        public int playerChips = 100; //AS1
        public int currentBet = 10; //AS1

        public void Start()
        {

            deck.Init();
            playerCards.Clear();
            dealerCards.Clear();
            DealToDealer();
            DealToPlayer();
            DealToDealer();
            DealToPlayer();
        }


        public void DealToDealer()
        {
            Card c = deck.RequestCard();
            dealerCards.Add(c);
        }
        public void DealToPlayer()
        {
            Card c = deck.RequestCard();
            playerCards.Add(c);
        }



        //By professor



        private int GetPlayerSum()
        {
            //complete this method:

            int total = 0;
            foreach (Card card in playerCards)
            {
                total += card.GetBlackjackValue();
            }
            return total;

        }

        private int GetDealerSum()
        {
            int total = 0;
            foreach (Card card in dealerCards)
            {
                total += card.GetBlackjackValue();
            }
            return total;
        }

        internal bool Hit()
        {
            DealToPlayer();
            if (GetPlayerSum() > 21)
            {
                AdjustChips(false); // Player loses chips if they bust
                return false;
            }
            return true;
        }

        internal string Stand()
        { //TODO Assignment 1

            // Dealer draws until their total score is less than the player’s total or until they bust
            while (GetDealerSum() <= GetPlayerSum() && GetDealerSum() <= 21)
            {
                DealToDealer();
            }

            int playerSum = GetPlayerSum();
            int dealerSum = GetDealerSum();
            // Determine the result and adjust the player's chips accordingly
            if (playerSum > 21)
            {
                AdjustChips(false); // Player loses
                return "Player Busted! You Lose!";
            }
            if (dealerSum > 21)
            {
                AdjustChips(true); // Player wins
                return "Dealer Busted! You Win!";
            }
            if (playerSum > dealerSum)
            {
                AdjustChips(true); // Player wins
                return "You Win!";
            }
            if (playerSum < dealerSum)
            {
                AdjustChips(false); // Player loses
                return "Dealer Wins!";
            }

            return "It's a Tie!";
        }

        public void AdjustChips(bool playerWon)
        {
            if (playerWon)
            {
                playerChips += currentBet;
            }
            else
            {
                playerChips -= currentBet;
            }
        }

        public void ResetGame()
        {
            playerChips = 100;
            currentBet = 0;
            playerCards.Clear();
            dealerCards.Clear();
        }




    }

}