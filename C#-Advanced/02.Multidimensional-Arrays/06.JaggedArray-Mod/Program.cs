using System;
using System.Linq;

namespace _06.JaggedArray_Mod
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int[][] jaggedArr = new int[n][];

			for (int row = 0; row < jaggedArr.Length; row++)
			{
				int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
				jaggedArr[row] = new int[input.Length];
				for (int col = 0; col < input.Length; col++)
				{
					jaggedArr[row][col] = input[col];
				}
				Console.WriteLine();
			}

			string[] cmdArgs = Console.ReadLine().Split();

			while (cmdArgs[0] != "END")
			{
				string command = cmdArgs[0];
				int row = int.Parse(cmdArgs[1]);
				int col = int.Parse(cmdArgs[2]);
				int @value = int.Parse(cmdArgs[3]);

				if (row < 0 || row >= jaggedArr.Length ||
					col < 0 || col >= jaggedArr.Length)
				{
					Console.WriteLine("Invalid coordinates");
					cmdArgs = Console.ReadLine().Split();
					continue;
				}

				if (command == "Add")
				{
					jaggedArr[row][col] += @value;
				}
				else if (command == "Subtract")
				{
					jaggedArr[row][col] -= @value;
				}

				cmdArgs = Console.ReadLine().Split();
			}

			for (int r = 0; r < jaggedArr.Length; r++)
			{
				for (int c = 0; c < jaggedArr[r].Length; c++)
				{
					Console.Write(jaggedArr[r][c] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}