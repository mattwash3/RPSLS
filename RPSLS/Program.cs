using System;

namespace RPSLS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gameplay game = new Gameplay();
            game.RunGame();
            Console.ReadLine();
        }
    }
}
