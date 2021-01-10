using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int result = SumFirstNumbers(n1, n2, n3);

            Console.WriteLine(result);
        }

        public static int SumFirstNumbers(int firstNum, int secondNum, int thirdNum)
        {
            int sumFirstAndSecond = firstNum + secondNum;
            return SubstractThirdNum(sumFirstAndSecond, thirdNum);
        }

        private static int SubstractThirdNum(int sumFirstAndSecond, int thirdNum )
        {
            return sumFirstAndSecond - thirdNum;
        }
    }
}
