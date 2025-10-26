using System;

class Program
{
    static void Main(string[] args)
    {
        //getting scripture and references
        string text = "For God so loved the world that he gave his one and only Son, " +
                      "that whosoever believeth in him shall not perish but have eternal life.";
        Reference reference = new Reference("John", 3, 16);

        Scripture scripture = new Scripture(text, reference);

        // Main loop
        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden, good job (:");
                break;
            }

            Console.WriteLine("\nPress enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input != null && input.ToLower() == "quit")
                break;

            scripture.HideWords();
        }
    }
}
