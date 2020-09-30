using System;

namespace SnakesLadders
{
    class Program
    {
        //constants
        public const int NO_OF_PLAYERS = 1;
        public const int LADDER = 1;
        public const int SNAKE = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snakes and Ladders!");

            //variables
            int START_POSITION = 0;
            int CURRENT_POSITION = 0;

            Random random = new Random();

            int die = random.Next(1, 7);
            Console.WriteLine("Rolling Die: " + die);

            int option = random.Next(0, 3);

            switch (option)
            {
                case LADDER:
                    CURRENT_POSITION += die;
                    Console.WriteLine("Ladder");
                    break;

                case SNAKE:
                    CURRENT_POSITION -= die;
                    Console.WriteLine("Snake");
                    break;

                default:
                    Console.WriteLine("No Play");
                    break;
            }
            Console.WriteLine("Your new position is: " + CURRENT_POSITION);
        }
    }
}
