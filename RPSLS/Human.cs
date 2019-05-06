using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human : Player
    {
        //member variables (Has a)
        //inherited from player


        //constructor
        public Human()
        {

        }



        //member methods (Can do)

        public void ChooseGesture()
        {
            Console.WriteLine("choose your gesture");
            string gesture = Console.ReadLine();
        }

        public override void MakeChoice()
        {
            Console.WriteLine("Pick one of these options: rock, paper, scissors, lizard, spock");
            choice = Console.ReadLine();
        }
    }
}
