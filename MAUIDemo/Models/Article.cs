using System;
namespace MAUIDemo.Models
{
    public class Article
    {
        public string Title { get; }

        public string ImageURL { get; }

        public string Body { get; }

        public string Category { get; }

        public string Time { get; }

        public Article(string title, string imageUrl, string body, string category, string time)
        {
            this.Title = title;
            this.ImageURL = imageUrl;
            this.Body = body;
            this.Category = category;
            this.Time = time;
        }
    }
}
