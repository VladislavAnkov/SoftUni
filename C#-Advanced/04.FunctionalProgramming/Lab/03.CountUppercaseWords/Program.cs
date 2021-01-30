using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> isFirstLetterCapital = word => word[0] == word.ToUpper()[0];

            Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Where(isFirstLetterCapital)
            .ToList()
            .ForEach(word => Console.WriteLine(word));
        }
    }
}
