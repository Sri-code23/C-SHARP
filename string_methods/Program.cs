using System;

class Program
{
    static void Main(string[] args)
    {
        // Define a string variable and assign it a value
        string a = "sri dharan";

        // Convert the string to uppercase
        a = a.ToUpper();
        Console.WriteLine("Uppercase: " + a); // Output: Uppercase: SRIDHARAN

        // Convert the string to lowercase
        string lower = a.ToLower();
        Console.WriteLine("Lowercase: " + lower); // Output: Lowercase: sridharan

        // Remove leading and trailing whitespace from the string
        string trim = a.Trim();
        Console.WriteLine("Trimmed: " + trim); // Output: Trimmed: SRIDHARAN

        // Extract a substring from the string
        string substring = a.Substring(2, 5);
        Console.WriteLine("Substring (2, 5): " + substring); // Output: Substring (2, 5): IDHAR

        // Replace a substring with another string
        string replace = a.Replace("sri", "SRI");
        Console.WriteLine("Replace 'sri' with 'SRI': " + replace); // Output: Replace 'sri' with 'SRI': SRIDHARAN

        // Split the string into an array of substrings
        string[] split = a.Split('h');
        Console.WriteLine("Split by 'h':"); // Output: Split by 'h':
        Console.WriteLine("Part 1: " + split[0]); // Output: Part 1: SRID
        Console.WriteLine("Part 2: " + split[1]); // Output: Part 2: ARAN

        // Check if the string contains a specific substring
        bool contains = a.Contains("dhar");
        Console.WriteLine("Contains 'dhar': " + contains); // Output: Contains 'dhar': True

        // Check if the string starts with a specific substring
        bool start = a.StartsWith("sri");
        Console.WriteLine("Starts with 'sri': " + start); // Output: Starts with 'sri': True

        // Check if the string ends with a specific substring
        bool end = a.EndsWith("n");
        Console.WriteLine("Ends with 'n': " + end); // Output: Ends with 'n': True

        // Find the index of the first occurrence of a specific character
        int index = a.IndexOf("d");
        Console.WriteLine("Index of 'd': " + index); // Output: Index of 'd': 3

        // Find the index of the last occurrence of a specific character
        int lastindex = a.LastIndexOf("a");
        Console.WriteLine("Last index of 'a': " + lastindex); // Output: Last index of 'a': 6
    }
}
