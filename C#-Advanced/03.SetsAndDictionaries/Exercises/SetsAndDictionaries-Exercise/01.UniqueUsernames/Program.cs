﻿using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());

			HashSet<string> users = new HashSet<string>();

			for (int i = 0; i < n; i++)
			{
				string userName = Console.ReadLine();

				users.Add(userName);
			}

			foreach (var user in users)
			{
				Console.WriteLine(user);
			}
		}
    }
}
