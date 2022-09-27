using System;
using MAUIDemo.Models;
using MAUIDemo.Services;

namespace MAUIDemo.ViewModels
{
	public class HomeViewModel
	{
		public HomeViewModel(INewsService news)
		{
            this.Tags = news.GetTags();

            this.LatestArticles = news.GetLatestArticles();

            this.RecommendedArticles = news.GetRecommendedArticles();

            this.PopularArticles = news.GetPopularArticles();

            this.TappedCommand = new Command<Article>((article) =>
            {
                var query = new Dictionary<string, object>()
                {
                    { "article", article }
                };
                Shell.Current.GoToAsync("//home/article", query);
            });
        }

		public ICollection<string> Tags { get; set; }

		public ICollection<Article> LatestArticles { get; set; }

        public ICollection<Article> PopularArticles { get; set; }
        
        public ICollection<Article> RecommendedArticles { get; set; }

        public Command<Article> TappedCommand { get; set; }
    }
}
