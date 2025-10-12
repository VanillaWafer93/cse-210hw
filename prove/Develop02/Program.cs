using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetPrompt();
                Console.WriteLine($"\n{prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                JournalEntry entry = new JournalEntry();
                entry._prompt = prompt;
                entry._text = response;
                entry._date = date;

                journal.AddEntry(entry.GetFullEntry());
                Console.WriteLine("Entry added!\n");
            }

            else if (choice == "2")
            {
                journal.DisplayJournal();
            }

            else if (choice == "3")
            {
                journal.SaveFile();
            }

            else if (choice == "4")
            {
                journal.LoadFile();
            }

            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
    }
}
