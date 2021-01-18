using System;
using System.Linq;

namespace _05.SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
			int rows = matrixSize[0];
			int cols = matrixSize[1];

			int[,] matrix = new int[rows, cols];
			for (int row = 0; row < rows; row++)
			{
				int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

				for (int col = 0; col < cols; col++)
				{
					matrix[row, col] = input[col];
				}
				Console.WriteLine();
			}

			int maxSum = int.MinValue;
			int rowIndex = -1;
			int colIndex = -1;

			for (int r = 0; r < rows - 1; r++)
			{
				for (int c = 0; c < cols - 1; c++)
				{
					int temp = matrix[r, c] + matrix[r, c + 1] + matrix[r + 1, c] + matrix[r + 1, c + 1];

					if (temp > maxSum)
					{
						maxSum = temp;
						rowIndex = r;
						colIndex = c;
					}
				}
			}

			Console.WriteLine($"{matrix[rowIndex, colIndex]} {matrix[rowIndex, colIndex + 1]}");
			Console.WriteLine($"{matrix[rowIndex + 1, colIndex]} {matrix[rowIndex + 1, colIndex + 1]}");
			Console.WriteLine(maxSum);
		}
    }
}
