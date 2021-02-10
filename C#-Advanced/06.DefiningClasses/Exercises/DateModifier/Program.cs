using System;

namespace DateModifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int difference = DateModifier.GetDiffBetweenDates(firstDate, secondDate);
            Console.WriteLine(difference);
        }
    }
}
