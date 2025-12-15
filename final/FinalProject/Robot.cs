public class Robot : Enemy
{
    public Robot(string name, string health, string description, string type)
        : base(name, health, description, type) { }

    public override int TakeDamage(int damage, Player attacker)
    {
        // Bonus damage if attacked by Hacker
        if (attacker is Hacker)
        {
            damage += 20;
            Console.WriteLine("Robot takes BONUS damage from Hacker!");
        }

        _health -= damage;
        Console.WriteLine($"{_name} takes {damage} damage. Remaining HP: {_health}");
        return _health;
    }
}