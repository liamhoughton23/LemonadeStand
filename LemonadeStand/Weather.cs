using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LemonadeStand
{
    class Weather
    {
        //member variables
        public int temperature;
        public int forecast;
        Random randTemp;
        Random randForecast;
        //public int forecastNumber;
        //public string temp;
        //public string condition;



        //constructor




        //member methods
        public int gettingTemp()
        {
            randTemp = new Random();
            temperature = randTemp.Next(50, 105);
            Console.WriteLine("temperature: " + temperature);
            return temperature;
        }

        public void gettingForecast()
        {
            randForecast = new Random();
            forecast = randForecast.Next(0, 3);
            if (forecast == 0)
            {
                Console.WriteLine("Clear sky");
            }
            else if (forecast == 1)
            {
                Console.WriteLine("partly cloudy");
            }
            else if (forecast == 2)
            {
                Console.WriteLine("Overcast");
            }
            else
            {
                Console.WriteLine("Rain");
            }

        }

    }
}
