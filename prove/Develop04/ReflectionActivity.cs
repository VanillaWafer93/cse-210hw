using System;

//parent class Activity
public class ReflectionActivity : Activity
{
    private string[] _prompts;
    private string[] _reflectionQuestions;

    public ReflectionActivity() : base(
        "Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
        "This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        //list of prompts for user
        _prompts = new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        //list of questions for user
        _reflectionQuestions = new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void DoActivity()
    {
        DoStartingMessage();

        //getting random prompt
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)];

        //displaying prompt
        Console.WriteLine($"\nConsider the following prompt:\n--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5); //starts beginning countdowm

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)  //loops until the set time is up
        {
            string question = _reflectionQuestions[rand.Next(_reflectionQuestions.Length)];
            Console.Write($"> {question} ");
            SpinnerAnimation(5);
            Console.WriteLine();
        }

        DoEndingMessage();
    }
}