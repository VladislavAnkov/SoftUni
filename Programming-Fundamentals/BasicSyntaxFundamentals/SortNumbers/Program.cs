using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int[] arr = new int[] { n1, n2, n3 };

            Array.Sort(arr);
            Array.Reverse(arr);

            PrintValues(arr);
        }

        public static void PrintValues(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element);
                Console.WriteLine();
            }
        }
    }
}
