using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 5);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("red", 4, 6);
        shapes.Add(rectangle);
        Circle circle = new Circle("green", 3);
        shapes.Add(circle);


        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}

