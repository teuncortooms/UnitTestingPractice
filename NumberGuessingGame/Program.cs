using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Let's start a guessing game.");
            while (true)
            {
                try
                {
                    Console.WriteLine("Set lower boundary: ");
                    int lower = int.Parse(Console.ReadLine());
                    Console.WriteLine("Set upper boundary: ");
                    int upper = int.Parse(Console.ReadLine());
                    Game g = new Game();
                    g.Start(lower, upper);
                    Console.WriteLine("Now guess!");
                    while (!g.HasWon)
                    {
                        int number = int.Parse(Console.ReadLine());
                        int feedback = g.Guess(number);
                        if (feedback == 1) Console.WriteLine("Wrong. Guess lower!");
                        if (feedback == -1) Console.WriteLine("Wrong. Guess higher!");
                    }
                    Console.WriteLine("You have won in " + g.GuessCount + " tries!");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    Console.WriteLine("Press enter to restart.");
                }
                Console.ReadKey();
                Console.WriteLine("Let's try again!");
                Console.ReadKey();
            }
        }
    }
}
