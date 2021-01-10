using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int totalAmount = 0;

            const int workersConsum = 26;

            int count = 0;

            if (startingYield < 100)
            {
                Console.WriteLine(count);
                Console.WriteLine(totalAmount);
            }
            else
            {
                while (startingYield >= 100)
                {

                    startingYield -= workersConsum;
                    totalAmount += startingYield;
                    startingYield -= 10;
                    count++;
                }
            }

            totalAmount -= 26;
            Console.WriteLine(count);
            Console.WriteLine(totalAmount);
        }
    }
}
