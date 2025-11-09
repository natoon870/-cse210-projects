using System.Diagnostics;
public class Listing: Activity
{
    private static readonly string[] _prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _rand;

    public Listing(string name, string description)
        : base(name, description)
    {
        _rand = new Random();
    }

    public void RunListing()
    {
        StartingMessage();
        PrepareToBegin();

        string prompt = _prompts[_rand.Next(_prompts.Length)];
        Console.WriteLine("\nList as many responses as you can to the following prompt:\n");
        Console.WriteLine("--- " + prompt + " ---\n");
        Console.Write("You may begin in: ");
        Countdown(5);

        List<string> items = new List<string>();
        
        var sw = Stopwatch.StartNew();
        while (sw.Elapsed.TotalSeconds < Duration())
        {
            if (Console.KeyAvailable)
            {
                string entry = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(entry))
                {
                    items.Add(entry.Trim());
                }
            }
            else
            {
                Thread.Sleep(50);
            }
        }

        Console.WriteLine("\nYou listed " + items.Count + " items!\n");
        EndingMessage();
    }
}
