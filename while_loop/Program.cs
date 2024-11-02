// This while loop will continue to prompt the user for their name until a non-empty string is entered.
// The syntax 'while (condition)' means the code inside the loop will execute as long as the condition is true.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter your name: ");
        string name=Console.ReadLine();
        while (name=="")
        {
            Console.Write("enter your name: ");
            name=Console.ReadLine();
        }
        Console.WriteLine($"hello {name}");
    }
}
