using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter the no of rows :");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter the no of columns :");
        int column = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter the symbol :");
        char symbol = Convert.ToChar(Console.ReadLine());
        

        // Error: loop condition should be i < row, not i <= row
        for (int i = 0; i < row; i++)
        {
            // Error: loop condition should be j < column, not j <= column
            for (int j = 0; j <column; j++)
            {
                // Error: symbol is an int, cannot be printed directly
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}
