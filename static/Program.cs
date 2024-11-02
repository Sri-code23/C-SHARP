// The static keyword is used to declare a static member, which belongs to the type itself rather than to a specific instance.
// In this case, the 'count' variable is static, meaning it is shared by all instances of the 'Names' class.
// This allows us to keep track of the total count of 'Names' instances created.

//Static -  allows methods to be called without an instance of the class. it is like constructor(__init__) in python , 
// it is called automamtically when the class is called, that means it doesnot require ant object to call the class.
// This is the main entry point of the program.
class Program
{
    // The Main method is the entry point of the program.
    static void Main(string[] args)
    {
        // Create instances of the Names class.
        Names name1 = new Names("sri");
        Names name2 = new Names("dharan");
        Names name3 = new Names("solo");
        Names name4 = new Names("leo");

        // Print the total count of Names instances created.
        Console.WriteLine("Total Names instances created: " + Names.count);
    }
}

// A class to represent a name.
class Names
{
    // The name property // (field)
    string name;

    // A static variable to keep track of the total count of Names instances.
    public static int count = 0;

    // The constructor to initialize a new Names instance.
    public Names(string name)
    {
        // Assign the name to the instance.
        this.name = name;

        // Increment the count of Names instances.
        count++;
    }
}
