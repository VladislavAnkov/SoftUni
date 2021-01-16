using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
			int numberOfQueries = int.Parse(Console.ReadLine());

			Stack<int> numbers = new Stack<int>();

			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < numberOfQueries; i++)
			{
				string[] query = Console.ReadLine().Split();

				int type = int.Parse(query[0]);

				if (type == 1)
				{
					numbers.Push(int.Parse(query[1]));
				}
				else if (type == 2 && numbers.Any())
				{
					numbers.Pop();
				}
				else if (type == 3 && numbers.Any())
				{
					sb.AppendLine(numbers.Max().ToString());
				}
				else if (type == 4 && numbers.Any())
				{
					sb.AppendLine(numbers.Min().ToString());
				}
			}

			sb.AppendLine(string.Join(", ", numbers));
			Console.WriteLine(sb);
		}
    }
}
