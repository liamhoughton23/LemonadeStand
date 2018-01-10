using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store 
    {
        //member variables
        public double priceOf10Lemons;
        public double priceOf30Lemons;
        public double priceOf75Lemons;
        public double priceOf25Cups;
        public double priceOf50Cups;
        public double priceOf100Cups;
        public double priceOf8CupsSugar;
        public double priceOf20CupsSugar;
        public double priceOf48CupsSugar;
        public double priceOf100IceCubes;
        public double priceOf250IceCubes;
        public double priceOf500IceCubes;
        public double cost;
        string option;
       

        //constructor
        public Store()
        {
            priceOf10Lemons = 0.98;
            priceOf30Lemons = 2.23;
            priceOf75Lemons = 4.12;
            priceOf25Cups = 0.96;
            priceOf50Cups = 1.70;
            priceOf100Cups = 3.04;
            priceOf8CupsSugar = 0.50;
            priceOf20CupsSugar = 1.59;
            priceOf48CupsSugar = 3.42;
            priceOf100IceCubes = 0.96;
            priceOf250IceCubes = 2.07;
            priceOf500IceCubes = 3.91;
            
            
        }

        //member methods

        public void DisplayingStoreInfo()
        {
            Console.WriteLine("This is the store, you will be brought here at the start of each day.");
            Console.WriteLine("If you wan to know the price of lemons, type 'lemons'");
            Console.WriteLine("If you want to know the price of cups, type 'cups'");
            Console.WriteLine("If you want to know the price of sugar, type 'sugar'");
            Console.WriteLine("If you want to know the price of ice cubes, type 'ice cubes'");
            


        }

        public void SelectingTypeOfItem(Player player, Inventory inventory, Wallet wallet)
        {
            option = Console.ReadLine();
            switch (option)
            {
                case "lemons":
                    Console.WriteLine("10 Lemons: " + priceOf10Lemons);
                    Console.WriteLine("30 Lemons: " + priceOf30Lemons);
                    Console.WriteLine("75 Lemons: " + priceOf75Lemons);
                    ChoosingLemons(player, inventory, wallet);
                    break;
                case "cups":
                    Console.WriteLine("25 cups: " + priceOf25Cups);
                    Console.WriteLine("50 cups: " + priceOf50Cups);
                    Console.WriteLine("100 cups: " + priceOf100Cups);
                    ChoosingCups(player, inventory, wallet);
                    break;
                case "sugar":
                    Console.WriteLine("8 Cubes of sugar: " + priceOf8CupsSugar);
                    Console.WriteLine("20 Cubes of sugar: " + priceOf20CupsSugar);
                    Console.WriteLine("48 Cubes of sugar: " + priceOf48CupsSugar);
                    ChoosingSugar(player, inventory, wallet);
                    break;
                case "ice cubes":
                    Console.WriteLine("100 ice cubes: " + priceOf100IceCubes);
                    Console.WriteLine("250 ice cubes: " + priceOf250IceCubes);
                    Console.WriteLine("500 ice cubes: " + priceOf500IceCubes);
                    ChoosingIceCubes(player, inventory, wallet);
                    break;
                default:
                    Console.WriteLine("Oops, you typed in something wrong, make sure nothing is capitalized.");
                    SelectingTypeOfItem(player, inventory, wallet);
                    break;
            }

        }
        public void ChoosingLemons(Player player, Inventory inventory, Wallet wallet)
        {

            Console.WriteLine("Type in the number of lemons you want to buy");
            option = Console.ReadLine();
            switch (option)
            {
                case "10":
                    Console.WriteLine("You bought 10 lemons.");
                    player.numberOfItemsBought = 10;
                    cost = priceOf10Lemons;
                    wallet.ValidatingFunds(player, cost);
                    inventory.AddingLemons(player);
                    buyingMore(player, inventory, wallet);
                    break;
                case "30":
                    Console.WriteLine("You bought 30 lemons.");
                    player.numberOfItemsBought = 30;
                    cost = priceOf30Lemons;
                    wallet.ValidatingFunds(player, cost);
                    inventory.AddingLemons(player);
                    buyingMore(player, inventory, wallet);
                    break;
                case "75":
                    Console.WriteLine("You bought 75 lemons.");
                    player.numberOfItemsBought = 75;
                    cost = priceOf75Lemons;
                    wallet.ValidatingFunds(player, cost);
                    inventory.AddingLemons(player);
                    buyingMore(player, inventory, wallet);
                    break;
                default:
                    Console.WriteLine("You typed in something wrong.");
                    ChoosingLemons(player, inventory, wallet);
                    break;


                
            }
        }

        public void ChoosingCups(Player player, Inventory inventory, Wallet wallet)
        {
            Console.WriteLine("Type in the number of cups you want to buy");
            option = Console.ReadLine();
            switch (option)
            {
                case "25":
                    Console.WriteLine("You bought 25 cups.");
                    player.numberOfItemsBought = 25;
                    cost = priceOf25Cups;
                    wallet.ValidatingFunds(player, cost);
                    inventory.AddingCups(player);
                    buyingMore(player, inventory, wallet);
                    break;
                case "50":
                    Console.WriteLine("You bought 50 cups.");
                    player.numberOfItemsBought = 50;
                    cost = priceOf50Cups;
                    wallet.ValidatingFunds(player, cost);
                    inventory.AddingCups(player);
                    buyingMore(player, inventory, wallet);
                    break;
                case "100":
                    Console.WriteLine("You bought 100 cups.");
                    player.numberOfItemsBought = 100;
                    cost = priceOf100Cups;
                    wallet.ValidatingFunds(player, cost);
                    inventory.AddingCups(player);
                    buyingMore(player, inventory, wallet);
                    break;
                default:
                    Console.WriteLine("You typed in something wrong.");
                    ChoosingCups(player, inventory, wallet);
                    break;
             }
        }

        public void ChoosingSugar(Player player, Inventory inventory, Wallet wallet)
        {
            Console.WriteLine("Type in the number of cups of sugar you want to buy");
            option = Console.ReadLine();
            switch (option)
            {
                case "8":
                    Console.WriteLine("You bought 8 cups of sugar.");
                    player.numberOfItemsBought = 8;
                    cost = priceOf8CupsSugar;
                    wallet.ValidatingFunds(player, cost);
                    inventory.AddingSugar(player);
                    buyingMore(player, inventory, wallet);
                    break;
                case "20":
                    Console.WriteLine("You bought 20 cups of sugar.");
                    player.numberOfItemsBought = 20;
                    cost = priceOf20CupsSugar;
                    wallet.ValidatingFunds(player, cost);
                    inventory.AddingSugar(player);
                    buyingMore(player, inventory, wallet);
                    break;
                case "48":
                    Console.WriteLine("You bought 48 cups of sugar.");
                    player.numberOfItemsBought = 48;
                    cost = priceOf48CupsSugar;
                    wallet.ValidatingFunds(player, cost);
                    inventory.AddingSugar(player);
                    buyingMore(player, inventory, wallet);
                    break;
                default:
                    Console.WriteLine("You typed in something wrong.");
                    ChoosingSugar(player, inventory, wallet);
                    break;
             }
        }

        public void ChoosingIceCubes(Player player, Inventory inventory, Wallet wallet)
        {
            Console.WriteLine("Type in the number of ice cubes you want to buy");
            option = Console.ReadLine();
            switch (option)
            {
                case "100":
                    Console.WriteLine("You bought 100 ice cubes.");
                    player.numberOfItemsBought = 100;
                    cost = priceOf100IceCubes;
                    wallet.ValidatingFunds(player, cost);
                    inventory.AddingIceCubes(player);
                    buyingMore(player, inventory, wallet);
                    break;
                case "250":
                    Console.WriteLine("You bought 250 ice cubes.");
                    player.numberOfItemsBought = 250;
                    cost = priceOf250IceCubes;
                    wallet.ValidatingFunds(player, cost);
                    inventory.AddingIceCubes(player);
                    buyingMore(player, inventory, wallet); 
                    break;
                case "500":
                    Console.WriteLine("You bought 500 ice cubes.");
                    player.numberOfItemsBought = 500;
                    cost = priceOf500IceCubes;
                    wallet.ValidatingFunds(player, cost);
                    inventory.AddingIceCubes(player);
                    buyingMore(player, inventory, wallet);
                    break;
                default:
                    Console.WriteLine("You typed in something wrong.");
                    ChoosingIceCubes(player, inventory, wallet);
                    break;



            }
        }

        public void buyingMore(Player player, Inventory inventory, Wallet wallet)
        {

            Console.WriteLine("Do you want to buy more?");
            option = Console.ReadLine();
            switch (option)
            {
                case "yes":
                    SelectingTypeOfItem(player, inventory, wallet);
                    break;
                case "no":
                    Console.WriteLine("Total inventory:");
                    inventory.displayInventory();
                    break;
                default:
                    Console.WriteLine("Oops, typed in something wrong.");
                    SelectingTypeOfItem(player, inventory, wallet);
                    break;
                


            }
        }
    }
}

