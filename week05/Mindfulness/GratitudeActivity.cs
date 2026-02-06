using System;
using System.Collections.Generic;

public class GratitudeActivity:Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public GratitudeActivity() :base("Gratitude","This activity will help you focus on gratitude by having you think about and reflect on things you are thankful for in your life.")
    {
        _prompts= new List<string>
        {
            "Think of three things you are grateful for today.",
            "Think of a person you are thankful to have in your life.",
            "Think of a recent moment that made you feel thankful.",
            "Think of something small that you usually take for granted.",
            "Think of a challenge that helped you grow."
        };
        _questions= new List<string>
        {
            "Why is this meaningful to you?",
            "How does this make your day better?",
            "How can you show appreciation for this?",
            "How does gratitude affect your mood?",
            "How can you practice gratitude daily?"
        };
    }
    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DateTime end= DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < end)
        {
            DisplayQuestions();
        }
        DisplayEndingMessage();
    }

    public string GetrandomPrompt()
    {
        Random gPrompt= new Random();
        int gIndex= gPrompt.Next(_prompts.Count);
        return _prompts[gIndex];
    }
    public string GetRandomQuestion()
    {
        Random tQuestion= new Random();
        int tIndex= tQuestion.Next(_questions.Count);
        return _questions[tIndex];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"{GetrandomPrompt()}");
        Console.WriteLine("When you have something in mind,press Enter to continue");
        Console.ReadLine();
    }
    public void DisplayQuestions()
    {
        Console.WriteLine($"{GetRandomQuestion()}");
        ShowSpinner(4);
    }
}