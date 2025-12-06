using System.Runtime.CompilerServices;

public class Enemy : Character
{
    
    public Enemy(string name , string health , string description , string type) 
    : base(name , health , description , type) {}


    public override int TakeDamage()
    {
        return 0;
    }

    public Action ActionRandomiser()
    {
        
    }




}