// Import the System namespace. This namespace contains fundamental classes and base classes.
using System;

// Define a namespace called ExampleForBasics. Namespaces help organize code elements.
namespace ExampleForBasics
{
    // Define a class called Program. Classes define the structure and behavior of objects.
    public class Program
    {
        // Define a static method called Main. The Main method is the entry point of the program.
        public static void Main(string[] args)
        {
            // Call the WriteHello method.
            WriteHello();

            // Call the WriteGreeting method and pass a parameter.
            WriteGreeting("World");
        }

        // Define a static method called WriteHello. This method prints "Hello, World!" to the console.
        public static void WriteHello()
        {
            Console.WriteLine("Hello, World!");
        }

        // Define a static method called WriteGreeting. This method takes a string parameter and prints a greeting message to the console.
        public static void WriteGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}