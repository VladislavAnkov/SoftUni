using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                Console.WriteLine(ManipulationDiferentTypes(input));
            }
            else if (input == "real")
            {
                Console.WriteLine($"{ManipulationDiferentTypes(input):F2}");
            }
            else
            {
                Console.WriteLine(ManipulationDiferentTypes(input));
            }

        }
        static string ManipulationDiferentTypes(string input)
        {
            string result = string.Empty;

            if (input == "real")
            {
                double numReal = double.Parse(Console.ReadLine()) * 1.5;

                result = numReal.ToString();
            }
            else if (input == "string")
            {
                string typeString = Console.ReadLine();
                
                Console.WriteLine("$" + typeString + "$");
                

            }
            else if (input == "int")
            {
                int numInt = int.Parse(Console.ReadLine()) * 2;
                result = numInt.ToString();
            }

            return result;

        }
    }
}