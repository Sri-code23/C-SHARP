
// Polymorphism is the ability of an object to take on multiple forms.
// This is achieved through method overriding and method overloading.

// Base class
public class Animal
{
    // Virtual method can be overridden in derived classes
    public virtual void Sound()
    {
        Console.WriteLine("The animal makes a sound.");
    }

    // ToString() method is overridden to provide a meaningful string representation
    public override string ToString()
    {
        return "I am an animal.";
    }
}

// Derived class
public class Dog : Animal
{
    // Overriding the Sound() method
    public override void Sound()
    {
        Console.WriteLine("The dog barks.");
    }

    // Overriding the ToString() method
    public override string ToString()
    {
        return "I am a dog.";
    }
}
 
class Program
{
    static void Main(string[] args)
    {
        // Creating objects
        Animal animal = new Animal();
        Dog dog = new Dog();

        // Polymorphism in action
        Animal polymorphicDog = new Dog();

        // Calling the Sound() method
        animal.Sound();  // Output: The animal makes a sound.
        dog.Sound();     // Output: The dog barks.
        polymorphicDog.Sound();  // Output: The dog barks.

        // Calling the ToString() method
        Console.WriteLine(animal.ToString());  // Output: I am an animal.
        Console.WriteLine(dog.ToString());     // Output: I am a dog.
        Console.WriteLine(polymorphicDog.ToString());  // Output: I am a dog.
    }
}

