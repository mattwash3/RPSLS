using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Computer : Player
    {
        //member variables (Has a)
        Random random = new Random();


        //constructor
        public Computer()
        {

        }

        //member methods (Can do)
        public int RandomNumber()
        {
            int i;
            i = random.Next(0, 4);
            return i;
        }

        public void ChooseGesture()
        {
            int randomNumber = RandomNumber();
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
            ChooseGesture();
        }

    }
}
