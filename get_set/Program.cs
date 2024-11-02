public class Employee
{
    // Auto-implemented property to store and retrieve the employee's name
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Employee class
        Employee emp = new Employee();

        // Set the employee's name
        emp.Name = "John Doe";

        // Get the employee's name
        string employeeName = emp.Name;

        // Print the employee's name to the console
        System.Console.WriteLine("Employee Name: " + employeeName);
    }
}
