using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade: ");
        string grade= Console.ReadLine();
        int number= int.Parse(grade);
        if (number >= 90)
        {
            Console.WriteLine("Your score is: A");
        }
        else if (number >= 80)
        {
            Console.WriteLine("Your score is: B");
        }
        else if (number >=70)
        {
            Console.WriteLine("Your score is: C");
        }
        else if (number >= 60)
        {
            Console.WriteLine("Your score is: D");
        }
        else
        {
            Console.WriteLine("Your score is: F");
        }

    }
}