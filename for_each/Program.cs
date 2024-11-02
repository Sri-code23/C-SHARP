// The foreach loop in C# is similar to the for loop in Python, 
// it is used to iterate over a collection of items, such as an array or a list.

// Syntax: foreach (type variable in collection)
// {
//     // code to be executed
// }

// In this example, we are using the foreach loop to iterate over the name_list array.
// The type of the variable 'name' is string, which is the same as the type of the items in the array.
// The 'in' keyword is used to specify the collection to be iterated over.

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] name_list={"sri","dhar","colo","feqhh","graeg","rabgh","ae"};

        foreach (string name in name_list)
        {
            Console.WriteLine(name);

        }    
     
    }
}
