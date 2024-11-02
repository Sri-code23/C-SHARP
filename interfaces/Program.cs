// The IPrintable interface is used to define a contract that must be implemented by any class that wants to be printable.
// It provides a way to achieve polymorphism, allowing objects of different classes to be treated as if they were of the same class.
// In this case, the IPrintable interface is used to define a common method (Print) that can be called on objects of different classes (Document and Photo).
// This allows the Printer class to print objects without knowing their specific class type, as long as they implement the IPrintable interface.

using System;

public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

public class Drawer
{
    public void Draw(IShape shape)
    {
        shape.Draw();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Drawer drawer = new Drawer();
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();

        drawer.Draw(circle);
        drawer.Draw(rectangle);
    }
}

// Output:
// Drawing a circle.
// Drawing a rectangle.
