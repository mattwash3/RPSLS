using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Computer : Player
    {
        //member variables (Has a)


        //constructor
        public Computer()
        {
        }

        //member methods (Can do)
        public void PickGesture()
        {
            int randomNumber = 0;
            // how to generate random number
            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("rock");
                    choice = "rock";
                    break;
                case 2:
                    Console.WriteLine("paper");
                    choice = "paper";
                    break;
                case 3:
                    Console.WriteLine("scissors");
                    choice = "scissors";
                    break;
                case 4:
                    Console.WriteLine("lizard");
                    choice = "lizard";
                    break;
                case 5:
                    Console.WriteLine("spock");
                    choice = "spock";
                    break;
            }
            
        }

        public override void MakeChoice()
        {
            Console.WriteLine();
        }

    }
}
