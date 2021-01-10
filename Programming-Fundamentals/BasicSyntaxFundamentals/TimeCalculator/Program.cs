using System;

namespace TimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                hour += 1;
                minutes = minutes - 60;
            }

            if (hour >= 24)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour:d2}:{minutes:d2}");
        }
    }
}
