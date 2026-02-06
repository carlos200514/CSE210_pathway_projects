using System;

public class BreathingActivity:Activity
{
    public BreathingActivity() : base("Breathing","This activity will help you relaxing by a guiding breathing exercise")
    {}
    public void Run()
    {
        DisplayStartingMessage();
        int duration= GetDuration();
        int timePassed= 0;
        while (timePassed < duration)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Breath out...");
            ShowCountDown(6);
            Console.WriteLine();
            timePassed += 10;
        }
        DisplayEndingMessage();
    }
}