using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.\n ");
        int entry = -1;

        while (entry != 0)
        {
            Console.Write("Enter number:  ");
            entry = int.Parse(Console.ReadLine());

            if (entry != 0)
            {
                numbers.Add(entry);
            }
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum is: {total}");

        float length = numbers.Count;
        float average = (float)total / length;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}