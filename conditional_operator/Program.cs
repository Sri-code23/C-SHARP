// The conditional operator in C# is a ternary operator that takes three operands: 
// a boolean expression, and two expressions to return if the boolean expression is true or false.
// It is often used as a shorthand for simple if-else statements.

// Syntax: condition ? first_expression : second_expression;

// Example:
// bool isAdmin = true;
// string message = isAdmin ? "Hello, Admin!" : "Hello, User!";
// Output: "Hello, Admin!"

using System;

class Program
{
    static void Main(string[] args)
    {
        int temperature;
        temperature=20;

        /*
        if (temperature>20)
        {
            Console.WriteLine("its Warm Outside");
            Console.WriteLine("Take a jacket");
        }
        else 
        {
            Console.WriteLine("its quite  outside");
        }
        */ 
        // instead of ^this, this >
        
        string message=(temperature>20) ? "its Warm Outside" : "its quite  outside";
        Console.WriteLine(message);

    }

}