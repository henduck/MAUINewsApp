using System;
namespace MAUIDemo.Models
{
    public class Article
    {
        public string Id { get; set; }

        public string Title { get; }

        public string ImageURL { get; }

        public string Category { get; }

        public string Time { get; }

        public Article(string id, string title, string imageUrl, string category, string time)
        {
            this.Id = id;
            this.Title = title;
            this.ImageURL = imageUrl;
            this.Category = category;
            this.Time = time;
        }
    }
}
