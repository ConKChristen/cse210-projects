using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade Percentage: ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";

        if (grade > 95)
        {
            Console.WriteLine("You have an A in the class");
        }
        else if (grade > 90 && grade < 95)
        {
            letter = "A-";
        }
        else if (grade > 85 && grade < 90)
        {
            letter = "B+";
        }
        else if (grade > 80 && grade < 85)
        {
            letter = "B-";
        }
        else if (grade > 75 && grade < 80)
        {
            letter = "C+";
        }
        else if (grade > 70 && grade < 75)
        {
            letter = "C-";
        }
        else if (grade > 65 && grade < 70)
        {
            letter = "D+";
        }
        else if (grade > 60 && grade < 65)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

        Console.WriteLine($"Your grade is: {letter}");

    }
}