using System;

// Typecasting is the process of converting a value of one data type to another data type.
// There are two types of typecasting in C#: Implicit and Explicit.
// Implicit typecasting is done automatically by the compiler, whereas explicit typecasting is done manually by the programmer.

class Program
{
    static void Main(string[] args)
    {
        // Explicit typecasting from double to int
        double e = 276.532;
        int b = Convert.ToInt32(e); // This will truncate the decimal part and convert to int

        // Implicit typecasting from int to double
        int a = 14;
        double d = Convert.ToDouble(a); // This will convert int to double

        // Explicit typecasting from double to string
        string s = Convert.ToString(d); // This will convert double to string

        // Explicit typecasting from char to string
        char c = 'a';
        string l = Convert.ToString(c); // This will convert char to string

        Console.WriteLine("Converting double to int: " + e + " to " + b);
        Console.WriteLine("Converting int to double: " + a + " to " + d);
        Console.WriteLine("Converting double to string: " + d + " to " + s);
        Console.WriteLine("Converting char to string: " + c + " to " + l);
        
        Console.WriteLine("Type of e: " + e.GetType());
        Console.WriteLine("Type of b: " + b.GetType());
        Console.WriteLine("Type of a: " + a.GetType());
        Console.WriteLine("Type of d: " + d.GetType());
        Console.WriteLine("Type of s: " + s.GetType());
        Console.WriteLine("Type of c: " + c.GetType());
        Console.WriteLine("Type of l: " + l.GetType());
    }
}
