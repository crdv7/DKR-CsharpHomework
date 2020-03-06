using System;
public abstract class Shape
{
    public int Id { get; set; }
    public Shape(int s){Id = s;}
    public abstract double Area{ get; }
    public virtual void ShowInfo() { }
    public abstract bool IsLegal();
}