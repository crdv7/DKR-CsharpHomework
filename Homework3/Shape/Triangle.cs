using System;
public class Triangle : Shape 
{ 
    private readonly double a, b, c;
    public double GetSideA()
    {
        return a;
    }
    public double GetSideB()
    {
        return b;
    }
    public double GetSideC()
    {
        return c;
    }
    public Triangle(double a,double b,double c,int id):base(id)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public override double Area
    {
        get
        {
            if (IsLegal())
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
                return Double.NaN;
        }
    }
    public override bool IsLegal()
    {
        return (a>0&&b>0&&c>0&&a + b > c && b + c > a && a + c > b);
    }
    public override void ShowInfo()
    {
        Console.WriteLine("这是{0}号三角形,它的面积是:{1}", Id, Area);
        Console.WriteLine("它的三边长为a:{0},b:{1},c:{2}\n", a, b, c);
    }
}
