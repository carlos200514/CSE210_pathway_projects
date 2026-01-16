using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts= new List<string>
    {
      "What was the hardest part of your day?",
      "Who did you help today?",
      "What is something you learned today?",
      "What are you grateful for today?",
      "What was the highlight of your day?"  
    };
    public Random _random= new Random();
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}