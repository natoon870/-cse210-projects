using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int userNumber = PromptUserNumber();
        int birthYear = PromtUserBirthYear();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(username, squareNumber, birthYear);



        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int PromtUserBirthYear()
        {
            Console.Write("Please enter the year you were born: ");
            int year = int.Parse(Console.ReadLine());
            return year;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResult(string name, int square, int year)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
            Console.WriteLine($"{name}, you will turn {2025 - year} this year.");
        }

    } 
        
}