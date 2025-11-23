using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace w09Demo_VideoGame;

class Program
{
    static void Main(string[] args)
    {
        List<Character> players = new List<Character>();


        Character bob = new Character("Bob");
        // bob.Attack();
        players.Add(bob);

        Magician larry = new Magician("Larry");
        // larry.Attack();
        players.Add(larry);

        RichDude steve = new RichDude();
        // steve.Attack();
        players.Add(steve);

        foreach(Character c in players)
        {
            c.Attack();
            mover.MoveCharacter()
        }




    }
    



}
