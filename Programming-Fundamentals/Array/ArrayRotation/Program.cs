using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()   
                          .Split(' ')
                          .Select(int.Parse)
                          .ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int firstElement = array[0];

                int[] temp = new int[array.Length]; 
                temp[temp.Length - 1] = firstElement;

                for (int j = 0; j < array.Length - 1; j++)
                {
                    temp[j] = array[j + 1];
                }

                array = temp;

            }
            Console.WriteLine(string.Join(' ', array));
        }
    }
}
