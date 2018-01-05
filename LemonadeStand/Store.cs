using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store : Player
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
            buyingItems();
        }

        //member methods

        public void displayingStoreInfo()
        {
            Console.WriteLine("This is the store, you will be brought here at the start of each day.");
            Console.WriteLine("If you wan to know the price of lemons, type 'lemons'");
            Console.WriteLine("If you want to know the price of cups, type 'cups'");
            Console.WriteLine("If you want to know the price of sugar, type 'sugar'");
            Console.WriteLine("If you want to know the price of ice cubes, type 'ice cubes'");
            
        }

        public double buyingItems()
        {
            switch ()
            {
                case "lemons":
                    Console.WriteLine("10 Lemons: " + priceOf10Lemons);
                    Console.WriteLine("30 Lemons: " + priceOf30Lemons);
                    Console.WriteLine("75 Lemons: " + priceOf75Lemons);
                    break;
                case "cups":
                    Console.WriteLine("25 cups: " + priceOf25Cups);
                    Console.WriteLine("50 cups: " + priceOf50Cups);
                    Console.WriteLine("100 cups: " + priceOf100Cups);
                    break;
                case "sugar":
                    Console.WriteLine("8 Cubes of sugar: " + priceOf8CupsSugar);
                    Console.WriteLine("20 Cubes of sugar: " + priceOf20CupsSugar);
                    Console.WriteLine("48 Cubes of sugar: " + priceOf48CupsSugar);
                    break;
                case "ice cubes":
                    Console.WriteLine("100 ice cubes: " + priceOf100IceCubes);
                    Console.WriteLine("250 ice cubes: " + priceOf250IceCubes);
                    Console.WriteLine("500 ice cubes: " + priceOf500IceCubes);
                    break;
                default:
                    Console.WriteLine("Oops, you typed in something wrong, make sure nothing is capitalized.");
                    break;
            }
    }
}
