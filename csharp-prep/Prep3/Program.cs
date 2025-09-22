using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        Console.WriteLine("Welcome to the magic number guessing game where you will be guessing a number from 0-100! \n");
        int guess = -1;

        while (guess != number)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess < number)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}