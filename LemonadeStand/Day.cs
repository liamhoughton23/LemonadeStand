﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        public int numberOfDays;
        


        //constructor
        public Day()
        {
            numberOfDays = 0;
            
        }

        //member methods
        public void GettingDay(Player player, Inventory inventory, Wallet wallet, Customer customer, Weather weather)
        {
            inventory = new Inventory();

            for (int i = 1; i <= 7; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("Day 1");
                    Store Store = new Store();
                    Store.DisplayingStoreInfo();
                    weather = new Weather();
                    weather.gettingTemp();
                    weather.gettingForecast();
                    Store.SelectingTypeOfItem(player, inventory, wallet);
                    Recipe recipe = new Recipe();
                    recipe.GettingPrice();
                    recipe.GettingLemonsPitcher(inventory, recipe);
                    recipe.GettingSugarPitcher(inventory, recipe);
                    recipe.GettingIcePerCup(inventory, recipe);
                    customer = new Customer();
                    customer.GettingInitialNumber();
                    customer.CheckingConditions(recipe, weather, inventory, player);
                    customer.DisplayInformation();
                    Console.WriteLine("You have: $" + player.amountOfMoney);
                    inventory.displayInventory();
                }
                else if (i == 2)
                {
                    Console.WriteLine("Day 2");
                    Store Store = new Store();
                    weather = new Weather();
                    weather.gettingTemp();
                    weather.gettingForecast();
                    Store.SelectingTypeOfItem(player, inventory, wallet);
                    Recipe recipe = new Recipe();
                    recipe.GettingPrice();
                    recipe.GettingLemonsPitcher(inventory, recipe);
                    recipe.GettingSugarPitcher(inventory, recipe);
                    recipe.GettingIcePerCup(inventory, recipe);
                    customer = new Customer();
                    customer.GettingInitialNumber();
                    customer.CheckingConditions(recipe, weather, inventory, player);
                    customer.DisplayInformation();
                    Console.WriteLine("You have: $" + player.amountOfMoney);
                    inventory.displayInventory();

                }
                else if (i == 3)
                {
                    Console.WriteLine("Day 3");
                    Store Store = new Store();
                    weather = new Weather();
                    weather.gettingTemp();
                    weather.gettingForecast();
                    Store.SelectingTypeOfItem(player, inventory, wallet);
                    Recipe recipe = new Recipe();
                    recipe.GettingPrice();
                    recipe.GettingLemonsPitcher(inventory, recipe);
                    recipe.GettingSugarPitcher(inventory, recipe);
                    recipe.GettingIcePerCup(inventory, recipe);
                    customer = new Customer();
                    customer.GettingInitialNumber();
                    customer.CheckingConditions(recipe, weather, inventory, player);
                    customer.DisplayInformation();
                    Console.WriteLine("You have: $" + player.amountOfMoney);
                    inventory.displayInventory();

                }
                else if (i== 4)
                {
                    Console.WriteLine("Day 4");
                    Store Store = new Store();
                    weather = new Weather();
                    weather.gettingTemp();
                    weather.gettingForecast();
                    Store.SelectingTypeOfItem(player, inventory, wallet);
                    Recipe recipe = new Recipe();
                    recipe.GettingPrice();
                    recipe.GettingLemonsPitcher(inventory, recipe);
                    recipe.GettingSugarPitcher(inventory, recipe);
                    recipe.GettingIcePerCup(inventory, recipe);
                    customer = new Customer();
                    customer.GettingInitialNumber();
                    customer.CheckingConditions(recipe, weather, inventory, player);
                    customer.DisplayInformation();
                    Console.WriteLine("You have: $" + player.amountOfMoney);
                    inventory.displayInventory();
                }
                else if (i == 5)
                {
                    Console.WriteLine("Day 5");
                    Store Store = new Store();
                    weather = new Weather();
                    weather.gettingTemp();
                    weather.gettingForecast();
                    Store.SelectingTypeOfItem(player, inventory, wallet);
                    Recipe recipe = new Recipe();
                    recipe.GettingPrice();
                    recipe.GettingLemonsPitcher(inventory, recipe);
                    recipe.GettingSugarPitcher(inventory, recipe);
                    recipe.GettingIcePerCup(inventory, recipe);
                    customer = new Customer();
                    customer.GettingInitialNumber();
                    customer.CheckingConditions(recipe, weather, inventory, player);
                    customer.DisplayInformation();
                    Console.WriteLine("You have: $" + player.amountOfMoney);
                    inventory.displayInventory();
                }
                else if (i == 6)
                {
                    Console.WriteLine("Day 6");
                    Store Store = new Store();
                    weather = new Weather();
                    weather.gettingTemp();
                    weather.gettingForecast();
                    Store.SelectingTypeOfItem(player, inventory, wallet);
                    Recipe recipe = new Recipe();
                    recipe.GettingPrice();
                    recipe.GettingLemonsPitcher(inventory, recipe);
                    recipe.GettingSugarPitcher(inventory, recipe);
                    recipe.GettingIcePerCup(inventory, recipe);
                    customer = new Customer();
                    customer.GettingInitialNumber();
                    customer.CheckingConditions(recipe, weather, inventory, player);
                    customer.DisplayInformation();
                    Console.WriteLine("You have: $" + player.amountOfMoney);
                    inventory.displayInventory();
                }
                else
                {
                    Console.WriteLine("Last Day!");
                    Store Store = new Store();
                    weather = new Weather();
                    weather.gettingTemp();
                    weather.gettingForecast();
                    Store.SelectingTypeOfItem(player, inventory, wallet);
                    Recipe recipe = new Recipe();
                    recipe.GettingPrice();
                    recipe.GettingLemonsPitcher(inventory, recipe);
                    recipe.GettingSugarPitcher(inventory, recipe);
                    recipe.GettingIcePerCup(inventory, recipe);
                    customer = new Customer();
                    customer.GettingInitialNumber();
                    customer.CheckingConditions(recipe, weather, inventory, player);
                    customer.DisplayInformation();
                    Console.WriteLine("You have: $" + player.amountOfMoney);
                    inventory.displayInventory();
                }
              

            }
        }
    }
}
