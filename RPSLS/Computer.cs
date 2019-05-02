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
            name = null;
            choice = null;
            score = 0;
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

                    break;
                case 3:
                    Console.WriteLine("scissors");
                    break;
                case 4:
                    Console.WriteLine("lizard");
                    break;
                case 5:
                    Console.WriteLine("spock");
                    break;
            }
            
        }

    }
}
