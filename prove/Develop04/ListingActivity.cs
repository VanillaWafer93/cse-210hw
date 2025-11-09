using System;

//parent class Activity
public class ListingActivity : Activity
{
    private string[] _prompts;

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void DoActivity()
    {
        DoStartingMessage();

        //getting random prompt
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)];

        //displaying prompt
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");

        Console.Write("You may begin in: ");
        Countdown(5);  //starts countdown from 5

        string[] responses = new string[_duration * 2];
        int count = 0; //setting number of response count
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses[count++] = response;
            }
        }

        //diaplay amount of items listed and ending message
        Console.WriteLine($"\nYou listed {count} items!");
        DoEndingMessage();
    }
}