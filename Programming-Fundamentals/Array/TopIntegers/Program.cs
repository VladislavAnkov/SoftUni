using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTop = true;
                int element = numbers[i];
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (element <= numbers[j])
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop)
                {
                    Console.Write(element + " ");
                }
            }
        }
    }
}
