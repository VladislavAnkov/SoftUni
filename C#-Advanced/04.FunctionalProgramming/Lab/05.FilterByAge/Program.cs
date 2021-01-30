using System;
using System.Collections.Generic;

namespace _05.FilterByAge
{
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
	}

	class Program
	{
		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());

			List<Person> people = new List<Person>(n);

			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Split(", ");
				string name = input[0];
				int age = int.Parse(input[1]);
				Person person = new Person(name, age);
				people.Add(person);
			}
			string filter = Console.ReadLine();
			int filterAge = int.Parse(Console.ReadLine());

			Func<Person, bool> condition = GetAgeFilter(filter, filterAge);
			Action<Person> formatter = GetFormat(Console.ReadLine());
			PrintPeople(people, condition, formatter);
		}

		public static Func<Person, bool> GetAgeFilter(string filter, int age)
		{
			switch (filter)
			{
				case "older":
					return p => p.Age >= age;
					break;
				case "younger":
					return p => p.Age < age;
					break;
				default:
					return null;
					break;
			}
		}

		public static Action<Person> GetFormat(string format)
		{
			switch (format)
			{
				case "name":
					return p => Console.WriteLine($"{p.Name}");
				case "age":
					return p => Console.WriteLine($"{p.Age}");
				case "name age":
					return p => Console.WriteLine($"{p.Name} - {p.Age}");
				default:
					return null;
			}
		}

		public static void PrintPeople(List<Person> people, Func<Person, bool> condition, Action<Person> formatter)
		{
			foreach (Person person in people)
			{
				if (condition(person))
				{
					formatter(person);
				}
			}
		}
	}
}
