// I add a library that stores two more scriptures and they are display randomly to the user each time the user start the program
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ScriptureMemorizer Project.");
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture(
            new Reference("Moroni", 10, 4, 5),
            "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."
        ));
        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son"
        ));

        scriptures.Add(new Scripture(
            new Reference("Psalm", 23, 1),
            "The Lord is my shepherd I shall not want"
        ));
        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        Scripture scripture = scriptures[randomIndex];
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Program ending.");
                break;
            }
        }
    }
}