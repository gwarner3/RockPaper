using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    public class GameRoom
    {
        protected Human player1 = new Human();
        protected Human player2 = new Human();
        protected Robot robotPlayer = new Robot();
        protected List<Player> players = new List<Player>();
        protected void GetGameType()
        {
            Console.WriteLine("How do you want to play?\n1. You vs the computer\n2. You vs another human.\nType 1 or 2 and press ENTER to choose.");
            string gameType = Console.ReadLine();
            //Console.ReadLine();

            switch (gameType)
            {
                case "1":                    
                    player1.CreatePlayer();
                    players.Add(player1);
                    players.Add(robotPlayer);
                    break;
                case "2":
                    //Get name of both huan players and place both in list
                    player1.CreatePlayer();
                    player2.CreatePlayer();
                    players.Add(player1);
                    players.Add(player2);
                    break;
                default:
                    //send back to beginning of switch ctatement
                    break;
            }
        }
        public void MakeChoices()
        {
            //while neither player has a score of 3
            while (players[0].score <= 3 && players[1].score <=3)
            {
                players[0].MakeChoice();
                players[1].MakeChoice();
            }

        }
        protected void SetScore()
        {

        }

        public void StartGame()
        {
            GetGameType();
            MakeChoices();
        }
    }
}
