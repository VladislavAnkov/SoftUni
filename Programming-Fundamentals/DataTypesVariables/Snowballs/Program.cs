using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            BigInteger highestValue = int.MinValue;

            short highestSnow = short.MinValue;
            short highestTime = short.MinValue;
            short highestQuality = short.MinValue;

            for (int i = 0; i < n; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                short snowballQuality = short.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > highestValue)
                {
                    highestValue = snowballValue;
                    highestSnow = snowballSnow;
                    highestTime = snowballTime;
                    highestQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");

        }
    }
}