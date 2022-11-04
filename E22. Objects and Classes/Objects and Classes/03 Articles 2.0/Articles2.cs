using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Articles_2._0
{
    class Articles2
    {
        static void Main()
        {
            List<Article> articles = new List<Article>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] articleInfo = Console.ReadLine().Split(',').ToArray();
                articles.Add(new Article(articleInfo[0], articleInfo[1].Trim(), articleInfo[2].Trim()));
            }
            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
}
