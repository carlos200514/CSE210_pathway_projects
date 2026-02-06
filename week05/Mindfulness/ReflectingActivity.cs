using System;
using System.Collections.Generic;

public class ReflectingActivity:Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity() :base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts= new List<string>
        {
            "Think of a time when you overcame a fear.",
            "Think of a time when you showed patience.",
            "Think of a time when you forgave someone.",
            "Think of a time when you worked hard to reach a goal.",
            "Think of a time when you helped improve someone’s day."
        };
        _questions= new List<string>
        {
            "What emotions did you feel during this experience?",
            "What did this experience teach you about perseverance?",
            "How can you apply what you learned to future challenges?",
            "What part of this experience are you most proud of?",
            "How did this experience help you grow as a person?",
            "What would you do differently if you faced this again?",
            "What advice would you give someone in a similar situation?",
            "How has this experience shaped your perspective?"
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
        Random rPrompt= new Random();
        int pIndex= rPrompt.Next(_prompts.Count);
        return _prompts[pIndex];
    }
    public string GetRandomQuestion()
    {
        Random rQuestion= new Random();
        int qIndex= rQuestion.Next(_questions.Count);
        return _questions[qIndex];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"{GetrandomPrompt()}");
        Console.WriteLine("When you have thinking something,press Enter to continue");
        Console.ReadLine();
    }
    public void DisplayQuestions()
    {
        Console.WriteLine($"{GetRandomQuestion()}");
        ShowSpinner(4);
    }
}