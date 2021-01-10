using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		List<Hero> heroes = new List<Hero>();
		int maxHP = 100;
		int maxMP = 200;

		for (int i = 0; i < n; i++)
		{
			string[] input = Console.ReadLine().Split(' ');

			string heroName = input[0];
			int hitPoints = int.Parse(input[1]);
			int manaPoints = int.Parse(input[2]);

			Hero hero = new Hero(heroName, (hitPoints > maxHP ? maxHP : hitPoints), (manaPoints > maxMP ? maxMP : manaPoints));

			heroes.Add(hero);
		}

		string inputB= Console.ReadLine();

		while (input != "End")
		{
			string[] command = inputB.Split(" - ");
			string action = command[0];
			string heroName = command[1];

			Hero hero = heroes.FirstOrDefault(h => h.Name == heroName);

			switch (action)
			{
				case "CastSpell":
					int mpNeeded = int.Parse(command[2]);
					string spellName = command[3];

					if (hero.ManaPoints >= mpNeeded)
					{
						hero.ManaPoints -= mpNeeded;
						Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {hero.ManaPoints} MP!");
					}
					else
					{
						Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
					}
					break;
				case "TakeDamage":
					int damage = int.Parse(command[2]);
					string attacker = command[3];

					if (hero.HitPoints >= damage)
					{
						hero.HitPoints -= damage;
						Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {hero.HitPoints} HP left!");
					}
					else
					{
						heroes.Remove(hero);
						Console.WriteLine($"{heroName} has been killed by {attacker}!");
					}
					break;
				case "Recharge":
					int amount = int.Parse(command[2]);
					if (hero.ManaPoints + amount >= maxMP)
					{
						amount = maxMP - hero.ManaPoints;
						hero.ManaPoints = maxMP;
					}
					else
					{
						hero.ManaPoints += amount;
					}
					Console.WriteLine($"{heroName} recharged for {amount} MP!");
					break;
				case "Heal":
					int amountHP = int.Parse(command[2]);
					if (hero.HitPoints + amountHP >= maxHP)
					{
						amountHP = maxHP - hero.HitPoints;
						hero.HitPoints = maxHP;
					}
					else
					{
						hero.HitPoints += amountHP;
					}
					Console.WriteLine($"{heroName} healed for {amountHP} HP!");
					break;
			}
			inputB = Console.ReadLine();
		}

		foreach (Hero hero in heroes.OrderByDescending(hp => hp.HitPoints).ThenBy(nick => nick.Name))
		{
			Console.WriteLine(hero.ToString());
		}

	}
}
public class Hero
{
	public string Name { get; set; }

	public int HitPoints { get; set; }

	public int ManaPoints { get; set; }

	public Hero(string name, int hitPoints, int manaPoints)
	{
		this.Name = name;
		this.HitPoints = hitPoints;
		this.ManaPoints = manaPoints;
	}

	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();

		sb.AppendLine(Name);
		sb.AppendLine($"  HP: {HitPoints}");
		sb.AppendLine($"  MP: {ManaPoints}");

		return sb.ToString();
	}
}