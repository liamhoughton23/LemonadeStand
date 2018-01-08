using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory 
    {
        //member variables
        Store store;
        List<int> storingLemons = new List<int>();
        List<int> storingCups = new List<int>();
        List<int> storingSugar = new List<int>();
        List<int> storingIceCubes = new List<int>();

        //constructor
        public Inventory()
        {
            store = new Store();
        }
        //member methods
        public void CapturingItemsForLemons()
        {
            for (int i = 0; i < store.numberOfItemsBought; i++)
            {
                Lemons Lemons = new Lemons();
                storingLemons.Add(1);
            }
        }
        public void CapturingItemsForCups()
        {
            for (int i = 0; i < store.numberOfItemsBought; i++)
            {
                Cups Cups = new Cups();
                storingCups.Add(1);
            }
        }

        public void CapturingItemsForSugar()
        {
            for (int i = 0; i < store.numberOfItemsBought; i++)
            {
                Sugar Sugar = new Sugar();
                storingSugar.Add(1);

            }
        }

        public void CapturingItemsForIceCubes()
        {
            for (int i = 0; i < store.numberOfItemsBought; i++)
            {
                IceCubes IceCubes = new IceCubes();
                storingIceCubes.Add(1);
            }
        }

    }
}
