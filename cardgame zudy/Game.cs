using System;
using System.Collections.Generic;
using System.Text;

namespace cardgame_zudy
{
    class Game
    {

        public List<Player> players = new List<Player>();
        public Deck deck = new Deck();

        public Game()
        {
            Console.WriteLine("amount of players");
            int nummber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nummber; i++)
            {
                Console.WriteLine("players "+i+ " name");
                string name = Console.ReadLine();
                Player player = new Player(name);
                players.Add(player);
            }

        }

    }
}
