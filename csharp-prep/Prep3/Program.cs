using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Chose a magic number (above 0): ");
        int mn = Int16.Parse(Console.ReadLine());
        int guess = 0;

        do
        {
            Console.WriteLine("What is your guess: ");
            guess = Int16.Parse(Console.ReadLine());

            if (guess < mn)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        } while (guess != mn);

        Console.WriteLine("You win lol");
    }
}