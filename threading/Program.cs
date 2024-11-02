using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread num= new Thread(numbers);
        Thread lett=  new Thread(letters);
        num.Start();
        lett.Start();
    }

    public static void numbers()
    {
        for(int i=0;i<10;i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    } 

    public static void  letters()
    {
        string[] animals={"dog","cat"," bird","fish","elephant"};

        foreach(string animal in animals)
        {
            Console.WriteLine(animal);
            Thread.Sleep(2000);
        }
    }
}
