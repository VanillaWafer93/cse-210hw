using System;
using System.ComponentModel;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    //setting protected variables
    public Activity(string name, string description, int duration = 0)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //starting message to user
    public void DoStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like your session to be? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready to begin...");
        SpinnerAnimation(3);
    }

    //ending message to user
    public void DoEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        SpinnerAnimation(3);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}.");
        SpinnerAnimation(3);
    }

    //creating spinner animation
    protected void SpinnerAnimation(int duration)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
            if (i >= spinner.Length) i = 0;
        }
    }

    protected void Countdown(int countFrom)
    {
        for (int i = countFrom; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public int GetDuration() => _duration;
}