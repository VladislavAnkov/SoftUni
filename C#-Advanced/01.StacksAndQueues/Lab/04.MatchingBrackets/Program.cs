using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string mathOperation = Console.ReadLine();

            Stack<int> bracketsIndex = new Stack<int>();

            //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5

            for (int i = 0; i < mathOperation.Length; i++)
            {
                char currentChar = mathOperation[i];
                if (currentChar == '(')
                {
                    bracketsIndex.Push(i);
                }
                else if (currentChar == ')')
                {
                    int startIndex = bracketsIndex.Pop();
                    Console.WriteLine(mathOperation.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
