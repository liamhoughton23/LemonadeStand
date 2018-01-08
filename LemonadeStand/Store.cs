using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store : Inventory
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
                    //numberOfLemons + 10;
                    //amountOfMoney - priceOf10Lemons;
                    break;
                case "30":
                    Console.WriteLine("You bought 30 lemons.");
                    //numberOfLemons + 30;
                    //amountOfMoney - priceOf30Lemons;
                    break;
                case "75":
                    Console.WriteLine("You bought 75 lemons.");
                    //numberOfLemons + 75;
                    //amountOfMoney - priceOf75Lemons;
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
                    //numberOfCups + 25;
                    //amountOfMoney - priceOf25Cups;
                    break;
                case "50":
                    Console.WriteLine("You bought 50 cups.");
                    //numberOfCups + 50;
                    //amountOfMoney - priceOf50Cups; 
                    break;
                case "100":
                    Console.WriteLine("You bought 100 cups.");
                    //numberOfCups + 100;
                    //amountOfMoney - priceOf100Cups;
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
                    //numberOfSugar + 8;
                    //amountOfMoney - priceOf8CupsSugar;

                    break;
                case "20":
                    Console.WriteLine("You bought 20 cups of sugar.");
                   // numberOfSugar + 20;
                    //amountOfMoney - priceOf20CupsSugar;
                    break;
                case "48":
                    Console.WriteLine("You bought 48 cups of sugar.");
                    //numberOfSugar + 48;
                    //amountOfMoney - priceOf48CupsSugar;
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
                    //numberOfLemons + 10;
                    //amountOfMoney - priceOf100IceCubes;
                    break;
                case "250":
                    Console.WriteLine("You bought 250 ice cubes.");
                   // numberOfLemons + 30;
                    //amountOfMoney - priceOf250IceCubes;
                    break;
                case "500":
                    Console.WriteLine("You bought 75 lemons.");
                    //numberOfLemons + 75;
                    //amountOfMoney - priceOf500IceCubes;
                    break;
                default:
                    Console.WriteLine("You typed in something wrong.");
                    ChoosingIceCubes();
                    break;



            }
        }

    }
}

