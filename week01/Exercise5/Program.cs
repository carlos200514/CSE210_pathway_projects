using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName= PromtUserName();
        int userNumber= PromtUserNumber();
        int squareNum=SquareNumber(userNumber);
        DisplayResult(userName,squareNum);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromtUserName()
    {
        Console.Write("Enter your name: ");
        string name= Console.ReadLine();
        return name;
    }
    static int PromtUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int num)
    {
        int square= num*num;
        return square;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is: {number}");
    }
}