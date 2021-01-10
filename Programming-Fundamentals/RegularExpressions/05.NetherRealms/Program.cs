using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    class Demon
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Health} health, {Damage:f2} damage";
        }

        public Demon(string name, int health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Demon> demons = new List<Demon>();
            char[] separators = new char[] { ' ', ',' };
            string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string healthPattern = @"[-+]?[0-9]+\.?[0-9]*[\*\/+-]*";
            string damagePattern = @"(?<numbers>[-+]?[0-9]+\.?[0-9]*)";
            string operatorsPattern = @"(?<mathOperators>[\*\/]*)";

            Regex damageRegex = new Regex(damagePattern);
            Regex operatorsRegex = new Regex(operatorsPattern);

            foreach (var demon in input)
            {
                string healthOfDemon = Regex.Replace(demon, healthPattern, "");
                int health = 0;

                for (int i = 0; i < healthOfDemon.Length; i++)
                {
                    health += healthOfDemon[i];
                }

                MatchCollection damage = damageRegex.Matches(demon);

                var list = damage.Cast<Match>().Select(match => match.Value).ToList();

                double totalDamage = 0;

                foreach (var item in list)
                {
                    double demonDamage = double.Parse(item);
                    totalDamage += demonDamage;
                }

                for (int i = 0; i < demon.Length; i++)
                {
                    if (demon[i] == '*')
                    {
                        totalDamage *= 2;
                    }
                    else if(demon[i] == '/')
                    {
                        totalDamage /= 2;
                    }
                }
                Demon currentDemon = new Demon(demon, health, totalDamage);

                demons.Add(currentDemon);

            }

            foreach (Demon item in demons.OrderBy(n => n.Name))
            {
                Console.WriteLine(item);
            }
        }
    }
}
