using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int entry = -1;
        while (entry != 0)
        {
            Console.WriteLine("Enter number: ");
            entry = int.Parse(Console.ReadLine());

            if (entry != 1)
            {
                numbers.Add(entry);
            }
        }

        
        Console.WriteLine(numbers.Count);

        
    }
}