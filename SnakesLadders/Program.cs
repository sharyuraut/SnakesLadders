using System;

namespace SnakesLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snakes and Ladders!");

            //constants
            int NO_OF_PLAYERS = 1;

            //variables
            int START_POSITION = 0;

            Random random = new Random();

            int die = random.Next(1, 7);
            Console.WriteLine("Rolling Die: " + die);
        }
    }
}
