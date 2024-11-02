using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome guest1=new Welcome("Mr","sridhar","padmabooshan");
        Welcome guest2=new Welcome("Mrs","sona","padmavibooshan");
        guest1.Praising();
        guest1.thanks();

        guest2.Praising();
        guest2.thanks();
    }
}
class Welcome
{
    string pronoun;
    string name;
    string award;

    public Welcome(string pronoun,string name,string award)
    {
        this.pronoun = pronoun;
        this.name = name;
        this.award = award;
        Console.WriteLine($"Welcome to the award ceremony,{pronoun}.{name}");

    }
    public void Praising()
    {
        Console.WriteLine(pronoun + "." + name + " has received the " + award);
    }
    public void thanks()
    {
        Console.WriteLine($"Thank you for your contribution {pronoun}.{name}");
    }
}