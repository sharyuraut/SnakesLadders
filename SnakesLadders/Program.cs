using System;

namespace SnakesLadders
{
    class Program
    {
        //constants
        public const int NO_OF_PLAYERS = 1;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int WINNING_POSITION = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snakes and Ladders!");

            //variables
            int START_POSITION = 0;
            int CURRENT_POSITION = 0, NEW_POSITION;
            int NO_OF_TIMES_DICE_ROLLED = 0 ;

            while (CURRENT_POSITION < WINNING_POSITION)
            {
                Random random = new Random();

                int die = random.Next(1, 7);
                Console.WriteLine("Rolling Die: " + die);

                //generating check option
                int option = random.Next(0, 3);

                switch (option)
                {
                    case LADDER:
                        CURRENT_POSITION += die;
                        Console.WriteLine("Ladder");
                        NEW_POSITION = CURRENT_POSITION;
                        if (CURRENT_POSITION > WINNING_POSITION)
                        {
                            CURRENT_POSITION -= die;
                        }
                        break;

                    case SNAKE:
                        CURRENT_POSITION -= die;
                        Console.WriteLine("Snake");
                        if (CURRENT_POSITION < START_POSITION)
                        {
                            CURRENT_POSITION = 0;
                        }
                        NEW_POSITION = CURRENT_POSITION;
                        break;

                    default:
                        Console.WriteLine("No Play");
                        break;
                }
                NO_OF_TIMES_DICE_ROLLED++;
                NEW_POSITION = CURRENT_POSITION;
                Console.WriteLine("Your new position is: " + NEW_POSITION);
            }
            Console.WriteLine("Number of times dice rolled to win: " + NO_OF_TIMES_DICE_ROLLED);
        }
    }
}
