﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRoom newGame = new GameRoom();
            newGame.StartGame();
        }
    }
}
