using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shapes Project.");
        List<Shape> shapes= new List<Shape>();
        Square S1= new Square("blue", 4);
        shapes.Add(S1);
        Rectangle S2= new Rectangle("green", 7, 5);
        shapes.Add(S2);
        Circle S3= new Circle("red", 15);
        shapes.Add(S3);
        foreach(Shape shape in shapes)
        {
            string color= shape.GetColor();
            double area= shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}