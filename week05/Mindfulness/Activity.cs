using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name= name;
        _description= description;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration=duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"This is the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("Type the duration of the activity in seconds: ");
        int duration= int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.WriteLine("The activity will begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! you have finished the activity");
        ShowSpinner(3);
        Console.WriteLine($"You completed the {_name} activity in {_duration} seconds");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner= {"<","^",">","."};
        DateTime end= DateTime.Now.AddSeconds(seconds);
        int i=0;
        while (DateTime.Now < end)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i= (i+1) % spinner.Length;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i= seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}