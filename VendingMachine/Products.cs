using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Products
    {
        public string[] Name = new string[6] { "Cola", "Sprite", "Fanta", "Dr.Pepper", "Water", "Red Bull"};
        public int[] Price = new int[6] { 165, 165, 165, 165, 99, 198 };
        public int[] Quantity = new int[6] { 20, 20, 20, 20, 20, 20 };

        public void Purchase(int product)
        {
            Quantity[product]--;
        }
    }
}
