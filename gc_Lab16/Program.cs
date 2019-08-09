using System;
using System.Threading;

namespace playRPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();                        

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

            int nameWins = 0;
            int brockWins = 0;

            if (championSelection == 1)
            {
                do
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
                        nameWins ++;
                    }

                    else if (output == "Scissors")
                    {
                        Console.WriteLine(b + " is the winner!");
                        brockWins++;
                    }
                }
                while (nameWins < 3 || brockWins < 3);
            }

            else if (championSelection == 2)
            {
                Misty m = new Misty("Misty");
                Human h = new Human(name);

                string output1 = m.GetRPS();
                string output = h.GetRPS();
                Console.WriteLine(output);
                Console.WriteLine(output1);
            }
        }
    }
}
