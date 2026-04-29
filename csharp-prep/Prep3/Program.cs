using System;

class Program
{
    static void Main(string[] args)
    {
        bool correct = false;
        Console.WriteLine("Guess the random number between 1 and 100");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        while (correct == false)
        {
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            if (guess > number)
            {
                Console.Write("Your guess is too high. Try again");
            }
            if (guess < number)
            {
                Console.Write("Your guess is too low. Try again");
            }
            if (guess == number)
            {
                Console.Write("You guessed correctly!");
                correct = true;
            }
        }
    }
}