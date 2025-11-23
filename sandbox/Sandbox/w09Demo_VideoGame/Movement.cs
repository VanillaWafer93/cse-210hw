using System.Runtime.CompilerServices;

public class Movement
{
    private string _startingLocation;
    private string _destination;

    public Movement()
    {

    }

    public MoveCharacter(Character c, string start, string end)
    {
        c.Move(start, end);
    }
    
    public void Move(string from, string to)
    {
        Console.WriteLine($"{_name} moved")
    }
}