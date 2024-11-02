// Multidimensional Arrays Explanation

// A multidimensional array is an array that contains one or more arrays as its elements. It's a way to store data in a tabular form, where each element is identified by a set of indices.

using System;
class Program
{
    static void Main(string[] args)
    {
        string[] names={"sri","dhar","agag"};

        string[,] database={{"sri","dhar","agag"},{"12","20","21"},{"chj","glbk","hcgh"}};
        
        // Accessing elements from multidimensional array
        /*
        foreach (string name in database)
        {
            Console.WriteLine(name);
        }
        */
        for (int i=0; i <database.GetLength(0); i++) // in array method length() is not possible, GetLength() is only possible
        {
            for (int j=0; j <database.GetLength(1); j++)
            {
                Console.Write(database[i,j] + " ");
            }
            Console.WriteLine();
        }

    }
}



