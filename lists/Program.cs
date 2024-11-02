using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> colors = new List<string> { "Red", "Green", "Blue" };

        Console.WriteLine("List of colors:");
        foreach (var item in colors)
        {
            Console.WriteLine(item);
        }

        colors.Insert(1, "Yellow");
        Console.WriteLine("List after inserting 'Yellow' at position 1:");
        foreach (var item in colors)
        {
            Console.WriteLine(item);
        }

        colors.Remove("Green");
        Console.WriteLine("List after removing 'Green':");
        foreach (var item in colors)
        {
            Console.WriteLine(item);
        }

        colors.Sort();
        Console.WriteLine("Sorted list:");
        foreach (var item in colors)
        {
            Console.WriteLine(item);
        }

        colors.Reverse();
        Console.WriteLine("Reversed list:");
        foreach (var item in colors)
        {
            Console.WriteLine(item);
        }

        colors.Clear();
        Console.WriteLine("List after clearing:");
        foreach (var item in colors)
        {
            Console.WriteLine(item);
        }
    }
}
