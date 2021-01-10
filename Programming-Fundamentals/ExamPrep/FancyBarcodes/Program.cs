using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBarcodes = int.Parse(Console.ReadLine());

            string pattern = @"@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+";
            string numPattern = @"\d";

            Regex barcodeRegex = new Regex(pattern);
            Regex numRegex = new Regex(numPattern);

            for (int i = 0; i < numberOfBarcodes; i++)
            {
                string barcode = Console.ReadLine();

                Match match = barcodeRegex.Match(barcode);

                if (match.Success)
                {
                    string productGroup = string.Empty;

                    MatchCollection numbers = numRegex.Matches(barcode);

                    foreach (Match number in numbers)
                    {
                        productGroup += number;
                    }

                    if (productGroup != "")
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
