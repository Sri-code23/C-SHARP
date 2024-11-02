using System;

class Program
{
    static void Main(string[] args)
    {
        bool play_again = true;
        Random random = new Random();

        string Computer;
        string Player;
        while (play_again)
        {
            Computer = "";
            Player = "";
            while (Player != "ROCK" && Player != "PAPER" && Player != "SCISSOR")
            {
                Console.Write("enter  your choice rock, paper or scissor: ");
                Player = Console.ReadLine();
                Player = Player.ToUpper();
            }
            

            Console.WriteLine("Player : " + Player);

            switch (random.Next(1, 4))
            {
                case 1:
                    Computer = "ROCK";
                    break;
                case 2:
                    Computer = "PAPER";
                    break;
                case 3:
                    Computer = "SCISSOR";
                    break;
            }
            Console.WriteLine("Computer :" + Computer);

            switch (Player)
            {
                case "ROCK":
                    if (Computer == "ROCK")
                    {
                        Console.WriteLine("you both chose rock, it's a tie");
                    }
                    else if (Computer == "PAPER")
                    {
                        Console.WriteLine("you lose, computer chose paper");
                    }
                    else if (Computer == "SCISSOR")
                    {
                        Console.WriteLine("you win, computer chose scissor");
                    }
                    break;

                case "PAPER":
                    if (Computer == "ROCK")
                    {
                        Console.WriteLine("you win, computer chose rock");
                    }
                    else if (Computer == "PAPER")
                    {
                        Console.WriteLine("you  both chose paper, it's a tie");
                    }
                    else if (Computer == "SCISSOR")
                    {
                        Console.WriteLine("you lose, computer chose scissor");
                    }
                    break;

                case "SCISSOR":
                    if (Computer == "ROCK")
                    {
                        Console.WriteLine("you lose, computer chose rock");
                    }
                    else if (Computer == "PAPER")
                    {
                        Console.WriteLine("you win, computer chose paper");
                    }
                    else if (Computer == "SCISSOR")
                    {
                        Console.WriteLine("you both chose scissor, it's a tie");
                    }
                    break;

            }
        Console.Write("do you want to play again (Y / N ): ");
        string answer = Console.ReadLine();
        answer=answer.ToUpper();
        if (answer=="Y")
        {
            play_again=true;
        }
        else
        {
            play_again=false;
            Console.Write("thanks for playing !!! ");
        }
        }
    }
}
