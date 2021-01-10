using System;

namespace PadawanAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsabres = 0;
            lightsabres = Math.Ceiling(students * 1.10);
            double lightsabresCost = lightsabres * lightsabrePrice;
            double robesCost = students * robePrice;
            double beltsCost = 0;

            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    continue;
                }
                else
                {
                    beltsCost+= beltPrice;
                }
            }

            double totalSum = lightsabresCost + beltsCost + robesCost;

            if (totalSum <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(totalSum - money):f2}lv more.");
            }
        }
    }
}
