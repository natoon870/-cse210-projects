using System.ComponentModel;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }
    public string Name()
    {
        return _name;
    }
    public string Description()
    {
        return _description;
    }
      public int Duration()
    {
        return _duration;
    }
    public void StartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the " + _name + " Activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        int seconds = int.Parse(input); 
        _duration = seconds;
        Console.WriteLine($"\nGreat! Your {_name} Activity will last {_duration} seconds.");
        Thread.Sleep(1500);
    }   
    public void PrepareToBegin()
    {
        Console.WriteLine("\nGet ready...");
        DisplaySpinner(3);
    }
    public void EndingMessage()
    {
        Console.WriteLine("\nWell done!");
        DisplaySpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the { _name} Activity.");
        DisplaySpinner(3);
    }
    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string s = i.ToString();
            Console.Write(s + " ");
            Thread.Sleep(1000);

            Console.Write(new string('\b', s.Length + 1));
            Console.Write(new string(' ', s.Length + 1));
            Console.Write(new string('\b', s.Length + 1));
        }
    }
    public void DisplaySpinner(int seconds)
    {
        char[] frames = new char[] { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(120);
            Console.Write('\b');
            i++;
        }

        Console.Write(' ');
        Console.Write('\b');
    }
}

 