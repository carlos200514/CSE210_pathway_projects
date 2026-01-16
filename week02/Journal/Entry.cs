using System;

public class Entry
{
    public string Date;
    public string Prompt;
    public string Response;

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }
    public string ToFileString()
    {
        return $"Date: {Date} | Prompt: {Prompt}| {Response}";
    }
    public static Entry FromFileString(string line)
    {
        string[] parts= line.Split('|');
        return new Entry
        {
            Date= parts[0],
            Prompt= parts[1],
            Response= parts[2]
        };
    }
}