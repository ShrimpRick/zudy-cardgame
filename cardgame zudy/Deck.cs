using System;
using System.Collections.Generic;

namespace cardgame_zudy
{
    public class Deck
    {
        public List<Card> deckOfCards = new List<Card>();
        private static Random rand = new Random();
        
        public Deck()
        {
            for (int i = 1; i <= 52; i++)
            {
                Card name = new Card(i);
                deckOfCards.Add(name);
                //Console.WriteLine(name.type + " "+ name.amount);
            }
        }
        public void Show()
        {
            foreach (var card in deckOfCards)
                card.Show();
        }

        public List<Card> Shuffle(List<Card> _deck)
        {
            for (int i = _deck.Count - 1; i > 0; i--)
            {
                int k = rand.Next(i + 1);
                Card card = _deck[k];
                _deck[k] = _deck[i];
                _deck[i] = card;
            }
            return _deck;
        }
    }
}
