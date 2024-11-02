// Inheritance in C# allows a derived class (ChildClass) to inherit the properties and methods of a base class (ParentClass).
// The derived class can also add new members or override the members of the base class.

// The 'base' keyword is used to access the members of the base class from the derived class.
// The 'override' keyword is used to provide a different implementation of a method in the derived class.

// In this example, the ChildClass inherits the 'Name' property and the 'DisplayName' method from the ParentClass.
// The ChildClass also adds a new property 'Age' and a new method 'DisplayAge'.
// The 'DisplayName' method in the ChildClass overrides the 'DisplayName' method in the ParentClass.
using System;

class Main_Program
{
    static void Main(string[] args)
    {
        //ParentClass parent=new ParentClass();
        ChildClass child=new ChildClass();
        child.DisplayName();
    }
}
class ParentClass
{
    public void DisplayName()
    {
        Console.WriteLine("Parent's Display Name");
    }
}

class ChildClass : ParentClass
{
    public void  DisplayAge()
    {
        Console.WriteLine("Child's Display Age");
    }

}
class  ChildClass2 : ParentClass
{
    public void Display_class()
    {
        Console.WriteLine("ChildClass2's Display Name");
    }
}
