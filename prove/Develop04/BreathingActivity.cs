using System;

//parent class Activity
public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly." + 
        "Clear your mind and focus on your breathing.")
    { }

    //executing activity
    public void DoActivity()
    {
        DoStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)  //makes sure that program loops until time is up
        {
            Console.Write("Breathe in...");
            Countdown(4);

            Console.Write("Now breathe out...");
            Countdown(6);
            Console.WriteLine();
        }

        DoEndingMessage();
    }
}