﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    public class Robot : Player
    {

        public Robot()
        {
            this.name = "Player 2";
        }
        public override void MakeChoice()
        {
            Random robotChoice = new Random();
            //choiceIndex = choice.Next(0, 4);
            choice = robotChoice.Next(1, 4);
        }
    }
}
