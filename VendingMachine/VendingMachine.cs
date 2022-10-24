using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            Products products = new Products();
            Coins coins = new Coins();
            Customer customer = new Customer();

            displayMenu(products);
            Console.WriteLine("Insert money(Coins - 200,100,50,20,10,5,2,1): ");
            insertCoins(Convert.ToInt32(Console.ReadLine()), coins, customer);
            customer.showBalance();
            Console.WriteLine("Type product you want to purchase: ");
            productPurchace(Console.ReadLine(), customer, products);
            customer.showChange();
            changeCalculation(coins, customer);
        }

        public static void displayMenu(Products products)
        {
            Console.WriteLine("Welcome to Vending Machine!");
            for (int i = 1; i < products.Name.Length; i++)
            {
                Console.WriteLine(i + ". Product: " + products.Name[i] + " | Quantity: " + products.Quantity[i] + " | Price: " + products.Price[i]);
            }
        }

        public static void insertCoins(int coin, Coins coins, Customer customer)
        {
            switch (coin)
            {
                case 200:
                    coins.increaseQuantity(0);
                    customer.increaseBalance(coin);
                    break;
                case 100:
                    coins.increaseQuantity(1);
                    customer.increaseBalance(coin);
                    break;
                case 50:
                    coins.increaseQuantity(2);
                    customer.increaseBalance(coin);
                    break;
                case 20:
                    coins.increaseQuantity(3);
                    customer.increaseBalance(coin);
                    break;
                case 10:
                    coins.increaseQuantity(4);
                    customer.increaseBalance(coin);
                    break;
                case 5:
                    coins.increaseQuantity(5);
                    customer.increaseBalance(coin);
                    break;
                case 2:
                    coins.increaseQuantity(6);
                    customer.increaseBalance(coin);
                    break;
                case 1:
                    coins.increaseQuantity(7);
                    customer.increaseBalance(coin);
                    break;
                default:
                    Console.WriteLine("Invalid coin!");
                    Environment.Exit(0);
                    break;
            }
        }

        public static void productPurchace(string product, Customer customer, Products products)
        {
            switch (product)
            {
                case "Cola":
                    products.Purchase(0);
                    customer.decreaseBalance(products.Price[0]);
                    break;
                case "Sprite":
                    products.Purchase(1);
                    customer.decreaseBalance(products.Price[1]);
                    break;
                case "Fanta":
                    products.Purchase(2);
                    customer.decreaseBalance(products.Price[2]);
                    break;
                case "Dr.Pepper":
                    products.Purchase(3);
                    customer.decreaseBalance(products.Price[3]);
                    break;
                case "Water":
                    products.Purchase(4);
                    customer.decreaseBalance(products.Price[4]);
                    break;
                case "Red Bull":
                    products.Purchase(5);
                    customer.decreaseBalance(products.Price[5]);
                    break;
                default:
                    Console.WriteLine("Invalid product!");
                    break;
            }
        }

        public static void changeCalculation(Coins coins, Customer customer)
        {
            int count;
            for (int i = 0; i < coins.Type.Length; i++)
            {
                count = customer.Balance / Convert.ToInt32(coins.Type[i]);
                if (count != 0)
                {
                    coins.decreaseQuantity(i);
                    Console.WriteLine("Count of {0} cents : {1}", Convert.ToInt32(coins.Type[i]), count);
                }
                customer.Balance %= Convert.ToInt32(coins.Type[i]);
            }
        }
    }
}
