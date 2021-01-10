using System;

namespace Rage
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = 0.0;
            int count = 0;
            int keyboarsBroken = 0;


            while (lostGames > 0)
            {
                count++;

                if (count % 2 == 0)
                {
                    expenses += headsetPrice;
                }

                if (count % 3 == 0)
                {
                    expenses += mousePrice;
                }

                if (count % 6 == 0)
                {
                    expenses += keyboardPrice;
                    keyboarsBroken++;
                    if (keyboarsBroken == 2)
                    {
                        expenses += displayPrice;
                        keyboarsBroken = 0;
                    }
                }

                lostGames--;
            }

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
