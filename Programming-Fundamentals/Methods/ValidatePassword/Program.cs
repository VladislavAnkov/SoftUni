using System;

public class Program
{
	public static void Main()
	{
		string password = Console.ReadLine();

		if ((Length(password) == true) &&
		   (ContainsCharsAndDigits(password) == true) &&
		   (Digits(password) == true))
		{
			Console.WriteLine("Password is valid");
		}

		if (Length(password) == false)
		{
			Console.WriteLine("Password must be between 6 and 10 characters");
		}

		if (ContainsCharsAndDigits(password) == false)
		{
			Console.WriteLine("Password must consist only of letters and digits");
		}

		if (Digits(password) == false)
		{
			Console.WriteLine("Password must have at least 2 digits");
		}

	}

	static bool Length(string password)
	{
		bool isLongEnough = false;

		if (password.Length >= 6 && password.Length <= 10)
		{
			isLongEnough = true;
		}

		return isLongEnough;
	}

	static bool ContainsCharsAndDigits(string password)
	{
		bool isValid = false;

		for (int i = 0; i < password.Length; i++)
		{
			int charAsInt = (int)(password[i]);

			if ((charAsInt >= 48 && charAsInt <= 57) ||
			   (charAsInt >= 65 && charAsInt <= 90) ||
			   (charAsInt >= 97 && charAsInt <= 122))
			{
				isValid = true;
			}
			else
			{
				isValid = false;
				break;
			}
		}
		return isValid;
	}

	static bool Digits(string password)
	{
		bool isValid = false;
		int count = 0;

		for (int i = 0; i < password.Length; i++)
		{
			int charAsInt = (int)(password[i]);

			if (charAsInt >= 48 && charAsInt <= 57)
			{
				count++;
			}
		}

		if (count >= 2)
		{
			isValid = true;
		}

		return isValid;
	}

}