using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article> {};

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();
                string title = input[0];
                string content = input[1];
                string author = input[2];


                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            string finalCommand = Console.ReadLine();

            if (finalCommand == "title")
            {
                articles = articles.OrderBy(t => t.Title).ToList();
            }
            else if (finalCommand == "content")
            {
                articles = articles.OrderBy(c => c.Content).ToList();
            }
            else
            {
                articles = articles.OrderBy(a => a.Author).ToList();
            }

            foreach (var item in articles)
            {
                Console.WriteLine(item);

            }
        }
    }

    class Article
    {
        private string title;
        private string content;
        private string author;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Content { get => content; set => content = value; }

        public string Author { get => author; set => author = value; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public override string ToString()
        {
            string output = ($"{Title} - {Content}: {Author}");
            return output;
        }
    }
}
