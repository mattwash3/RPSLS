﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human : Player
    {
        //member variables (Has a)

        //constructor
        public Human()
        {
            name = null;
            choice = null;
            score = 0;
        }

        //member methods (Can do)
        public void PlayerName()
        {
            Console.WriteLine("Enter player name");
            string name = Console.ReadLine();
        }

        public void ChooseMove()
        {
            Console.WriteLine("Choose your gesture");
            string gesture = Console.ReadLine();
        }

        public void PlayerScore()
        {
            if(gesture)
            {

            }
        }
    }
}