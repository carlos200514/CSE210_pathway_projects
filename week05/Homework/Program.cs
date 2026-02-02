using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Homework Project.");
        Assignment a1= new Assignment("Felipe Rojas","Fractions");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();
        MathAssignment a2= new MathAssignment("Felipe Rojas", "Division", "7.3", "8-12");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();
        WritingAssignment a3= new WritingAssignment("Felipe Rojas", "USA History", "The Causes of the Cold War");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}