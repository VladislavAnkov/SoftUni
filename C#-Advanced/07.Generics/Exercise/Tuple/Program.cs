using System;

namespace Tuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
			string[] firstLineData = Console.ReadLine().Split(" ");
			string fullName = firstLineData[0] + " " + firstLineData[1];
			string address = firstLineData[2];
			Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, address);

			string[] secondLineData = Console.ReadLine().Split(" ");
			string name = secondLineData[0];
			int beer = int.Parse(secondLineData[1]);
			Tuple<string, int> secondTuple = new Tuple<string, int>(name, beer);

			string[] thirdLineData = Console.ReadLine().Split(" ");
			int intNum = int.Parse(thirdLineData[0]);
			double doubleNum = double.Parse(thirdLineData[1]);
			Tuple<int, double> thirdTuple = new Tuple<int, double>(intNum, doubleNum);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
		}
    }
}
