using System.Net;

public class Player : Character
{

    public Player(string name , string health , string description , string type)
    : base(name , health , description , type) {}

    public Action ActionSelect()
    {
        
    }


    public override int TakeDamage()
    {
        return 0;
    }

    public override int SpecialAttack()
    {
        return 0;
    }


}