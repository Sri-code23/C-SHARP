// An array in C# is a collection of variables of the same data type stored in a single variable.
// It is a fixed-size, homogeneous collection of elements, each identified by an index or subscript.
// Arrays are zero-based, meaning the first element is at index 0.

// Syntax: 
// type[] arrayName = new type[size];

// Example:
// string[] name_list = new string[4];

// Use cases:
// 1. Storing a collection of values of the same type.
// 2. When the number of values is fixed and known at compile time.
// 3. When memory efficiency is important, as arrays store elements in contiguous memory locations.

// Declaration:
// type[] arrayName;

// Initialization:
// arrayName = new type[size];

// Accessing elements:
// arrayName[index]


using System;

class Program
{
    static void Main(string[] args)
    {
        string[] name_list={"sri","dhar","colo","adfjh"};

        for (int i=0;i<name_list.Length;i++)
        {
            Console.WriteLine(name_list[i]);
        }
    }
}
