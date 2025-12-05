public class EternalGoal : Goal
{
    public EternalGoal(string name, string points, string description)
        : base(name, points, description) {}

    public override bool IsComplete() => false;

    public override int RecordEvent()  //see program.cs for functionality of RecordEvent() function
    {
        return GetPoints();
    }

    public override string GetStatus()
    {
        return "[\u221E]"; //this is syntax for an infinity symbol to appear in brackets
    }

    public override string GetStringRepresentation()  //typing out the literal string for the name/points/description of 
                                                        //the specific goal
    {
        return $"EternalGoal:{GetName()},{GetPoints()},{GetDescription()}";
    }
}