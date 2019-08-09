using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace playRPS
{
    class Human : Player
    {
        public Human(string Name) : base(Name) { }
        public override string GetRPS()
        {
            Console.WriteLine("Hello there! Please select from the following below");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");
            Console.Write("\nSelection: ");

            string input = Console.ReadLine().Trim();

            if (input == "1")
            {
                return RPSEnum.Rock.ToString();
            }

            else if (input == "2")
            {
                return RPSEnum.Paper.ToString();
            }

            else if (input == "3")
            {
                return RPSEnum.Scissors.ToString();
            }

            else
            {
                
                Console.WriteLine("I'm sorry, you didn't select one the options. Give it another go!");
                Thread.Sleep(1500);
                Console.Clear();
                return GetRPS();
            }
        }
    }
}
