// The params keyword in C# is used to specify a method parameter that takes a variable number of arguments.
// It allows a method to accept any number of parameters, which are then accessible as an array within the method.
// The params keyword can only be used with the last parameter in a method's parameter list.
// Here's an example of how to use the params keyword:

using System;

class  Program
{
    static void Main(string[] args)
    {
        double sum = add(1.5, 2.7, 3.2, 4.8, 5.9);
        Console.WriteLine("Sum: " + sum);
    }
    static double add(params double[]  numbers)
    {
        double total=0;
        foreach (double number in  numbers)
        {
            total+=number;
        }
        return total;

    }

}

