using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] data = input.Split(", ");
                string command = data[0];
                string carNum = data[1];

                if (command == "IN")
                {
                    cars.Add(carNum);
                }
                else if (command == "OUT")
                {
                    cars.Remove(carNum);
                }

                input = Console.ReadLine();
            }
                
            

            if (!cars.Any())
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (string car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
