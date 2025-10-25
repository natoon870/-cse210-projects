using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Isaiah", 53, 4, 5);
        Scripture scripture = new Scripture(reference, "Surely he hath borne our griefs and carried our sorrows; yet we did esteem him stricken, "
        +  "smitten of God, and afflicted. But he was wounded for our transgressions, he was bruised for our iniquities: the chastisement of our "
        +  "peace was upon him; and with his stripes we are healed.");
        Console.WriteLine();

        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            scripture.ScriptureDisplay();

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Christ is King!");
                keepRunning = false;
            }
            else
            {
                scripture.HideRandomWords(3);

                if (scripture.AllWordsHidden())
                {
                    Console.Clear();
                    scripture.ScriptureDisplay();
                    keepRunning = false;
                }
            }
        }
    }
}