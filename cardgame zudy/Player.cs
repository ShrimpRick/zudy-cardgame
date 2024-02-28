using System;
using System.Collections.Generic;
using System.Text;

namespace cardgame_zudy
{
    class Player
    {
        public string name;
        public List<Card> hand = new List<Card>();
        public int monny;

        public Player(string _name)
        {
            name = _name;
            monny = 1000;
        }

         
    }
}
