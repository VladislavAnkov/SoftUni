using System;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string biggerNum = Console.ReadLine().TrimStart('0');
            int smallerNum = int.Parse(Console.ReadLine());
            string sum = string.Empty;
            int multiply = 0;
            int lastDigit = 0;
            int firstDigit = 0;

            if (smallerNum == 0 || biggerNum == "")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = biggerNum.Length - 1; i >= 0; i--)
            {
                int currentNum = (int)(biggerNum[i] - 48);

                multiply = currentNum * smallerNum;
                multiply += firstDigit;

                lastDigit = multiply % 10;
                firstDigit = multiply / 10;
                sum += lastDigit;
              
                if (i == 0 && firstDigit > 0)
                {
                    sum += firstDigit;
                }
            }
            char[] chArr = sum.ToCharArray() ;
            string reversed = string.Empty;

            for (int i = chArr.Length - 1; i >= 0; i--)
            {
                reversed += chArr[i];
            }

            Console.WriteLine(reversed);
        }
    }
}
