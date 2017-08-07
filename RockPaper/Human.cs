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
            Console.WriteLine("\nKey in Player name and press ENTER.");
            name = Console.ReadLine();            
        }
        public override void MakeChoice()
        {
            Console.WriteLine("\nChoose one and press ENTER:\n1. Rock\n2. Paper\n3. Scissors\n4. Spock\n5. Lizard");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nPlease read the instructions and try again.\n");
                MakeChoice();
            }

            if (choice > 5)
            {
                Console.WriteLine("\nPlease read the instructions and try again.\n");
                MakeChoice();
            }
        }
        public override void CreatePlayer()
        {
            SetName();
        }
    }
}
