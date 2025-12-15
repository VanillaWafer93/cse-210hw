public class Psychopath : Enemy
{
    public Psychopath(string name, string health, string description, string type)
        : base(name, health, description, type) { }

    public override int TakeDamage(int damage, Player attacker)
    {
        // Bonus damage if attacked by Hitman
        if (attacker is Hitman)
        {
            damage += 20;
            Console.WriteLine("Psychopath takes BONUS damage from Hitman!");
        }

        _health -= damage;
        Console.WriteLine($"{_name} takes {damage} damage. Remaining HP: {_health}");
        return _health;
    }
}