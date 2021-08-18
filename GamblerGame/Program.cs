using System;

namespace GamblerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Gambler Stimulation Problem");
            Gambler gambler = new Gambler();
            gambler.winOrLoss();
            Console.ReadLine();
        }
    }
}
