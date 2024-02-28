using System;

namespace cardgame_zudy
{
    public enum types
    {
        hart, schoppen, klaveren, ruiten
    }
    public class Card
    {
        public int amount;
        public types type;
        public void Show() => Console.WriteLine($"{type}-{amount}");
        public Card(int code)
        {
            if (code <= 13)
            {
                amount = code;
                type = types.hart;
            }
            else if (code <= 26)
            {
                amount = code - 13;
                type = types.schoppen;
            }
            else if (code <= 39)
            {
                amount = code - 26;
                type = types.klaveren;
            }
            else if (code <= 52)
            {
                amount = code - 39;
                type = types.ruiten;
            }
            else
            {
                Console.WriteLine("Dit is geen kaart :(");
            }
        }
    }
}
