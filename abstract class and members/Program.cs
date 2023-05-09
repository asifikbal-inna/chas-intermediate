using System;

public abstract class Shape
{
    public abstract double CalculateArea(); // Abstract method

    public void DisplayArea()
    {
        double area = CalculateArea();
        Console.WriteLine("Area: " + area);
    }
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double CalculateArea()
    {
        return length * width;
    }
}

public class Program
{
    public static void Main()
    {
        Shape circle = new Circle(3.5);
        circle.DisplayArea(); // Output: Area: 38.48451000647496

        Shape rectangle = new Rectangle(4.2, 6.8);
        rectangle.DisplayArea(); // Output: Area: 28.559999999999995
    }
}
