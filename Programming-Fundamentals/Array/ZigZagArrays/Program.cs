using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];



            for (int i = 0; i < n; i++)
            {
                int[] currentNum = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

                if (i % 2 == 0)
                {
                    firstArray[i] = currentNum[0];
                    secondArray[i] = currentNum[1];
                }
                else
                {
                    firstArray[i] = currentNum[1];
                    secondArray[i] = currentNum[0];
                }

            }

            Console.WriteLine(string.Join(' ', firstArray));
            Console.WriteLine(string.Join(' ', secondArray));

        }
    }
}
