using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score: ");
        string grade= Console.ReadLine();
        int number= int.Parse(grade);
        string letterG= "";
        if (number >= 90)
        {
            letterG= "A";
        }
        else if (number >= 80)
        {
            letterG= "B";
        }
        else if (number >=70)
        {
            letterG= "C";
        }
        else if (number >= 60)
        {
            letterG= "D";
        }
        else
        {
            letterG= "F";
        }
        Console.WriteLine($"Your grade is: {letterG}");
        if (number >=70)
        {
            Console.WriteLine("Congratulations! you pass");
        }
        else
        {
            Console.WriteLine("Good effort, study more next time");
        }

    }
}