using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace(" ", "");
            char[] charArr = input.ToCharArray();

            Dictionary<char, int> characters = new Dictionary<char, int>();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (characters.ContainsKey(charArr[i]) == false)
                {
                    characters.Add(charArr[i], 1);
                }
                else
                {
                    characters[charArr[i]]++;
                }
            }

            foreach (var character in characters)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }


        }
    }
}
