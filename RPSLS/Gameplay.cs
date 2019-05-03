using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Gameplay
    {
        //member variables (Has a)
        List<Gameplay> choice;
        Player player1;
        Player player2;

        //constructor
        public Gameplay()
        {
            choice = new List<Gameplay>();
        }

        //member methods (Can do)
        public void GameStart()
        {
            Console.WriteLine();
            Console.ReadLine();
        }

        public void DisplayIntroAndRules()
        {
            Console.WriteLine();
            Console.ReadLine();
        }

        public int PickNumberOfPlayers()
        {
            Console.WriteLine("How many players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }

        public void SetUpPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if (numberOfPlayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
        }

        public void PlayGame()
        {
            Console.WriteLine();
            Console.ReadLine();
        }

        public void ChooseGestures()
        {
            player1.MakeChoice();
            player2.MakeChoice();
        }

        public void ReplayQuit()
        {
            Console.WriteLine();
            Console.ReadLine();
        }

        public void RPSLP()
        {
            GameStart();
            DisplayIntroAndRules();
            PickNumberOfPlayers();
            PlayGame();
            ReplayQuit();
        }
    }
}
