using System;

public class Circle:Shape
{
    private readonly double radius;
    public double GetRadius()
    {
        return radius;
    }
    public Circle(double radius,int id):base(id)
    {
        this.radius = radius;
    }
    public override double Area {
        get {
            if (IsLegal())
                return radius * radius * Math.PI;
            else
                return Double.NaN;
        }
    }
    public override bool IsLegal()
    {
        return (radius > 0);
    }
    public override void ShowInfo()
    {
        Console.WriteLine("这是{0}号圆 形,它的面积是:{1}", Id, Area);
        Console.WriteLine("它的半径为{0}\n", radius);
    }
}
