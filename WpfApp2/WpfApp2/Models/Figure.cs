using System.Windows;

namespace WpfApp2.Models;

public abstract class Figure
{
    public double X { get; set; }
    public double Y { get; set; }

    public Figure(double x, double y)
    {
        X = x;
        Y = y;
    }

    public abstract Rect GetEnclosingRectangle();
    public abstract double GetArea();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Center: {X}, {Y}");
        Console.WriteLine($"Enclosing Rectangle: {GetEnclosingRectangle().Width} x {GetEnclosingRectangle().Height}");
        Console.WriteLine($"Area: {GetArea()}");
    }
}