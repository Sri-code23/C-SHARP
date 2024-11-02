using System;

namespace math_class_funcs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter two numbers
            
            int a = 2;//+
            int b = 3;//+

            // Calculate the sum, difference, product, and quotient of a and b
            // Calculate the power of a and b
            int c = (int)Math.Pow(a, b);
            Console.WriteLine($"The result of {a}^{b} is: {c}");

            // Calculate the square root of b
            double d = Math.Sqrt(b);
            Console.WriteLine($"The square root of {b} is: {d}");

            // Calculate the absolute values of a and b
            int e = Math.Abs(a);
            int f = Math.Abs(b);
            Console.WriteLine($"The absolute value of {a} is: {e}");
            Console.WriteLine($"The absolute value of {b} is: {f}");

            // Find the maximum and minimum of a and b
            int g = Math.Max(a, b);
            Console.WriteLine($"The maximum of {a} and {b} is {g}");
            int h = Math.Min(a, b);
            Console.WriteLine($"The minimum of {a} and {b} is {h}");

            // Round, ceiling, and floor values of a
            double i = Math.Round((double)a);//+
            Console.WriteLine($"The rounded value of {a} is: {i}");
            double j = Math.Ceiling((double)a);//+
            Console.WriteLine($"The ceiling value of {a} is: {j}");
            double k = Math.Floor((double)a);//+
            Console.WriteLine($"The floor value of {a} is: {k}");
        }
    }
}
