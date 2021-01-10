using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());

            int people = int.Parse(Console.ReadLine());

            int hoursCount = 0;

            while (people > 0)
            {
                people -= (firstEmployee + secondEmployee + thirdEmployee);
                hoursCount++;

                if (hoursCount % 4 == 0)
                {
                    hoursCount++;
                }
            }

            Console.WriteLine($"Time needed: {hoursCount}h.");
        }
    }
}
