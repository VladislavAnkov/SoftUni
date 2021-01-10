using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == '>')
                {
                    int explosion = int.Parse(input[i + 1].ToString());

                    for (int k = 1; k <= explosion; k++)
                    {
                        if (input[i + 1] != '>')
                        {
                            input = input.Remove(i+1, 1);
                            explosion--;
                        }
                        else
                        {
                            explosion += int.Parse(input[i + 2].ToString());
                        }
                    }
                }
            }
            Console.WriteLine(input);
        }
    }


  
}
