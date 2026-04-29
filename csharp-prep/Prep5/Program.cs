using System;


// static void Main()
//             try
//         {
//             {
//                 // Attempt to divide by zero
//                 int numerator = 10;
//                 int denominator = 0;
//                 int result = numerator / denominator;
//                 Console.WriteLine("Result: " + result);
//             }
//             catch (DivideByZeroException ex)  //Handle only divide by 0 exception
//             {
//                 Console.WriteLine("Error: Cannot divide by zero.");
//                 Console.WriteLine("Exception message: " + ex.Message);
//             }
//             catch (Exception ex)  // Catches all other exceptions
//             {
//                 Console.WriteLine("Error: Exception Occurred");
//                 Console.WriteLine("Exception message: " + ex.Message);
//             }
//             finally
//             {
//                 Console.WriteLine("This block always executes, regardless of exceptions.");
//             }
//         }
class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        int birthYear;
        PromptUserBirthYear(out birthYear);


        DisplayResult(userName, squaredNumber, birthYear);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write($"Enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());

    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} years old this year.");
    }
}