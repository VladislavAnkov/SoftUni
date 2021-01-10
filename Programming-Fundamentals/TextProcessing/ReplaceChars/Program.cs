using System;

namespace ReplaceChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char firstChar = input[0];
            string result = string.Empty;
            result += firstChar;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (!(currentChar == firstChar))
                {
                    firstChar = currentChar;
                    result += firstChar;
                }
            }

            Console.WriteLine(result);
        }
    }
}
