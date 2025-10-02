/*using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 2;
        int y = 3;
        int sum = Adder(x, y);
        Console.WriteLine(sum);

        GreetUser("Bob");

        string someonesName = "Jill";
        GreetUser(someonesName);

        Console.WriteLine($"x before {x}");
        changeValue(x);
        Console.WriteLine($"x after {x}");

        int[] myArray = new int[] { 1, 2, 3, 4, 5 };
        Console.Write("Before: ");
        foreach (int number in myArray)
        {
            Console.Write($"{number}");
        }

        changeReference(myArray);
        Console.Write("\nAfter: ");
        foreach (int number in myArray)
        {
            Console.Write($"{number}");
        }

    }

    static void changeValue(int x)
    {
        x = 100;
    }

    static void changeReference(int[] data)
    {
        data[2] = 100;
    }

    // def adder(a , b):
    //return a + b

    static int Adder(int a, int b)
    {
        return a + b;
    }

    static void GreetUser(string firstName)
    {
        Console.WriteLine($"Hello {firstName}!");
    }
    
}*/