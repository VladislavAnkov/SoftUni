using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> products = new Dictionary<string, List<int>>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "buy")
            {
                string product = input[0];
                int price = int.Parse(input[1]);
                int quantity = int.Parse(input[2]);



                if (products.ContainsKey(product) == false)
                {
                    List<int> priceAndQuantity = new List<int> { price, quantity };

                    products.Add(product, priceAndQuantity);

                }
                else
                {
                    if (products.Values())
                    {

                    }
                }




                input = Console.ReadLine().Split();
            }
        }
    }
}
