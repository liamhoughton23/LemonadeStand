using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables
        Player player;
        Day day;



        //constructor
        public Game()
        {
            DisplayRules();
            player = new Player();
            
        }

        //member methods
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.ReadLine();
            Console.WriteLine("The goal of the game is to make as much profit from selling lemonade as possible.");
            Console.WriteLine("The weather will affect how much people want lemonade, so price it accordingly. ");
            Console.ReadLine();
            Console.WriteLine("You start with $20.00");
            
        }
      

        
    }
}
