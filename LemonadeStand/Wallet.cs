using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
       

        public void ValidatingFunds(Player player, double amount)
        {
            if (player.amountOfMoney < amount)
            {
                Console.WriteLine("you don't have enough money to buy that.");
            }
            else
            {
                player.amountOfMoney -= amount;
                Console.WriteLine("You have this much money now: " + player.amountOfMoney);
            }
        }
    }
}
