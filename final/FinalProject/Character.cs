public abstract class Character
{
    public string _name;
    public int _health;
    protected string _description;
    protected string _type;

    public Character(string name, string health, string description, string type)
    {
        _name = name;
        _health = int.Parse(health);
        _description = description;
        _type = type;
    }

    public int DisplayHealth() => _health;

    public int BasicAttack(int damage)
    {
        Console.WriteLine($"{_name} attacks for {damage} damage!");
        return damage;
    }

    public virtual int SpecialAttack() => 0;

    public abstract int TakeDamage(int damage, Player attacker);

    public int Heal()
    {
        _health += 50;
        Console.WriteLine($"{_name} heals 50 HP. Current HP: {_health}");
        return _health;
    }
}