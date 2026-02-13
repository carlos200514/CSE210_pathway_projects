// I add level up method and the program tracks the level and the points to level up
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("EternalQuest Project.");
        GoalManager manager= new GoalManager();
        manager.Start();
    }
}