using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxValue = double.MinValue;
            string biggestKeg = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > maxValue)
                {
                    maxValue = volume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
