using System;
using System.Text;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Done")
            {
                string command = input[0];

                switch (command)
                {
                    case "TakeOdd":
                        string newPassword = string.Empty;
                        for (int i = 1;i < password.Length; i+=2)
                        {
                            newPassword += password[i];
                        }
                        password = newPassword;

                        Console.WriteLine(password);

                        break;
                    case "Cut":
                        int index = int.Parse(input[1]);
                        int length = int.Parse(input[2]);

                        password = password.Remove(index, length);

                        Console.WriteLine(password) ;
                        break;
                    case "Substitute":
                        string substring = input[1];
                        string substitute = input[2];
                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);
                            Console.WriteLine(password) ;
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;

                }


                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
