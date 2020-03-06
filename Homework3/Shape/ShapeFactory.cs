using System;
using System.Collections.Generic;

class ShapeFactory
{
    private static readonly Random rd = new Random();
    static int recCount = 0, squCount = 0, cirCount = 0, triCount = 0, unkCount=0;
    public static Shape GetShape(string shapeType)
    {
        switch (shapeType.ToLower())
        {
            case "rectangle":
                {
                    Rectangle rectangle = new Rectangle(10 * rd.NextDouble(), 10 * rd.NextDouble(), ++recCount);
                    while (!rectangle.IsLegal())
                    {
                        recCount--;
                        rectangle = new Rectangle(10 * rd.NextDouble(), 10 * rd.NextDouble(), ++recCount);
                    }
                    return rectangle;
                }
            case "square":
                {
                    Square square = new Square(10 * rd.NextDouble(), ++squCount);
                    while (!square.IsLegal())
                    {
                        squCount--;
                        square = new Square(10 * rd.NextDouble(), ++squCount);
                    }
                    return square;
                }
            case "circle":
                {
                    Circle circle = new Circle(10 * rd.NextDouble(), ++cirCount);
                    while (!circle.IsLegal())
                    {
                        cirCount--;
                        circle = new Circle(10 * rd.NextDouble(), ++cirCount);
                    }
                    return circle;
                }
            case "triangle":
                {
                    Triangle triangle = new Triangle(10 * rd.NextDouble(), 10 * rd.NextDouble(), 10 * rd.NextDouble(), ++triCount);
                    while (!triangle.IsLegal())
                    {
                        triCount--;
                        triangle = new Triangle(10 * rd.NextDouble(), 10 * rd.NextDouble(), 10 * rd.NextDouble(), ++triCount);
                    }
                    return triangle;
                }
            default:throw new ArgumentException("Unkown Shape!");
        }
    }
    public static Shape GetShape()
    {
        string[] shapes = { "rectangle", "square", "circle", "triangle" };
        return GetShape(shapes[(rd.Next(0, 4))]);
    }
}
class ProduceShape
{
    public static void Main()
    {
        double areaSum = 0;
        List<Shape> shapes = new List<Shape>();
        for (int i = 0; i < 10; i++)
        {
            shapes.Add(ShapeFactory.GetShape());
        }
        foreach(Shape shape in shapes)
        {
            areaSum += shape.Area;
            shape.ShowInfo();
        }
        Console.WriteLine("面积总和:" + areaSum);
        Console.ReadLine();
    }
}