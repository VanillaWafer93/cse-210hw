using System;

class Program
{
    static void Main(string[] args)
    {
        //setting initial variable for menu loop
        int choice = 0;

        //menu loop
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            if (!int.TryParse(Console.ReadLine(), out choice)) continue;

            switch (choice)
            {
                case 1:
                    new BreathingActivity().DoActivity();
                    break;
                case 2:
                    new ReflectionActivity().DoActivity();
                    break;
                case 3:
                    new ListingActivity().DoActivity();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                
                //for invalid choices
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}