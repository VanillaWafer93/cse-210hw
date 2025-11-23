using System;
using System.Collections.Generic;
using System.IO;

public class FileLoaderSaver
{
    //saving and organizing goals into a file
    public static void Save(string filename, int points, List<Goal> goals)
    {
        List<string> lines = new List<string>();

        // adding the current points
        lines.Add(points.ToString());

        // Adding goals
        foreach (Goal g in goals)
        {
            lines.Add(g.GetStringRepresentation()); //see definition in SimpleGoal.cs
        }

        // Write all lines to the file at once
        File.WriteAllLines(filename, lines);
    }

    //file loader
    public static (int, List<Goal>) Load(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        int score = int.Parse(lines[0]);  //score
        List<Goal> goals = new List<Goal>(); //goals list

        for (int i = 1; i < lines.Length; i++)
        {
            //separating lines in new file
            string line = lines[i];
            string[] parts = line.Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            switch (type)
            {
                case "SimpleGoal":  //pulling from simple goal
                    SimpleGoal sg = new SimpleGoal(data[0], data[1], data[2]);
                    if (bool.Parse(data[3])) sg.RecordEvent();
                    goals.Add(sg);
                    break;

                case "EternalGoal":  //pulling from eternal goal
                    goals.Add(new EternalGoal(data[0], data[1], data[2]));
                    break;

                case "ChecklistGoal":  //pulling from checklist goal
                    ChecklistGoal cg = new ChecklistGoal(data[0], data[1], data[2],
                                                         int.Parse(data[3]), int.Parse(data[4]));
                    cg.LoadProgress(int.Parse(data[5]));
                    goals.Add(cg);
                    break;
            }
        }

        return (score, goals);  //returning goals list and score from load function
    }
}