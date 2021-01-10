using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chArr = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                chArr[i] = (char)(input[i] + 3);
            }

            for (int i = 0; i < chArr.Length; i++)
            {
                Console.Write(chArr[i]);
            }
        }
    }
}
