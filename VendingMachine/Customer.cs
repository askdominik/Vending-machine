using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Customer
    {
        public int Balance = 0;

        public void showBalance()
        {
            Console.WriteLine("Your balance is: " + Balance);
        }

        public void showChange()
        {
            Console.WriteLine("Your change is: " + Balance);
        }

        public void increaseBalance(int coin)
        {
            Balance += coin;  
        }

        public void decreaseBalance(int productPrice)
        {
            Balance -= productPrice;
        }
    }
}
