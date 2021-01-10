using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            keyMaterials["motes"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["shards"] = 0;
            bool winnerFound = false;

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "motes" || material == "fragments" || material == "shards")
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;

                            if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }

                            winnerFound = true;
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += quantity;
                        }
                        else
                        {
                            junk.Add(material, quantity);
                        }
                    }
                }

                if (winnerFound)
                {
                    break;
                }
            }

            Dictionary<string, int> filter = keyMaterials
                .OrderByDescending(v => v.Value)
                .ThenBy(k => k.Key)
                .ToDictionary(a => a.Key, a => a.Value);

            foreach (var kvp in filter)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
