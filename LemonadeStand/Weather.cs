using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables
        public int tempature;
        public Random randTemp;
        public Random rand



        //constructor


        //member methods
        public int gettingTemp()
        {
            tempature = rand.Next(50, 105);
            return tempature;
        }



    }
}
