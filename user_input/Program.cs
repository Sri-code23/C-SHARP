using System;

// Define the main class for the program
class Program
{
    // Define the main entry point for the program
    static void Main(string[] args)
    {
        // Prompt the user to enter their name
        Console.Write("Enter your name: ");
        // Read the user's input and store it in the 'name' variable
        string name = Console.ReadLine();

        // Prompt the user to enter their age
        Console.Write("Enter your age: ");
        // Read the user's input, convert it to an integer, and store it in the 'age' variable
        int age = Convert.ToInt32(Console.ReadLine());

        // Display a message to the user with their name and age
        Console.WriteLine($"Your name is {name} and your age is {age}");
    }
}
