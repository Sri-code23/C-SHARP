using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the day: ");
        string day = Console.ReadLine();
        day = day.ToUpper();

        switch (day)
        {
            case "MONDAY":
                Console.WriteLine("Monday is the first day of the week");
                break;
            case "TUESDAY":
                Console.WriteLine("Tuesday is the second day of the week");
                break;
            case "WEDNESDAY":
                Console.WriteLine("Wednesday is the third day of the week");
                break;
            case "THURSDAY":
                Console.WriteLine("Thursday is the fourth day of the week");
                break;
            case "FRIDAY":
                Console.WriteLine("Friday is the fifth day of the week");
                break;
            case "SATURDAY":
                Console.WriteLine("Saturday is the sixth day of the week");
                break;
            case "SUNDAY":
                Console.WriteLine("Sunday is the seventh day of the week");
                break;
            default:
                Console.WriteLine($"{day} is not a day");
                break;
        }
    }
}
