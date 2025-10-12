using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the weirdest thing that happened today?",
        "What was the best part of my day?",
        "What was the worst part of my day",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private Random _randomPrompt = new Random();

    public string GetPrompt()
    {
        int index = _randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
}
