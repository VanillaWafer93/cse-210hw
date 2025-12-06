public class Psychopath : Enemy
{
    
    public Psychopath(string name , string health , string description , string type) 
    : base(name , health , description , type){}

    public override int TakeDamage()
    {
        return 0;
    }






}