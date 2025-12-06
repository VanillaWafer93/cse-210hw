public class Robot : Enemy
{
    

    public Robot(string name , string health , string description , string type)
     : base(name , health , description , type) {}


    public override int TakeDamage()
    {
        return 0;
    }






}