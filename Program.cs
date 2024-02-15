using System;
using rpg_game_in_c_.src.Entities;

namespace rpg_game_in_c_
{
    class Program
    {
        static void Main(string[] args)
        {
          Knight arus = new Knight("Arus", 23, "Knight");
          Wizard wizard = new Wizard("Jenica", 23, "White Wizard");

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}

