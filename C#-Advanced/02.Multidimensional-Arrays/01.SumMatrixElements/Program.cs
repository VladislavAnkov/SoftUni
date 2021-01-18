using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = tokens[0];
            int cols = tokens[1];
            int[,] numberMatrix = new int[rows, cols];
            int sum = 0;

            for (int row = 0; row < numberMatrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < numberMatrix.GetLength(1); col++)
                {
                    numberMatrix[row, col] = input[col];
                    sum += input[col];
                }
                Console.WriteLine();
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
