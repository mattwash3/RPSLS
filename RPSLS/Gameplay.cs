using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Gameplay
    {
        //member variables (Has a)
        string player;
        string player1;
        string player2;

        //constructor
        public Gameplay()
        {
            player = player1;
            player = player2;
        }

        //member methods (Can do)
        public int GetNumberOfPlayers()
        {
            Console.WriteLine("How many players?");
            int numberOfPlayers = int.Parse(Console.ReadLine);
            return numberOfPlayers;
        }

        public void SetupPlayers(int numberOfPlayers)
        {
            if(numberOfPlayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
            else if(numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new Computer();
            }
        }

        public void ChooseGestures()
        {
            player1.MakeChoice();
            player2.MakeChoice();
        }
    }
}
