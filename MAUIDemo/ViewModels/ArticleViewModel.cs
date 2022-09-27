using System;
using MAUIDemo.Models;
using MAUIDemo.Services;

namespace MAUIDemo.ViewModels
{
	public class ArticleViewModel
	{
		public ArticleViewModel(INewsService news, Article a)
		{
			this.Title = a.Title;
			this.ImageURL = a.ImageURL;
			this.Body = news.GetArticleBody(a.Id);
		}

		public string Title { get; set; }

		public string ImageURL { get; set; }

		public string Body { get; set; }
	}
}
