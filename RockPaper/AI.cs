using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    public class AI : Player
    {

        public AI()
        {
            this.name = "Robot";
        }
        public override void MakeChoice()
        {
            Random choice = new Random();
            choiceIndex = choice.Next(0, 4);
        }
    }
}
