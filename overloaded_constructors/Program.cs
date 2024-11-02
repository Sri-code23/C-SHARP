// overloaded constructors is just like metod overloading, that is the method
// is called based on the parameters size or count
// method + parameters === signature 

using System;

class Program
{
    static void Main(string[] args)
    {
        Orders order1=new Orders("chapti", "poori" , " chutney", " idli");
        Orders order2=new Orders("sambar","vada"," papad");
        Orders order3=new Orders("dal makhani","roti");
        Orders order4=new Orders("vadapav");

        Console.WriteLine($"total number of orders {Orders.count}");
    }
}
class Orders
{
    string dish1;
    string dish2;
    string dish3;
    string dish4;
    public static int count=0;

    public Orders(string dish1, string dish2, string dish3, string dish4)
    {
        this.dish1=dish1;
        this.dish2=dish2;
        this.dish3=dish3;
        this.dish4=dish4;
        Console.WriteLine($"your dishes are {dish1}, {dish2}, {dish3}, {dish4}");
        count=count+1;

    }

    public Orders(string dish1, string dish2, string dish3)
    {
        this.dish1=dish1;
        this.dish2=dish2;
        this.dish3=dish3;
        Console.WriteLine($"your dishes are {dish1}, {dish2}, {dish3}");
        count=count+1;

    }

    public Orders(string dish1, string dish2)
    {
        this.dish1=dish1;
        this.dish2=dish2;
        Console.WriteLine($"your dishes are {dish1}, {dish2}");
        count=count+1;

    }

    public Orders(string dish)
    {
        this.dish1=dish;
        Console.WriteLine($"your dish is {dish}");
        count=count+1;

    }

}
