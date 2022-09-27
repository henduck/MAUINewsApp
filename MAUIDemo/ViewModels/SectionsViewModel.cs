using System;
using MAUIDemo.Models;
using MAUIDemo.Services;
using MAUIDemo.Views;

namespace MAUIDemo.ViewModels
{
    public class SectionsViewModel
    {
        public SectionsViewModel(INewsService news)
        {
            this.Sections = news.GetCategories();
        }

        public ICollection<Category> Sections { get; set; }
    }
}

