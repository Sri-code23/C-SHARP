using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
           int a=1;
           int b = 2;
           int sum=a+b;
           Console.WriteLine($"the sum of a and b is :{sum}");
           int difference=a-b;
           Console.WriteLine($"difference between them is :{difference}");
           int product=a*b;
           Console.WriteLine($"product of a and b is :{product}");
           double quotient=a/b;
           Console.WriteLine($"quotient of a and b is :{quotient}");
           int remainder=a%b;
           Console.WriteLine($"remainder of a divided by b is :{remainder}");
           
        }
    }
}
