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
        protected int score;        

        public abstract void MakeChoice();
    }
}
