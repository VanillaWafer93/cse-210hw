using System.Runtime.CompilerServices;

public class Hitman : Player
{
    
    public Hitman(string name , string health , string description , string type) 
    : base(name , health , description , type){}


    public override int SpecialAttack()
    {
        return 0;
    }




}