using System;
using System.Collections.Generic;
using System.Threading;

namespace Names_space
{
    class Main_class
    {
        static void Main(string[] args)
        {
            // Error: Console.Raedline() should be Console.ReadLine()
            Console.Write("enter a number: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                Console.Write($"you entered {num}"); // Corrected 'entererd' to 'entered'
                Programo obj = new Programo();
                obj.method_name(num); 
                // method_name is correctly called with 'num' as an argument// Error: method_name was not being called
                Thread_class ob=new Thread_class(obj.method_name); // Pass method_name as a parameter
            }

            else
            {
                Console.Write("invalid input");
            }
        }
    }
    class Programo
    {
        // Error: method_name should have a return type and parameter type
        public void method_name(int num)
        {
            Console.Write($" number: {num + 22}");
            // Error: Thread.sleep() should be Thread.Sleep()
            Thread.Sleep(2000);
            Console.WriteLine("program ended");

        }
    }
    class Thread_class
    {
        // Error: 'pubic' should be 'public' and 'function_name' should have a type
        // Corrected: 'pubic' to 'public' and added type 'ThreadStart' to 'function_name'
        // why the function type is set to threadstart ?
        //  because the function is being passed to the thread constructor 

        public Thread_class(ThreadStart function_name)
        {
            // Error: 'chore1.start()' should be 'chore1.Start()'
            // Corrected: 'chore1.start()' to 'chore1.Start()'
            Thread chore1 = new Thread(function_name);
            chore1.Start();

            
        }
    }

