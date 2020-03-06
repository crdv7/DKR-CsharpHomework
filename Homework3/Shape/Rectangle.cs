using System;

public class Rectangle : Shape
{
    private readonly double width, height;
    public double GetWidth()
    {
        return width;
    }
    public double GetHeight()
    {
        return height;
    }
    public Rectangle(double width, double height, int id) : base(id)
    {
        this.width = width;
        this.height = height;
    }
    public override double Area
    {
        get
        {
            if (IsLegal())
                return width * height;
            else
                return Double.NaN;
        }
    }
    public override bool IsLegal()
    {
        return (height>0&&width>0);
    }
    public override void ShowInfo()
    {
        Console.WriteLine("这是{0}号矩 形,它的面积是:{1}", Id, Area);
        Console.WriteLine("它的长为:{0}宽为:{1}\n", width, height);
    }
}
