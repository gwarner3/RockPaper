using System;
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
            
        }
        public override void MakeChoice()
        {
            Random robotChoice = new Random();
            choice = robotChoice.Next(1, 4);
        }
        public override void CreatePlayer()
        {
            this.name = "Player 2";
        }
    }
}
