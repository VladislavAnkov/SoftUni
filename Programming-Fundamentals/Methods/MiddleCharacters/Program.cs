using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = GetMiddleChar(input);
            Console.WriteLine(output);
        }

        private static string GetMiddleChar(string text)
        {
            if (text.Length % 2 == 0)
            {
                int index = text.Length / 2;
                string chars = text.Substring(index - 1, 2);
                return chars;
            
            }
            else
            {
                int index = text.Length / 2;
                string chars = text.Substring(index, 1);
                return chars;
            }
        }
    }
}
