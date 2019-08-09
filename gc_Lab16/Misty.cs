using System;
using System.Collections.Generic;
using System.Text;

namespace playRPS
{
    class Misty : Player
    {
        public Misty(string Name) : base(Name) { }

        public override string GetRPS()
        {
            string[] word = { "Rock", "Paper", "Scissors" };
            Random rand = new Random();
            int index = rand.Next(word.Length);
            return word[index];
        }

    }
}
