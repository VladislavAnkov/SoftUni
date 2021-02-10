using System;
using System.Linq;

namespace Threeuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split(' ');
            string fullName = $"{firstTupleData[0]} {firstTupleData[1]}";
            string address = firstTupleData[2];
            string[] city = firstTupleData.Skip(3).ToArray();

            Threeuple<string, string, string> firstTuple =
                new Threeuple<string, string, string>(fullName, address, string.Join(" ", city));

            string[] secondTupleData = Console.ReadLine().Split(' ');
            string name = secondTupleData[0];
            int litersOfBeer = int.Parse(secondTupleData[1]);
            bool isDrunk = secondTupleData[2] == "drunk";

            Threeuple<string, int, bool> secondThreeuple =
                new Threeuple<string, int, bool>(name, litersOfBeer, isDrunk);

            string[] thirdTupleData = Console.ReadLine().Split(' ');
            string name3 = thirdTupleData[0];
            double balance = double.Parse(thirdTupleData[1]);
            string bank = thirdTupleData[2];

            Threeuple<string, double, string> thirdThreeuple =
                new Threeuple<string, double, string>(name3, balance, bank);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdThreeuple);
        }
    }
}
