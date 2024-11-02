
// Abstract classes in C# are used to create a blueprint for other classes to follow.
// They can contain both abstract and non-abstract members.
// abstract means it denotes the specific class or methods is incomplete and object cannnot be created for the class
// and the method cannot called

// Using the abstract class and derived class
public class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.MakeSound();  // Outputs: Woof!
        dog.Eat();        // Outputs: Eating...
    }
}


// Abstract class declaration
public abstract class Animal
{
    // Abstract method (must be implemented by derived classes)
    public abstract void MakeSound();

    // Non-abstract method (can be used by derived classes)
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

// Derived class
public class Dog : Animal
{
    // Implementing the abstract method
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}
// static means the object is not required  to call the method
// abstract  means the method is incomplete and cannot be called




