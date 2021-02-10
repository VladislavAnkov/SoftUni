using System;

namespace GenericBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> text = new Box<int>(input);
                Console.WriteLine(text);
            }
        }
    }
}
