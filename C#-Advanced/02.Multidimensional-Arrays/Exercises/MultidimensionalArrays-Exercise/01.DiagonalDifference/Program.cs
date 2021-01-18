using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
			int size = int.Parse(Console.ReadLine());

			int[,] matrix = new int[size, size];

			int primarySum = 0;
			int secondarySum = 0;

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					matrix[row, col] = input[col];
				}
				Console.WriteLine();
			}

			for (int row = 0; row < size; row++)
			{
				int col = row;
				primarySum += matrix[row, col];
			}

			int currentCol = 0;

			for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
			{
				secondarySum += matrix[row, currentCol];
				currentCol++;
			}

			int difference = primarySum - secondarySum;
			Console.WriteLine(Math.Abs(difference));
		}
    }
}
