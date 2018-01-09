using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        public string numberOfLemonsPerPitcherInput;
        public string amountOfSugarPerPitcherInput;
        public int amountOfIcePerCup;
        public int numberOfLemonsPerPitcher;
        public int amountOfSugarPerPitcher;
        public string amountOfIcePerCupInput;
        public string priceInput;
        public double price;

        public void GettingPrice()
        {
            Console.WriteLine("What do you want the price of your lemonade to be set at?");
            priceInput = Console.ReadLine();
            try
            {
                price = Convert.ToDouble(priceInput);
            }
            catch
            {
                Console.WriteLine("you didnt't type in a number... try again.");
                GettingPrice();
            }
        }


        public void GettingLemonsPitcher(Inventory inventory, Recipe recipe)
        {
            Console.WriteLine("How many lemons do you want to have per pitcher?");
            numberOfLemonsPerPitcherInput = Console.ReadLine();
            try
            {
                numberOfLemonsPerPitcher = Convert.ToInt32(numberOfLemonsPerPitcherInput);
                inventory.CheckingInventoryLemons(inventory, recipe);
            }
            catch
            {
                Console.WriteLine("You didnt type in a number. try again");
                GettingLemonsPitcher(inventory, recipe);
            }

        }

        public void GettingSugarPitcher(Inventory inventory, Recipe recipe)
        {
            Console.WriteLine("How many cubes of sugar do you want to have per pitcher?");
            amountOfSugarPerPitcherInput = Console.ReadLine();
           try
            {
                amountOfSugarPerPitcher = Convert.ToInt32(amountOfSugarPerPitcher);
                inventory.CheckingInventorySugar(inventory, recipe);
            }
            catch
            {
                Console.WriteLine("You didnt type in a number. try again");
                GettingSugarPitcher(inventory, recipe);
            }

   
        }

        public void GettingIcePerCup(Inventory inventory, Recipe recipe)
        {
            Console.WriteLine("How many cubes of sugar do you want to have per pitcher?");
            amountOfIcePerCupInput = Console.ReadLine();
            try
            {
                amountOfIcePerCup = Convert.ToInt32(amountOfIcePerCupInput);
                inventory.CheckingInventoryIceCubes(inventory, recipe);
            }
            catch
            {
                Console.WriteLine("You didnt type in a number. try again");
                GettingIcePerCup(inventory, recipe);
            }


        }
     
    }
}
