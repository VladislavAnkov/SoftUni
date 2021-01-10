using System;

namespace _01.AdvertismentMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Message message = new Message();
                string[] output = new string[4];
                output[0] = (message.Phrase = message.GetPhrase());
                output[1] = (message.Event = message.GetEvent());
                output[3] = (message.City = message.GetCity());
                output[2] = (message.Author = message.GetAuthor());

                Console.WriteLine($"{output[0]} {output[1]} {output[2]} - {output[3]}");
            }


        }
    }
}
