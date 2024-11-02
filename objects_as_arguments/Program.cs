using System;

// Define the main program class
class MainProgram
{
    // Define the main entry point of the program
    static void Main(string[] args)
    {
        // Create an instance of the Greet_class with name "sri" and age 20
        Greet_class name1 = new Greet_class("sri", 20);
        
        // Call the display_name method to display the name and age
        display_name(name1);
    }

    // Define a method to display the name and age of a Greet_class object
    public static void display_name(Greet_class nam)
    {
        // Use string interpolation to display a greeting message with the name
        Console.WriteLine($"hello {nam.User_name}");
        
        // Use string interpolation to display the age
        Console.WriteLine($"your age is :{nam.Age}");
    }
}

// Define a class to represent a person with a name and age
class Greet_class
{
    // Define public properties for the name and age
    public string User_name;
    public int Age;

    // Define a constructor to initialize the name and age properties
    public Greet_class(string name, int age)
    {
        // Initialize the name property
        User_name = name;
        
        // Initialize the age property
        Age = age;
    }
}


/*
// Define a simple class
public class Person
{
    // Class properties
    public string Name;
    public int Age;

    // Constructor to initialize the properties
    public Person(string name, int age)
    {
        // Initialize the properties
        Name = name;
        Age = age;
    }
}

// Define a function that takes an object as an argument
public class Program
{
    public static void Main()
    {
        // Create an object of the Person class
        Person person1 = new Person("John", 30);

        // Pass the object as an argument to the function
        GreetPerson(person1);
    }

    // Function to greet a person
    public static void GreetPerson(Person person)
    {
        // Access the object's properties
        // This is where the magic happens - we can access the properties of the object
        // because we passed the object as an argument to the function
        System.Console.WriteLine($"Hello, my name is {person.Name} and I am {person.Age} years old.");
    }
}
*/