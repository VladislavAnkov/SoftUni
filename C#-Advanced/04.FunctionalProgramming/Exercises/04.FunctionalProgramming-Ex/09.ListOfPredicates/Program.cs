using System;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> isDivisible = (num, div) => num % div == 0;

            for (int i = 1; i <= range; i++)
            {
                int currentNum = i;
                bool isDivided = true;
                for (int j = 0; j < dividers.Length; j++)
                {
                    if (!isDivisible(currentNum, dividers[j]))
                    {
                        isDivided = false;
                        break;
                    }
                }

                if (isDivided)
                {
                    Console.Write(currentNum + " ");
                }
            }
        }
    }
}
