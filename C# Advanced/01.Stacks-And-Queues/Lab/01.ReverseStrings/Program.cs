using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] chArray = input.ToCharArray();

            Stack<char> result = new Stack<char>();

            for (int i = 0; i < chArray.Length; i++)
            {
                result.Push(chArray[i]);
            }

            for (int j = 0; j < chArray.Length; j++)
            {
                Console.Write(result.Pop());
            }
        }
    }
}
