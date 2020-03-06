using System;

public class Square : Shape
{
    private readonly double mySide;
    public double GetMyside()
    {
        return mySide;
    }
    public Square(double side,int id):base(id)
    {
        mySide = side;
    }
    public override double Area
    {
        get
        {
            if (IsLegal())
                return  mySide* mySide;
            else
                return Double.NaN;
        }
    }
    public override bool IsLegal()
    {
        return (mySide > 0);
    }
    public override void ShowInfo()
    {
        Console.WriteLine("这是{0}号正方形,它的面积是:{1}", this.Id, this.Area);
        Console.WriteLine("它的边长为:{0}\n", mySide);
    }
}
