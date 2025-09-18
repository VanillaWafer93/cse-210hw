using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        string firstName = "Aiden";

        Console.WriteLine("hello" + firstName);
        Console.WriteLine($"Hello {firstName}");
        Console.Write($"Hello Bob");
        Console.Write("Thise is another line\n");

        Console.Write("What is your faviorite color?");
        string favorite_color = Console.ReadLine();

        Console.WriteLine($"{firstName}, your favorite color is {favorite_color}.");

        Console.Write("How old are you?");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"{firstName} you are {age} years old!");

        int a = 13;
        int b = 7;
        int c = a + b;

        Console.WriteLine($"c is {c}");
        Console.WriteLine($"a/b is {a / b}");
        Console.WriteLine($"{(double)a / b}");

        // double x = 1.5;
        // float y = 1.5f;

        bool is_done = false;

        if (is_done)
        {
            Console.WriteLine("All done.");
        }
        else
        {
            Console.WriteLine("Not done yet.");
        }
    }
}