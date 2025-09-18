using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int gradePercentage = int.Parse(grade);
        string letter = "";


        if (gradePercentage >= 90)
        {
            letter = "A";
        }

        else if (gradePercentage >= 80)
        {
            letter = "B";
        }

        else if (gradePercentage >= 70)
        {
            letter = "C";
        }

        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is a/an {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Since your grade was a/an {letter}, you have passed the course!");

        }
        else
        {
            Console.WriteLine($"Sorry!! Since your grade was a/an {letter}, you have not passed the course. Better luck next time!");
        }
    }
}