
// Enum in C# is a value type that enables you to define a set of named values.
// Enums are useful when you have a fixed set of distinct values that have a particular meaning in your application.

// Example of an enum in C#:
public enum Day
{
    // Enum values are implicitly assigned a value starting from 0.
    // You can also assign explicit values to enum members.
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

// Using the enum in a class:
public class Program
{
    public static void Main()
    {
        // You can use the enum values in your code like this:
        Day today = Day.Monday;
        Console.WriteLine($"Today is {today}");  // Outputs: Monday
    }
}


/*
public enum UserRole
{
    Admin,
    Moderator,
    User,
    Guest
}

// Example usage
public void AssignRole(UserRole role)
{
    if (role == UserRole.Admin)
    {
        // Grant admin privileges
    }
}
*/




