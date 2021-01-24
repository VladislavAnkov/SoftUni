using System;
using System.Collections.Generic;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> foodSHops = new SortedDictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();

            while (input != "Revision")
            {
                var tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shopName = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!foodSHops.ContainsKey(shopName))
                {
                    foodSHops.Add(shopName, new Dictionary<string, double>());
                }

                foodSHops[shopName].Add(product, price);

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, double>> shop in foodSHops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (KeyValuePair<string, double> product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
