using System;
using System.Collections.Generic;
using System.Text;

namespace playRPS
{
    abstract class Player
    {
        public string name { get; set; }

        public Player(string Name)
        {
            this.name = Name;
        }

        public abstract string GetRPS();
    }
}
