using System;

class Program 
{
    static void Main(string[] args)
    {
        happy_birthday("sri",20);
        happy_birthday("dharan",20);
    }
    static void happy_birthday(string name,int age)
    {
        Console.WriteLine($"Hi {name} ! you are {age} years old ");
        Console.WriteLine("Nice to meet you "+ name);
        Console.WriteLine();
    }
}
