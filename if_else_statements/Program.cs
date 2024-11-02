using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your age: ");
            string input = Console.ReadLine();

// The int.TryParse() method attempts to convert the input string to an integer.
// It returns true if the conversion is successful, and false otherwise.
// The 'out' keyword is used to pass the converted integer value to the 'age' variable.
// This statement is used to validate the user's input and prevent the program from crashing due to invalid input
            if(int.TryParse(input,out int age))
            {
                if (age <= 18)
                {
                    Console.WriteLine("you are not eligible");
                }
                else if (age >= 18 && age < 30)
                {
                    Console.WriteLine("you are eligible");
                }
                else
                {
                    Console.WriteLine("you are not eligible");
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
