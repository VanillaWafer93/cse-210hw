using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

public abstract class Character
{
    private string _name;  //name of character
    private int _health;  //character health
    private string _description;  //description of character
    private string _type;  //character type

    public Character(string name , string health , string description , string type)
    {
        _name = name;
        _health = int.Parse(health);
        _description = description;
        _type = type;

    }

    public int DisplayHealth() => _health;  //showing character health
    
    public int BasicAttack(int damage)
    {
        Console.WriteLine($"{_name} performs a basic attack");
        return damage;
    }

    public virtual int SpecialAttack()
    {
        return 0;
    }
    public abstract  int TakeDamage();
    public int Heal()
    {
        Console.WriteLine($"{_name} patches up their wounds to heal");
        _health += 50;
        return _health;
    }

}