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
        protected List<string> choices = new List<string>() {"Empty String", "Rock", "Paper", "Scissor", "Spock", "Spock"};
        protected void GetGameType()
        {
            Console.WriteLine("How do you want to play?\n1. You vs the computer.\n2. You vs another human.\nType 1 or 2 and press ENTER to choose.");
            string gameType = Console.ReadLine();

            switch (gameType)
            {
                case "1":                    
                    player1.CreatePlayer();
                    players.Add(player1);
                    players.Add(robotPlayer);
                    break;
                case "2":
                    player1.CreatePlayer();
                    player2.CreatePlayer();
                    players.Add(player1);
                    players.Add(player2);
                    break;
                default:
                    Console.WriteLine("You did not choose a game type. Please try again.");
                    GetGameType();
                    break;
            }
        }
        public void MakeChoices()
        {
            while (players[0].score <3 && players[1].score < 3)
            {
                players[0].MakeChoice();
                players[1].MakeChoice();
                CompareChoices();
            }
            DisplayWinner();
            Console.ReadLine();
        }
        protected void DisplayWinner()
        {
            if (players[0].score > players[1].score)
            {
                Console.WriteLine($"{players[0].name} wins the game.");
            }
            else
            {
                Console.WriteLine($"{players[1].name} wins the game.");
            }
        }
        protected void CompareChoices()
        {
            if (players[0].choice == players[1].choice)
            {
                Console.WriteLine($"Both players chose {players[0].choice}. Press ENTER to continue.");
                Console.ReadLine();
            }
            else if ((players[0].choice % 2 == 0 && players[1].choice % 2 == 0) || (players[0].choice % 2 != 0 && players[1].choice % 2 != 0))
            {
                LowerScored();
            }
            else if ((players[0].choice % 2 == 0 && players[1].choice % 2 != 0) || (players[0].choice % 2 != 0 && players[1].choice % 2 == 0))
            {
                HigherScored();
            }
        }
        protected void LowerScored()
        {
            if (players[0].choice > players[1].choice)
            {
                players[1].score += 1;
                DisplayPlayer2Win();                
            }
            else
            {
                players[0].score += 1;
                DisplayPlayer1Win();
                
            }
        }
        protected void DisplayPlayer2Win()
        {
            Console.WriteLine($"{players[1].name} chose {choices[players[1].choice]}\n{players[0].name} chose {choices[players[0].choice]}\n{players[1].name} wins!");
        }
        protected void DisplayPlayer1Win()
        {
            Console.WriteLine($"{players[0].name} chose {choices[players[0].choice]}\n{players[1].name} chose {choices[players[1].choice]}\n{players[0].name} wins!");
        }

        protected void HigherScored()
        {
            if (players[0].choice > players[1].choice)
            {
                players[0].score += 1;
                DisplayPlayer1Win();                
            }
            else
            {
                players[1].score += 1;
                DisplayPlayer2Win();
            }
        }

        public void StartGame()
        {
            GetGameType();
            MakeChoices();
        }
    }
}
