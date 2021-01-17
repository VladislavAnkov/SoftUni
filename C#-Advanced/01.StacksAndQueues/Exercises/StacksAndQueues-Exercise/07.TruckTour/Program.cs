using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<List<int>> petrolPumps = new Queue<List<int>>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int fuel = input[0];
                int distance = input[1];
                
                petrolPumps.Enqueue(new List<int>{ fuel, distance});
            }

            int index = 0;


            for (int j = 0; j < n; j++)
            {
                bool isSuccessfull = true;
                int currentFuel = 0;
                int currentDistance = 0;

                for (int k = 0; k < n; k++)
                {
                    currentFuel += petrolPumps.Peek()[0];
                    currentDistance += petrolPumps.Peek()[1];
                    petrolPumps.Enqueue(petrolPumps.Dequeue());

                    if (currentFuel < currentDistance)
                    {
                        isSuccessfull = false;
                    }
                }

                if (isSuccessfull)
                {
                    index = j;
                    break;
                }
                else
                {
                    List<int> temp = petrolPumps.Dequeue();
                    petrolPumps.Enqueue(temp);
                }
            }

            Console.WriteLine(index);
        }
    }
}
