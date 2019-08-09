using System;
using System.Collections.Generic;
using System.Text;

namespace playRPS
{
    class Brock : Player
    {
        public Brock(string Name) : base(Name) { }

        public override string GetRPS()
        {
            return RPSEnum.Rock.ToString();
        }
    }
}
