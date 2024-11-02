
// List of Objects Concept in C#

// Define a simple class called Person
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor to initialize the object
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method to display the person's details
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Create a list of Person objects
List<Person> people = new List<Person>()
{
    new Person("John Doe", 30),
    new Person("Jane Doe", 25),
    new Person("Bob Smith", 40)
};

// Iterate through the list and display each person's details
foreach (var person in people)
{
    person.DisplayDetails();
}

