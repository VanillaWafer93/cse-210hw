using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //creating list
        List<int> numbers = new List<int>();
        int userInput;

        //loop for adding user numbers to list
        do
        {
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

        } while (userInput != 0);

        //solving for the average of list
        int total = numbers.Sum();
        int amountOfNumbers = numbers.Count;
        Double average = (Double)total / amountOfNumbers;

        //getting biggest number in list
        int biggestNumber = numbers.Max();

        //printing the list
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        //printing the sum, average and biggest number
        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {biggestNumber}");

        


    }
    
}