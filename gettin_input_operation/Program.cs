using System;

namespace getting_input_and_performing_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum of {a} and {b} is {a + b}");
        }
    }
}
