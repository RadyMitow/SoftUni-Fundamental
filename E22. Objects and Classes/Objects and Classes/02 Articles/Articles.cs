using System;
using System.Linq;

namespace _02_Articles
{
    class Articles
    {
        static void Main()
        {
            string[] articleInfo = Console.ReadLine().Split(',').ToArray();
            Article article = new Article(articleInfo[0], articleInfo[1].Trim(), articleInfo[2].Trim());
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] commandInfo = Console.ReadLine().Split(':').ToArray();
                if (commandInfo[0] == "Edit")
                {
                    article.Edit(commandInfo[1].Trim());
                }
                else if (commandInfo[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(commandInfo[1].Trim());
                }
                else if(commandInfo[0] == "Rename")
                {
                    article.Rename(commandInfo[1].Trim());
                }
            }
            Console.WriteLine(article);
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

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
            
            return $"{Title} - {Content}: {Author}";
        }

    }
}
