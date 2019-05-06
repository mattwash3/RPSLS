using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables (Has a)
        List<string> gesture = new List<string>();
        public string name;
        public string choice;
        public int score;


        //constructor
        public Player()
        {
            score = 0;
            gesture.Add("rock");
            gesture.Add("paper");
            gesture.Add("scissors");
            gesture.Add("lizard");
            gesture.Add("spock");
        }

        //member methods (Can do)
        public abstract void MakeChoice();

        public void ChooseGesture()
        {
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
