using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wins = 0;
            bool isWinner = true;

            string input = Console.ReadLine();

            while (input != "End of battle")
            {
                int distance = int.Parse(input);

                if (energy >= distance)
                {
                    energy -= distance;
                    wins++;

                    if (wins % 3 == 0)
                    {
                        energy += wins;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    isWinner = false;
                    break;
                }

                input = Console.ReadLine();
            }

            if (isWinner)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
        }
    }
}
