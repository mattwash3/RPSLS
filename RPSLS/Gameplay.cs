using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Gameplay
    {
        //member variables (Has a)
        public List<string> gestures;
        Player player1;
        Player player2;

        //constructor
        public Gameplay()
        {

        }

        //member methods (Can do)
        public int GetNumberOfPlayers()
        {
            Console.WriteLine("How many players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }

        public void SetUpPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
            else if (numberOfPlayers == 1)
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
