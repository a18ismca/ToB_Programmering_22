using System;
using System.Collections.Generic;
using System.Text;

namespace ToB2
{
    public class Round
    {
        public void startBattle()
        {
            Battle btl = new Battle();
            btl.CreatePlayer();
            btl.CreateOpponents();
        }

        public void RollDice()
        {
            
        }
    }
}
