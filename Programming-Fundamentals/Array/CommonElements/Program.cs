using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ');
            var arr2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int k = 0; k < arr1.Length; k++)
                {
                    if (arr2[i] == arr1[k])
                    {
                        Console.Write(arr2[i] + " ");
                    }
                }
            }
        }
    }
}
