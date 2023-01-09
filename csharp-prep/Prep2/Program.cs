using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        float grade = float.Parse(Console.ReadLine());
        string letter =  "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else
        {
            letter = "F";
        }

        if (grade > 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("You Failed :(");
        }

        Console.WriteLine($"You got a {letter}");
    }
}