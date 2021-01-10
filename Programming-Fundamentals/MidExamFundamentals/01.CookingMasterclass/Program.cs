using System;

namespace _01.CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine()) * 10;
            double apronPrice = double.Parse(Console.ReadLine()) * Math.Ceiling(students * 1.20);
            double totalCost = 0.00;

            for (int i = 1; i <= students; i++)
            {
                totalCost += eggPrice;

                if (!(i % 5 == 0))
                {
                    totalCost += flourPrice;
                }
            }

            totalCost += apronPrice;

            if (budget - totalCost >= 0)
            {
                Console.WriteLine($"Items purchased for {totalCost:f2}$.");
            }
            else
            {
                double neededMoney = totalCost - budget;
                Console.WriteLine($"{neededMoney:f2}$ more needed.");

            }
        }

    }
}
