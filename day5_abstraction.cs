using System;

abstract class Shape
{
    // abstact method(no body)
    public abstract double calculateArean();

}

class Reactangle : Shape
{
    public double lenght =10;
    public double width =5;

    public override double calculateArean()
    {
        return lenght * width;
    }
}

class Circle : Shape
{
    public double radius = 7;

    public override double calculateArean()
    {
        return 3.14 * radius * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape shape;
        
       Reactangle r = new Reactangle();
        Console.WriteLine(r.calculateArean());

        shape = new Circle();
        Console.WriteLine(shape.calculateArean());

    }
}