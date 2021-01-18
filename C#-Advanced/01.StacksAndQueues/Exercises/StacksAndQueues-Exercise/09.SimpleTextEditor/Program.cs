using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> text = new Stack<string>();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();

                string command = cmdArgs[0];

                if (command == "1")
                {
                    text.Push(sb.ToString());
                    string currentText = cmdArgs[1];
                    sb.Append(currentText);
                }
                else if (command == "2")
                {
                    text.Push(sb.ToString());
                    int count = int.Parse(cmdArgs[1]);
                    sb.Remove(sb.Length - count, count);
                }
                else if (command == "3")
                {
                    int index = int.Parse(cmdArgs[1]) - 1;

                        Console.WriteLine(sb[index]);

                }
                else if (command == "4")
                {
                    sb.Clear();
                    sb.Append(text.Pop());
                }
            }
            
        }
    }
}
