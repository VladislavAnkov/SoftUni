using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			Stack<int> numbersStack = new Stack<int>(numbers);

			string[] cmdArgs = Console.ReadLine().Split();

			while (cmdArgs[0] != "end")
			{
				string command = cmdArgs[0].ToLower();

				if (command == "add")
				{
					numbersStack.Push(int.Parse(cmdArgs[1]));
					numbersStack.Push(int.Parse(cmdArgs[2]));
				}
				else
				{
					int num = int.Parse(cmdArgs[1]);

					if (num > numbersStack.Count)
					{
						cmdArgs = Console.ReadLine().Split();
						continue;
					}
					else
					{
						for (int j = 0; j < num; j++)
						{
							numbersStack.Pop();
						}
					}
				}
				cmdArgs = Console.ReadLine().Split();
			}

			int sum = numbersStack.Sum();
			Console.WriteLine("Sum: {0}", sum);
		}
    }
}
