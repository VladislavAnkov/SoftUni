using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBar
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.?\d*)\$";

            double totalSum = 0;

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            while (input != "end of shift")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double customerTotal = count * price;
                    totalSum += customerTotal;

                    Console.WriteLine($"{match.Groups["customer"]}: {match.Groups["product"]} - {customerTotal:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalSum:f2}");

        }
    }
}
