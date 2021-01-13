using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] input = Console.ReadLine().Split();

			Stack<string> reversed = new Stack<string>(input.Reverse());

			while (reversed.Count > 1)
			{
				int firstNum = int.Parse(reversed.Pop());
				string mathOperator = reversed.Pop();
				int secondNum = int.Parse(reversed.Pop());
				int result = 0;

				if (mathOperator == "+")
				{
					result = firstNum + secondNum;
				}
				else
				{
					result = firstNum - secondNum;
				}

				reversed.Push(result.ToString());

			}

			Console.WriteLine(int.Parse(reversed.Pop()));
		}
    }
}
