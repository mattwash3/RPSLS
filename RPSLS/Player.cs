using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables (Has a)
        public string name;
        public string choice;
        public int score;

        //constructor
        public Player()
        {

        }

        //member methods (Can do)
        public abstract void MakeChoice();

        public void SetUpPlayer()
        {
            Console.WriteLine("Enter your player name");
            name = Console.ReadLine();
        }

    }
}
