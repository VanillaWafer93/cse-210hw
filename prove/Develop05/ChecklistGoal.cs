public class ChecklistGoal : Goal
{
    private int _requiredTimes;
    private int _completedTimes;
    private int _bonus;

    public ChecklistGoal(string name, string points, string description, int required, int bonus)
        : base(name, points, description)
    {
        _requiredTimes = required;
        _bonus = bonus;
    }

    public void LoadProgress(int completed)
    {
        _completedTimes = completed;
    }

    public override bool IsComplete() => _completedTimes >= _requiredTimes;

    public override int RecordEvent()
    {
        _completedTimes++;  //marking number of times complete

        if (_completedTimes == _requiredTimes)  //give bonus when reached correct amount
            return GetPoints() + _bonus;

        return GetPoints();
    }

    public override string GetStatus()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} Completed {_completedTimes}/{_requiredTimes}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetPoints()},{GetDescription()},{_requiredTimes},{_bonus},{_completedTimes}";
    }
}