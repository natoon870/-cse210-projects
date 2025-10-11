using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string option = "";
        while (option != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? ");
            option = Console.ReadLine();
            Console.WriteLine();

            if (option == "1")
            {
                Entry newEntry = new Entry();
                newEntry._Date = DateTime.Now.ToShortDateString();
                newEntry._Prompt = newEntry.RandomPrompt();

                Console.WriteLine(newEntry._Prompt);
                Console.Write("Your response: ");
                newEntry._Response = Console.ReadLine();

                myJournal.AddEntry(newEntry);
            }
            else if (option == "2")
            {
                myJournal.DisplayJournal();
            }
            else if (option == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.Load(filename);
            }
            else if (option == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.Save(filename);
            }
            else if (option == "5")
            {
                myJournal.Quit();
            }
        }

    }
}