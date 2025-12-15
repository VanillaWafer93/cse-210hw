public class Enemy : Character
{
    public Enemy(string name, string health, string description, string type)
        : base(name, health, description, type) { }

    public override int TakeDamage(int damage, Player attacker)
    {
        _health -= damage;
        Console.WriteLine($"{_name} takes {damage} damage. Remaining HP: {_health}");
        return _health;
    }

    public int ActionRandomiser()
    {
        // Random attack damage
        Random rnd = new Random();
        int dmg = rnd.Next(15, 30);
        Console.WriteLine($"{_name} attacks for {dmg} damage!");
        return dmg;
    }
}