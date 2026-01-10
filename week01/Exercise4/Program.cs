using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers to create a list,type 0 when you finished");
        List<int> numbers= new List<int>();
        int enter= -1;
        while (enter != 0)
        {
            Console.Write("Enter a number: ");
            enter= int.Parse(Console.ReadLine());
            if (enter !=0)
            {
               numbers.Add(enter); 
            }
        }
        int sum =0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The total of the numbers is: {sum}");
        float average= ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the numbers are: {average}");
        int largest= numbers[0];
        foreach (int number in numbers)
        {
           if (number > largest)
            {
                largest= number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}