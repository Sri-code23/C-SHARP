// Write a C# program to check if a given year is a leap year or not using logical operators.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
    }
}
