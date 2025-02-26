using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public decimal TotalPrice()
        {
            return Price * Quantity;
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enther the product Count you want to add your shope card:");
            int countprod = int.Parse(Console.ReadLine());
            decimal totalrate = 0; 
            Product[] products = new Product[countprod];
            for (int i = 0; i < countprod; i++)
            {
                Console.WriteLine("Enther the product Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the product price");
                decimal price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enther the product quantity");
                int quantity = int.Parse(Console.ReadLine());
                products[i] = new Product(name, price, quantity);
                totalrate += products[i].TotalPrice();
            }
            if(countprod > 5)
            {
                totalrate = totalrate - (totalrate * 0.1m);
                Console.WriteLine("10% discount has been applied because you have more than 5 items");
            }
            Console.WriteLine("Finely Cost of your Cart is " + totalrate);
        }
    }
}
