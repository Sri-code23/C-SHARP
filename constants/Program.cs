// Constants in C# are immutable values that cannot be changed once they are declared.
// They are typically used to store values that do not change, such as mathematical constants or configuration settings.
// In this example, we declare a constant for pi with a value of 3.14.
// The 'const' keyword is used to declare a constant, and the value is assigned using the '=' operator.
// The data type of the constant is specified before its name, in this case 'double' to represent a decimal number.
// const double pi = 3.14;

using System;

// Define the main class for the program
class Program
{
    // Define the main entry point for the program
    static void Main(string[] args)
    {
        // Define a constant for pi with a value of 3.14
        const double pi = 3.14;

        // Print the value of pi to the console
        // Console.WriteLine(pi);
        Console.WriteLine($"{pi+1}")
    }
}
//output 
