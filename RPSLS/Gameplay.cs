using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Gameplay
    {
        //member variables (Has a)
        Player player1;
        Player player2;
        public int numberofplayers;
        

        //constructor
        public Gameplay()
        {
            player1 = new Human();
        }

        //member methods (Can do)
        public void RunGame()
        {
            GameStart();
            DisplayRules();
            SetupPlayers();
            //SetupPlayers();
            //GetPlayerNames();
            //PlayGame();
            ChooseGestures();
            DisplayResults();
            DetermineWinner();
            ReplayQuit();
        }

        public void GameStart()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Console.ReadLine();
            Console.Clear();
        }

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!" +
                "Here are the rules:" +
                "Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, and as it always has Rock crushes Scissors. Got it?");
            Console.ReadLine();
            Console.Clear();
        }

        public int SetupPlayers()
        {
            
            Console.WriteLine("How many players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            if (numberOfPlayers == 1)
            {
                player1 = new Human();
                Console.WriteLine("Player 1");
                player2 = new Computer();
            }
            else if (numberOfPlayers == 2)
            {
                player1 = new Human();
                Console.WriteLine("Player 1");
                player2 = new Human();
                Console.WriteLine("Player 2");
            }
            return numberOfPlayers;
        }

        //public void SetupPlayers()
        //{
        //    int numberOfPlayers;
        //    if (numberOfPlayers == 1)
        //    {
        //        player1 = new Human();
        //        player2 = new Computer();
        //    }
        //    else if (numberOfPlayers == 2)
        //    {
        //        player1 = new Human();
        //        player2 = new Human();
        //    }
        //}

        //public void GetPlayerNames()
        //{
        //    Console.WriteLine("Player 1");
        //    Console.WriteLine("Player 2");
        //    Console.ReadLine();
        //}

        //public void PlayGame()
        //{
        //    Console.WriteLine();
        //    Console.ReadLine();
        //}

        public void ChooseGestures()
        {
            player1.MakeChoice();
            player2.MakeChoice();
            while (player1.choice == player2.choice)
            {

                Console.WriteLine("Result is a draw!");
                player1.MakeChoice();
                player2.MakeChoice();
            }
            if ((player1.choice == "scissors" && player2.choice == "paper") || (player1.choice == "paper" && player2.choice == "rock") || (player1.choice == "rock" && player2.choice == "lizard") ||
                 (player1.choice == "lizard" && player2.choice == "spock") || (player1.choice == "spock" && player2.choice == "scissors") || (player1.choice == "scissors" && player2.choice == "lizard") ||
                 (player1.choice == "lizard" && player2.choice == "paper") || (player1.choice == "paper" && player2.choice == "spock") || (player1.choice == "spock" && player2.choice == "rock") ||
                 (player1.choice == "rock" && player2.choice == "scissors"))
            {
                Console.WriteLine("Player 1 wins");
            }
            else
            {
                Console.WriteLine("Player 2 wins");
            }
            Console.WriteLine();
            Console.Clear();
            return;
        }

        public void DisplayResults()
        {
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }

        public void DetermineWinner()
        {
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }

        public void ReplayQuit()
        {
            Console.WriteLine("Game Over. Would you like to Replay?");
            Console.ReadLine();
            RunGame();
        }
    }
}
