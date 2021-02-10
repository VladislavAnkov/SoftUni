using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<Trainer> trainers = new List<Trainer>();

            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int health = int.Parse(input[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, health);

                if (trainers.Any(t => t.Name == trainerName))
                {
                    int index = trainers.FindIndex(t => t.Name == trainerName);
                    trainers[index].Pokemons.Add(pokemon);
                }
                else
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string element = Console.ReadLine();

            while (element != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    if(trainer.Pokemons.Any(e => e.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(a => a.Health -= 10);

                        trainer.Pokemons = trainer.Pokemons.Where(h => h.Health > 0).ToList();
                    }
                }

                element = Console.ReadLine();
            }

            List<Trainer> sortedTrainers = trainers.OrderByDescending(t => t.Badges).ToList();

            foreach (Trainer trainer in sortedTrainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
