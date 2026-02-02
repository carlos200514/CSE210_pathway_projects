using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Homework Project.");
        Assignment assignment= new Assignment("Felipe Rojas","Fractions");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();
        MathAssignment mathAssignment= new MathAssignment("Felipe Rojas", "Division", "Section 7.3", "Problems 8-12");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();
        WritingAssignment writingAssignment= new WritingAssignment("Felipe Rojas", "USA History", "The Causes of the Cold War");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}