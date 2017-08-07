using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    public abstract class Player
    {
        public string name;
        public int score;
        public int choice;

        
        public abstract void MakeChoice();
    }
}
