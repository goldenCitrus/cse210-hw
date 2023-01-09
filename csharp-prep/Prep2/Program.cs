using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        float grade = float.Parse(Console.ReadLine());
        Console.WriteLine(grade);

        if (grade >= 90)
        {
            Console.WriteLine("You have an A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You have a B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You have a C");
        }
        else
        {
            Console.WriteLine("You are failing");
        }
    }
}