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
        public int numberOfItemsBought;
        string option;
        Inventory inventory;
        Player player;


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
            numberOfItemsBought = 0;
            player = new Player();
            inventory = new Inventory();
            DisplayingStoreInfo();
        }

        //member methods

        public void DisplayingStoreInfo()
        {
            Console.WriteLine("This is the store, you will be brought here at the start of each day.");
            Console.WriteLine("If you wan to know the price of lemons, type 'lemons'");
            Console.WriteLine("If you want to know the price of cups, type 'cups'");
            Console.WriteLine("If you want to know the price of sugar, type 'sugar'");
            Console.WriteLine("If you want to know the price of ice cubes, type 'ice cubes'");
            SelectingTypeOfItem();


        }

        public void SelectingTypeOfItem()
        {
            option = Console.ReadLine();
            switch (option)
            {
                case "lemons":
                    Console.WriteLine("10 Lemons: " + priceOf10Lemons);
                    Console.WriteLine("30 Lemons: " + priceOf30Lemons);
                    Console.WriteLine("75 Lemons: " + priceOf75Lemons);
                    ChoosingLemons();
                    break;
                case "cups":
                    Console.WriteLine("25 cups: " + priceOf25Cups);
                    Console.WriteLine("50 cups: " + priceOf50Cups);
                    Console.WriteLine("100 cups: " + priceOf100Cups);
                    ChoosingCups();
                    break;
                case "sugar":
                    Console.WriteLine("8 Cubes of sugar: " + priceOf8CupsSugar);
                    Console.WriteLine("20 Cubes of sugar: " + priceOf20CupsSugar);
                    Console.WriteLine("48 Cubes of sugar: " + priceOf48CupsSugar);
                    ChoosingSugar();
                    break;
                case "ice cubes":
                    Console.WriteLine("100 ice cubes: " + priceOf100IceCubes);
                    Console.WriteLine("250 ice cubes: " + priceOf250IceCubes);
                    Console.WriteLine("500 ice cubes: " + priceOf500IceCubes);
                    ChoosingIceCubes();
                    break;
                default:
                    Console.WriteLine("Oops, you typed in something wrong, make sure nothing is capitalized.");
                    SelectingTypeOfItem();
                    break;
            }

        }
        public void ChoosingLemons()
        {
            Console.WriteLine("Type in the number of lemons you want to buy");
            option = Console.ReadLine();
            switch (option)
            {
                case "10":
                    Console.WriteLine("You bought 10 lemons.");
                    numberOfItemsBought = 10;
                    player.amountOfMoney -= priceOf10Lemons;
                    inventory.CapturingItemsForLemons();
                    buyingMore();
                    break;
                case "30":
                    Console.WriteLine("You bought 30 lemons.");
                    numberOfItemsBought = 30;
                    player.amountOfMoney -= priceOf30Lemons;
                    inventory.CapturingItemsForLemons();
                    buyingMore();
                    break;
                case "75":
                    Console.WriteLine("You bought 75 lemons.");
                    numberOfItemsBought = 75;
                    player.amountOfMoney -= priceOf75Lemons;
                    inventory.CapturingItemsForLemons();
                    buyingMore();
                    break;
                default:
                    Console.WriteLine("You typed in something wrong.");
                    ChoosingLemons();
                    break;


                
            }
        }

        public void ChoosingCups()
        {
            Console.WriteLine("Type in the number of cups you want to buy");
            option = Console.ReadLine();
            switch (option)
            {
                case "25":
                    Console.WriteLine("You bought 25 cups.");
                    numberOfItemsBought = 25;
                    player.amountOfMoney -= priceOf25Cups;
                    inventory.CapturingItemsForCups();
                    buyingMore();
                    break;
                case "50":
                    Console.WriteLine("You bought 50 cups.");
                    numberOfItemsBought = 50;
                    player.amountOfMoney -= priceOf50Cups;
                    inventory.CapturingItemsForCups();
                    buyingMore();
                    break;
                case "100":
                    Console.WriteLine("You bought 100 cups.");
                    numberOfItemsBought = 100;
                    player.amountOfMoney -= priceOf100Cups;
                    inventory.CapturingItemsForCups();
                    buyingMore();
                    break;
                default:
                    Console.WriteLine("You typed in something wrong.");
                    ChoosingCups();
                    break;
             }
        }

        public void ChoosingSugar()
        {
           Console.WriteLine("Type in the number of cups of sugar you want to buy");
            option = Console.ReadLine();
            switch (option)
            {
                case "8":
                    Console.WriteLine("You bought 8 cups of sugar.");
                    numberOfItemsBought = 8;
                    player.amountOfMoney -= priceOf8CupsSugar;
                    inventory.CapturingItemsForSugar();
                    buyingMore();
                    break;
                case "20":
                    Console.WriteLine("You bought 20 cups of sugar.");
                    numberOfItemsBought = 20;
                    player.amountOfMoney -= priceOf20CupsSugar;
                    inventory.CapturingItemsForSugar();
                    buyingMore();
                    break;
                case "48":
                    Console.WriteLine("You bought 48 cups of sugar.");
                    numberOfItemsBought = 48;
                    player.amountOfMoney -= priceOf48CupsSugar;
                    inventory.CapturingItemsForSugar();
                    buyingMore();
                    break;
                default:
                    Console.WriteLine("You typed in something wrong.");
                    ChoosingSugar();
                    break;
             }
        }

        public void ChoosingIceCubes()
        {
            Console.WriteLine("Type in the number of ice cubes you want to buy");
            option = Console.ReadLine();
            switch (option)
            {
                case "100":
                    Console.WriteLine("You bought 100 ice cubes.");
                    numberOfItemsBought = 10;
                    player.amountOfMoney -= priceOf100IceCubes;
                    inventory.CapturingItemsForIceCubes();
                    buyingMore();
                    break;
                case "250":
                    Console.WriteLine("You bought 250 ice cubes.");
                    numberOfItemsBought = 30;
                    player.amountOfMoney -= priceOf250IceCubes;
                    inventory.CapturingItemsForIceCubes();
                    buyingMore();
                    break;
                case "500":
                    Console.WriteLine("You bought 75 lemons.");
                    numberOfItemsBought = 75;
                    player.amountOfMoney -= priceOf500IceCubes;
                    inventory.CapturingItemsForIceCubes();
                    buyingMore();
                    break;
                default:
                    Console.WriteLine("You typed in something wrong.");
                    ChoosingIceCubes();
                    break;



            }
        }

        public void buyingMore()
        {
            Console.WriteLine("Do you want to buy more?");
            switch (option)
            {
                case "yes":
                    SelectingTypeOfItem();
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Oops, typed in something wrong.");
                    break;
                


            }
        }
    }
}

