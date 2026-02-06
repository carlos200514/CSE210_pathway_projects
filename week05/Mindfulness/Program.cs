// I add another activity that is related with the gratitude
using System;

class Program
{
    static void Main(string[] args)
    {
        int option= 0;
        while (option != 4)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program.");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select one of the activities: ");
            option= int.Parse(Console.ReadLine());
            if (option == 1)
            {
                BreathingActivity act1= new BreathingActivity();
                act1.Run();
            }
            else if (option == 2)
            {
                ListingActivity act2= new ListingActivity();
                act2.Run();
            }
            else if (option == 3)
            {
                ReflectingActivity act3= new ReflectingActivity();
                act3.Run();
            }
            else if (option == 4)
            {
                GratitudeActivity act4= new GratitudeActivity();
                act4.Run();
            }
        }
    }
}