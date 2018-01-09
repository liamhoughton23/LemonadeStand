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
        int probabilityFirst;
        int probabilitySecond;
        int numberOfCustomers;
        int numberOfCustomersBuy;


        //constructor
        public Customer()
        {
            random = new Random();
        }

        public void CheckingPrice()
        {
            Recipe recipe = new Recipe();
            if (recipe.price < 0.50)
            {
                GettingCustomer();
            }
        }

        //member methods
        public void GettingCustomer()
        {
            probabilityFirst = random.Next(0, 100);
            probabilitySecond = random.Next(0, 100);
            if (probabilityFirst > probabilitySecond)
            {

                numberOfCustomers++;
                numberOfCustomersBuy++;
            }
            else
            {
                numberOfCustomers++; 
            }


        }
    }
}
