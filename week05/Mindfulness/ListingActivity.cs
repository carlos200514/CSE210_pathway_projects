using System;
using System.Collections.Generic;

public class ListingActivity:Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by listing them")
    {
        _prompts= new List<string>
        {
            "What are things that make you smile?",
            "What are moments today that you are grateful for?",
            "What are skills or talents you are thankful to have?",
            "What are places where you feel peaceful?",
            "What are small successes you have had recently?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine(GetrandomPrompt());
        List<string> items= GetListFromUser();
        _count= items.Count;
        Console.WriteLine($"You listed {_count} items");
        DisplayEndingMessage();
    }
    public string GetrandomPrompt()
    {
        Random random= new Random();
        int index= random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> items= new List<string>();
        DateTime end= DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < end)
        {
            string item= Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }
        return items;
    }
}