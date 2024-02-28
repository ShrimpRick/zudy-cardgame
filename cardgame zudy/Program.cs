using System;

namespace cardgame_zudy
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();


            //for (int i = 0; i < game.Playeres.Count; i++)
            //{
            //    Console.WriteLine(i+ " " + game.Playeres[i].name);
            //}



            Console.ReadLine();





            Deck deck = new Deck();


            deck.Show();


            //for (int i = 0; i < deck.deckOfCards.Count; i++)
            //{
            //    Console.WriteLine(deck.deckOfCards[i].type + " "+ deck.deckOfCards[i].amount);
            //}


            //Console.WriteLine(text.deckOfCards[0].type);

            Console.WriteLine("\n\n" + "suffle---------------------------------------" + "\n\n");


            deck.Shuffle(deck.deckOfCards);

            deck.Show();
            //for (int i = 0; i < deck.deckOfCards.Count; i++)
            //{
            //    Console.WriteLine(deck.deckOfCards[i].type + " " + deck.deckOfCards[i].amount);
            //}
        }
    }
}
