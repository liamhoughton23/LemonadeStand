using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variable
        public double amountOfMoney;
        public int numberOfItemsBought;
        Day day;

        public Player()
        {
            day = new Day();
            numberOfItemsBought = 0;
        }
        
        public void Money()
        {
            amountOfMoney = 20.00;
            
        }

        //member methods
          
    }
}
