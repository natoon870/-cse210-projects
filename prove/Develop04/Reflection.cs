public class Reflection: Activity
{
    private static readonly string[] _prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] _questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _rand;

    public Reflection(string name, string description)
        : base(name, description)
    {
        _rand = new Random();
    }

    public void RunReflection()
    {
        StartingMessage();
        PrepareToBegin();

        string prompt = _prompts[_rand.Next(_prompts.Length)];
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine("--- " + prompt + " ---\n");
        Console.WriteLine("When you have something in mind, press ENTER to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);

        int remaining = Duration();
        int thinkPerQuestion = 8;

        while (remaining > 0)
        {
            string q = _questions[_rand.Next(_questions.Length)];
            Console.WriteLine("\n> " + q);
            int slice = Math.Min(thinkPerQuestion, remaining);
            DisplaySpinner(slice);
            remaining -= slice;
        }

        EndingMessage();
    }
}
