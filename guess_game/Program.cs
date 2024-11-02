using System;

class Program
{
    static void Main(string[] args)
    {
       // Error: 'Random' class is not properly used. It should be used with 'using' statement or fully qualified name.
       // Corrected Statement: System.Random random = new System.Random();
       Random random = new Random();
       int guess;
       bool play_again = true;
       while (play_again)
       {
           int correct_number = random.Next(1, 100);
           guess = 0;
           int guesses = 0;

           while (guess != correct_number)
           {
                
                Console.Write("enter you guess between 1 - 100 : ");
                
                guess = Convert.ToInt32(Console.ReadLine());
                
                if (guess < correct_number)
                {
                    Console.WriteLine("too low");
                }
                else if (guess > correct_number)
                {
                    Console.WriteLine("too high");
                }
                guesses++;
           }
           Console.WriteLine("the number is :" + correct_number);
           Console.WriteLine("you took " + guesses + " guesses");

           Console.WriteLine(" do you want to play again (Y / N): ");
           string user_choice = Console.ReadLine();
           user_choice = user_choice.ToUpper();

           if (user_choice == "Y")
           {
                play_again = true;
           }
           else
           {
                play_again = false;
                Console.WriteLine(" thanks for playing  !!!");
           }

       } 
    }
}
