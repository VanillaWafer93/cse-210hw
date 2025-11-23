public abstract class Goal
{
    private string _goalName;
    private string _description;
    private int _points;

    public Goal(string goalName, string points, string description)
    {
        _goalName = goalName;
        _description = description;
        _points = int.Parse(points);
    }

    public string GetName() => _goalName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    public abstract bool IsComplete();  //completed goals
    public abstract int RecordEvent();  //record goal and give points
    public abstract string GetStatus();  //Showing if goal is complete or not
    public abstract string GetStringRepresentation();
}