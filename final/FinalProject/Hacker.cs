public class Hacker : Player
{
    public Hacker(string name, string health, string description, string type)
        : base(name, health, description, type) { }

    public override int SpecialAttack()
    {
        Console.WriteLine("Hacker does his special attack and launches a system breach!");
        return 40;
    }
}