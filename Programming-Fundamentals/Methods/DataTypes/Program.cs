using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if (dataType == "int")
            {
                int number = int.Parse(Console.ReadLine());
                PrintResult(number);
            }
            else if (dataType == "real") 
            {
                double number = double.Parse(Console.ReadLine());
                PrintResult(number);
            }
            else
            {
                string input = Console.ReadLine();
                PrintResult(input);
            }
            
        }

        static void PrintResult(int number)
        {

            number *= 2;

            Console.WriteLine(number);
        }

        static void PrintResult(double floatingNumber)
        {
            floatingNumber *= 1.5;

            Console.WriteLine($"{floatingNumber:f2}");
        }

        static void PrintResult(string input)
        {
            Console.WriteLine("$" + input + "$");
        }
    }
}
