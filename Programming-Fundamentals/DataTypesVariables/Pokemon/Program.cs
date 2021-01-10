using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int initialPower = pokePower;
            int targetsPoked = 0;

            while (pokePower >= distance)
            {
                if (pokePower == (initialPower / 2))
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                        continue;
                    }
                }

                pokePower -= distance;
                targetsPoked++;

            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetsPoked);
        }
    }
}
