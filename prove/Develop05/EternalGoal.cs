public class EternalGoal : Goal
{
    public EternalGoal(string name, string points, string description)
        : base(name, points, description) {}

    public override bool IsComplete() => false;

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override string GetStatus()
    {
        return "[X]";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetPoints()},{GetDescription()}";
    }
}