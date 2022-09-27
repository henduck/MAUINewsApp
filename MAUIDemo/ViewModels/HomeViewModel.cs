using System;
using MAUIDemo.Models;

namespace MAUIDemo.ViewModels
{
	public class HomeViewModel
	{
		public HomeViewModel()
		{
			this.Tags = new List<string>()
			{
				"#Test1",
				"#Hello",
				"#What!!"
			};

			this.LatestArticles = new List<Article>()
			{
				new Article("Some Article Title Here", "https://picsum.photos/seed/one/300/200", "This is the body, it's very long!", "Business", "8m ago"),
				new Article("And another one!", "https://picsum.photos/seed/two/300/200", "This is ALSO the body, it's very long!", "Sports", "12m ago"),
                new Article("Wait, There's More.", "https://picsum.photos/seed/three/300/200", "Blah blah blah. Talking talking talking.", "Science", "16m ago"),
                new Article("Just Another", "https://picsum.photos/seed/four/300/200", "I'm tired of making up fake content.", "Politics", "23m ago")
            };

            this.RecommendedArticles = new List<Article>()
            {
                new Article("Some Article Title Here", "https://picsum.photos/seed/five/300/200", "This is the body, it's very long!", "Business", "8m ago"),
                new Article("And another one!", "https://picsum.photos/seed/six/300/200", "This is ALSO the body, it's very long!", "Sports", "12m ago"),
                new Article("Wait, There's More.", "https://picsum.photos/seed/seven/300/200", "Blah blah blah. Talking talking talking.", "Science", "16m ago"),
                new Article("Just Another", "https://picsum.photos/seed/eight/300/200", "I'm tired of making up fake content.", "Politics", "23m ago")
            };

            this.PopularArticles = new List<Article>()
            {
                new Article("Some Article Title Here", "https://picsum.photos/seed/nine/300/200", "This is the body, it's very long!", "Business", "8m ago"),
                new Article("And another one!", "https://picsum.photos/seed/ten/300/200", "This is ALSO the body, it's very long!", "Sports", "12m ago"),
                new Article("Wait, There's More.", "https://picsum.photos/seed/eleven/300/200", "Blah blah blah. Talking talking talking.", "Science", "16m ago"),
                new Article("Just Another", "https://picsum.photos/seed/twelve/300/200", "I'm tired of making up fake content.", "Politics", "23m ago")
            };

            this.TappedCommand = new Command<Article>((article) =>
            {
                //TODO: pass the given article in as a param
                Shell.Current.GoToAsync("//home/article");
            });
        }

		public List<string> Tags { get; set; }

		public List<Article> LatestArticles { get; set; }

        public List<Article> PopularArticles { get; set; }
        
        public List<Article> RecommendedArticles { get; set; }

        public Command<Article> TappedCommand { get; set; }
    }
}
