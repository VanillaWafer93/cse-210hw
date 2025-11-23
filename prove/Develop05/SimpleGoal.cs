public class SimpleGoal : Goal
{
    private bool _isComplete = false;  //setting initial variable 

    //constructor
    public SimpleGoal(string name, string points, string description)
        : base(name, points, description) {}

    public override bool IsComplete() => _isComplete;  //returning false to IsComplete() since task is not done yet

    public override int RecordEvent()
    {
        _isComplete = true;  //switch _isComplete to true since event has been done (results in ISComplete() being changed)
        return GetPoints();
    }

    public override string GetStatus()
    {
        return IsComplete() ? "[X]" : "[ ]";  //new marking for task being complete
    }

    //showing entire goal/points and description
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetPoints()},{GetDescription()},{_isComplete}";
    }
}