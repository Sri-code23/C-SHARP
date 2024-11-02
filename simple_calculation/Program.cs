using System;

namespace hypotenuse
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("enter side a:");
            double a=Convert.ToDouble(Console.ReadLine());

            Console.Write("enter side b:");
            double b=Convert.ToDouble(Console.ReadLine());

            double c=((a*a)+(b*b));

            double d=Math.Sqrt(c);

            Console.WriteLine($"the hypotenuse of {a} and {b} is {d} ");
            
        }
    }

}