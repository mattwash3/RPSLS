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
        public int result;
        public int numbers;

        //constructor
        public Gameplay()
        {
            player1 = new Human();
        }

        //member methods (Can do)
        public void RunGame()
        {
            GameStart();
            SetupPlayers();
            ChooseGestures();
            DisplayResults();
            ReplayQuit();
        }


        public void GameStart()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! Here are the rules: Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, and as it always has Rock crushes Scissors. Got it?");
            Console.ReadLine();
            Console.Clear();
        }

        public int SetupPlayers()
        { 
            Console.WriteLine("How many players? 1 or 2");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            int result = numberOfPlayers;
            int[] numbers = { 1, 2 };
            if (numberOfPlayers == 1)
            {
                player1 = new Human();
                Console.WriteLine("Player 1");
                player2 = new Computer();
                Console.Clear();
            }
            else if (numberOfPlayers == 2)
            {
                player1 = new Human();
                Console.WriteLine("Player 1");
                player2 = new Human();
                Console.WriteLine("Player 2");
                Console.Clear();
            }
            try
            {
                result = numberOfPlayers;
                Console.WriteLine("Number of players is" + " " + result);
                Console.ReadLine();
                Console.Clear();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Incorrect value. Number must be either 1 or 2" + (numbers.Length));
                Console.ReadLine();
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter either 1 or 2");
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
            }
            finally
            {
                Console.Clear();
            }
            return result;
        }

        public void ChooseGestures()
        {
            player1.MakeChoice();
            Console.Clear();
            player2.MakeChoice();
            Console.Clear();
            while (player1.choice == player2.choice)
            {
                Console.WriteLine("Result is a draw!");
                Console.ReadLine();
                Console.Clear();
                player1.MakeChoice();
                Console.Clear();
                player2.MakeChoice();
                Console.Clear();
            }
            while (player1.score <= 3 && player2.score <= 3)
            {
                if ((player1.choice == "scissors" && player2.choice == "paper") || (player1.choice == "paper" && player2.choice == "rock") || (player1.choice == "rock" && player2.choice == "lizard") ||
                 (player1.choice == "lizard" && player2.choice == "spock") || (player1.choice == "spock" && player2.choice == "scissors") || (player1.choice == "scissors" && player2.choice == "lizard") ||
                 (player1.choice == "lizard" && player2.choice == "paper") || (player1.choice == "paper" && player2.choice == "spock") || (player1.choice == "spock" && player2.choice == "rock") ||
                 (player1.choice == "rock" && player2.choice == "scissors"))
                {
                    Console.WriteLine("Player 1 wins");
                    player1.score++;
                }
                else
                {
                    Console.WriteLine("Player 2 wins");
                    player2.score++;
                }
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
                return;
            }
        }

        public void DisplayResults()
        {
            Console.WriteLine($" Player 1 {player1.name} = {player1.score}");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($" Player 2 {player2.name} = {player2.score}");
            Console.ReadLine();
            Console.Clear();
            ChooseGestures();
        }

        public void ReplayQuit()
        {
            Console.WriteLine("Game Over. Would you like to Replay?");
            Console.ReadLine();
            Console.Clear();
            RunGame();
        }
    }
}
