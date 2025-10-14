using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<string> _entries = new List<string>();

    public void AddEntry(string text)
    {
        _entries.Add($"{text}");
    }

    public void DisplayJournal()
    {
        if (_entries.Count == 0)
            {
                Console.WriteLine("No journal entries found.\n");
                return;
            }

            foreach (string entry in _entries)
            {
                Console.WriteLine(entry);
                
            }
                // Console.WriteLine("");
    }

    public void SaveFile()
    {
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine($"{entry}\n");
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFile()
    {
        Console.Write("Enter a filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _entries = new List<string>(lines);
            Console.WriteLine($"Journal loaded from {filename}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}