using System;

class Program
{
    static void Main(string[] args)
    {
        double a;
        double b;
        Console.Write("enter  first number: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter  second number: ");
        b = Convert.ToDouble(Console.ReadLine());

        double result = add(a, b);
        double result2 = subtract(a, b);
        double result3 = multiply(a, b);
        double result4 = divide(a, b);

        Console.WriteLine($"the addition  of {a} and {b} is {result}");
        Console.WriteLine($"the  subtraction of {a} and {b} is {result2}");
        Console.WriteLine($"the multiplication of {a} and {b} is {result3}");
        Console.WriteLine($"the division of {a} and {b} is {result4}");
    }

    
    static double add(double x, double y)
    {
        double addition;
        addition = x + y;
        return addition;
    }

   
    static double subtract(double x, double y)
    {
        double subtraction;
        subtraction = x - y;
        return subtraction;
    }

   
    static double multiply(double x, double y)
    {
        double multiplication;
        multiplication = x * y;
        return multiplication;
    }

   
    static double divide(double x, double y)
    {
        double division;
        division = x / y;
        return division;
    }
}
