using System;
using System.Threading;

namespace playRPS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPlayAgain = false;

            do
            {
                Intro();
                Console.WriteLine();
                Console.Write("Would you like to play again? (y/n): ");
                string response = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (response == "y")
                {
                    isPlayAgain = true;
                }

                else
                {
                    isPlayAgain = false;
                }
            }

            while (isPlayAgain == true);

        }   
        
        static void Intro()
        {
            Console.WriteLine("Welcome player to Rock Paper Scissors! I'm glad you're here, have fun!");
            Console.Write("\nPlease enter your name: ");
            string name = Console.ReadLine();

            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.WriteLine(".");
            Thread.Sleep(300);

            Console.WriteLine(name + ", what a wonderful name. Below are your champions to attempt to defeat.");
            Console.WriteLine("1) Brock");
            Console.WriteLine("2) Misty");
            Console.Write("\nType in 1 or 2 to challenge a champion: ");
            string champion = Console.ReadLine();
            int championSelection;
            int.TryParse(champion, out championSelection);

            if (championSelection == 1)
            {
                    Brock b = new Brock("Brock");
                    Human h = new Human(name);

                    string output1 = b.GetRPS();
                    string output = h.GetRPS();
                    Console.WriteLine(output);
                    Console.WriteLine(output1);

                    if (output1 == output)
                    {
                        Console.WriteLine("Draw!");
                    }

                    else if (output == "Paper")
                    {                       
                        Console.WriteLine(name + " is the winner!");
                    }

                    else if (output == "Scissors")
                    {
                        Console.WriteLine("Brock is the winner!");
                    }
            }

            else if (championSelection == 2)
            {
                Misty m = new Misty("Misty");
                Human h = new Human(name);

                string output1 = m.GetRPS();
                string output = h.GetRPS();
                Console.WriteLine(output);
                Console.WriteLine(output1);

                if (output == "Rock")
                {
                    if (output1 == "Rock")
                    {
                        Console.WriteLine("Draw!");
                    }

                    else if (output1 == "Paper")
                    {
                        Console.WriteLine("Misty is the Winner!");
                    }

                    else if (output1 == "Scissors")
                    {
                        Console.WriteLine(name + " is the Winner!");
                    }
                }

                else if (output == "Paper")
                {
                    if (output1 == "Rock")
                    {
                        Console.WriteLine(name + " is the Winner!");
                    }

                    else if (output1 == "Paper")
                    {
                        Console.WriteLine("Draw!");
                    }

                    else if (output1 == "Scissors")
                    {
                        Console.WriteLine("Misty is the Winner!");
                    }
                }

                else if (output == "Scissors")
                {
                    if (output1 == "Rock")
                    {
                        Console.WriteLine("Misty is the Winner!");
                    }

                    else if (output1 == "Paper")
                    {
                        Console.WriteLine(name + " is the Winner!");
                    }

                    else if (output1 == "Scissors")
                    {
                        Console.WriteLine("Draw!");
                    }
                }

                else
                {
                    Console.WriteLine("Incorrect input!");
                }
            }
        }
    }
}
