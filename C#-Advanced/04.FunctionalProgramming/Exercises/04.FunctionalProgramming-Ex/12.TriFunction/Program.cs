using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Func<string, int, bool> checkLength = (string name, int num) => name.ToCharArray().Select(c => (int)c).Sum() >= num;

            Func<List<string>, Func<string, int, bool>, string> personFinder = (people, function) =>
              {
                  string searchedPerson = string.Empty;
                  foreach (var person in people)
                  {
                      if (function(person, number))
                      {
                          searchedPerson = person;
                          break;
                      }
                  }

                  return searchedPerson;
              };

            List<string> names = Console.ReadLine().Split(" ").ToList();

            Console.WriteLine(personFinder(names, checkLength));
        }
    }
}
