using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 1 - Create a Product Class

namespace Lecture7
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

        public decimal CalculateTotalCost()
        {
            return Price * Quantity;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Total Cost: {CalculateTotalCost()}");
        }
    }

    public class Task1
    {
        public void Run()
        {
            Console.WriteLine("Dynamic Product Creation:");

            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            decimal price;
            while (true)
            {
                Console.Write("Enter product price: ");
                if (decimal.TryParse(Console.ReadLine(), out price) && price >= 0)
                    break;
                Console.WriteLine("Invalid input. Please enter a non-negative decimal value for the price.");
            }

            int quantity;
            while (true)
            {
                Console.Write("Enter product quantity: ");
                if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 0)
                    break;
                Console.WriteLine("Invalid input. Please enter a non-negative integer value for the quantity.");
            }

            Product userProduct = new Product(name, price, quantity);

            Console.WriteLine("\nProduct Details:");
            userProduct.DisplayProductInfo();
        }
    }
}
