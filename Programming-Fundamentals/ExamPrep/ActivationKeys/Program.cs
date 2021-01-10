using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		string activationKey = Console.ReadLine();

		string command = Console.ReadLine();

		while (command != "Generate")
		{
			string[] strArr = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

			if (strArr[0] == "Contains")
			{
				string substring = strArr[1];

				if (activationKey.Contains(substring))
				{
					Console.WriteLine("{0} contains {1}", activationKey, substring);
				}
				else
				{
					Console.WriteLine("Substring not found!");
				}
			}
			else if (strArr[0] == "Flip")
			{
				int startIndex = int.Parse(strArr[2]);
				int endIndex = int.Parse(strArr[3]);
				string firstPart = activationKey.Substring(0, startIndex);
				string substring = activationKey.Substring(startIndex, endIndex - startIndex);
				string lastPart = activationKey.Substring(endIndex);

				if (strArr[1].ToUpper() == "UPPER")
				{
					substring = substring.ToUpper();
				}
				else if (strArr[1].ToUpper() == "LOWER")
				{
					substring = substring.ToLower();
				}

				activationKey = firstPart + substring + lastPart;
				Console.WriteLine(activationKey);
			}
			else if (strArr[0] == "Slice")
			{
				int startIndex = int.Parse(strArr[1]);
				int endIndex = int.Parse(strArr[2]);

				activationKey = activationKey.Remove(startIndex, endIndex - startIndex);

				Console.WriteLine(activationKey);
			}


			command = Console.ReadLine();
		}

		Console.WriteLine($"Your activation key is: {activationKey}");
	}
}