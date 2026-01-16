// I add some behaviors in the entry file to handle better the construction of the text file 
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal= new Journal();
        PromptGenerator promptGenerator= new PromptGenerator();
        Console.WriteLine("Welcome to your Journal");
        int choice= 0;
        while (choice !=5)
        {
            Console.WriteLine("Select the number of the following choices: ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What will you do: ");
            choice= int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("-- ");
                string response = Console.ReadLine();
                Entry entry = new Entry
                {
                    Date= DateTime.Now.ToShortDateString(),
                    Prompt= prompt,
                    Response= response
                };
                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
                Console.WriteLine("Journal saved.");
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
                Console.WriteLine("Journal loaded.");
            }
        }
    }
}