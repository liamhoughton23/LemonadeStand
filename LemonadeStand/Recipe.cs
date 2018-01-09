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
        public string amountOfSugarPerPitcher;
        public string amountOfIcePerCup;
        public int numberOfLemonsPerPitcher;



        public void GettingLemonsPitcher(Inventory inventory, Recipe recipe)
        {
            Console.WriteLine("How many lemons do you want to have per pitcher?");
            numberOfLemonsPerPitcherInput = Console.ReadLine();
            try
            {
                numberOfLemonsPerPitcher = Convert.ToInt32(numberOfLemonsPerPitcherInput);
                inventory.CheckingInventory(recipe);
            }
            catch
            {
                Console.WriteLine("You didnt type in a number. try again");
                GettingLemonsPitcher(inventory, recipe);
            }

        }

        public void GettingSugarPitcher()
        {
            Console.WriteLine("How many cubes of sugar do you want to have per pitcher?");
            amountOfSugarPerPitcher = Console.ReadLine();
           try
            {
                Convert.ToInt32(amountOfSugarPerPitcher);

            }
            catch
            {
                Console.WriteLine("You didnt type in a number. try again");
                GettingSugarPitcher();
            }

   
        }

        public void GettingIcePerCup()
        {
            Console.WriteLine("How many cubes of sugar do you want to have per pitcher?");
            amountOfIcePerCup = Console.ReadLine();
            try
            {
                Convert.ToInt32(amountOfIcePerCup);

            }
            catch
            {
                Console.WriteLine("You didnt type in a number. try again");
                GettingSugarPitcher();
            }


        }
    }
}
