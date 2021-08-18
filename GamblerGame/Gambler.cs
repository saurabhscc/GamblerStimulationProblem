using System;
using System.Collections.Generic;
using System.Text;

namespace GamblerGame
{
    public class Gambler
    {
        public int stake = 100;
        public int bet = 1;
        public void winOrLoss()
        {
            //create a random value
            Random random = new Random();
            int value = random.Next(0, 2);
            if (value == 1)
                Console.WriteLine("Gambler Wins");
            else
                Console.WriteLine("Gambler Lost");
        }
    }
}
