using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int rows = dimensions[0];
			int cols = dimensions[1];

			string[,] matrix = new string[rows, cols];

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				string[] input = Console.ReadLine().Split();
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					matrix[row, col] = input[col];
				}
				Console.WriteLine();
			}

			int count = 0;

			for (int row = 0; row < rows - 1; row++)
			{
				for (int col = 0; col < cols - 1; col++)
				{
					if (matrix[row, col] == matrix[row, col + 1] &&
					   matrix[row, col] == matrix[row + 1, col] &&
					   matrix[row, col] == matrix[row + 1, col + 1])
					{
						count++;
					}
				}
			}

			Console.WriteLine(count);
		}
    }
}
