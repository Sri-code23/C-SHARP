using System;

namespace objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting person1=new Greeting();
            Greeting person2=new Greeting();

            person1.name="sri";
            person1.age=23;

            person2.name="dharan";
            person2.age=25;

            person1.greet();
            person1.welcome();

            person2.greet();
            person2.welcome();
        }
    }

    class Greeting
    {
        public string name;
        public int age;

        public void greet()
        {
            Console.WriteLine("hi " + name );
            Console.WriteLine("your age is " + age );
        }
        public void welcome()
        {
            Console.WriteLine("welcome " + name );
            Console.WriteLine();
        }

    }
}
