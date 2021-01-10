using System;

namespace CharManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstString = input[0];
            string secondString = input[1];

            string longer = firstString;
            string shorter = secondString;

            if (firstString.Length < secondString.Length)
            {
                longer = secondString;
                shorter = firstString;
            }

            int sum = GetSum(longer, shorter);

            Console.WriteLine(sum);
        }

        public static int GetSum(string longerString, string shorterString)
        {
            int sum = 0;

            for (int i = 0; i < shorterString.Length; i++)
            {
                sum += longerString[i] * shorterString[i];
            }

            for (int k = shorterString.Length; k < longerString.Length; k++)
            {
                sum += longerString[k];
            }

            return sum;
        }
    }
}
