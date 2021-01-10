using System;
using System.Collections.Generic;
using System.Text;

namespace _01.AdvertismentMessage
{
    class Message
    {
        public string Phrase { get; set; }
        public string Event { get; set; }
        public string Author { get; set; }
        public string City { get; set; }


        public string GetPhrase()
        {
            Random rand = new Random();
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            return phrases[rand.Next(0, phrases.Length)];
        }

        public string GetEvent()
        {
            Random rand = new Random();
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            return events[rand.Next(0, events.Length)];
        }

        public string GetAuthor()
        {
            Random rand = new Random();
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            return authors[rand.Next(0, authors.Length)];
        }

        public string GetCity()
        {
            Random rand = new Random();
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            return cities[rand.Next(0, cities.Length)];
        }



    }
}
