// String Interpolation in C#

/*
Without string interpolation
string name = "John";
int age = 30;
Console.WriteLine("My name is " + name + " and I am " + age + " years old.");

// With string interpolation (using $ symbol)
Console.WriteLine($"My name is {name} and I am {age} years old.");

// With string interpolation (using string.Format())
Console.WriteLine(string.Format("My name is {0} and I am {1} years old.", name, age));

// With string interpolation (using string interpolation with named placeholders)
Console.WriteLine($"My name is {nameof(name)} and I am {nameof(age)} years old.");
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        string name="sridharan";
        int age=22;

        Console.WriteLine("hi " +name+ "your are " +age+ "years old");

        Console.WriteLine($"hi {name} , you are {age} years old");

    }
}
