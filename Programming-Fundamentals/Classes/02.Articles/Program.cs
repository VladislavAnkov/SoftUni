using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initialArticle = Console.ReadLine().Split(", ").ToArray();

            string title = initialArticle[0];
            string content = initialArticle[1];
            string author = initialArticle[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        article.Rename(command[1]);
                        break;
                }
            }

            Console.WriteLine(article.ToString()) ;
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

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            string output = ($"{Title} - {Content}: {Author}");
            return output;
        }

    }
}
