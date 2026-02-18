using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise Tracking Project.");
        List<Activity> activities= new List<Activity>();

        activities.Add(new Running(DateTime.Today, 30, 3.0));
        activities.Add(new Cycling(DateTime.Today, 40, 15.0));
        activities.Add(new Swimming(DateTime.Today, 25, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}