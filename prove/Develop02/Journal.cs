using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _Entries = new List<Entry>();

    
    public void DisplayJournal()
    {
        foreach (Entry entry in _Entries)
        {
            entry.DsisplayEntry();
        }

    }
    public void AddEntry(Entry newEntry)
    {
        _Entries.Add(newEntry);
    }
    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _Entries)
            {
                outputFile.WriteLine($"{entry._Date},{entry._Prompt},{entry._Response}");
            }
        }
    }
    public void Load(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts.Length == 3)
            {
                Entry newEntry = new Entry();
                newEntry._Date = parts[0];
                newEntry._Prompt = parts[1];
                newEntry._Response = parts[2];
                _Entries.Add(newEntry);
            }
        }
    }
    public void Quit()
    {
        Console.WriteLine("We will see you tommorrow!");
    }
}

