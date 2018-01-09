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
        //public int temperature;
        //public string forecast;
        //public Random randTemp;
        // public Random randForecast;
        string temp;
        string condition;



        //constructor

        public String GetWeather()
        {
            String query = String.Format("https://query.yahooapis.com/v1/public/yql?q=select * from weather.forecast where woeid in (select woeid from geo.places(1) where text='miami, fl')&format=xml&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys");
            XmlDocument wData = new XmlDocument();
            wData.Load(query);

            XmlNamespaceManager manager = new XmlNamespaceManager(wData.NameTable);
            manager.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");

            XmlNode channel = wData.SelectSingleNode("query").SelectSingleNode("results").SelectSingleNode("channel");
            XmlNodeList nodes = wData.SelectNodes("query/results/channel");
            //try
            //{
                temp = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["temp"].Value;
                condition = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["text"].Value;
                Console.WriteLine(temp);
                Console.WriteLine(condition);
                Console.ReadLine();
            //}
            //catch
            //{
               // return "Error Reciving data";
            //}
            return "error";
           
        }




        //member methods
        //public int gettingTemp()
        //{
        // temperature = randTemp.Next(50, 105);
        // return temperature;
        //}

        //public string gettingForecast()
        //{

        //}

    }
}
