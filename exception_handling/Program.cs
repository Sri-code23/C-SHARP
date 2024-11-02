// Exceptional handling is used to handle runtime errors, 
// such as DivideByZeroException and FormatException, 
// to prevent the program from crashing and provide a better user experience.
// try
// catch
// finally

using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int x;
            int y;
            Console.WriteLine("Enter first number: ");
            x=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter  second number: ");
            y=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"the division of  {x} and {y} is {x/y}");
        }
        catch (DivideByZeroException a)
        {
            
            Console.WriteLine("Something went wrong !!");
            Console.WriteLine($"error type : {a.Message}");
        }
        catch (FormatException b)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.WriteLine($"error type : {b.Message}");
        }
        finally 
        {
            Console.WriteLine("program ran successfully");
        }
    }

}
