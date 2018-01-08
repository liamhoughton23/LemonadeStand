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
        public string priceOflemonade;

        //constructor


        //member methods
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.ReadLine();
            Console.WriteLine("The goal of the game is to make as much profit from selling lemonade as possible.");
            Console.WriteLine("The weather will affect how much people want lemonade, so price it accordingly. ");
            Console.ReadLine();
            Console.WriteLine("You start with $20.00");
            Store Store = new Store();
        }
        public string SettingPrice()
        {
            Console.WriteLine("What do you want your price to be?");
            priceOflemonade = Console.ReadLine();
            return priceOflemonade;

        }
    }
}
