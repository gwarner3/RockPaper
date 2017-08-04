using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    public class Human : Player
    {
        public Human()
        {
            //empty constructor
        }
        public override void MakeChoice()
        {
            Console.WriteLine("Choose one and press ENTER:\n1. Rock\n2. Paper\n 3. Scissors\n4. Spock\n5. Lizard");
            Console.ReadLine();
        }
    }
}
