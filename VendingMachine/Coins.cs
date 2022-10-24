using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Coins
    {
        public string[] Type = new string[8] { "200", "100", "50", "20", "10", "5", "2", "1" };
        public int[] Quantity = new int[8] {100, 100, 100, 100, 100, 100, 100, 100 };

        public void increaseQuantity(int type)
        {
            Quantity[type]++;
        }
        public void decreaseQuantity(int type)
        {
            Quantity[type]--;
        }
    }
}
