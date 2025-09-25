using System;

class Program
{
    static void Main(string[] args)
    {
        //variables for later
        int user_guess = -1;
        string continue_or_not = "YES";

        //continue the game loop
        while (continue_or_not == "YES")
        {

            //for variable for couning the guesses later in program
            int guess_counter = 0;

            //getting random number
            Random random_number = new Random();
            int magic_number = random_number.Next(1, 100);

            //guessing loop
            while (user_guess != magic_number)
            {
                guess_counter++;

                Console.Write("What is your guess? ");
                user_guess = int.Parse(Console.ReadLine());

                //finding if lower, higher or equal to magic number
                if (user_guess > magic_number)
                {
                    Console.WriteLine("Lower");
                }
                else if (user_guess < magic_number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You got it right!!!");
                    Console.WriteLine($"It took you {guess_counter} guesses to get it.");
                }
            }

            //play again?
            Console.Write("\nWould you like to play again? (yes / no) ");
            continue_or_not = Console.ReadLine().ToUpper();
        }

        //ending message
        Console.WriteLine("\nThank you for playing!"); 
    }
}