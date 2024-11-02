// Polymorphism is a fundamental concept in object-oriented programming (OOP) that allows objects of 
// different classes to be treated as objects of a common superclass. 
// It enables code reusability, flexibility, and extensibility.

// Define a superclass called Animal
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Define a subclass called Dog that inherits from Animal
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

// Define a subclass called Cat that inherits from Animal
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows.");
    }
}

// Main method to demonstrate polymorphism
public class Program
{
    static void Main(string[] args)
    {
        // Create objects of Dog and Cat classes
        Dog dog = new Dog();
        Cat cat = new Cat();

        // Create an array of Animal objects
        Animal[] animals = { dog, cat }; 
        //In object-oriented programming, polymorphism allows objects of different classes 
        //  to be treated as objects of a common superclass. 

        // Call the MakeSound method on each object in the array
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}