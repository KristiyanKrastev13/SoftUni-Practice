using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shopAndProducts = new SortedDictionary<string, Dictionary<string, double>>();
            string command = Console.ReadLine();
            
            
            while (command != "Revision")
            {
                string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);
                if (!shopAndProducts.ContainsKey(shop))
                {
                    shopAndProducts.Add(shop, new Dictionary<string, double>());
                    shopAndProducts[shop].Add(product, price);
                }
                else
                {
                    shopAndProducts[shop].Add(product, price);
                }
                command = Console.ReadLine();
            }
            

            foreach (var item in shopAndProducts)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var products in item.Value)
                {
                    Console.WriteLine($"Product: {products.Key}, Price: {products.Value}");
                    
                }
            }
        }
    }
}
