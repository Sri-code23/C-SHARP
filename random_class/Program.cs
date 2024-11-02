using System;

namespace randomo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Random class to generate random numbers
            Random r = new Random(); 
            // 'Random' is the class name, 'r' is the instance name, 'new' is the keyword to create a new instance, 
            // and 'Random()' is the constructor call.
            // Generate a random integer between 1 and 7 (exclusive)
            int a = r.Next(1, 7);
            
            // Print the generated random number to the console
            Console.WriteLine("Random number: " + a);
        }
    }
}
// Python equivalent
// import random
// a = random.randint(1, 6)
// print("Random number: ", a)
// Note: Python's randint is inclusive of the end value, so we use 6 instead of 7
