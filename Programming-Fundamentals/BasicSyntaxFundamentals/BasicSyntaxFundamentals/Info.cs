using System;

namespace BasicSyntaxFundamentals
{
    class Info
    {
        static void Main(string[] args)
        {
            int beltsCost = 0;

            for (int i = 1; i <= 42; i++)
            {
                if (i % 6 == 0)
                {
                    break;
                }
                else
                {
                    beltsCost += 3;
                }
            }
        }
    }
}
