using System;
using System.Collections.Generic;

class Program
{
    static int _currentPoints = 0;  //starting points
    static List<Goal> _goals = new List<Goal>();  //list of added goals

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine($"\nYou have {_currentPoints} points");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoals();
            else if (choice == "3") RecordEvent();
            else if (choice == "4") SaveGoals();
            else if (choice == "5") LoadGoals();
            else if (choice == "6") break;
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("\nTypes of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type? ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        string pts = Console.ReadLine();

        //adding goals to _goals list
        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, pts, desc));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, pts, desc));
        }
        else if (type == "3")
        {
            Console.Write("How many times required? ");
            int required = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, pts, desc, required, bonus));
        }
    }

    static void ListGoals()  //showing current goals
    {
        Console.WriteLine("\nYour Goals:");
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.GetStatus()} {g.GetName()} ({g.GetDescription()})");
            i++;
        }
    }

    static void RecordEvent()  //recording any completed tasks
    {
        ListGoals();

        Console.Write("\nWhich goal did you complete? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int gained = _goals[index].RecordEvent();
        _currentPoints += gained;

        Console.WriteLine($"\nYou gained {gained} points!");
    }

    static void SaveGoals()  //saving to a file
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();
        FileLoaderSaver.Save(file, _currentPoints, _goals);
        Console.WriteLine("Saved!");
    }

    static void LoadGoals()  //loading from file
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();
        (int score, List<Goal> goals) = FileLoaderSaver.Load(file);

        _currentPoints = score;
        _goals = goals;

        Console.WriteLine("Loaded!");
    }
}