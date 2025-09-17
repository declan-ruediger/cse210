// Exceeding Requirements: I improved the Journal.SaveToFile and Journal.LoadFromFile functions
//                         so they generate valid CSV files, which are still correctly saved and
//                         loaded, but can also viewed and edited in spreadsheet software.

using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator._prompts.AddRange([
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "How did I experience the Holy Ghost today?",
            "How was I shown love today?"
        ]);

        Journal journal = new Journal();

        string choice;
        do
        {
            Console.WriteLine("Please select one of the following choices:\n" +
            "1. Write\n" +
            "2. Display\n" +
            "3. Load\n" +
            "4. Save\n" +
            "5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = promptGenerator.getRandomPrompt();
                    Console.WriteLine(newEntry._promptText);
                    Console.Write("> ");
                    newEntry._entryText = Console.ReadLine();

                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("What is the filename? ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("What filename? ");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "5":
                    break;
                default:
                    break;
            }
            Console.WriteLine();
        } while (choice != "5");
    }
}