public class Hitman : Player
{
    public Hitman(string name, string health, string description, string type)
        : base(name, health, description, type) { }

    public override int SpecialAttack()
    {
        Console.WriteLine("Hitman performs his special attack, Deadshot blast!");
        return 45;
    }
}