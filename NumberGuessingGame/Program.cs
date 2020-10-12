using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Let's start a guessing game.");
            while (true)
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
                    if (g.GuessCount > 0) Console.WriteLine("Wrong. Guess again!");    
                    int number = int.Parse(Console.ReadLine());
                    g.Guess(number);
                }
                Console.WriteLine("You have won in " + g.GuessCount + " tries!");
                Console.ReadKey();
                Console.WriteLine("Let's try again!");
                Console.ReadKey();
            }
        }
    }
}
