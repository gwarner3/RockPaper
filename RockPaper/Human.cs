using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    public class Human : Player
    {
        protected void SetName()
        {
            Console.WriteLine("Key in Player 1 name and press ENTER.");
            name = Console.ReadLine();            
        }
        public override void MakeChoice()
        {
            Console.WriteLine("Choose one and press ENTER:\n1. Rock\n2. Paper\n3. Scissors\n4. Spock\n5. Lizard");
            choice = int.Parse(Console.ReadLine());
        }
        public void CreatePlayer()
        {
            SetName();
        }
    }
}
