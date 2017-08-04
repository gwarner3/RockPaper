using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    public class GameRoom
    {
        protected void GetGameType()
        {
            Console.WriteLine("How do you want to play?\n1. You vs the computer\n2. You vs another human.\nType 1 or 2 and press ENTER to choose.");
            string gameType = Console.ReadLine();
            //Console.ReadLine();

            switch (gameType)
            {
                case "1":
                    //create one human and one robot player
                    CreateAIPlayer();
                    Console.WriteLine("Key in Player 1 name (don't worry");
                    break;
                case "2":
                    //create two human players
                    break;
                default:
                    //send back to beginning of switch ctatement
                    break;
            }
        }
        protected void CreateAIPlayer()
        {
            //code to create AI player
            Robot player2 = new Robot();
        }
        protected void CreateHumanPlayer()
        {
            //code to instantiate human player
            Human player1 = new Human();
            Human player2 = new Human();
        }
        public void StartGame()
        {
            GetGameType();
        }
    }
}
