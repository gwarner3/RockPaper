using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    public abstract class Player
    {
        private string name;
        private int choiceIndex;
        private List<int> choices = new List<int> {1,2,3,4,5};
        private int score;

        public Player()
        {
            //empty constructor for now
        }

        public abstract void MakeChoice();
    }
}
