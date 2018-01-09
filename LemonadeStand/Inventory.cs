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
        //Player player;
        List<int> storingLemons = new List<int>();
        List<int> storingCups = new List<int>();
        List<int> storingSugar = new List<int>();
        List<int> storingIceCubes = new List<int>();

        //constructor
        public Inventory()
        {
            //player = new Player();
        }
        //member methods
        public void CapturingItemsForLemons(Player player)
        {
            for (int i = 0; i < player.numberOfItemsBought; i++)
            {
                Lemons Lemons = new Lemons();
                storingLemons.Add(1);
            }
        }
        public void CapturingItemsForCups(Player player)
        {
            for (int i = 0; i < player.numberOfItemsBought; i++)
            {
                Cups Cups = new Cups();
                storingCups.Add(1);
            }
        }

        public void CapturingItemsForSugar(Player player)
        {
            for (int i = 0; i < player.numberOfItemsBought; i++)
            {
                Sugar Sugar = new Sugar();
                storingSugar.Add(1);

            }
        }

        public void CapturingItemsForIceCubes(Player player)
        {
            for (int i = 0; i < player.numberOfItemsBought; i++)
            {
                IceCubes IceCubes = new IceCubes();
                storingIceCubes.Add(1);
            }
        }

    }
}
