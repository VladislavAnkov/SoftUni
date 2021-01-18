using System;
using System.Linq;

namespace _02.SumMatricColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] numbers = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    numbers[row, col] = input[col];
                }
                Console.WriteLine();
            }

            for (int c = 0; c < numbers.GetLength(1); c++)
            {
                int sum = 0;
                for (int r = 0; r < numbers.GetLength(0); r++)
                {
                    sum += numbers[r, c];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
