using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0.0;

            while (input != "Start")
            {
                double coin = double.Parse(input);

                if ((coin != 0.1) && (coin != 0.2) &&
                    (coin != 0.5) && (coin != 1.0) &&
                    (coin != 2.0))
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                else
                {
                    sum += coin;
                }

                input = Console.ReadLine();
            }

            string product = Console.ReadLine();
            double price = 0.0;
            //“Nuts”, “Water”, “Crisps”, “Soda”, “Coke”

            while (product != "End")
            {
                bool invalid = false;
                switch (product)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1.0;
                        break;
                    default:
                        invalid = true;
                        Console.WriteLine("Invalid product");
                        break;
                }

                if (sum >= price && !invalid)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    sum -= price;
                }
                else if (sum < price && !invalid)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                
                product = Console.ReadLine();
            }            
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
