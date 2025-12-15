public class Player : Character
{
    public Player(string name, string health, string description, string type)
        : base(name, health, description, type) { }

    public override int TakeDamage(int damage, Player attacker = null)
    {
        _health -= damage;
        Console.WriteLine($"{_name} takes {damage} damage. Remaining HP: {_health}");
        return _health;
    }

    public override int SpecialAttack() => 0;

    public int ChooseAction()
    {
        Console.WriteLine("\nChoose action:\n1. Basic Attack\n2. Special Attack\n3. Heal");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
}