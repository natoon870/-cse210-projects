using System;

public class Entry
{
    public string _Date;
    public string _Prompt;
    public string _Response;


    public void DsisplayEntry()
    {
        Console.WriteLine($"Date: {_Date}");
        Console.WriteLine($"Prompt: {_Prompt}");
        Console.WriteLine(_Response);
        Console.WriteLine();
    
    }
    public string RandomPrompt()
    {
        string[] prompts =
        {
            "Describe a tender mercy that you saw this week!", "What was the verse of the day?", "Did you exercise today? If so, what did you do?",
            "What is a new skill that you learned today?", "How were you charitable today?", "What was the weather like today?"

        };
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        return prompts[index];
    }

    




}