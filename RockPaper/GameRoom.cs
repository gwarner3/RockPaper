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
            while (players[0].score <3 && players[1].score < 3)
            {
                players[0].MakeChoice();
                players[1].MakeChoice();
                CompareChoices();
            }
            DisplayWinner();
        }
        protected void DisplayWinner()
        {
            if (players[0].score > players[1].score)
            {
                Console.WriteLine(players[0].name + " won.");
            }
            else
            {
                Console.WriteLine(players[1].name + " won.");
            }
        }
        protected void CompareChoices()
        {
            if (players[0].choice == players[1].choice)
            {
                Console.WriteLine("Both chose the same thing. Press ENTER to continue.");
                Console.ReadLine();
            }
            else if ((players[0].choice % 2 == 0 && players[1].choice % 2 == 0) || (players[0].choice % 2 != 0 && players[1].choice % 2 != 0))
            {
                //both odd or both even, lower number wins
                //put both choices in a list
                //select the lowest of the two choices
                LowerScored();
            }
            else if ((players[0].choice % 2 == 0 && players[1].choice % 2 != 0) || (players[0].choice % 2 != 0 && players[1].choice % 2 == 0))
            {
                //one odd and other is even, higher number wins
                HigherScored();
            }
        }
        protected void LowerScored()
        {
            if (players[0].choice > players[1].choice)
            {
                players[1].score += 1;
            }
            else
            {
                players[0].score += 1;
            }
        }

        protected void HigherScored()
        {
            if (players[0].choice > players[1].choice)
            {
                players[0].score += 1;
            }
            else
            {
                players[1].score += 1;
            }
        }

        public void StartGame()
        {
            GetGameType();
            MakeChoices();
        }
    }
}
