// The for loop is used to iterate over a block of code for a specified number of times.
// The syntax is: for (initializer; condition; increment/decrement)
//   - initializer: executed once before the loop starts
//   - condition: evaluated before each iteration; if true, the loop continues
//   - increment/decrement: executed after each iteration
// for (i = 10; i <= 100; i += 10)
using System;

class Program
{
    static void Main(string[] args)
    {
        // You are missing a semicolon at the end of this line
        int i = 10;
        
        // The for loop syntax is incorrect. It should be initialized, then the condition, then the increment
        for (i = 10; i <= 100; i += 10)
        {
            Console.WriteLine(i);
        }
        
    }
}
