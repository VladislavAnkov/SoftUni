using System;
using System.Collections.Generic;
using System.Linq;

namespace Targets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            int shotTargetValue = 0;
            int shotCounter = 0;

            string command = Console.ReadLine();

            while (command?.ToLower() != "end")
            {
                int index = int.Parse(command);

                if (index >= 0 && index < targets.Count)
                {
                    if (targets[index] != -1)
                    {
                        shotTargetValue = targets[index];
                        targets[index] = -1;
                        shotCounter++;

                        for (int i = 0; i < targets.Count; i ++)
                        {
                            if (targets[i] != -1)
                            {
                                if (targets[i] > shotTargetValue)
                                {
                                    targets[i] -= shotTargetValue;
                                }
                                else if (targets[i] <= shotTargetValue)
                                {
                                    targets[i] += shotTargetValue;
                                }
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.Write($"Shot targets: {shotCounter} -> ");

            foreach (var target in targets)
            {
                Console.Write(target + " ");
            }
        }
    }
}
