using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        Random random;
        int numberOfCustomersBuy;
        public int customerNumber;


        //constructor
        public Customer()
        {
            
           
        }

        public int GettingInitialNumber()
        {
            random = new Random();
            customerNumber = random.Next(0, 20);
            return customerNumber;
        }

        public void CheckingConditions(Recipe recipe, Weather weather, Inventory inventory, Player player)
        {
            for (int i = 0; i < 100; i++)
            {
                if (recipe.price <= 0.10)
                {
                    customerNumber += 8;
                }
                else if (recipe.price > 0.10 && recipe.price <= 0.25)
                {
                    customerNumber += 6;
                }
                else if (recipe.price > 0.25 && recipe.price <= 0.50)
                {
                    customerNumber -= 6;
                }
                else if (recipe.price > 0.50)
                {
                    customerNumber -= 8;
                }
                if (weather.temperature >= 90)
                {
                    customerNumber += 8;
                }
                else if (weather.temperature >= 80 && weather.temperature < 90)
                {
                    customerNumber += 6;
                }
                else if (weather.temperature >= 70 && weather.temperature < 80)
                {
                    customerNumber += 4;
                }
                else if (weather.temperature >= 60 && weather.temperature < 70)
                {
                    customerNumber -= 4;
                }
                else
                {
                    customerNumber -= 6;
                }
                if (weather.forecast == 0)
                {
                    customerNumber += 6;
                }
                else if (weather.forecast == 1)
                {
                    customerNumber += 4;
                }
                else if (weather.forecast == 2)
                {
                    customerNumber -= 4;
                }
                else
                {
                    customerNumber -= 8;
                }
                CheckingtoBuy(inventory, recipe, player);
                GettingInitialNumber();
            }
        }
            
        public void CheckingtoBuy(Inventory inventory, Recipe recipe, Player player)
        {
            if (customerNumber >= 20)
            {
                numberOfCustomersBuy++;
                inventory.CheckingInventoryCups(recipe);
                inventory.RemoveIceCubes(recipe);
                player.amountOfMoney += recipe.price;
            }
        }
        public void DisplayInformation()
        {
            Console.WriteLine(numberOfCustomersBuy + " Customers out of 100 bought your lemonade.");
        }

    }
}