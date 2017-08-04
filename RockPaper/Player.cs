using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    public abstract class Player
    {
        protected string name;
        //protected int choiceIndex;
        //List<int> choices = new List<int> {1,2,3,4,5};
        protected int score;

        public abstract void MakeChoice();
    }
}
