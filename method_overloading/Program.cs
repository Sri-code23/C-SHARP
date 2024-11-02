// Method Overloading: This is a feature in C# that allows multiple methods with the same name to be defined, 
// as long as they have different parameter lists. This is useful when you want to perform the same operation 
// on different types of data.

// Example of Method Overloading:
// method + parameters == signature

// The add method is overloaded to accept different numbers of parameters.
// This allows the method to be used in different situations, making the code more flexible and reusable.

// The following methods are examples of method overloading:

using System;

class Program
{
    static void Main(string[] args)
    {
        double x=add(1,2);
        double y=add(2,3,4);
        double z=add(3,4,5,6);
        Console.WriteLine("Sum of 1 and 2: " + x);
        Console.WriteLine("sum of three nos: " + y);
        Console.WriteLine("sum of four nos: " + z);
    }



    static double add(double a , double b)
    {
        return a + b;
    }
    static double add(double a, double b, double c)
    {
        return a + b + c;
    }
    static double add(double a, double b, double  c, double d)
    {
        return a + b + c + d;
    }

}
